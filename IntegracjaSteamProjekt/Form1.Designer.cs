﻿
namespace IntegracjaSteamProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.googleDriveButton = new System.Windows.Forms.Button();
            this.initialGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.finalGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.insertToDbButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playedHoursTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameplayTimeTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.friendsNumberTextBox = new System.Windows.Forms.TextBox();
            this.gamesNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountCreationDateTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.downloadFromDatabaseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.googleDriveButton);
            this.tabPage1.Controls.Add(this.initialGamesValueTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.finalGamesValueTextBox);
            this.tabPage1.Controls.Add(this.insertToDbButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.playedHoursTextBox);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.gameplayTimeTextBox);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.steamIdTextBox);
            this.tabPage1.Controls.Add(this.activityLabel);
            this.tabPage1.Controls.Add(this.friendsNumberTextBox);
            this.tabPage1.Controls.Add(this.gamesNumberTextBox);
            this.tabPage1.Controls.Add(this.accountCreationDateTextBox);
            this.tabPage1.Controls.Add(this.userNameTextBox);
            this.tabPage1.Controls.Add(this.avatarPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // googleDriveButton
            // 
            this.googleDriveButton.Location = new System.Drawing.Point(735, 362);
            this.googleDriveButton.Name = "googleDriveButton";
            this.googleDriveButton.Size = new System.Drawing.Size(75, 23);
            this.googleDriveButton.TabIndex = 31;
            this.googleDriveButton.Text = "Drive";
            this.googleDriveButton.UseVisualStyleBackColor = true;
            this.googleDriveButton.Click += new System.EventHandler(this.googleDriveButton_Click);
            // 
            // initialGamesValueTextBox
            // 
            this.initialGamesValueTextBox.Location = new System.Drawing.Point(864, 217);
            this.initialGamesValueTextBox.Name = "initialGamesValueTextBox";
            this.initialGamesValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.initialGamesValueTextBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Pierwotna wartość koszyka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Aktualna wartość koszyka:";
            // 
            // finalGamesValueTextBox
            // 
            this.finalGamesValueTextBox.Location = new System.Drawing.Point(864, 249);
            this.finalGamesValueTextBox.Name = "finalGamesValueTextBox";
            this.finalGamesValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.finalGamesValueTextBox.TabIndex = 27;
            // 
            // insertToDbButton
            // 
            this.insertToDbButton.Location = new System.Drawing.Point(725, 278);
            this.insertToDbButton.Name = "insertToDbButton";
            this.insertToDbButton.Size = new System.Drawing.Size(168, 43);
            this.insertToDbButton.TabIndex = 26;
            this.insertToDbButton.Text = "Dodaj do bazy";
            this.insertToDbButton.UseVisualStyleBackColor = true;
            this.insertToDbButton.Click += new System.EventHandler(this.insertToDbButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "SteamId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Łączna liczba godzin w grach";
            // 
            // playedHoursTextBox
            // 
            this.playedHoursTextBox.Location = new System.Drawing.Point(366, 135);
            this.playedHoursTextBox.Name = "playedHoursTextBox";
            this.playedHoursTextBox.Size = new System.Drawing.Size(169, 23);
            this.playedHoursTextBox.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 74);
            this.button5.TabIndex = 22;
            this.button5.Text = "xmlImport";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.xmlImportButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 59);
            this.button4.TabIndex = 21;
            this.button4.Text = "jsonImport";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.jsonImportButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(357, 112);
            this.button3.TabIndex = 20;
            this.button3.Text = "XML!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.xmlExportButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 103);
            this.button2.TabIndex = 19;
            this.button2.Text = "jsonExportButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.jsonExportButtonClick);
            // 
            // gameplayTimeTextBox
            // 
            this.gameplayTimeTextBox.Location = new System.Drawing.Point(1078, 119);
            this.gameplayTimeTextBox.Name = "gameplayTimeTextBox";
            this.gameplayTimeTextBox.Size = new System.Drawing.Size(84, 23);
            this.gameplayTimeTextBox.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(704, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 94);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ilość znajomych:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liczba posiadanych gier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data utworzenia konta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(965, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(791, 14);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(153, 23);
            this.steamIdTextBox.TabIndex = 8;
            this.steamIdTextBox.Text = "76561198182526571";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(342, 175);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(38, 15);
            this.activityLabel.TabIndex = 6;
            this.activityLabel.Text = "label1";
            // 
            // friendsNumberTextBox
            // 
            this.friendsNumberTextBox.Location = new System.Drawing.Point(342, 106);
            this.friendsNumberTextBox.Name = "friendsNumberTextBox";
            this.friendsNumberTextBox.Size = new System.Drawing.Size(169, 23);
            this.friendsNumberTextBox.TabIndex = 5;
            // 
            // gamesNumberTextBox
            // 
            this.gamesNumberTextBox.Location = new System.Drawing.Point(342, 77);
            this.gamesNumberTextBox.Name = "gamesNumberTextBox";
            this.gamesNumberTextBox.Size = new System.Drawing.Size(169, 23);
            this.gamesNumberTextBox.TabIndex = 4;
            // 
            // accountCreationDateTextBox
            // 
            this.accountCreationDateTextBox.Location = new System.Drawing.Point(342, 35);
            this.accountCreationDateTextBox.Name = "accountCreationDateTextBox";
            this.accountCreationDateTextBox.Size = new System.Drawing.Size(169, 23);
            this.accountCreationDateTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(342, 6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.userNameTextBox.TabIndex = 1;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.Gray;
            this.avatarPictureBox.Location = new System.Drawing.Point(8, 6);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(184, 184);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.downloadFromDatabaseButton);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1195, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // downloadFromDatabaseButton
            // 
            this.downloadFromDatabaseButton.Location = new System.Drawing.Point(32, 544);
            this.downloadFromDatabaseButton.Name = "downloadFromDatabaseButton";
            this.downloadFromDatabaseButton.Size = new System.Drawing.Size(220, 44);
            this.downloadFromDatabaseButton.TabIndex = 1;
            this.downloadFromDatabaseButton.Text = "Podpierdol z bazy danych";
            this.downloadFromDatabaseButton.UseVisualStyleBackColor = true;
            this.downloadFromDatabaseButton.Click += new System.EventHandler(this.downloadFromDatabaseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.TextBox friendsNumberTextBox;
        private System.Windows.Forms.TextBox gamesNumberTextBox;
        private System.Windows.Forms.TextBox accountCreationDateTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox gameplayTimeTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox playedHoursTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertToDbButton;
        private System.Windows.Forms.Button downloadFromDatabaseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox finalGamesValueTextBox;
        private System.Windows.Forms.TextBox initialGamesValueTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button googleDriveButton;
        public System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.Button button1;
    }
}

