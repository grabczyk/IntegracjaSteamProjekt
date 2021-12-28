using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracjaSteamProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PlayerProfile playerProfile = new();
            playerProfile = await playerProfile.DownloadData(Convert.ToUInt64(steamIdTextBox.Text));
            userNameTextBox.Text = playerProfile.PlayerName;
            lastLogOffTextBox.Text = playerProfile.LastLogOff.ToString();
            activityLabel.Text = playerProfile.PlayerStatus.ToString();
            avatarPictureBox.LoadAsync(playerProfile.Url);
        }
    }
}
