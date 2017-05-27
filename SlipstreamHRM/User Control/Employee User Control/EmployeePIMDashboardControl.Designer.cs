namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeePIMDashboardControl
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
            this.PIMDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.PIMLink = new MetroFramework.Controls.MetroLink();
            this.myEmployeeListDataGridView = new System.Windows.Forms.DataGridView();
            this.pimPanel = new MetroFramework.Controls.MetroPanel();
            this.WorkShiftLabel = new MetroFramework.Controls.MetroLabel();
            this.LocationLabel = new MetroFramework.Controls.MetroLabel();
            this.SubUnitLabel = new MetroFramework.Controls.MetroLabel();
            this.JobTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.EmployeeStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpID = new MetroFramework.Controls.MetroTextBox();
            this.txtJobTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtSubUnit = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpStatus = new MetroFramework.Controls.MetroTextBox();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.txtWorkShit = new MetroFramework.Controls.MetroTextBox();
            this.SmokerLabel = new MetroFramework.Controls.MetroLabel();
            this.MarriedStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.GenderLabel = new MetroFramework.Controls.MetroLabel();
            this.NationalityLabel = new MetroFramework.Controls.MetroLabel();
            this.NickNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DOBLabel = new MetroFramework.Controls.MetroLabel();
            this.txtNickName = new MetroFramework.Controls.MetroTextBox();
            this.txtDob = new MetroFramework.Controls.MetroTextBox();
            this.txtMarriedStatus = new MetroFramework.Controls.MetroTextBox();
            this.txtCountry = new MetroFramework.Controls.MetroTextBox();
            this.txtGender = new MetroFramework.Controls.MetroTextBox();
            this.txtSmoker = new MetroFramework.Controls.MetroTextBox();
            this.PIMDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeListDataGridView)).BeginInit();
            this.pimPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIMDashboardPanel
            // 
            this.PIMDashboardPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PIMDashboardPanel.Controls.Add(this.pimPanel);
            this.PIMDashboardPanel.Controls.Add(this.myEmployeeListDataGridView);
            this.PIMDashboardPanel.Controls.Add(this.PIMLink);
            this.PIMDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIMDashboardPanel.HorizontalScrollbarBarColor = true;
            this.PIMDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PIMDashboardPanel.HorizontalScrollbarSize = 10;
            this.PIMDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.PIMDashboardPanel.Name = "PIMDashboardPanel";
            this.PIMDashboardPanel.Size = new System.Drawing.Size(1326, 492);
            this.PIMDashboardPanel.TabIndex = 0;
            this.PIMDashboardPanel.UseCustomBackColor = true;
            this.PIMDashboardPanel.VerticalScrollbarBarColor = true;
            this.PIMDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.PIMDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // PIMLink
            // 
            this.PIMLink.BackColor = System.Drawing.Color.SteelBlue;
            this.PIMLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIMLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.PIMLink.ForeColor = System.Drawing.Color.White;
            this.PIMLink.Location = new System.Drawing.Point(0, 0);
            this.PIMLink.Name = "PIMLink";
            this.PIMLink.Size = new System.Drawing.Size(1326, 39);
            this.PIMLink.TabIndex = 3;
            this.PIMLink.Text = "Employee Personal Information";
            this.PIMLink.UseCustomBackColor = true;
            this.PIMLink.UseCustomForeColor = true;
            this.PIMLink.UseSelectable = true;
            // 
            // myEmployeeListDataGridView
            // 
            this.myEmployeeListDataGridView.AllowUserToAddRows = false;
            this.myEmployeeListDataGridView.AllowUserToDeleteRows = false;
            this.myEmployeeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myEmployeeListDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.myEmployeeListDataGridView.Location = new System.Drawing.Point(0, 39);
            this.myEmployeeListDataGridView.Name = "myEmployeeListDataGridView";
            this.myEmployeeListDataGridView.ReadOnly = true;
            this.myEmployeeListDataGridView.Size = new System.Drawing.Size(255, 453);
            this.myEmployeeListDataGridView.TabIndex = 4;
            this.myEmployeeListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myEmployeeListDataGridView_CellClick);
            // 
            // pimPanel
            // 
            this.pimPanel.Controls.Add(this.txtSmoker);
            this.pimPanel.Controls.Add(this.txtGender);
            this.pimPanel.Controls.Add(this.txtCountry);
            this.pimPanel.Controls.Add(this.txtMarriedStatus);
            this.pimPanel.Controls.Add(this.txtDob);
            this.pimPanel.Controls.Add(this.txtNickName);
            this.pimPanel.Controls.Add(this.SmokerLabel);
            this.pimPanel.Controls.Add(this.MarriedStatusLabel);
            this.pimPanel.Controls.Add(this.GenderLabel);
            this.pimPanel.Controls.Add(this.NationalityLabel);
            this.pimPanel.Controls.Add(this.NickNameLabel);
            this.pimPanel.Controls.Add(this.DOBLabel);
            this.pimPanel.Controls.Add(this.txtWorkShit);
            this.pimPanel.Controls.Add(this.txtLocation);
            this.pimPanel.Controls.Add(this.txtEmpStatus);
            this.pimPanel.Controls.Add(this.txtSubUnit);
            this.pimPanel.Controls.Add(this.txtJobTitle);
            this.pimPanel.Controls.Add(this.txtEmpID);
            this.pimPanel.Controls.Add(this.metroLabel1);
            this.pimPanel.Controls.Add(this.WorkShiftLabel);
            this.pimPanel.Controls.Add(this.LocationLabel);
            this.pimPanel.Controls.Add(this.SubUnitLabel);
            this.pimPanel.Controls.Add(this.JobTitleLabel);
            this.pimPanel.Controls.Add(this.EmployeeStatusLabel);
            this.pimPanel.Controls.Add(this.txtEmployeeName);
            this.pimPanel.Controls.Add(this.EmployeeNameLabel);
            this.pimPanel.HorizontalScrollbarBarColor = true;
            this.pimPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.pimPanel.HorizontalScrollbarSize = 10;
            this.pimPanel.Location = new System.Drawing.Point(299, 58);
            this.pimPanel.Name = "pimPanel";
            this.pimPanel.Size = new System.Drawing.Size(979, 416);
            this.pimPanel.TabIndex = 5;
            this.pimPanel.VerticalScrollbarBarColor = true;
            this.pimPanel.VerticalScrollbarHighlightOnWheel = false;
            this.pimPanel.VerticalScrollbarSize = 10;
            this.pimPanel.Visible = false;
            // 
            // WorkShiftLabel
            // 
            this.WorkShiftLabel.AutoSize = true;
            this.WorkShiftLabel.Location = new System.Drawing.Point(348, 180);
            this.WorkShiftLabel.Name = "WorkShiftLabel";
            this.WorkShiftLabel.Size = new System.Drawing.Size(69, 19);
            this.WorkShiftLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.WorkShiftLabel.TabIndex = 27;
            this.WorkShiftLabel.Text = "Work Shift";
            this.WorkShiftLabel.UseStyleColors = true;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(29, 180);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(58, 19);
            this.LocationLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LocationLabel.TabIndex = 26;
            this.LocationLabel.Text = "Location";
            this.LocationLabel.UseStyleColors = true;
            // 
            // SubUnitLabel
            // 
            this.SubUnitLabel.AutoSize = true;
            this.SubUnitLabel.Location = new System.Drawing.Point(348, 99);
            this.SubUnitLabel.Name = "SubUnitLabel";
            this.SubUnitLabel.Size = new System.Drawing.Size(58, 19);
            this.SubUnitLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.SubUnitLabel.TabIndex = 25;
            this.SubUnitLabel.Text = "Sub Unit";
            this.SubUnitLabel.UseStyleColors = true;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(29, 99);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(58, 19);
            this.JobTitleLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.JobTitleLabel.TabIndex = 24;
            this.JobTitleLabel.Text = "Job Title";
            this.JobTitleLabel.UseStyleColors = true;
            // 
            // EmployeeStatusLabel
            // 
            this.EmployeeStatusLabel.AutoSize = true;
            this.EmployeeStatusLabel.Location = new System.Drawing.Point(668, 99);
            this.EmployeeStatusLabel.Name = "EmployeeStatusLabel";
            this.EmployeeStatusLabel.Size = new System.Drawing.Size(105, 19);
            this.EmployeeStatusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeStatusLabel.TabIndex = 20;
            this.EmployeeStatusLabel.Text = "Employee Status";
            this.EmployeeStatusLabel.UseStyleColors = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(29, 44);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(278, 23);
            this.txtEmployeeName.TabIndex = 19;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(29, 22);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 18;
            this.EmployeeNameLabel.Text = "Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(348, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Employee ID";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmpID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmpID.CustomButton.Image = null;
            this.txtEmpID.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtEmpID.CustomButton.Name = "";
            this.txtEmpID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpID.CustomButton.TabIndex = 1;
            this.txtEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpID.CustomButton.UseSelectable = true;
            this.txtEmpID.CustomButton.Visible = false;
            this.txtEmpID.Lines = new string[0];
            this.txtEmpID.Location = new System.Drawing.Point(348, 44);
            this.txtEmpID.MaxLength = 32767;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.ShortcutsEnabled = true;
            this.txtEmpID.Size = new System.Drawing.Size(278, 23);
            this.txtEmpID.TabIndex = 33;
            this.txtEmpID.UseSelectable = true;
            this.txtEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtJobTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtJobTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJobTitle.CustomButton.Image = null;
            this.txtJobTitle.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtJobTitle.CustomButton.Name = "";
            this.txtJobTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJobTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJobTitle.CustomButton.TabIndex = 1;
            this.txtJobTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJobTitle.CustomButton.UseSelectable = true;
            this.txtJobTitle.CustomButton.Visible = false;
            this.txtJobTitle.Lines = new string[0];
            this.txtJobTitle.Location = new System.Drawing.Point(29, 121);
            this.txtJobTitle.MaxLength = 32767;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.PasswordChar = '\0';
            this.txtJobTitle.ReadOnly = true;
            this.txtJobTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJobTitle.SelectedText = "";
            this.txtJobTitle.SelectionLength = 0;
            this.txtJobTitle.SelectionStart = 0;
            this.txtJobTitle.ShortcutsEnabled = true;
            this.txtJobTitle.Size = new System.Drawing.Size(278, 23);
            this.txtJobTitle.TabIndex = 34;
            this.txtJobTitle.UseSelectable = true;
            this.txtJobTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJobTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubUnit
            // 
            this.txtSubUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSubUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSubUnit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSubUnit.CustomButton.Image = null;
            this.txtSubUnit.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtSubUnit.CustomButton.Name = "";
            this.txtSubUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubUnit.CustomButton.TabIndex = 1;
            this.txtSubUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubUnit.CustomButton.UseSelectable = true;
            this.txtSubUnit.CustomButton.Visible = false;
            this.txtSubUnit.Lines = new string[0];
            this.txtSubUnit.Location = new System.Drawing.Point(348, 121);
            this.txtSubUnit.MaxLength = 32767;
            this.txtSubUnit.Name = "txtSubUnit";
            this.txtSubUnit.PasswordChar = '\0';
            this.txtSubUnit.ReadOnly = true;
            this.txtSubUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubUnit.SelectedText = "";
            this.txtSubUnit.SelectionLength = 0;
            this.txtSubUnit.SelectionStart = 0;
            this.txtSubUnit.ShortcutsEnabled = true;
            this.txtSubUnit.Size = new System.Drawing.Size(278, 23);
            this.txtSubUnit.TabIndex = 35;
            this.txtSubUnit.UseSelectable = true;
            this.txtSubUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmpStatus
            // 
            this.txtEmpStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmpStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmpStatus.CustomButton.Image = null;
            this.txtEmpStatus.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtEmpStatus.CustomButton.Name = "";
            this.txtEmpStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpStatus.CustomButton.TabIndex = 1;
            this.txtEmpStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpStatus.CustomButton.UseSelectable = true;
            this.txtEmpStatus.CustomButton.Visible = false;
            this.txtEmpStatus.Lines = new string[0];
            this.txtEmpStatus.Location = new System.Drawing.Point(668, 121);
            this.txtEmpStatus.MaxLength = 32767;
            this.txtEmpStatus.Name = "txtEmpStatus";
            this.txtEmpStatus.PasswordChar = '\0';
            this.txtEmpStatus.ReadOnly = true;
            this.txtEmpStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpStatus.SelectedText = "";
            this.txtEmpStatus.SelectionLength = 0;
            this.txtEmpStatus.SelectionStart = 0;
            this.txtEmpStatus.ShortcutsEnabled = true;
            this.txtEmpStatus.Size = new System.Drawing.Size(278, 23);
            this.txtEmpStatus.TabIndex = 36;
            this.txtEmpStatus.UseSelectable = true;
            this.txtEmpStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLocation
            // 
            this.txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLocation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = null;
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.CustomButton.Visible = false;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(29, 202);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.ReadOnly = true;
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(278, 23);
            this.txtLocation.TabIndex = 37;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWorkShit
            // 
            this.txtWorkShit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWorkShit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWorkShit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWorkShit.CustomButton.Image = null;
            this.txtWorkShit.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtWorkShit.CustomButton.Name = "";
            this.txtWorkShit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWorkShit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWorkShit.CustomButton.TabIndex = 1;
            this.txtWorkShit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWorkShit.CustomButton.UseSelectable = true;
            this.txtWorkShit.CustomButton.Visible = false;
            this.txtWorkShit.Lines = new string[0];
            this.txtWorkShit.Location = new System.Drawing.Point(348, 202);
            this.txtWorkShit.MaxLength = 32767;
            this.txtWorkShit.Name = "txtWorkShit";
            this.txtWorkShit.PasswordChar = '\0';
            this.txtWorkShit.ReadOnly = true;
            this.txtWorkShit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorkShit.SelectedText = "";
            this.txtWorkShit.SelectionLength = 0;
            this.txtWorkShit.SelectionStart = 0;
            this.txtWorkShit.ShortcutsEnabled = true;
            this.txtWorkShit.Size = new System.Drawing.Size(278, 23);
            this.txtWorkShit.TabIndex = 38;
            this.txtWorkShit.UseSelectable = true;
            this.txtWorkShit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWorkShit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SmokerLabel
            // 
            this.SmokerLabel.AutoSize = true;
            this.SmokerLabel.Location = new System.Drawing.Point(29, 341);
            this.SmokerLabel.Name = "SmokerLabel";
            this.SmokerLabel.Size = new System.Drawing.Size(54, 19);
            this.SmokerLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.SmokerLabel.TabIndex = 70;
            this.SmokerLabel.Text = "Smoker";
            this.SmokerLabel.UseStyleColors = true;
            // 
            // MarriedStatusLabel
            // 
            this.MarriedStatusLabel.AutoSize = true;
            this.MarriedStatusLabel.Location = new System.Drawing.Point(29, 265);
            this.MarriedStatusLabel.Name = "MarriedStatusLabel";
            this.MarriedStatusLabel.Size = new System.Drawing.Size(94, 19);
            this.MarriedStatusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.MarriedStatusLabel.TabIndex = 67;
            this.MarriedStatusLabel.Text = "Married Status";
            this.MarriedStatusLabel.UseStyleColors = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(668, 265);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(52, 19);
            this.GenderLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.GenderLabel.TabIndex = 69;
            this.GenderLabel.Text = "Gender";
            this.GenderLabel.UseStyleColors = true;
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Location = new System.Drawing.Point(348, 265);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(71, 19);
            this.NationalityLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.NationalityLabel.TabIndex = 68;
            this.NationalityLabel.Text = "Nationality";
            this.NationalityLabel.UseStyleColors = true;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Location = new System.Drawing.Point(668, 22);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(74, 19);
            this.NickNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.NickNameLabel.TabIndex = 65;
            this.NickNameLabel.Text = "Nick Name";
            this.NickNameLabel.UseStyleColors = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(668, 180);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(84, 19);
            this.DOBLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.DOBLabel.TabIndex = 66;
            this.DOBLabel.Text = "Date of Birth";
            this.DOBLabel.UseStyleColors = true;
            // 
            // txtNickName
            // 
            this.txtNickName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNickName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNickName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNickName.CustomButton.Image = null;
            this.txtNickName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtNickName.CustomButton.Name = "";
            this.txtNickName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNickName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNickName.CustomButton.TabIndex = 1;
            this.txtNickName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNickName.CustomButton.UseSelectable = true;
            this.txtNickName.CustomButton.Visible = false;
            this.txtNickName.Lines = new string[0];
            this.txtNickName.Location = new System.Drawing.Point(668, 44);
            this.txtNickName.MaxLength = 32767;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.PasswordChar = '\0';
            this.txtNickName.ReadOnly = true;
            this.txtNickName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNickName.SelectedText = "";
            this.txtNickName.SelectionLength = 0;
            this.txtNickName.SelectionStart = 0;
            this.txtNickName.ShortcutsEnabled = true;
            this.txtNickName.Size = new System.Drawing.Size(278, 23);
            this.txtNickName.TabIndex = 71;
            this.txtNickName.UseSelectable = true;
            this.txtNickName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNickName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDob
            // 
            this.txtDob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDob.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDob.CustomButton.Image = null;
            this.txtDob.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtDob.CustomButton.Name = "";
            this.txtDob.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDob.CustomButton.TabIndex = 1;
            this.txtDob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDob.CustomButton.UseSelectable = true;
            this.txtDob.CustomButton.Visible = false;
            this.txtDob.Lines = new string[0];
            this.txtDob.Location = new System.Drawing.Point(668, 202);
            this.txtDob.MaxLength = 32767;
            this.txtDob.Name = "txtDob";
            this.txtDob.PasswordChar = '\0';
            this.txtDob.ReadOnly = true;
            this.txtDob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDob.SelectedText = "";
            this.txtDob.SelectionLength = 0;
            this.txtDob.SelectionStart = 0;
            this.txtDob.ShortcutsEnabled = true;
            this.txtDob.Size = new System.Drawing.Size(278, 23);
            this.txtDob.TabIndex = 72;
            this.txtDob.UseSelectable = true;
            this.txtDob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMarriedStatus
            // 
            this.txtMarriedStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMarriedStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMarriedStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMarriedStatus.CustomButton.Image = null;
            this.txtMarriedStatus.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtMarriedStatus.CustomButton.Name = "";
            this.txtMarriedStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarriedStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarriedStatus.CustomButton.TabIndex = 1;
            this.txtMarriedStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarriedStatus.CustomButton.UseSelectable = true;
            this.txtMarriedStatus.CustomButton.Visible = false;
            this.txtMarriedStatus.Lines = new string[0];
            this.txtMarriedStatus.Location = new System.Drawing.Point(29, 287);
            this.txtMarriedStatus.MaxLength = 32767;
            this.txtMarriedStatus.Name = "txtMarriedStatus";
            this.txtMarriedStatus.PasswordChar = '\0';
            this.txtMarriedStatus.ReadOnly = true;
            this.txtMarriedStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarriedStatus.SelectedText = "";
            this.txtMarriedStatus.SelectionLength = 0;
            this.txtMarriedStatus.SelectionStart = 0;
            this.txtMarriedStatus.ShortcutsEnabled = true;
            this.txtMarriedStatus.Size = new System.Drawing.Size(278, 23);
            this.txtMarriedStatus.TabIndex = 73;
            this.txtMarriedStatus.UseSelectable = true;
            this.txtMarriedStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarriedStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCountry
            // 
            this.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCountry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCountry.CustomButton.Image = null;
            this.txtCountry.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtCountry.CustomButton.Name = "";
            this.txtCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCountry.CustomButton.TabIndex = 1;
            this.txtCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCountry.CustomButton.UseSelectable = true;
            this.txtCountry.CustomButton.Visible = false;
            this.txtCountry.Lines = new string[0];
            this.txtCountry.Location = new System.Drawing.Point(348, 287);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.ReadOnly = true;
            this.txtCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCountry.SelectedText = "";
            this.txtCountry.SelectionLength = 0;
            this.txtCountry.SelectionStart = 0;
            this.txtCountry.ShortcutsEnabled = true;
            this.txtCountry.Size = new System.Drawing.Size(278, 23);
            this.txtCountry.TabIndex = 74;
            this.txtCountry.UseSelectable = true;
            this.txtCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGender
            // 
            this.txtGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGender.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGender.CustomButton.Image = null;
            this.txtGender.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtGender.CustomButton.Name = "";
            this.txtGender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGender.CustomButton.TabIndex = 1;
            this.txtGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGender.CustomButton.UseSelectable = true;
            this.txtGender.CustomButton.Visible = false;
            this.txtGender.Lines = new string[0];
            this.txtGender.Location = new System.Drawing.Point(668, 287);
            this.txtGender.MaxLength = 32767;
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.ReadOnly = true;
            this.txtGender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGender.SelectedText = "";
            this.txtGender.SelectionLength = 0;
            this.txtGender.SelectionStart = 0;
            this.txtGender.ShortcutsEnabled = true;
            this.txtGender.Size = new System.Drawing.Size(278, 23);
            this.txtGender.TabIndex = 75;
            this.txtGender.UseSelectable = true;
            this.txtGender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGender.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSmoker
            // 
            this.txtSmoker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSmoker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSmoker.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSmoker.CustomButton.Image = null;
            this.txtSmoker.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtSmoker.CustomButton.Name = "";
            this.txtSmoker.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSmoker.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSmoker.CustomButton.TabIndex = 1;
            this.txtSmoker.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSmoker.CustomButton.UseSelectable = true;
            this.txtSmoker.CustomButton.Visible = false;
            this.txtSmoker.Lines = new string[0];
            this.txtSmoker.Location = new System.Drawing.Point(29, 363);
            this.txtSmoker.MaxLength = 32767;
            this.txtSmoker.Name = "txtSmoker";
            this.txtSmoker.PasswordChar = '\0';
            this.txtSmoker.ReadOnly = true;
            this.txtSmoker.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSmoker.SelectedText = "";
            this.txtSmoker.SelectionLength = 0;
            this.txtSmoker.SelectionStart = 0;
            this.txtSmoker.ShortcutsEnabled = true;
            this.txtSmoker.Size = new System.Drawing.Size(278, 23);
            this.txtSmoker.TabIndex = 76;
            this.txtSmoker.UseSelectable = true;
            this.txtSmoker.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSmoker.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmployeePIMDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PIMDashboardPanel);
            this.Name = "EmployeePIMDashboardControl";
            this.Size = new System.Drawing.Size(1326, 492);
            this.Load += new System.EventHandler(this.EmployeePIMDashboardControl_Load);
            this.PIMDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeListDataGridView)).EndInit();
            this.pimPanel.ResumeLayout(false);
            this.pimPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PIMDashboardPanel;
        private MetroFramework.Controls.MetroLink PIMLink;
        private System.Windows.Forms.DataGridView myEmployeeListDataGridView;
        private MetroFramework.Controls.MetroPanel pimPanel;
        private MetroFramework.Controls.MetroLabel WorkShiftLabel;
        private MetroFramework.Controls.MetroLabel LocationLabel;
        private MetroFramework.Controls.MetroLabel SubUnitLabel;
        private MetroFramework.Controls.MetroLabel JobTitleLabel;
        private MetroFramework.Controls.MetroLabel EmployeeStatusLabel;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MetroFramework.Controls.MetroTextBox txtEmpID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtJobTitle;
        private MetroFramework.Controls.MetroTextBox txtWorkShit;
        private MetroFramework.Controls.MetroTextBox txtLocation;
        private MetroFramework.Controls.MetroTextBox txtEmpStatus;
        private MetroFramework.Controls.MetroTextBox txtSubUnit;
        private MetroFramework.Controls.MetroTextBox txtSmoker;
        private MetroFramework.Controls.MetroTextBox txtGender;
        private MetroFramework.Controls.MetroTextBox txtCountry;
        private MetroFramework.Controls.MetroTextBox txtMarriedStatus;
        private MetroFramework.Controls.MetroTextBox txtDob;
        private MetroFramework.Controls.MetroTextBox txtNickName;
        private MetroFramework.Controls.MetroLabel SmokerLabel;
        private MetroFramework.Controls.MetroLabel MarriedStatusLabel;
        private MetroFramework.Controls.MetroLabel GenderLabel;
        private MetroFramework.Controls.MetroLabel NationalityLabel;
        private MetroFramework.Controls.MetroLabel NickNameLabel;
        private MetroFramework.Controls.MetroLabel DOBLabel;
    }
}
