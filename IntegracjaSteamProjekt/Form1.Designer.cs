
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
            this.apiGatewayStateLabel = new System.Windows.Forms.Label();
            this.soapApiStateLabel = new System.Windows.Forms.Label();
            this.apiGatewayStopButton = new System.Windows.Forms.Button();
            this.soapApiStopButton = new System.Windows.Forms.Button();
            this.apigatewayStartButton = new System.Windows.Forms.Button();
            this.soapApiStartButton = new System.Windows.Forms.Button();
            this.googleDriveButton = new System.Windows.Forms.Button();
            this.initialGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.finalGamesValueTextBox = new System.Windows.Forms.TextBox();
            this.insertToDbButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPlayedHoursTextBox = new System.Windows.Forms.TextBox();
            this.xmlImportButton = new System.Windows.Forms.Button();
            this.jsonImportButton = new System.Windows.Forms.Button();
            this.xmlExportButton = new System.Windows.Forms.Button();
            this.jsonExportButton = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.apiGatewayStateLabel);
            this.tabPage1.Controls.Add(this.soapApiStateLabel);
            this.tabPage1.Controls.Add(this.apiGatewayStopButton);
            this.tabPage1.Controls.Add(this.soapApiStopButton);
            this.tabPage1.Controls.Add(this.apigatewayStartButton);
            this.tabPage1.Controls.Add(this.soapApiStartButton);
            this.tabPage1.Controls.Add(this.googleDriveButton);
            this.tabPage1.Controls.Add(this.initialGamesValueTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.finalGamesValueTextBox);
            this.tabPage1.Controls.Add(this.insertToDbButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.totalPlayedHoursTextBox);
            this.tabPage1.Controls.Add(this.xmlImportButton);
            this.tabPage1.Controls.Add(this.jsonImportButton);
            this.tabPage1.Controls.Add(this.xmlExportButton);
            this.tabPage1.Controls.Add(this.jsonExportButton);
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
            this.tabPage1.Size = new System.Drawing.Size(1195, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // apiGatewayStateLabel
            // 
            this.apiGatewayStateLabel.AutoSize = true;
            this.apiGatewayStateLabel.BackColor = System.Drawing.Color.Red;
            this.apiGatewayStateLabel.Location = new System.Drawing.Point(384, 252);
            this.apiGatewayStateLabel.Name = "apiGatewayStateLabel";
            this.apiGatewayStateLabel.Size = new System.Drawing.Size(72, 15);
            this.apiGatewayStateLabel.TabIndex = 37;
            this.apiGatewayStateLabel.Text = "Not running";
            // 
            // soapApiStateLabel
            // 
            this.soapApiStateLabel.AutoSize = true;
            this.soapApiStateLabel.BackColor = System.Drawing.Color.Red;
            this.soapApiStateLabel.Location = new System.Drawing.Point(276, 252);
            this.soapApiStateLabel.Name = "soapApiStateLabel";
            this.soapApiStateLabel.Size = new System.Drawing.Size(72, 15);
            this.soapApiStateLabel.TabIndex = 36;
            this.soapApiStateLabel.Text = "Not running";
            // 
            // apiGatewayStopButton
            // 
            this.apiGatewayStopButton.Enabled = false;
            this.apiGatewayStopButton.Location = new System.Drawing.Point(365, 334);
            this.apiGatewayStopButton.Name = "apiGatewayStopButton";
            this.apiGatewayStopButton.Size = new System.Drawing.Size(109, 40);
            this.apiGatewayStopButton.TabIndex = 35;
            this.apiGatewayStopButton.Text = "Api gateway stop";
            this.apiGatewayStopButton.UseVisualStyleBackColor = true;
            this.apiGatewayStopButton.Click += new System.EventHandler(this.ApiGatewayStopButton_Click);
            // 
            // soapApiStopButton
            // 
            this.soapApiStopButton.Enabled = false;
            this.soapApiStopButton.Location = new System.Drawing.Point(257, 318);
            this.soapApiStopButton.Name = "soapApiStopButton";
            this.soapApiStopButton.Size = new System.Drawing.Size(102, 24);
            this.soapApiStopButton.TabIndex = 34;
            this.soapApiStopButton.Text = "Soap api stop";
            this.soapApiStopButton.UseVisualStyleBackColor = true;
            this.soapApiStopButton.Click += new System.EventHandler(this.SoapApiStopButton_Click);
            // 
            // apigatewayStartButton
            // 
            this.apigatewayStartButton.Location = new System.Drawing.Point(365, 288);
            this.apigatewayStartButton.Name = "apigatewayStartButton";
            this.apigatewayStartButton.Size = new System.Drawing.Size(109, 40);
            this.apigatewayStartButton.TabIndex = 33;
            this.apigatewayStartButton.Text = "Api gateway start";
            this.apigatewayStartButton.UseVisualStyleBackColor = true;
            this.apigatewayStartButton.Click += new System.EventHandler(this.ApigatewayStartButton_Click);
            // 
            // soapApiStartButton
            // 
            this.soapApiStartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.soapApiStartButton.Location = new System.Drawing.Point(257, 288);
            this.soapApiStartButton.Name = "soapApiStartButton";
            this.soapApiStartButton.Size = new System.Drawing.Size(102, 23);
            this.soapApiStartButton.TabIndex = 32;
            this.soapApiStartButton.Text = "Soap api start";
            this.soapApiStartButton.UseVisualStyleBackColor = true;
            this.soapApiStartButton.Click += new System.EventHandler(this.SoapApiStartButton_Click);
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
            this.insertToDbButton.Click += new System.EventHandler(this.InsertToDbButton_Click);
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
            this.totalPlayedHoursTextBox.Size = new System.Drawing.Size(169, 23);
            this.totalPlayedHoursTextBox.TabIndex = 23;
            // 
            // xmlImportButton
            // 
            this.xmlImportButton.Location = new System.Drawing.Point(141, 270);
            this.xmlImportButton.Name = "xmlImportButton";
            this.xmlImportButton.Size = new System.Drawing.Size(88, 21);
            this.xmlImportButton.TabIndex = 22;
            this.xmlImportButton.Tag = "xml";
            this.xmlImportButton.Text = "xmlImport";
            this.xmlImportButton.UseVisualStyleBackColor = true;
            this.xmlImportButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // jsonImportButton
            // 
            this.jsonImportButton.Location = new System.Drawing.Point(141, 240);
            this.jsonImportButton.Name = "jsonImportButton";
            this.jsonImportButton.Size = new System.Drawing.Size(88, 24);
            this.jsonImportButton.TabIndex = 21;
            this.jsonImportButton.Tag = "json";
            this.jsonImportButton.Text = "Import JSON";
            this.jsonImportButton.UseVisualStyleBackColor = true;
            this.jsonImportButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // xmlExportButton
            // 
            this.xmlExportButton.Location = new System.Drawing.Point(14, 270);
            this.xmlExportButton.Name = "xmlExportButton";
            this.xmlExportButton.Size = new System.Drawing.Size(88, 21);
            this.xmlExportButton.TabIndex = 20;
            this.xmlExportButton.Tag = "xml";
            this.xmlExportButton.Text = "Export XML";
            this.xmlExportButton.UseVisualStyleBackColor = true;
            this.xmlExportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // jsonExportButton
            // 
            this.jsonExportButton.Location = new System.Drawing.Point(14, 240);
            this.jsonExportButton.Name = "jsonExportButton";
            this.jsonExportButton.Size = new System.Drawing.Size(88, 24);
            this.jsonExportButton.TabIndex = 19;
            this.jsonExportButton.Tag = "json";
            this.jsonExportButton.Text = "Export JSON";
            this.jsonExportButton.UseVisualStyleBackColor = true;
            this.jsonExportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // gameplayTimeTextBox
            // 
            this.gameplayTimeTextBox.Location = new System.Drawing.Point(1078, 119);
            this.gameplayTimeTextBox.Name = "gameplayTimeTextBox";
            this.gameplayTimeTextBox.Size = new System.Drawing.Size(84, 23);
            this.gameplayTimeTextBox.TabIndex = 18;
            // 
            // playerOwnedGamesListBox
            // 
            this.playerOwnedGamesListBox.FormattingEnabled = true;
            this.playerOwnedGamesListBox.ItemHeight = 15;
            this.playerOwnedGamesListBox.Location = new System.Drawing.Point(704, 119);
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
            this.searchButton.Location = new System.Drawing.Point(965, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(791, 14);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(153, 23);
            this.steamIdTextBox.TabIndex = 8;
            this.steamIdTextBox.Text = "76561198182526571";
            // 
            // profileStatusLabel
            // 
            this.profileStatusLabel.AutoSize = true;
            this.profileStatusLabel.Location = new System.Drawing.Point(257, 157);
            this.profileStatusLabel.Name = "profileStatusLabel";
            this.profileStatusLabel.Size = new System.Drawing.Size(38, 15);
            this.profileStatusLabel.TabIndex = 6;
            this.profileStatusLabel.Text = "label1";
            this.profileStatusLabel.TextChanged += new System.EventHandler(this.activityLabel_TextChanged);
            // 
            // numberOfFriendsTextBox
            // 
            this.numberOfFriendsTextBox.Location = new System.Drawing.Point(373, 93);
            this.numberOfFriendsTextBox.Name = "numberOfFriendsTextBox";
            this.numberOfFriendsTextBox.Size = new System.Drawing.Size(169, 23);
            this.numberOfFriendsTextBox.TabIndex = 5;
            // 
            // numberOfOwnedGamesTextBox
            // 
            this.numberOfOwnedGamesTextBox.Location = new System.Drawing.Point(373, 64);
            this.numberOfOwnedGamesTextBox.Name = "numberOfOwnedGamesTextBox";
            this.numberOfOwnedGamesTextBox.Size = new System.Drawing.Size(169, 23);
            this.numberOfOwnedGamesTextBox.TabIndex = 4;
            // 
            // accountCreationDateTextBox
            // 
            this.accountCreationDateTextBox.Location = new System.Drawing.Point(373, 35);
            this.accountCreationDateTextBox.Name = "accountCreationDateTextBox";
            this.accountCreationDateTextBox.Size = new System.Drawing.Size(169, 23);
            this.accountCreationDateTextBox.TabIndex = 3;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(373, 6);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.playerNameTextBox.TabIndex = 1;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

