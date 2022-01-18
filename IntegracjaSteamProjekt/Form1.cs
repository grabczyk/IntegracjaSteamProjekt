using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.Diagnostics;

namespace IntegracjaSteamProjekt
{
    public partial class Form1 : Form
    {
        PlayerProfile playerProfile;
        public Form1()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            playerProfile = new();
            playerProfile.SteamId = Convert.ToUInt64(steamIdTextBox.Text);
            playerProfile = await playerProfile.DownloadData(playerProfile.SteamId);
            userNameTextBox.Text = playerProfile.PlayerName;
            accountCreationDateTextBox.Text = playerProfile.AccountCreationDate.ToString();
            activityLabel.Text = playerProfile.PlayerStatus.ToString();
            gamesNumberTextBox.Text = playerProfile.OwnedGames.Count.ToString();
            friendsNumberTextBox.Text = playerProfile.NumberOfFriends.ToString();
            avatarPictureBox.LoadAsync(playerProfile.Url);
            var lista = playerProfile.OwnedGames.Select(x => x.Name).ToList();
            listBox1.DataSource = lista;
            playedHoursTextBox.Text = playerProfile.TotalHoursPlayed.ToString();

            var client = new WebClient();
            int sumaPierwotna = 0;
            int sumaAktualna = 0;

            foreach (var item in playerProfile.OwnedGames)
            {
                string response = client.DownloadString($@"https://store.steampowered.com/api/appdetails?appids={item.GameId}&cc=pl&l=pl");
                Regex rx = new Regex("(?<=price_overview\":)(.*)(?=,\"packages\")");
                response = rx.Match(response).Value;
                if (!String.IsNullOrEmpty(response))
                {
                    Prices.Rootobject appDetails = JsonSerializer.Deserialize<Prices.Rootobject>(response);
                    sumaPierwotna += appDetails.initial;
                    sumaAktualna += appDetails.final;
                }


            }
            initialGamesValueTextBox.Text = (sumaPierwotna / 100).ToString() + " PLN";
            finalGamesValueTextBox.Text = (sumaAktualna / 100).ToString() + " PLN";

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var a = listBox1.SelectedItem;
                gameplayTimeTextBox.Text = playerProfile.OwnedGames.First(x => x.Name.Equals(a)).PlayTime.ToString();
            }
            catch (Exception)
            {
            }
            
        }


        private void xmlExportButtonClick(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new(typeof(PlayerProfile));
            using (StringWriter writer = new())
            {
                xmlSerializer.Serialize(writer, playerProfile);
                var testXML = writer.ToString();
                System.IO.File.WriteAllText("xml.xml", testXML);
            }
            
        }

        private void jsonImportButtonClick(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            accountCreationDateTextBox.Clear();
            activityLabel.Text = "";
            gamesNumberTextBox.Clear();
            friendsNumberTextBox.Clear();
            avatarPictureBox.Image = null;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;
                string json = System.IO.File.ReadAllText(path);
                playerProfile = System.Text.Json.JsonSerializer.Deserialize<PlayerProfile>(json);
            }
            userNameTextBox.Text = playerProfile.PlayerName;
            accountCreationDateTextBox.Text = playerProfile.AccountCreationDate.ToString();
            activityLabel.Text = playerProfile.PlayerStatus.ToString();
            gamesNumberTextBox.Text = playerProfile.OwnedGames.Count.ToString();
            friendsNumberTextBox.Text = playerProfile.NumberOfFriends.ToString();
            avatarPictureBox.LoadAsync(playerProfile.Url);
            var lista = playerProfile.OwnedGames.Select(x => x.Name).ToList();
            listBox1.DataSource = lista;
            playedHoursTextBox.Text = playerProfile.TotalHoursPlayed.ToString();
        }

        private void xmlImportButtonClick(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            accountCreationDateTextBox.Clear();
            activityLabel.Text = "";
            gamesNumberTextBox.Clear();
            friendsNumberTextBox.Clear();
            avatarPictureBox.Image = null;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            XmlSerializer xmlSerializer = new(typeof(PlayerProfile));
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;
                string json = System.IO.File.ReadAllText(path);
                using (Stream stream = new FileStream(path, FileMode.Open))
                {
                    playerProfile = (PlayerProfile)xmlSerializer.Deserialize(stream);
                }
            }
            userNameTextBox.Text = playerProfile.PlayerName;
            accountCreationDateTextBox.Text = playerProfile.AccountCreationDate.ToString();
            activityLabel.Text = playerProfile.PlayerStatus.ToString();
            gamesNumberTextBox.Text = playerProfile.OwnedGames.Count.ToString();
            friendsNumberTextBox.Text = playerProfile.NumberOfFriends.ToString();
            avatarPictureBox.LoadAsync(playerProfile.Url);
            var lista = playerProfile.OwnedGames.Select(x => x.Name).ToList();
            listBox1.DataSource = lista;
            playedHoursTextBox.Text = playerProfile.TotalHoursPlayed.ToString();
        }

        private void jsonExportButtonClick(object sender, EventArgs e)
        {
            var testJSON = System.Text.Json.JsonSerializer.Serialize(playerProfile);
            System.IO.File.WriteAllText("json.json", testJSON);
        }

        private void insertToDbButton_Click(object sender, EventArgs e)
        {
            string connectionString = "" +
            "datasource=127.0.0.1;" + // adres domyślny dlaserwera lokalnego
"port=3306;" + // domyślny port
"username=root;" + // domyślna nazwa użytkownika który ma dostęp do bazy danych
"password=;" + // hasło dostępowe
"SslMode = none;"
+ "database=integracja_steam_projekt;";
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command;
            string query = @"INSERT INTO `player_profile` (`steam_id`, `player_name`, `account_create_date`, `player_status`, `avatar_url`, `number_of_friends`, `total_hours_played`)
                            VALUES (@steamId, @playerName, @accountCreateDate, @playerStatus, @avatarUrl, @numberOfFriends, @totalHoursPlayed)";
            command = new(query, connection);
            command.CommandTimeout = 60;
            command.Parameters.AddWithValue("@steamId", playerProfile.SteamId.ToString());
            command.Parameters.AddWithValue("@playerName", playerProfile.PlayerName);
            command.Parameters.AddWithValue("@accountCreateDate", playerProfile.AccountCreationDate);
            command.Parameters.AddWithValue("@playerStatus", playerProfile.PlayerStatus);
            command.Parameters.AddWithValue("@avatarUrl", playerProfile.Url);
            command.Parameters.AddWithValue("@numberOfFriends", playerProfile.NumberOfFriends);
            command.Parameters.AddWithValue("@totalHoursPlayed", playerProfile.TotalHoursPlayed);
            command.ExecuteNonQuery();

            query = "SELECT LAST_INSERT_ID();";
            command = new(query, connection);
            int raport_id = Convert.ToInt32(command.ExecuteScalar());

            StringBuilder sCommand = new StringBuilder("INSERT INTO `owned_games` (`game_name`, `play_time`, `raport_id`) VALUES ");
            List<string> rows = new();
            foreach (var item in playerProfile.OwnedGames)
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
            string connectionString = "" +
            "datasource=127.0.0.1;" + // adres domyślny dlaserwera lokalnego
"port=3306;" + // domyślny port
"username=root;" + // domyślna nazwa użytkownika który ma dostęp do bazy danych
"password=;" + // hasło dostępowe
"SslMode = none;"
+ "database=integracja_steam_projekt;";
            MySqlConnection connection = new(connectionString);
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

            MemoryStream uploadStream = new MemoryStream(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(playerProfile)));

            Google.Apis.Drive.v3.Data.File driveFile = new Google.Apis.Drive.v3.Data.File
            {
                Name = "test.json"
            };
            // Get the media upload request object.
            FilesResource.CreateMediaUpload insertRequest = service.Files.Create(
                driveFile, uploadStream, "application/json");
            insertRequest.Upload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\grabowiecm\source\repos\pllub\pllub\bin\Release\net5.0\pllub.exe");
        }

    }
}
