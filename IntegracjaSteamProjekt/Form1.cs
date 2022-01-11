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
                File.WriteAllText("xml.xml", testXML);
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
                string json = File.ReadAllText(path);
                playerProfile = JsonSerializer.Deserialize<PlayerProfile>(json);
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
                string json = File.ReadAllText(path);
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
            var testJSON = JsonSerializer.Serialize(playerProfile);
            File.WriteAllText("json.json", testJSON);
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
    }
}
