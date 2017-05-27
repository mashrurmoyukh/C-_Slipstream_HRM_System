namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeePersonalInformationDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personalInformationPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LicenseExpireDateTime = new MetroFramework.Controls.MetroDateTime();
            this.comboSmoker = new MetroFramework.Controls.MetroComboBox();
            this.LicenseExpireLabel = new MetroFramework.Controls.MetroLabel();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.MilitaryServiceLabel = new MetroFramework.Controls.MetroLabel();
            this.txtMilitaryService = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SmokerLabel = new MetroFramework.Controls.MetroLabel();
            this.comboGender = new MetroFramework.Controls.MetroComboBox();
            this.txtEmployeeID = new MetroFramework.Controls.MetroTextBox();
            this.MarriedStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.comboNationality = new MetroFramework.Controls.MetroComboBox();
            this.GenderLabel = new MetroFramework.Controls.MetroLabel();
            this.NationalityLabel = new MetroFramework.Controls.MetroLabel();
            this.comboMarriedStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtNickName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NickNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DOBLabel = new MetroFramework.Controls.MetroLabel();
            this.txtDOB = new MetroFramework.Controls.MetroTextBox();
            this.employeeInformationHeaderPanel = new MetroFramework.Controls.MetroPanel();
            this.ChangePasswordLink = new MetroFramework.Controls.MetroLink();
            this.personalInformationPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.employeeInformationHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInformationPanel
            // 
            this.personalInformationPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personalInformationPanel.Controls.Add(this.metroPanel1);
            this.personalInformationPanel.Controls.Add(this.employeeInformationHeaderPanel);
            this.personalInformationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInformationPanel.HorizontalScrollbarBarColor = true;
            this.personalInformationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.personalInformationPanel.HorizontalScrollbarSize = 10;
            this.personalInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.personalInformationPanel.Name = "personalInformationPanel";
            this.personalInformationPanel.Size = new System.Drawing.Size(1326, 520);
            this.personalInformationPanel.TabIndex = 0;
            this.personalInformationPanel.UseCustomBackColor = true;
            this.personalInformationPanel.VerticalScrollbarBarColor = true;
            this.personalInformationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.personalInformationPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.LicenseExpireDateTime);
            this.metroPanel1.Controls.Add(this.comboSmoker);
            this.metroPanel1.Controls.Add(this.LicenseExpireLabel);
            this.metroPanel1.Controls.Add(this.EmployeeNameLabel);
            this.metroPanel1.Controls.Add(this.MilitaryServiceLabel);
            this.metroPanel1.Controls.Add(this.txtMilitaryService);
            this.metroPanel1.Controls.Add(this.SmokerLabel);
            this.metroPanel1.Controls.Add(this.comboGender);
            this.metroPanel1.Controls.Add(this.txtEmployeeID);
            this.metroPanel1.Controls.Add(this.MarriedStatusLabel);
            this.metroPanel1.Controls.Add(this.comboNationality);
            this.metroPanel1.Controls.Add(this.GenderLabel);
            this.metroPanel1.Controls.Add(this.NationalityLabel);
            this.metroPanel1.Controls.Add(this.comboMarriedStatus);
            this.metroPanel1.Controls.Add(this.txtNickName);
            this.metroPanel1.Controls.Add(this.NickNameLabel);
            this.metroPanel1.Controls.Add(this.DOBLabel);
            this.metroPanel1.Controls.Add(this.txtDOB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(38, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1255, 425);
            this.metroPanel1.TabIndex = 67;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Employee ID";
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(1078, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(83, 60);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(282, 23);
            this.txtName.TabIndex = 35;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // LicenseExpireDateTime
            // 
            this.LicenseExpireDateTime.Location = new System.Drawing.Point(897, 146);
            this.LicenseExpireDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.LicenseExpireDateTime.Name = "LicenseExpireDateTime";
            this.LicenseExpireDateTime.Size = new System.Drawing.Size(282, 29);
            this.LicenseExpireDateTime.TabIndex = 59;
            // 
            // comboSmoker
            // 
            this.comboSmoker.FormattingEnabled = true;
            this.comboSmoker.ItemHeight = 23;
            this.comboSmoker.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboSmoker.Location = new System.Drawing.Point(473, 321);
            this.comboSmoker.Name = "comboSmoker";
            this.comboSmoker.Size = new System.Drawing.Size(282, 29);
            this.comboSmoker.TabIndex = 65;
            this.comboSmoker.UseSelectable = true;
            // 
            // LicenseExpireLabel
            // 
            this.LicenseExpireLabel.AutoSize = true;
            this.LicenseExpireLabel.Location = new System.Drawing.Point(897, 124);
            this.LicenseExpireLabel.Name = "LicenseExpireLabel";
            this.LicenseExpireLabel.Size = new System.Drawing.Size(121, 19);
            this.LicenseExpireLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LicenseExpireLabel.TabIndex = 58;
            this.LicenseExpireLabel.Text = "License Expire Date";
            this.LicenseExpireLabel.UseStyleColors = true;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(83, 38);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 37;
            this.EmployeeNameLabel.Text = "Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // MilitaryServiceLabel
            // 
            this.MilitaryServiceLabel.AutoSize = true;
            this.MilitaryServiceLabel.Location = new System.Drawing.Point(897, 38);
            this.MilitaryServiceLabel.Name = "MilitaryServiceLabel";
            this.MilitaryServiceLabel.Size = new System.Drawing.Size(99, 19);
            this.MilitaryServiceLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.MilitaryServiceLabel.TabIndex = 53;
            this.MilitaryServiceLabel.Text = "Military Service";
            this.MilitaryServiceLabel.UseStyleColors = true;
            // 
            // txtMilitaryService
            // 
            this.txtMilitaryService.Depth = 0;
            this.txtMilitaryService.Hint = "";
            this.txtMilitaryService.Location = new System.Drawing.Point(897, 60);
            this.txtMilitaryService.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMilitaryService.Name = "txtMilitaryService";
            this.txtMilitaryService.PasswordChar = '\0';
            this.txtMilitaryService.SelectedText = "";
            this.txtMilitaryService.SelectionLength = 0;
            this.txtMilitaryService.SelectionStart = 0;
            this.txtMilitaryService.Size = new System.Drawing.Size(282, 23);
            this.txtMilitaryService.TabIndex = 52;
            this.txtMilitaryService.UseSystemPasswordChar = false;
            // 
            // SmokerLabel
            // 
            this.SmokerLabel.AutoSize = true;
            this.SmokerLabel.Location = new System.Drawing.Point(473, 299);
            this.SmokerLabel.Name = "SmokerLabel";
            this.SmokerLabel.Size = new System.Drawing.Size(54, 19);
            this.SmokerLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.SmokerLabel.TabIndex = 63;
            this.SmokerLabel.Text = "Smoker";
            this.SmokerLabel.UseStyleColors = true;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 23;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(83, 321);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(282, 29);
            this.comboGender.TabIndex = 64;
            this.comboGender.UseSelectable = true;
            // 
            // txtEmployeeID
            // 
            // 
            // 
            // 
            this.txtEmployeeID.CustomButton.Image = null;
            this.txtEmployeeID.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txtEmployeeID.CustomButton.Name = "";
            this.txtEmployeeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeID.CustomButton.TabIndex = 1;
            this.txtEmployeeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeID.CustomButton.UseSelectable = true;
            this.txtEmployeeID.CustomButton.Visible = false;
            this.txtEmployeeID.Lines = new string[0];
            this.txtEmployeeID.Location = new System.Drawing.Point(83, 140);
            this.txtEmployeeID.MaxLength = 32767;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.PasswordChar = '\0';
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeID.SelectedText = "";
            this.txtEmployeeID.SelectionLength = 0;
            this.txtEmployeeID.SelectionStart = 0;
            this.txtEmployeeID.ShortcutsEnabled = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(282, 23);
            this.txtEmployeeID.TabIndex = 50;
            this.txtEmployeeID.UseSelectable = true;
            this.txtEmployeeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MarriedStatusLabel
            // 
            this.MarriedStatusLabel.AutoSize = true;
            this.MarriedStatusLabel.Location = new System.Drawing.Point(83, 204);
            this.MarriedStatusLabel.Name = "MarriedStatusLabel";
            this.MarriedStatusLabel.Size = new System.Drawing.Size(94, 19);
            this.MarriedStatusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.MarriedStatusLabel.TabIndex = 54;
            this.MarriedStatusLabel.Text = "Married Status";
            this.MarriedStatusLabel.UseStyleColors = true;
            // 
            // comboNationality
            // 
            this.comboNationality.FormattingEnabled = true;
            this.comboNationality.ItemHeight = 23;
            this.comboNationality.Location = new System.Drawing.Point(473, 226);
            this.comboNationality.Name = "comboNationality";
            this.comboNationality.Size = new System.Drawing.Size(282, 29);
            this.comboNationality.TabIndex = 57;
            this.comboNationality.UseSelectable = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(83, 299);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(52, 19);
            this.GenderLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.GenderLabel.TabIndex = 62;
            this.GenderLabel.Text = "Gender";
            this.GenderLabel.UseStyleColors = true;
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Location = new System.Drawing.Point(473, 204);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(71, 19);
            this.NationalityLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.NationalityLabel.TabIndex = 56;
            this.NationalityLabel.Text = "Nationality";
            this.NationalityLabel.UseStyleColors = true;
            // 
            // comboMarriedStatus
            // 
            this.comboMarriedStatus.FormattingEnabled = true;
            this.comboMarriedStatus.ItemHeight = 23;
            this.comboMarriedStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Other"});
            this.comboMarriedStatus.Location = new System.Drawing.Point(83, 226);
            this.comboMarriedStatus.Name = "comboMarriedStatus";
            this.comboMarriedStatus.Size = new System.Drawing.Size(282, 29);
            this.comboMarriedStatus.TabIndex = 55;
            this.comboMarriedStatus.UseSelectable = true;
            // 
            // txtNickName
            // 
            this.txtNickName.Depth = 0;
            this.txtNickName.Hint = "";
            this.txtNickName.Location = new System.Drawing.Point(473, 60);
            this.txtNickName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.PasswordChar = '\0';
            this.txtNickName.SelectedText = "";
            this.txtNickName.SelectionLength = 0;
            this.txtNickName.SelectionStart = 0;
            this.txtNickName.Size = new System.Drawing.Size(282, 23);
            this.txtNickName.TabIndex = 46;
            this.txtNickName.UseSystemPasswordChar = false;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Location = new System.Drawing.Point(470, 38);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(74, 19);
            this.NickNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.NickNameLabel.TabIndex = 47;
            this.NickNameLabel.Text = "Nick Name";
            this.NickNameLabel.UseStyleColors = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(473, 118);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(84, 19);
            this.DOBLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.DOBLabel.TabIndex = 51;
            this.DOBLabel.Text = "Date of Birth";
            this.DOBLabel.UseStyleColors = true;
            // 
            // txtDOB
            // 
            // 
            // 
            // 
            this.txtDOB.CustomButton.Image = null;
            this.txtDOB.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txtDOB.CustomButton.Name = "";
            this.txtDOB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDOB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDOB.CustomButton.TabIndex = 1;
            this.txtDOB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDOB.CustomButton.UseSelectable = true;
            this.txtDOB.CustomButton.Visible = false;
            this.txtDOB.Lines = new string[0];
            this.txtDOB.Location = new System.Drawing.Point(473, 140);
            this.txtDOB.MaxLength = 32767;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.ReadOnly = true;
            this.txtDOB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDOB.SelectedText = "";
            this.txtDOB.SelectionLength = 0;
            this.txtDOB.SelectionStart = 0;
            this.txtDOB.ShortcutsEnabled = true;
            this.txtDOB.Size = new System.Drawing.Size(282, 23);
            this.txtDOB.TabIndex = 49;
            this.txtDOB.UseSelectable = true;
            this.txtDOB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDOB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // employeeInformationHeaderPanel
            // 
            this.employeeInformationHeaderPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.employeeInformationHeaderPanel.Controls.Add(this.ChangePasswordLink);
            this.employeeInformationHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeInformationHeaderPanel.HorizontalScrollbarBarColor = true;
            this.employeeInformationHeaderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.employeeInformationHeaderPanel.HorizontalScrollbarSize = 10;
            this.employeeInformationHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeInformationHeaderPanel.Name = "employeeInformationHeaderPanel";
            this.employeeInformationHeaderPanel.Size = new System.Drawing.Size(1326, 37);
            this.employeeInformationHeaderPanel.TabIndex = 7;
            this.employeeInformationHeaderPanel.UseCustomBackColor = true;
            this.employeeInformationHeaderPanel.VerticalScrollbarBarColor = true;
            this.employeeInformationHeaderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.employeeInformationHeaderPanel.VerticalScrollbarSize = 10;
            // 
            // ChangePasswordLink
            // 
            this.ChangePasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangePasswordLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ChangePasswordLink.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordLink.Image = global::SlipstreamHRM.Properties.Resources.Seetign_Icon_White;
            this.ChangePasswordLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordLink.ImageSize = 32;
            this.ChangePasswordLink.Location = new System.Drawing.Point(1150, 0);
            this.ChangePasswordLink.Name = "ChangePasswordLink";
            this.ChangePasswordLink.Size = new System.Drawing.Size(176, 37);
            this.ChangePasswordLink.TabIndex = 3;
            this.ChangePasswordLink.Text = "   Change Password   ";
            this.ChangePasswordLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordLink.UseCustomBackColor = true;
            this.ChangePasswordLink.UseCustomForeColor = true;
            this.ChangePasswordLink.UseSelectable = true;
            this.ChangePasswordLink.Click += new System.EventHandler(this.ChangePasswordLink_Click);
            // 
            // EmployeePersonalInformationDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personalInformationPanel);
            this.Name = "EmployeePersonalInformationDashboardControl";
            this.Size = new System.Drawing.Size(1326, 520);
            this.Load += new System.EventHandler(this.EmployeePersonalInformationDashboardControl_Load);
            this.personalInformationPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.employeeInformationHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel personalInformationPanel;
        private MetroFramework.Controls.MetroPanel employeeInformationHeaderPanel;
        private MetroFramework.Controls.MetroLink ChangePasswordLink;
        private MetroFramework.Controls.MetroLabel NickNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNickName;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MetroFramework.Controls.MetroLabel MilitaryServiceLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMilitaryService;
        private MetroFramework.Controls.MetroLabel DOBLabel;
        private MetroFramework.Controls.MetroTextBox txtEmployeeID;
        private MetroFramework.Controls.MetroTextBox txtDOB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime LicenseExpireDateTime;
        private MetroFramework.Controls.MetroLabel LicenseExpireLabel;
        private MetroFramework.Controls.MetroComboBox comboNationality;
        private MetroFramework.Controls.MetroLabel NationalityLabel;
        private MetroFramework.Controls.MetroComboBox comboMarriedStatus;
        private MetroFramework.Controls.MetroLabel MarriedStatusLabel;
        private MetroFramework.Controls.MetroComboBox comboSmoker;
        private MetroFramework.Controls.MetroComboBox comboGender;
        private MetroFramework.Controls.MetroLabel SmokerLabel;
        private MetroFramework.Controls.MetroLabel GenderLabel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
