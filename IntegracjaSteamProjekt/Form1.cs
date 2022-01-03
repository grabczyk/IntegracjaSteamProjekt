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

namespace IntegracjaSteamProjekt
{
    public partial class Form1 : Form
    {
        PlayerProfile playerProfile;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            playerProfile = new();
            playerProfile = await playerProfile.DownloadData(Convert.ToUInt64(steamIdTextBox.Text));
            userNameTextBox.Text = playerProfile.PlayerName;
            accountCreationDateTextBox.Text = playerProfile.AccountCreationDate.ToString();
            activityLabel.Text = playerProfile.PlayerStatus.ToString();
            gamesNumberTextBox.Text = playerProfile.OwnedGames.Count.ToString();
            friendsNumberTextBox.Text = playerProfile.NumberOfFriends.ToString();
            avatarPictureBox.LoadAsync(playerProfile.Url);
            var lista = playerProfile.OwnedGames.Select(x => x.Name).ToList();
            listBox1.DataSource = lista;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var testJSON = JsonSerializer.Serialize(playerProfile);
            File.WriteAllText("json.json", testJSON);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new(typeof(PlayerProfile));
            using (StringWriter writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, playerProfile);
                var testXML = writer.ToString();
                File.WriteAllText("xml.xml", testXML);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            accountCreationDateTextBox.Clear();
            activityLabel.Text = "";
            gamesNumberTextBox.Clear();
            friendsNumberTextBox.Clear();
            avatarPictureBox.Image = null;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
        }

        private void button5_Click(object sender, EventArgs e)
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
        }
    }
}
