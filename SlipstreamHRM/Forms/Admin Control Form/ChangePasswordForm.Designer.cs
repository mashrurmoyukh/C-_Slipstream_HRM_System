namespace SlipstreamHRM.Forms
{
    partial class ChangePasswordForm
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
            this.OldPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtOldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNewPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NewPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConfirmPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnSubmit = new MaterialSkin.Controls.MaterialFlatButton();
            this.UserNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Depth = 0;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OldPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OldPasswordLabel.Location = new System.Drawing.Point(28, 174);
            this.OldPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(105, 19);
            this.OldPasswordLabel.TabIndex = 0;
            this.OldPasswordLabel.Text = "Old Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Depth = 0;
            this.txtOldPassword.Hint = "";
            this.txtOldPassword.Location = new System.Drawing.Point(173, 170);
            this.txtOldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.Size = new System.Drawing.Size(255, 23);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.UseSystemPasswordChar = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Depth = 0;
            this.txtNewPassword.Hint = "";
            this.txtNewPassword.Location = new System.Drawing.Point(173, 234);
            this.txtNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.Size = new System.Drawing.Size(255, 23);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Depth = 0;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NewPasswordLabel.Location = new System.Drawing.Point(28, 238);
            this.NewPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(113, 19);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "New Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Depth = 0;
            this.txtConfirmPassword.Hint = "";
            this.txtConfirmPassword.Location = new System.Drawing.Point(173, 298);
            this.txtConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.Size = new System.Drawing.Size(255, 23);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Depth = 0;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(28, 302);
            this.ConfirmPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(137, 19);
            this.ConfirmPasswordLabel.TabIndex = 4;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(366, 354);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = false;
            this.btnSubmit.Size = new System.Drawing.Size(62, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Depth = 0;
            this.UserNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameLabel.Location = new System.Drawing.Point(28, 108);
            this.UserNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 19);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "Username:";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(173, 104);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ReadOnly = true;
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(255, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 405);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.OldPasswordLabel);
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel OldPasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewPassword;
        private MaterialSkin.Controls.MaterialLabel NewPasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmPassword;
        private MaterialSkin.Controls.MaterialLabel ConfirmPasswordLabel;
        private MaterialSkin.Controls.MaterialFlatButton btnSubmit;
        private MaterialSkin.Controls.MaterialLabel UserNameLabel;
        private MetroFramework.Controls.MetroTextBox txtUserName;
    }
}