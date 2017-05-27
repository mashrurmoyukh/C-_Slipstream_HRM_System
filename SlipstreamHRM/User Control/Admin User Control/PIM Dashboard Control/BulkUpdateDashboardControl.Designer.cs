namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    partial class BulkUpdateDashboardControl
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
            this.BulkUpdatePanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SelectEmployeesHavingLink = new MetroFramework.Controls.MetroLink();
            this.BulkPanel = new MetroFramework.Controls.MetroPanel();
            this.btnBulkUpdate = new MetroFramework.Controls.MetroButton();
            this.dateTimeJoined = new MetroFramework.Controls.MetroDateTime();
            this.JoinedDateLabel = new MetroFramework.Controls.MetroLabel();
            this.comboWorkShift = new MetroFramework.Controls.MetroComboBox();
            this.comboLocation = new MetroFramework.Controls.MetroComboBox();
            this.comboInclude = new MetroFramework.Controls.MetroComboBox();
            this.comboSubunit = new MetroFramework.Controls.MetroComboBox();
            this.comboJobTitle = new MetroFramework.Controls.MetroComboBox();
            this.WorkShiftLabel = new MetroFramework.Controls.MetroLabel();
            this.LocationLabel = new MetroFramework.Controls.MetroLabel();
            this.IncludeLavel = new MetroFramework.Controls.MetroLabel();
            this.SubUnitLabel = new MetroFramework.Controls.MetroLabel();
            this.JobTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.comboEmployeeStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtSupervisorName = new MetroFramework.Controls.MetroTextBox();
            this.SupervisorNameLabel = new MetroFramework.Controls.MetroLabel();
            this.EmployeeStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.BulkUpdateLink = new MetroFramework.Controls.MetroLink();
            this.BulkUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.BulkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BulkUpdatePanel
            // 
            this.BulkUpdatePanel.Controls.Add(this.pictureBox);
            this.BulkUpdatePanel.Controls.Add(this.SelectEmployeesHavingLink);
            this.BulkUpdatePanel.Controls.Add(this.BulkPanel);
            this.BulkUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BulkUpdatePanel.HorizontalScrollbarBarColor = true;
            this.BulkUpdatePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BulkUpdatePanel.HorizontalScrollbarSize = 10;
            this.BulkUpdatePanel.Location = new System.Drawing.Point(0, 23);
            this.BulkUpdatePanel.Name = "BulkUpdatePanel";
            this.BulkUpdatePanel.Size = new System.Drawing.Size(945, 604);
            this.BulkUpdatePanel.TabIndex = 3;
            this.BulkUpdatePanel.VerticalScrollbarBarColor = true;
            this.BulkUpdatePanel.VerticalScrollbarHighlightOnWheel = false;
            this.BulkUpdatePanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::SlipstreamHRM.Properties.Resources.orange_color;
            this.pictureBox.Image = global::SlipstreamHRM.Properties.Resources.UpArrow_Icon;
            this.pictureBox.Location = new System.Drawing.Point(883, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(59, 39);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // SelectEmployeesHavingLink
            // 
            this.SelectEmployeesHavingLink.BackgroundImage = global::SlipstreamHRM.Properties.Resources.orange_color;
            this.SelectEmployeesHavingLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectEmployeesHavingLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectEmployeesHavingLink.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.SelectEmployeesHavingLink.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.SelectEmployeesHavingLink.Location = new System.Drawing.Point(0, 0);
            this.SelectEmployeesHavingLink.Name = "SelectEmployeesHavingLink";
            this.SelectEmployeesHavingLink.Size = new System.Drawing.Size(945, 39);
            this.SelectEmployeesHavingLink.Style = MetroFramework.MetroColorStyle.Black;
            this.SelectEmployeesHavingLink.TabIndex = 3;
            this.SelectEmployeesHavingLink.Text = "Select Employees Having";
            this.SelectEmployeesHavingLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectEmployeesHavingLink.UseSelectable = true;
            this.SelectEmployeesHavingLink.UseStyleColors = true;
            this.SelectEmployeesHavingLink.Click += new System.EventHandler(this.SelectEmployeesHavingLink_Click);
            // 
            // BulkPanel
            // 
            this.BulkPanel.Controls.Add(this.btnBulkUpdate);
            this.BulkPanel.Controls.Add(this.dateTimeJoined);
            this.BulkPanel.Controls.Add(this.JoinedDateLabel);
            this.BulkPanel.Controls.Add(this.comboWorkShift);
            this.BulkPanel.Controls.Add(this.comboLocation);
            this.BulkPanel.Controls.Add(this.comboInclude);
            this.BulkPanel.Controls.Add(this.comboSubunit);
            this.BulkPanel.Controls.Add(this.comboJobTitle);
            this.BulkPanel.Controls.Add(this.WorkShiftLabel);
            this.BulkPanel.Controls.Add(this.LocationLabel);
            this.BulkPanel.Controls.Add(this.IncludeLavel);
            this.BulkPanel.Controls.Add(this.SubUnitLabel);
            this.BulkPanel.Controls.Add(this.JobTitleLabel);
            this.BulkPanel.Controls.Add(this.comboEmployeeStatus);
            this.BulkPanel.Controls.Add(this.txtSupervisorName);
            this.BulkPanel.Controls.Add(this.SupervisorNameLabel);
            this.BulkPanel.Controls.Add(this.EmployeeStatusLabel);
            this.BulkPanel.Controls.Add(this.txtEmployeeName);
            this.BulkPanel.Controls.Add(this.EmployeeNameLabel);
            this.BulkPanel.HorizontalScrollbarBarColor = true;
            this.BulkPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.BulkPanel.HorizontalScrollbarSize = 10;
            this.BulkPanel.Location = new System.Drawing.Point(0, 45);
            this.BulkPanel.Name = "BulkPanel";
            this.BulkPanel.Size = new System.Drawing.Size(945, 559);
            this.BulkPanel.TabIndex = 3;
            this.BulkPanel.VerticalScrollbarBarColor = true;
            this.BulkPanel.VerticalScrollbarHighlightOnWheel = false;
            this.BulkPanel.VerticalScrollbarSize = 10;
            // 
            // btnBulkUpdate
            // 
            this.btnBulkUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnBulkUpdate.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnBulkUpdate.Location = new System.Drawing.Point(824, 500);
            this.btnBulkUpdate.Name = "btnBulkUpdate";
            this.btnBulkUpdate.Size = new System.Drawing.Size(101, 32);
            this.btnBulkUpdate.TabIndex = 46;
            this.btnBulkUpdate.Text = "&Bulk Update";
            this.btnBulkUpdate.UseSelectable = true;
            this.btnBulkUpdate.Click += new System.EventHandler(this.btnBulkUpdate_Click);
            // 
            // dateTimeJoined
            // 
            this.dateTimeJoined.Location = new System.Drawing.Point(17, 354);
            this.dateTimeJoined.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeJoined.Name = "dateTimeJoined";
            this.dateTimeJoined.Size = new System.Drawing.Size(278, 29);
            this.dateTimeJoined.TabIndex = 19;
            // 
            // JoinedDateLabel
            // 
            this.JoinedDateLabel.AutoSize = true;
            this.JoinedDateLabel.Location = new System.Drawing.Point(17, 322);
            this.JoinedDateLabel.Name = "JoinedDateLabel";
            this.JoinedDateLabel.Size = new System.Drawing.Size(78, 19);
            this.JoinedDateLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.JoinedDateLabel.TabIndex = 18;
            this.JoinedDateLabel.Text = "Joined Date";
            this.JoinedDateLabel.UseStyleColors = true;
            // 
            // comboWorkShift
            // 
            this.comboWorkShift.FormattingEnabled = true;
            this.comboWorkShift.ItemHeight = 23;
            this.comboWorkShift.Location = new System.Drawing.Point(336, 253);
            this.comboWorkShift.Name = "comboWorkShift";
            this.comboWorkShift.Size = new System.Drawing.Size(278, 29);
            this.comboWorkShift.TabIndex = 17;
            this.comboWorkShift.UseSelectable = true;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.ItemHeight = 23;
            this.comboLocation.Location = new System.Drawing.Point(17, 253);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(278, 29);
            this.comboLocation.TabIndex = 16;
            this.comboLocation.UseSelectable = true;
            // 
            // comboInclude
            // 
            this.comboInclude.FormattingEnabled = true;
            this.comboInclude.ItemHeight = 23;
            this.comboInclude.Items.AddRange(new object[] {
            "Current Employees Only",
            "Current  and Past Employees",
            "Past Employees Only"});
            this.comboInclude.Location = new System.Drawing.Point(647, 253);
            this.comboInclude.Name = "comboInclude";
            this.comboInclude.Size = new System.Drawing.Size(278, 29);
            this.comboInclude.TabIndex = 15;
            this.comboInclude.UseSelectable = true;
            // 
            // comboSubunit
            // 
            this.comboSubunit.FormattingEnabled = true;
            this.comboSubunit.ItemHeight = 23;
            this.comboSubunit.Items.AddRange(new object[] {
            "Sales Department",
            "Engineering Department",
            "Finance Department",
            "Administration Department",
            "IT Department"});
            this.comboSubunit.Location = new System.Drawing.Point(336, 148);
            this.comboSubunit.Name = "comboSubunit";
            this.comboSubunit.Size = new System.Drawing.Size(278, 29);
            this.comboSubunit.TabIndex = 14;
            this.comboSubunit.UseSelectable = true;
            // 
            // comboJobTitle
            // 
            this.comboJobTitle.FormattingEnabled = true;
            this.comboJobTitle.ItemHeight = 23;
            this.comboJobTitle.Location = new System.Drawing.Point(17, 148);
            this.comboJobTitle.Name = "comboJobTitle";
            this.comboJobTitle.Size = new System.Drawing.Size(278, 29);
            this.comboJobTitle.TabIndex = 13;
            this.comboJobTitle.UseSelectable = true;
            // 
            // WorkShiftLabel
            // 
            this.WorkShiftLabel.AutoSize = true;
            this.WorkShiftLabel.Location = new System.Drawing.Point(336, 221);
            this.WorkShiftLabel.Name = "WorkShiftLabel";
            this.WorkShiftLabel.Size = new System.Drawing.Size(69, 19);
            this.WorkShiftLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.WorkShiftLabel.TabIndex = 12;
            this.WorkShiftLabel.Text = "Work Shift";
            this.WorkShiftLabel.UseStyleColors = true;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(17, 221);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(58, 19);
            this.LocationLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LocationLabel.TabIndex = 11;
            this.LocationLabel.Text = "Location";
            this.LocationLabel.UseStyleColors = true;
            // 
            // IncludeLavel
            // 
            this.IncludeLavel.AutoSize = true;
            this.IncludeLavel.Location = new System.Drawing.Point(647, 221);
            this.IncludeLavel.Name = "IncludeLavel";
            this.IncludeLavel.Size = new System.Drawing.Size(50, 19);
            this.IncludeLavel.Style = MetroFramework.MetroColorStyle.Red;
            this.IncludeLavel.TabIndex = 10;
            this.IncludeLavel.Text = "Include";
            this.IncludeLavel.UseStyleColors = true;
            // 
            // SubUnitLabel
            // 
            this.SubUnitLabel.AutoSize = true;
            this.SubUnitLabel.Location = new System.Drawing.Point(336, 119);
            this.SubUnitLabel.Name = "SubUnitLabel";
            this.SubUnitLabel.Size = new System.Drawing.Size(58, 19);
            this.SubUnitLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.SubUnitLabel.TabIndex = 9;
            this.SubUnitLabel.Text = "Sub Unit";
            this.SubUnitLabel.UseStyleColors = true;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(17, 119);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(58, 19);
            this.JobTitleLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.JobTitleLabel.TabIndex = 8;
            this.JobTitleLabel.Text = "Job Title";
            this.JobTitleLabel.UseStyleColors = true;
            // 
            // comboEmployeeStatus
            // 
            this.comboEmployeeStatus.FormattingEnabled = true;
            this.comboEmployeeStatus.ItemHeight = 23;
            this.comboEmployeeStatus.Location = new System.Drawing.Point(647, 148);
            this.comboEmployeeStatus.Name = "comboEmployeeStatus";
            this.comboEmployeeStatus.Size = new System.Drawing.Size(278, 29);
            this.comboEmployeeStatus.TabIndex = 7;
            this.comboEmployeeStatus.UseSelectable = true;
            // 
            // txtSupervisorName
            // 
            this.txtSupervisorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSupervisorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSupervisorName.CustomButton.Image = null;
            this.txtSupervisorName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtSupervisorName.CustomButton.Name = "";
            this.txtSupervisorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupervisorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupervisorName.CustomButton.TabIndex = 1;
            this.txtSupervisorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupervisorName.CustomButton.UseSelectable = true;
            this.txtSupervisorName.CustomButton.Visible = false;
            this.txtSupervisorName.Lines = new string[0];
            this.txtSupervisorName.Location = new System.Drawing.Point(336, 53);
            this.txtSupervisorName.MaxLength = 32767;
            this.txtSupervisorName.Name = "txtSupervisorName";
            this.txtSupervisorName.PasswordChar = '\0';
            this.txtSupervisorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupervisorName.SelectedText = "";
            this.txtSupervisorName.SelectionLength = 0;
            this.txtSupervisorName.SelectionStart = 0;
            this.txtSupervisorName.ShortcutsEnabled = true;
            this.txtSupervisorName.Size = new System.Drawing.Size(278, 23);
            this.txtSupervisorName.TabIndex = 6;
            this.txtSupervisorName.UseSelectable = true;
            this.txtSupervisorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupervisorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SupervisorNameLabel
            // 
            this.SupervisorNameLabel.AutoSize = true;
            this.SupervisorNameLabel.Location = new System.Drawing.Point(336, 25);
            this.SupervisorNameLabel.Name = "SupervisorNameLabel";
            this.SupervisorNameLabel.Size = new System.Drawing.Size(114, 19);
            this.SupervisorNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.SupervisorNameLabel.TabIndex = 5;
            this.SupervisorNameLabel.Text = "Supervisor Name:";
            this.SupervisorNameLabel.UseStyleColors = true;
            // 
            // EmployeeStatusLabel
            // 
            this.EmployeeStatusLabel.AutoSize = true;
            this.EmployeeStatusLabel.Location = new System.Drawing.Point(647, 119);
            this.EmployeeStatusLabel.Name = "EmployeeStatusLabel";
            this.EmployeeStatusLabel.Size = new System.Drawing.Size(105, 19);
            this.EmployeeStatusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeStatusLabel.TabIndex = 4;
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
            this.txtEmployeeName.Location = new System.Drawing.Point(17, 53);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(278, 23);
            this.txtEmployeeName.TabIndex = 3;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(17, 25);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 2;
            this.EmployeeNameLabel.Text = "Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // BulkUpdateLink
            // 
            this.BulkUpdateLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.BulkUpdateLink.Location = new System.Drawing.Point(0, 0);
            this.BulkUpdateLink.Name = "BulkUpdateLink";
            this.BulkUpdateLink.Size = new System.Drawing.Size(945, 23);
            this.BulkUpdateLink.TabIndex = 2;
            this.BulkUpdateLink.Text = "Bulk Update";
            this.BulkUpdateLink.UseSelectable = true;
            // 
            // BulkUpdateDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BulkUpdatePanel);
            this.Controls.Add(this.BulkUpdateLink);
            this.Name = "BulkUpdateDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.BulkUpdateDashboardControl_Load);
            this.BulkUpdatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.BulkPanel.ResumeLayout(false);
            this.BulkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel BulkUpdatePanel;
        private MetroFramework.Controls.MetroLink BulkUpdateLink;
        private MetroFramework.Controls.MetroPanel BulkPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLink SelectEmployeesHavingLink;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MetroFramework.Controls.MetroComboBox comboEmployeeStatus;
        private MetroFramework.Controls.MetroTextBox txtSupervisorName;
        private MetroFramework.Controls.MetroLabel SupervisorNameLabel;
        private MetroFramework.Controls.MetroLabel EmployeeStatusLabel;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroLabel IncludeLavel;
        private MetroFramework.Controls.MetroLabel SubUnitLabel;
        private MetroFramework.Controls.MetroLabel JobTitleLabel;
        private MetroFramework.Controls.MetroLabel LocationLabel;
        private MetroFramework.Controls.MetroComboBox comboWorkShift;
        private MetroFramework.Controls.MetroComboBox comboLocation;
        private MetroFramework.Controls.MetroComboBox comboInclude;
        private MetroFramework.Controls.MetroComboBox comboSubunit;
        private MetroFramework.Controls.MetroComboBox comboJobTitle;
        private MetroFramework.Controls.MetroLabel WorkShiftLabel;
        private MetroFramework.Controls.MetroLabel JoinedDateLabel;
        private MetroFramework.Controls.MetroDateTime dateTimeJoined;
        private MetroFramework.Controls.MetroButton btnBulkUpdate;
    }
}
