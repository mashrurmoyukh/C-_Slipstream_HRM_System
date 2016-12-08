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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logInPanel = new MetroFramework.Controls.MetroPanel();
            this.LogInButton = new MetroFramework.Controls.MetroButton();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.slipstreamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel.Controls.Add(this.slipstreamLogoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.logInPanel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.61956F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.38044F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(940, 500);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.LogInButton);
            this.logInPanel.Controls.Add(this.PasswordLabel);
            this.logInPanel.Controls.Add(this.UserNameLabel);
            this.logInPanel.Controls.Add(this.PasswordTextBox);
            this.logInPanel.Controls.Add(this.UserNameTextBox);
            this.logInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInPanel.HorizontalScrollbarBarColor = true;
            this.logInPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logInPanel.HorizontalScrollbarSize = 10;
            this.logInPanel.Location = new System.Drawing.Point(378, 204);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(381, 161);
            this.logInPanel.TabIndex = 0;
            this.logInPanel.VerticalScrollbarBarColor = true;
            this.logInPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logInPanel.VerticalScrollbarSize = 10;
            // 
            // LogInButton
            // 
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Location = new System.Drawing.Point(298, 128);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(77, 30);
            this.LogInButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseSelectable = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PasswordLabel.Location = new System.Drawing.Point(27, 82);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserNameLabel.Location = new System.Drawing.Point(17, 22);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 25);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "UserName:";
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(217, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(132, 79);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 28);
            this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseStyleColors = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserNameTextBox
            // 
            // 
            // 
            // 
            this.UserNameTextBox.CustomButton.Image = null;
            this.UserNameTextBox.CustomButton.Location = new System.Drawing.Point(217, 2);
            this.UserNameTextBox.CustomButton.Name = "";
            this.UserNameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.UserNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.CustomButton.TabIndex = 1;
            this.UserNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextBox.CustomButton.UseSelectable = true;
            this.UserNameTextBox.CustomButton.Visible = false;
            this.UserNameTextBox.Lines = new string[0];
            this.UserNameTextBox.Location = new System.Drawing.Point(132, 19);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.ShortcutsEnabled = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(243, 28);
            this.UserNameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.UseSelectable = true;
            this.UserNameTextBox.UseStyleColors = true;
            this.UserNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // slipstreamLogoPictureBox
            // 
            this.slipstreamLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slipstreamLogoPictureBox.Image = global::SlipstreamHRM.Properties.Resources.SlipstreamHRM_Logo;
            this.slipstreamLogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.slipstreamLogoPictureBox.Name = "slipstreamLogoPictureBox";
            this.slipstreamLogoPictureBox.Size = new System.Drawing.Size(369, 195);
            this.slipstreamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slipstreamLogoPictureBox.TabIndex = 4;
            this.slipstreamLogoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MetroFramework.Controls.MetroPanel logInPanel;
        private MetroFramework.Controls.MetroButton LogInButton;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox slipstreamLogoPictureBox;
    }
}

