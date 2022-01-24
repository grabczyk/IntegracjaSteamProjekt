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
using System.Threading.Tasks;

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
            Application.DoEvents();
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            searchButton.Enabled = false;
            loadingSpinner.Visible = true;
            Application.DoEvents();
            PlayerProfile = await PlayerProfile.LoadDataAsync(Convert.ToUInt64(steamIdTextBox.Text));
            loadingSpinner.Visible = false;
            searchButton.Enabled = true;
            Application.DoEvents();
            SetFormData();
        }

        private async void InsertToDbButton_Click(object sender, EventArgs e)
        {
            await AddToDbAsync();
        }

        private async void DownloadFromDatabaseButton_Click(object sender, EventArgs e)
        {
            await DownloadPlayerProfilesAsync();
        }

        private async void googleDriveButton_Click(object sender, EventArgs e)
        {
            await UploadToGoogleDriveAsync();
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
            totalPlayedHoursTextBox.Clear();
            gameplayTimeTextBox.Clear();
            gameDescriptionTextBox.Clear();
            Application.DoEvents();
        }

        private void PlayerOwnedGamesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedItem = playerOwnedGamesListBox.SelectedItem;
            if (selectedItem is not null)
            {
                gameplayTimeTextBox.Text = PlayerProfile.OwnedGames.First(x => x.Name.Equals(selectedItem)).PlayTime.ToString();
                gameDescriptionTextBox.Text = PlayerProfile.OwnedGames.First(x => x.Name.Equals(selectedItem)).Description;
            }
        }

        private async Task AddToDbAsync()
        {
            MySqlConnection connection = new(Variables.ConnectionString);
            await connection.OpenAsync();
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
            await command.ExecuteNonQueryAsync();

            query = "SELECT LAST_INSERT_ID();";
            command = new(query, connection);
            int raport_id = Convert.ToInt32(await command.ExecuteScalarAsync());

            StringBuilder sCommand = new StringBuilder("INSERT INTO `owned_games` (`game_name`, `game_description`, `play_time`, `raport_id`) VALUES ");
            List<string> rows = new();
            foreach (var item in PlayerProfile.OwnedGames)
            {
                rows.Add($"('{item.Name}', '{item.Description}','{item.PlayTime}', '{raport_id}')");
            }
            sCommand.Append(string.Join(",", rows));
            sCommand.Append(';');
            command = new(sCommand.ToString(), connection);
            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();
        }

        private async Task DownloadPlayerProfilesAsync()
        {
            MySqlConnection connection = new(Variables.ConnectionString);
            await connection.OpenAsync();
            MySqlCommand command;
            string query = @"SELECT * FROM `player_profile`;";
            command = new(query, connection);
            command.CommandTimeout = 60;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            await dataAdapter.FillAsync(dataTable);
            playerProfileGridView.DataSource = dataTable;
            await connection.CloseAsync();
        }

        private async Task DownloadOwnedGames(int raportId)
        {
            MySqlConnection connection = new(Variables.ConnectionString);
            await connection.OpenAsync();
            MySqlCommand command;
            string query = @"SELECT `game_name`, `game_description`, `play_time` FROM `owned_games` WHERE raport_id = @raportId";
            command = new(query, connection);
            command.CommandTimeout = 60;
            command.Parameters.AddWithValue("@raportId", raportId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            await dataAdapter.FillAsync(dataTable);
            ownedGamesGridView.DataSource = dataTable;
            await connection.CloseAsync();
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

        private void steamIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private async void playerProfileGridView_SelectionChanged(object sender, EventArgs e)
        {
            int raportId = -1;
            var selected = playerProfileGridView.SelectedRows;
            if (selected.Count != 0)
            {
                var value = selected[0].Cells[0].Value;
                raportId = value != DBNull.Value ? (int)value : -1;
            }
            await DownloadOwnedGames(raportId);
            

        }

        private async Task UploadToGoogleDriveAsync()
        {
            googleDriveLinkTextBox.Text = "Wysyłanie pliku...";
            string[] Scopes = { DriveService.Scope.Drive };
            string ApplicationName = "Integracja Steam Projekt";
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
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

            MemoryStream uploadStream = new(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(PlayerProfile)));

            Google.Apis.Drive.v3.Data.File driveFile = new Google.Apis.Drive.v3.Data.File
            {
                Name = "playerProfile.json"
            };
            FilesResource.CreateMediaUpload insertRequest = service.Files.Create(
                driveFile, uploadStream, "application/json");
            var filesList = await service.Files.List().ExecuteAsync();
            if (filesList.Files.Count > 0)
            {
                foreach (var item in filesList.Files)
                {
                    await service.Files.Delete(item.Id).ExecuteAsync();
                }
            }
            await insertRequest.UploadAsync();
            filesList = await service.Files.List().ExecuteAsync();
            await Task.Delay(5000);
            Google.Apis.Drive.v3.Data.Permission permission = new();
            permission.Role = "reader";
            permission.Type = "anyone";
            await service.Permissions.Create(permission, filesList.Files[0].Id).ExecuteAsync();
            filesList = await service.Files.List().ExecuteAsync();
            googleDriveLinkTextBox.Text = $"https://drive.google.com/file/d/{filesList.Files[0].Id}/view?usp=sharing";
        }
    }
}
