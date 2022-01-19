using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using MySql.Data.MySqlClient;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace IntegracjaSteamProjekt
{
    public partial class Form1 : Form
    {
        public SynchronizationContext Context { get; set; }
        private PlayerProfile PlayerProfile { get; set; }
        public CancellationTokenSource SoapApiCancallationTokenSource { get; set; }
        public CancellationTokenSource ApigatewayCancallationTokenSource { get; set; }
        public Form1()
        {
            InitializeComponent();
            Context = SynchronizationContext.Current;
        }

        private void SetFormData()
        {
            playerNameTextBox.Text = PlayerProfile.PlayerName;
            accountCreationDateTextBox.Text = PlayerProfile.AccountCreationDate.ToString();
            profileStatusLabel.Text = PlayerProfile.PlayerStatus.ToString();
            numberOfOwnedGamesTextBox.Text = PlayerProfile.OwnedGames.Count.ToString();
            numberOfFriendsTextBox.Text = PlayerProfile.NumberOfFriends.ToString();
            avatarPictureBox.LoadAsync(PlayerProfile.Url);
            playerOwnedGamesListBox.DataSource = PlayerProfile.OwnedGames.Select(x => x.Name).ToList();
            totalPlayedHoursTextBox.Text = PlayerProfile.TotalHoursPlayed.ToString();
            initialGamesValueTextBox.Text = (PlayerProfile.OwnedGamesInitialValue / 100).ToString() + " PLN";
            finalGamesValueTextBox.Text = (PlayerProfile.OwnedGamesFinalValue / 100).ToString() + " PLN";
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            PlayerProfile = await PlayerProfile.LoadData(Convert.ToUInt64(steamIdTextBox.Text));
            SetFormData();

        }

        private void InsertToDbButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new(Variables.ConnectionString);
            connection.Open();
            MySqlCommand command;
            string query = @"INSERT INTO `player_profile` (`steam_id`, `player_name`, `account_create_date`, `player_status`, `avatar_url`, `number_of_friends`, `total_hours_played`)
                            VALUES (@steamId, @playerName, @accountCreateDate, @playerStatus, @avatarUrl, @numberOfFriends, @totalHoursPlayed)";
            command = new(query, connection);
            command.CommandTimeout = 60;
            command.Parameters.AddWithValue("@steamId", PlayerProfile.SteamId.ToString());
            command.Parameters.AddWithValue("@playerName", PlayerProfile.PlayerName);
            command.Parameters.AddWithValue("@accountCreateDate", PlayerProfile.AccountCreationDate);
            command.Parameters.AddWithValue("@playerStatus", PlayerProfile.PlayerStatus);
            command.Parameters.AddWithValue("@avatarUrl", PlayerProfile.Url);
            command.Parameters.AddWithValue("@numberOfFriends", PlayerProfile.NumberOfFriends);
            command.Parameters.AddWithValue("@totalHoursPlayed", PlayerProfile.TotalHoursPlayed);
            command.ExecuteNonQuery();

            query = "SELECT LAST_INSERT_ID();";
            command = new(query, connection);
            int raport_id = Convert.ToInt32(command.ExecuteScalar());

            StringBuilder sCommand = new StringBuilder("INSERT INTO `owned_games` (`game_name`, `play_time`, `raport_id`) VALUES ");
            List<string> rows = new();
            foreach (var item in PlayerProfile.OwnedGames)
            {
                rows.Add($"('{item.Name}', '{item.PlayTime}', '{raport_id}')");
            }
            sCommand.Append(string.Join(",", rows));
            sCommand.Append(";");
            command = new(sCommand.ToString(), connection);
            command.ExecuteNonQuery();
            

        }

        private void downloadFromDatabaseButton_Click(object sender, EventArgs e)
        {
            List<PlayerProfile> lista = new();
            MySqlDataReader reader;
            MySqlConnection connection = new(Variables.ConnectionString);
            connection.Open();
            MySqlCommand command;
            string query = @"SELECT `steam_id`, `player_name`, `account_create_date`, `player_status`, `avatar_url`, `number_of_friends`, `total_hours_played` FROM `player_profile`;";
            command = new(query, connection);
            command.CommandTimeout = 60;

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new PlayerProfile
                    {
                        SteamId = reader.GetUInt64(0),
                        PlayerName = reader.GetString(1),
                        AccountCreationDate = reader.GetDateTime(2),
                        PlayerStatus = reader.GetString(3),
                        Url = reader.GetString(4),
                        NumberOfFriends = reader.GetInt32(5),
                        TotalHoursPlayed = reader.GetInt32(6)
                    });
                }
            }
            dataGridView1.DataSource = lista;


        }

        private void googleDriveButton_Click(object sender, EventArgs e)
        {
            string[] Scopes = { DriveService.Scope.Drive };
            string ApplicationName = "Drive API .NET Quickstart";
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            MemoryStream uploadStream = new MemoryStream(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(PlayerProfile)));

            Google.Apis.Drive.v3.Data.File driveFile = new Google.Apis.Drive.v3.Data.File
            {
                Name = "test.json"
            };
            FilesResource.CreateMediaUpload insertRequest = service.Files.Create (
                driveFile, uploadStream, "application/json");
            var a = service.Files.List().Execute();
            // var b = service.Files.Get(a.Files[0].Id).Execute();
            if (a.Files.Count > 0)
            {
                foreach (var item in a.Files)
                {
                    service.Files.Delete(item.Id).Execute();
                }
            }
            insertRequest.Upload();
            a = service.Files.List().Execute();
            Google.Apis.Drive.v3.Data.Permission permission = new();
            permission.Role = "reader";
            permission.Type = "anyone";
            service.Permissions.Create(permission, a.Files[0].Id).Execute();
            a = service.Files.List().Execute();
            Clipboard.SetText($"https://drive.google.com/file/d/{a.Files[0].Id}/view?usp=sharing");

        }


        private void activityLabel_TextChanged(object sender, EventArgs e)
        {
            switch (profileStatusLabel.Text)
            {
                case "Offline":
                    profileStatusLabel.BackColor = Color.Gray;
                    break;
                case "Online":
                    profileStatusLabel.BackColor = Color.Green;
                    break;
                case "Busy":
                case "Away":
                case "Snooze":
                    profileStatusLabel.BackColor = Color.Orange;
                    break;
                case "Unknown":
                    profileStatusLabel.BackColor = Color.Black;
                    break;
                case "InGame":
                    profileStatusLabel.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private bool ExportFile(string fileType)
        {
            SaveFileDialog saveFileDialog = new();
            string fileContent;
            if (fileType == "xml")
            {
                saveFileDialog.Filter = "Pliki xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FileName = "player_profile.xml";
                XmlSerializer xmlSerializer = new(typeof(PlayerProfile));
                var encoding = Encoding.GetEncoding("utf-8");
                using StringWriter writer = new();
                xmlSerializer.Serialize(writer, PlayerProfile);
                fileContent = writer.ToString();
            }
            else
            {
                saveFileDialog.Filter = "Pliki json (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FileName = "player_profile.json";
                fileContent = JsonSerializer.Serialize(PlayerProfile);
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, fileContent);
                return true;
            }
            return false;
        }

        private bool ImportFile(string fileType)
        {
            OpenFileDialog openFileDialog = new();
            string fileContent;
            string filePath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileContent = System.IO.File.ReadAllText(filePath);
            }
            else
            {
                return false;
            }
            if (fileType == "xml")
            {
                XmlSerializer xmlSerializer = new(typeof(PlayerProfile));
                using Stream stream = new FileStream(filePath, FileMode.Open);
                PlayerProfile = (PlayerProfile)xmlSerializer.Deserialize(stream);
            }
            else
            {
                PlayerProfile = JsonSerializer.Deserialize<PlayerProfile>(fileContent);
            }
            return true;
        }

        private void ExportButtonClick(object sender, EventArgs e)
        {
            string fileType = (sender as Button).Tag.ToString();
            if (ExportFile(fileType))
            {
                MessageBox.Show($"Wyexportowano plik .{fileType}");
            }
        }

        private void ImportButtonClick(object sender, EventArgs e)
        {
            string fileType = (sender as Button).Tag.ToString();
            ClearForm();
            if (ImportFile(fileType))
            {
                SetFormData();
            }
        }

        private void ClearForm()
        {
            playerNameTextBox.Clear();
            accountCreationDateTextBox.Clear();
            profileStatusLabel.Text = "";
            numberOfOwnedGamesTextBox.Clear();
            numberOfFriendsTextBox.Clear();
            avatarPictureBox.Image = null;
            playerOwnedGamesListBox.DataSource = null;
            playerOwnedGamesListBox.Items.Clear();
            initialGamesValueTextBox.Clear();
            finalGamesValueTextBox.Clear();
        }

        private void PlayerOwnedGamesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedItem = playerOwnedGamesListBox.SelectedItem;
            if (selectedItem is not null)
            {
                gameplayTimeTextBox.Text = PlayerProfile.OwnedGames.First(x => x.Name.Equals(selectedItem)).PlayTime.ToString();

            }
        }

        private void SoapApiStartButton_Click(object sender, EventArgs e)
        {
            Api.StartStopSoapApi(5000);
        }

        private void ApigatewayStartButton_Click(object sender, EventArgs e)
        {
            Api.StartStopApiGateway(5100);
        }


        private void SoapApiStopButton_Click(object sender, EventArgs e)
        {
            SoapApiCancallationTokenSource.Cancel();
            soapApiStopButton.Enabled = false;
            soapApiStartButton.Enabled = true;
        }

        private void ApiGatewayStopButton_Click(object sender, EventArgs e)
        {
            ApigatewayCancallationTokenSource.Cancel();
            apiGatewayStopButton.Enabled = false;
            apigatewayStartButton.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Program.SoapApiTask is not null || Program.ApiGatewayTask is not null)
            {
                MessageBox.Show("Należy najpierw wyłączyć Web Serwisy!");
                e.Cancel = true;
            }
        }
    }
}
