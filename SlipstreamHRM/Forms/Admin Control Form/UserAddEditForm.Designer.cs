namespace SlipstreamHRM.Forms
{
    partial class UserAddEditForm
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
            this.comboBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.UserNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UserRoleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EmployeeNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegionsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxStatus = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxRegion = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConfirmPaswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.ItemHeight = 23;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Global Admin",
            "ESS",
            "Supervisor"});
            this.comboBoxRole.Location = new System.Drawing.Point(593, 179);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(257, 29);
            this.comboBoxRole.TabIndex = 1;
            this.comboBoxRole.UseSelectable = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Depth = 0;
            this.UserNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameLabel.Location = new System.Drawing.Point(46, 125);
            this.UserNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 19);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Username:";
            // 
            // UserRoleLabel
            // 
            this.UserRoleLabel.AutoSize = true;
            this.UserRoleLabel.Depth = 0;
            this.UserRoleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserRoleLabel.Location = new System.Drawing.Point(451, 189);
            this.UserRoleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserRoleLabel.Name = "UserRoleLabel";
            this.UserRoleLabel.Size = new System.Drawing.Size(78, 19);
            this.UserRoleLabel.TabIndex = 3;
            this.UserRoleLabel.Text = "User Role:";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Depth = 0;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EmployeeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(451, 125);
            this.EmployeeNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(123, 19);
            this.EmployeeNameLabel.TabIndex = 4;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Depth = 0;
            this.StatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusLabel.Location = new System.Drawing.Point(46, 189);
            this.StatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(56, 19);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // RegionsLabel
            // 
            this.RegionsLabel.AutoSize = true;
            this.RegionsLabel.Depth = 0;
            this.RegionsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RegionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegionsLabel.Location = new System.Drawing.Point(46, 246);
            this.RegionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegionsLabel.Name = "RegionsLabel";
            this.RegionsLabel.Size = new System.Drawing.Size(59, 19);
            this.RegionsLabel.TabIndex = 6;
            this.RegionsLabel.Text = "Region:";
            // 
            // txtUserName
            // 
            this.txtUserName.Depth = 0;
            this.txtUserName.Hint = "";
            this.txtUserName.Location = new System.Drawing.Point(147, 121);
            this.txtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.Size = new System.Drawing.Size(257, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.ItemHeight = 23;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBoxStatus.Location = new System.Drawing.Point(147, 179);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(257, 29);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.UseSelectable = true;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.ItemHeight = 23;
            this.comboBoxRegion.Location = new System.Drawing.Point(147, 236);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(257, 29);
            this.comboBoxRegion.TabIndex = 4;
            this.comboBoxRegion.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(775, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(593, 121);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(257, 23);
            this.txtEmployeeName.TabIndex = 7;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(130, 13);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(253, 23);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // ConfirmPaswordLabel
            // 
            this.ConfirmPaswordLabel.AutoSize = true;
            this.ConfirmPaswordLabel.Location = new System.Drawing.Point(3, 55);
            this.ConfirmPaswordLabel.Name = "ConfirmPaswordLabel";
            this.ConfirmPaswordLabel.Size = new System.Drawing.Size(121, 19);
            this.ConfirmPaswordLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ConfirmPaswordLabel.TabIndex = 16;
            this.ConfirmPaswordLabel.Text = "Confirm Password*";
            this.ConfirmPaswordLabel.UseStyleColors = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 17);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 19);
            this.PasswordLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password*";
            this.PasswordLabel.UseStyleColors = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Depth = 0;
            this.txtConfirmPassword.Hint = "";
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 51);
            this.txtConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.Size = new System.Drawing.Size(253, 23);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.txtPassword);
            this.metroPanel.Controls.Add(this.txtConfirmPassword);
            this.metroPanel.Controls.Add(this.ConfirmPaswordLabel);
            this.metroPanel.Controls.Add(this.PasswordLabel);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(47, 329);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(400, 100);
            this.metroPanel.TabIndex = 20;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox
            // 
            this.metroCheckBox.AutoSize = true;
            this.metroCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroCheckBox.Location = new System.Drawing.Point(50, 304);
            this.metroCheckBox.Name = "metroCheckBox";
            this.metroCheckBox.Size = new System.Drawing.Size(134, 19);
            this.metroCheckBox.TabIndex = 21;
            this.metroCheckBox.Text = "Change Password";
            this.metroCheckBox.UseSelectable = true;
            this.metroCheckBox.Visible = false;
            this.metroCheckBox.CheckedChanged += new System.EventHandler(this.metroCheckBox_CheckedChanged);
            // 
            // UserAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 456);
            this.Controls.Add(this.metroCheckBox);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.RegionsLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.UserRoleLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.comboBoxRole);
            this.MaximizeBox = false;
            this.Name = "UserAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Add/Edit";
            this.Load += new System.EventHandler(this.UserAddEditForm_Load);
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox comboBoxRole;
        private MaterialSkin.Controls.MaterialLabel UserNameLabel;
        private MaterialSkin.Controls.MaterialLabel UserRoleLabel;
        private MaterialSkin.Controls.MaterialLabel EmployeeNameLabel;
        private MaterialSkin.Controls.MaterialLabel StatusLabel;
        private MaterialSkin.Controls.MaterialLabel RegionsLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUserName;
        private MetroFramework.Controls.MetroComboBox comboBoxStatus;
        private MetroFramework.Controls.MetroComboBox comboBoxRegion;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MetroFramework.Controls.MetroLabel ConfirmPaswordLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmPassword;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox;
    }
}