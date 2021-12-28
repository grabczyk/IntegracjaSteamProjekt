
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.lastPlayedGameTextEdit = new System.Windows.Forms.TextBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.friendsNumberTextBox = new System.Windows.Forms.TextBox();
            this.achivmentsNumberTextBox = new System.Windows.Forms.TextBox();
            this.lastLogOffTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
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
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.steamIdTextBox);
            this.tabPage1.Controls.Add(this.lastPlayedGameTextEdit);
            this.tabPage1.Controls.Add(this.activityLabel);
            this.tabPage1.Controls.Add(this.friendsNumberTextBox);
            this.tabPage1.Controls.Add(this.achivmentsNumberTextBox);
            this.tabPage1.Controls.Add(this.lastLogOffTextBox);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(534, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(906, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(791, 14);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.steamIdTextBox.TabIndex = 8;
            // 
            // lastPlayedGameTextEdit
            // 
            this.lastPlayedGameTextEdit.Location = new System.Drawing.Point(212, 135);
            this.lastPlayedGameTextEdit.Name = "lastPlayedGameTextEdit";
            this.lastPlayedGameTextEdit.Size = new System.Drawing.Size(169, 23);
            this.lastPlayedGameTextEdit.TabIndex = 7;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(418, 14);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(38, 15);
            this.activityLabel.TabIndex = 6;
            this.activityLabel.Text = "label1";
            // 
            // friendsNumberTextBox
            // 
            this.friendsNumberTextBox.Location = new System.Drawing.Point(212, 105);
            this.friendsNumberTextBox.Name = "friendsNumberTextBox";
            this.friendsNumberTextBox.Size = new System.Drawing.Size(169, 23);
            this.friendsNumberTextBox.TabIndex = 5;
            // 
            // achivmentsNumberTextBox
            // 
            this.achivmentsNumberTextBox.Location = new System.Drawing.Point(212, 76);
            this.achivmentsNumberTextBox.Name = "achivmentsNumberTextBox";
            this.achivmentsNumberTextBox.Size = new System.Drawing.Size(169, 23);
            this.achivmentsNumberTextBox.TabIndex = 4;
            // 
            // lastLogOffTextBox
            // 
            this.lastLogOffTextBox.Location = new System.Drawing.Point(212, 34);
            this.lastLogOffTextBox.Name = "lastLogOffTextBox";
            this.lastLogOffTextBox.Size = new System.Drawing.Size(169, 23);
            this.lastLogOffTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(212, 5);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.userNameTextBox.TabIndex = 1;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(8, 6);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(184, 184);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1195, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(534, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 11;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox lastPlayedGameTextEdit;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.TextBox friendsNumberTextBox;
        private System.Windows.Forms.TextBox achivmentsNumberTextBox;
        private System.Windows.Forms.TextBox lastLogOffTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

