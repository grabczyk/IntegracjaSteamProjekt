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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.googleDriveButton = new System.Windows.Forms.Button();
            this.googleDriveLinkTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.apiGatewayStateLabel = new System.Windows.Forms.Label();
            this.apigatewayStartButton = new System.Windows.Forms.Button();
            this.apiGatewayStopButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.soapApiStateLabel = new System.Windows.Forms.Label();
            this.soapApiStartButton = new System.Windows.Forms.Button();
            this.soapApiStopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jsonImportButton = new System.Windows.Forms.Button();
            this.xmlImportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jsonExportButton = new System.Windows.Forms.Button();
            this.xmlExportButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gameDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.initialGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.finalGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.insertToDbButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPlayedHoursTextBox = new System.Windows.Forms.TextBox();
            this.gameplayTimeTextBox = new System.Windows.Forms.TextBox();
            this.playerOwnedGamesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.profileStatusLabel = new System.Windows.Forms.Label();
            this.numberOfFriendsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfOwnedGamesTextBox = new System.Windows.Forms.TextBox();
            this.accountCreationDateTextBox = new System.Windows.Forms.TextBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ownedGamesGridView = new System.Windows.Forms.DataGridView();
            this.downloadFromDatabaseButton = new System.Windows.Forms.Button();
            this.playerProfileGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedGamesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProfileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.gameDescriptionTextBox);
            this.tabPage1.Controls.Add(this.initialGamesValueTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.finalGamesValueTextBox);
            this.tabPage1.Controls.Add(this.insertToDbButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.totalPlayedHoursTextBox);
            this.tabPage1.Controls.Add(this.gameplayTimeTextBox);
            this.tabPage1.Controls.Add(this.playerOwnedGamesListBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.steamIdTextBox);
            this.tabPage1.Controls.Add(this.profileStatusLabel);
            this.tabPage1.Controls.Add(this.numberOfFriendsTextBox);
            this.tabPage1.Controls.Add(this.numberOfOwnedGamesTextBox);
            this.tabPage1.Controls.Add(this.accountCreationDateTextBox);
            this.tabPage1.Controls.Add(this.playerNameTextBox);
            this.tabPage1.Controls.Add(this.avatarPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.googleDriveButton);
            this.groupBox5.Controls.Add(this.googleDriveLinkTextBox);
            this.groupBox5.Location = new System.Drawing.Point(14, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 59);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Google Drive";
            // 
            // googleDriveButton
            // 
            this.googleDriveButton.Enabled = false;
            this.googleDriveButton.Location = new System.Drawing.Point(6, 22);
            this.googleDriveButton.Name = "googleDriveButton";
            this.googleDriveButton.Size = new System.Drawing.Size(75, 23);
            this.googleDriveButton.TabIndex = 31;
            this.googleDriveButton.Text = "Drive";
            this.googleDriveButton.UseVisualStyleBackColor = true;
            this.googleDriveButton.Click += new System.EventHandler(this.GoogleDriveButton_Click);
            // 
            // googleDriveLinkTextBox
            // 
            this.googleDriveLinkTextBox.Location = new System.Drawing.Point(88, 22);
            this.googleDriveLinkTextBox.Name = "googleDriveLinkTextBox";
            this.googleDriveLinkTextBox.ReadOnly = true;
            this.googleDriveLinkTextBox.Size = new System.Drawing.Size(434, 23);
            this.googleDriveLinkTextBox.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.apiGatewayStateLabel);
            this.groupBox4.Controls.Add(this.apigatewayStartButton);
            this.groupBox4.Controls.Add(this.apiGatewayStopButton);
            this.groupBox4.Location = new System.Drawing.Point(345, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 132);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API GATEWAY";
            // 
            // apiGatewayStateLabel
            // 
            this.apiGatewayStateLabel.AutoSize = true;
            this.apiGatewayStateLabel.BackColor = System.Drawing.Color.Red;
            this.apiGatewayStateLabel.Location = new System.Drawing.Point(28, 19);
            this.apiGatewayStateLabel.Name = "apiGatewayStateLabel";
            this.apiGatewayStateLabel.Size = new System.Drawing.Size(72, 15);
            this.apiGatewayStateLabel.TabIndex = 37;
            this.apiGatewayStateLabel.Text = "Not running";
            // 
            // apigatewayStartButton
            // 
            this.apigatewayStartButton.Location = new System.Drawing.Point(9, 42);
            this.apigatewayStartButton.Name = "apigatewayStartButton";
            this.apigatewayStartButton.Size = new System.Drawing.Size(109, 40);
            this.apigatewayStartButton.TabIndex = 33;
            this.apigatewayStartButton.Text = "Api gateway start";
            this.apigatewayStartButton.UseVisualStyleBackColor = true;
            this.apigatewayStartButton.Click += new System.EventHandler(this.ApigatewayStartButton_Click);
            // 
            // apiGatewayStopButton
            // 
            this.apiGatewayStopButton.Enabled = false;
            this.apiGatewayStopButton.Location = new System.Drawing.Point(9, 88);
            this.apiGatewayStopButton.Name = "apiGatewayStopButton";
            this.apiGatewayStopButton.Size = new System.Drawing.Size(109, 40);
            this.apiGatewayStopButton.TabIndex = 35;
            this.apiGatewayStopButton.Text = "Api gateway stop";
            this.apiGatewayStopButton.UseVisualStyleBackColor = true;
            this.apiGatewayStopButton.Click += new System.EventHandler(this.ApiGatewayStopButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.soapApiStateLabel);
            this.groupBox3.Controls.Add(this.soapApiStartButton);
            this.groupBox3.Controls.Add(this.soapApiStopButton);
            this.groupBox3.Location = new System.Drawing.Point(225, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 105);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOAP API";
            // 
            // soapApiStateLabel
            // 
            this.soapApiStateLabel.AutoSize = true;
            this.soapApiStateLabel.BackColor = System.Drawing.Color.Red;
            this.soapApiStateLabel.Location = new System.Drawing.Point(24, 19);
            this.soapApiStateLabel.Name = "soapApiStateLabel";
            this.soapApiStateLabel.Size = new System.Drawing.Size(72, 15);
            this.soapApiStateLabel.TabIndex = 36;
            this.soapApiStateLabel.Text = "Not running";
            // 
            // soapApiStartButton
            // 
            this.soapApiStartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.soapApiStartButton.Location = new System.Drawing.Point(6, 42);
            this.soapApiStartButton.Name = "soapApiStartButton";
            this.soapApiStartButton.Size = new System.Drawing.Size(102, 23);
            this.soapApiStartButton.TabIndex = 32;
            this.soapApiStartButton.Text = "Soap api start";
            this.soapApiStartButton.UseVisualStyleBackColor = true;
            this.soapApiStartButton.Click += new System.EventHandler(this.SoapApiStartButton_Click);
            // 
            // soapApiStopButton
            // 
            this.soapApiStopButton.Enabled = false;
            this.soapApiStopButton.Location = new System.Drawing.Point(6, 72);
            this.soapApiStopButton.Name = "soapApiStopButton";
            this.soapApiStopButton.Size = new System.Drawing.Size(102, 24);
            this.soapApiStopButton.TabIndex = 34;
            this.soapApiStopButton.Text = "Soap api stop";
            this.soapApiStopButton.UseVisualStyleBackColor = true;
            this.soapApiStopButton.Click += new System.EventHandler(this.SoapApiStopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jsonImportButton);
            this.groupBox2.Controls.Add(this.xmlImportButton);
            this.groupBox2.Location = new System.Drawing.Point(118, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 83);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import";
            // 
            // jsonImportButton
            // 
            this.jsonImportButton.Location = new System.Drawing.Point(6, 22);
            this.jsonImportButton.Name = "jsonImportButton";
            this.jsonImportButton.Size = new System.Drawing.Size(88, 24);
            this.jsonImportButton.TabIndex = 21;
            this.jsonImportButton.Tag = "json";
            this.jsonImportButton.Text = "Import JSON";
            this.jsonImportButton.UseVisualStyleBackColor = true;
            this.jsonImportButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // xmlImportButton
            // 
            this.xmlImportButton.Location = new System.Drawing.Point(6, 52);
            this.xmlImportButton.Name = "xmlImportButton";
            this.xmlImportButton.Size = new System.Drawing.Size(88, 24);
            this.xmlImportButton.TabIndex = 22;
            this.xmlImportButton.Tag = "xml";
            this.xmlImportButton.Text = "Import XML";
            this.xmlImportButton.UseVisualStyleBackColor = true;
            this.xmlImportButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jsonExportButton);
            this.groupBox1.Controls.Add(this.xmlExportButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 83);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // jsonExportButton
            // 
            this.jsonExportButton.Enabled = false;
            this.jsonExportButton.Location = new System.Drawing.Point(6, 22);
            this.jsonExportButton.Name = "jsonExportButton";
            this.jsonExportButton.Size = new System.Drawing.Size(88, 24);
            this.jsonExportButton.TabIndex = 19;
            this.jsonExportButton.Tag = "json";
            this.jsonExportButton.Text = "Export JSON";
            this.jsonExportButton.UseVisualStyleBackColor = true;
            this.jsonExportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // xmlExportButton
            // 
            this.xmlExportButton.Enabled = false;
            this.xmlExportButton.Location = new System.Drawing.Point(6, 52);
            this.xmlExportButton.Name = "xmlExportButton";
            this.xmlExportButton.Size = new System.Drawing.Size(88, 24);
            this.xmlExportButton.TabIndex = 20;
            this.xmlExportButton.Tag = "xml";
            this.xmlExportButton.Text = "Export XML";
            this.xmlExportButton.UseVisualStyleBackColor = true;
            this.xmlExportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Opis gry:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Liczba godzin w grze:";
            // 
            // gameDescriptionTextBox
            // 
            this.gameDescriptionTextBox.Location = new System.Drawing.Point(551, 195);
            this.gameDescriptionTextBox.Multiline = true;
            this.gameDescriptionTextBox.Name = "gameDescriptionTextBox";
            this.gameDescriptionTextBox.ReadOnly = true;
            this.gameDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameDescriptionTextBox.Size = new System.Drawing.Size(354, 71);
            this.gameDescriptionTextBox.TabIndex = 38;
            // 
            // initialGamesValueTextBox
            // 
            this.initialGamesValueTextBox.Location = new System.Drawing.Point(705, 273);
            this.initialGamesValueTextBox.Name = "initialGamesValueTextBox";
            this.initialGamesValueTextBox.ReadOnly = true;
            this.initialGamesValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.initialGamesValueTextBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Pierwotna wartość koszyka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Aktualna wartość koszyka:";
            // 
            // finalGamesValueTextBox
            // 
            this.finalGamesValueTextBox.Location = new System.Drawing.Point(705, 300);
            this.finalGamesValueTextBox.Name = "finalGamesValueTextBox";
            this.finalGamesValueTextBox.ReadOnly = true;
            this.finalGamesValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.finalGamesValueTextBox.TabIndex = 27;
            // 
            // insertToDbButton
            // 
            this.insertToDbButton.Enabled = false;
            this.insertToDbButton.Location = new System.Drawing.Point(548, 329);
            this.insertToDbButton.Name = "insertToDbButton";
            this.insertToDbButton.Size = new System.Drawing.Size(158, 43);
            this.insertToDbButton.TabIndex = 26;
            this.insertToDbButton.Text = "Dodaj profil gracza do bazy";
            this.insertToDbButton.UseVisualStyleBackColor = true;
            this.insertToDbButton.Click += new System.EventHandler(this.InsertToDbButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "SteamId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Łączna liczba godzin w grach:";
            // 
            // totalPlayedHoursTextBox
            // 
            this.totalPlayedHoursTextBox.Location = new System.Drawing.Point(373, 122);
            this.totalPlayedHoursTextBox.Name = "totalPlayedHoursTextBox";
            this.totalPlayedHoursTextBox.ReadOnly = true;
            this.totalPlayedHoursTextBox.Size = new System.Drawing.Size(169, 23);
            this.totalPlayedHoursTextBox.TabIndex = 23;
            // 
            // gameplayTimeTextBox
            // 
            this.gameplayTimeTextBox.Location = new System.Drawing.Point(676, 139);
            this.gameplayTimeTextBox.Name = "gameplayTimeTextBox";
            this.gameplayTimeTextBox.ReadOnly = true;
            this.gameplayTimeTextBox.Size = new System.Drawing.Size(84, 23);
            this.gameplayTimeTextBox.TabIndex = 18;
            // 
            // playerOwnedGamesListBox
            // 
            this.playerOwnedGamesListBox.FormattingEnabled = true;
            this.playerOwnedGamesListBox.ItemHeight = 15;
            this.playerOwnedGamesListBox.Location = new System.Drawing.Point(554, 42);
            this.playerOwnedGamesListBox.Name = "playerOwnedGamesListBox";
            this.playerOwnedGamesListBox.Size = new System.Drawing.Size(352, 94);
            this.playerOwnedGamesListBox.TabIndex = 16;
            this.playerOwnedGamesListBox.SelectedValueChanged += new System.EventHandler(this.PlayerOwnedGamesListBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ilość znajomych:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liczba posiadanych gier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data utworzenia konta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(784, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(610, 5);
            this.steamIdTextBox.MaxLength = 17;
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(153, 23);
            this.steamIdTextBox.TabIndex = 8;
            this.steamIdTextBox.Text = "76561198182526571";
            this.steamIdTextBox.TextChanged += new System.EventHandler(this.SteamIdTextBox_TextChanged);
            this.steamIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SteamIdTextBox_KeyPress);
            // 
            // profileStatusLabel
            // 
            this.profileStatusLabel.AutoSize = true;
            this.profileStatusLabel.Location = new System.Drawing.Point(257, 157);
            this.profileStatusLabel.Name = "profileStatusLabel";
            this.profileStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.profileStatusLabel.TabIndex = 6;
            this.profileStatusLabel.TextChanged += new System.EventHandler(this.ActivityLabel_TextChanged);
            // 
            // numberOfFriendsTextBox
            // 
            this.numberOfFriendsTextBox.Location = new System.Drawing.Point(373, 93);
            this.numberOfFriendsTextBox.Name = "numberOfFriendsTextBox";
            this.numberOfFriendsTextBox.ReadOnly = true;
            this.numberOfFriendsTextBox.Size = new System.Drawing.Size(169, 23);
            this.numberOfFriendsTextBox.TabIndex = 5;
            // 
            // numberOfOwnedGamesTextBox
            // 
            this.numberOfOwnedGamesTextBox.Location = new System.Drawing.Point(373, 64);
            this.numberOfOwnedGamesTextBox.Name = "numberOfOwnedGamesTextBox";
            this.numberOfOwnedGamesTextBox.ReadOnly = true;
            this.numberOfOwnedGamesTextBox.Size = new System.Drawing.Size(169, 23);
            this.numberOfOwnedGamesTextBox.TabIndex = 4;
            // 
            // accountCreationDateTextBox
            // 
            this.accountCreationDateTextBox.Location = new System.Drawing.Point(373, 35);
            this.accountCreationDateTextBox.Name = "accountCreationDateTextBox";
            this.accountCreationDateTextBox.ReadOnly = true;
            this.accountCreationDateTextBox.Size = new System.Drawing.Size(169, 23);
            this.accountCreationDateTextBox.TabIndex = 3;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(373, 6);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.ReadOnly = true;
            this.playerNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.Gray;
            this.avatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarPictureBox.Location = new System.Drawing.Point(8, 6);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(184, 184);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ownedGamesGridView);
            this.tabPage2.Controls.Add(this.downloadFromDatabaseButton);
            this.tabPage2.Controls.Add(this.playerProfileGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Posiadane gry gracza dla danego raportu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Raporty profilu gracza";
            // 
            // ownedGamesGridView
            // 
            this.ownedGamesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ownedGamesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedGamesGridView.Location = new System.Drawing.Point(6, 196);
            this.ownedGamesGridView.Name = "ownedGamesGridView";
            this.ownedGamesGridView.RowTemplate.Height = 25;
            this.ownedGamesGridView.Size = new System.Drawing.Size(900, 147);
            this.ownedGamesGridView.TabIndex = 2;
            // 
            // downloadFromDatabaseButton
            // 
            this.downloadFromDatabaseButton.Location = new System.Drawing.Point(7, 349);
            this.downloadFromDatabaseButton.Name = "downloadFromDatabaseButton";
            this.downloadFromDatabaseButton.Size = new System.Drawing.Size(160, 43);
            this.downloadFromDatabaseButton.TabIndex = 1;
            this.downloadFromDatabaseButton.Text = "Pobierz dane z bazy danych";
            this.downloadFromDatabaseButton.UseVisualStyleBackColor = true;
            this.downloadFromDatabaseButton.Click += new System.EventHandler(this.DownloadFromDatabaseButton_Click);
            // 
            // playerProfileGridView
            // 
            this.playerProfileGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerProfileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerProfileGridView.Location = new System.Drawing.Point(8, 21);
            this.playerProfileGridView.Name = "playerProfileGridView";
            this.playerProfileGridView.RowTemplate.Height = 25;
            this.playerProfileGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playerProfileGridView.Size = new System.Drawing.Size(898, 147);
            this.playerProfileGridView.TabIndex = 0;
            this.playerProfileGridView.SelectionChanged += new System.EventHandler(this.PlayerProfileGridView_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 431);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integracja Systemów Informatycznych - projekt końcowy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedGamesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerProfileGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label profileStatusLabel;
        private System.Windows.Forms.TextBox numberOfFriendsTextBox;
        private System.Windows.Forms.TextBox numberOfOwnedGamesTextBox;
        private System.Windows.Forms.TextBox accountCreationDateTextBox;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox playerOwnedGamesListBox;
        private System.Windows.Forms.TextBox gameplayTimeTextBox;
        private System.Windows.Forms.Button jsonExportButton;
        private System.Windows.Forms.Button xmlExportButton;
        private System.Windows.Forms.Button xmlImportButton;
        private System.Windows.Forms.Button jsonImportButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPlayedHoursTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertToDbButton;
        private System.Windows.Forms.Button downloadFromDatabaseButton;
        private System.Windows.Forms.DataGridView playerProfileGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox finalGamesValueTextBox;
        private System.Windows.Forms.TextBox initialGamesValueTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button googleDriveButton;
        public System.Windows.Forms.TextBox steamIdTextBox;
        public System.Windows.Forms.Label soapApiStateLabel;
        public System.Windows.Forms.Label apiGatewayStateLabel;
        public System.Windows.Forms.Button soapApiStartButton;
        public System.Windows.Forms.Button apigatewayStartButton;
        public System.Windows.Forms.Button soapApiStopButton;
        public System.Windows.Forms.Button apiGatewayStopButton;
        private System.Windows.Forms.TextBox gameDescriptionTextBox;
        private System.Windows.Forms.DataGridView ownedGamesGridView;
        private System.Windows.Forms.TextBox googleDriveLinkTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

