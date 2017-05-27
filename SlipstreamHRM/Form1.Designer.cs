namespace SlipstreamHRM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logInPanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slipstreamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LogInButton = new MetroFramework.Controls.MetroButton();
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logInPanel
            // 
            this.logInPanel.BackColor = System.Drawing.Color.White;
            this.logInPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInPanel.Controls.Add(this.pictureBox1);
            this.logInPanel.Controls.Add(this.slipstreamLogoPictureBox);
            this.logInPanel.Controls.Add(this.LogInButton);
            this.logInPanel.Controls.Add(this.UserNameTextBox);
            this.logInPanel.Controls.Add(this.PasswordTextBox);
            this.logInPanel.Controls.Add(this.PasswordLabel);
            this.logInPanel.Controls.Add(this.UserNameLabel);
            this.logInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInPanel.HorizontalScrollbarBarColor = true;
            this.logInPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logInPanel.HorizontalScrollbarSize = 10;
            this.logInPanel.Location = new System.Drawing.Point(20, 60);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(940, 500);
            this.logInPanel.TabIndex = 0;
            this.logInPanel.UseCustomBackColor = true;
            this.logInPanel.VerticalScrollbarBarColor = true;
            this.logInPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logInPanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // slipstreamLogoPictureBox
            // 
            this.slipstreamLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.slipstreamLogoPictureBox.Image = global::SlipstreamHRM.Properties.Resources.Logo;
            this.slipstreamLogoPictureBox.Location = new System.Drawing.Point(147, 188);
            this.slipstreamLogoPictureBox.Name = "slipstreamLogoPictureBox";
            this.slipstreamLogoPictureBox.Size = new System.Drawing.Size(260, 239);
            this.slipstreamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slipstreamLogoPictureBox.TabIndex = 4;
            this.slipstreamLogoPictureBox.TabStop = false;
            // 
            // LogInButton
            // 
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Location = new System.Drawing.Point(691, 374);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(77, 30);
            this.LogInButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseSelectable = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.UserNameTextBox.CustomButton.Image = null;
            this.UserNameTextBox.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.UserNameTextBox.CustomButton.Name = "";
            this.UserNameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.UserNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.CustomButton.TabIndex = 1;
            this.UserNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextBox.CustomButton.UseSelectable = true;
            this.UserNameTextBox.CustomButton.Visible = false;
            this.UserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.UserNameTextBox.Lines = new string[0];
            this.UserNameTextBox.Location = new System.Drawing.Point(515, 257);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.ShortcutsEnabled = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(253, 28);
            this.UserNameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.UseCustomBackColor = true;
            this.UserNameTextBox.UseSelectable = true;
            this.UserNameTextBox.UseStyleColors = true;
            this.UserNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(515, 312);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(253, 28);
            this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseCustomBackColor = true;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseStyleColors = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PasswordLabel.Location = new System.Drawing.Point(413, 315);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.UseCustomBackColor = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserNameLabel.Location = new System.Drawing.Point(413, 260);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 25);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "UserName:";
            this.UserNameLabel.UseCustomBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.logInPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel logInPanel;
        private System.Windows.Forms.PictureBox slipstreamLogoPictureBox;
        private MetroFramework.Controls.MetroButton LogInButton;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

