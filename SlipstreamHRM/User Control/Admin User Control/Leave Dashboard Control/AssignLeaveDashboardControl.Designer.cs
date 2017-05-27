namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    partial class AssignLeaveDashboardControl
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
            this.AssignLeaveLink = new MetroFramework.Controls.MetroLink();
            this.assignLeavepanel = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.txtComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.FromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.comboLeaveType = new MetroFramework.Controls.MetroComboBox();
            this.ValidUptoLabel = new MetroFramework.Controls.MetroLabel();
            this.ValidFromLabel = new MetroFramework.Controls.MetroLabel();
            this.LeaveTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.assignLeavepanel.SuspendLayout();
            this.metroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignLeaveLink
            // 
            this.AssignLeaveLink.BackColor = System.Drawing.Color.SteelBlue;
            this.AssignLeaveLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssignLeaveLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AssignLeaveLink.ForeColor = System.Drawing.Color.White;
            this.AssignLeaveLink.Location = new System.Drawing.Point(0, 0);
            this.AssignLeaveLink.Name = "AssignLeaveLink";
            this.AssignLeaveLink.Size = new System.Drawing.Size(942, 36);
            this.AssignLeaveLink.TabIndex = 0;
            this.AssignLeaveLink.Text = "Assign Leave";
            this.AssignLeaveLink.UseCustomBackColor = true;
            this.AssignLeaveLink.UseCustomForeColor = true;
            this.AssignLeaveLink.UseSelectable = true;
            // 
            // assignLeavepanel
            // 
            this.assignLeavepanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.assignLeavepanel.Controls.Add(this.metroPanel);
            this.assignLeavepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignLeavepanel.HorizontalScrollbarBarColor = true;
            this.assignLeavepanel.HorizontalScrollbarHighlightOnWheel = false;
            this.assignLeavepanel.HorizontalScrollbarSize = 10;
            this.assignLeavepanel.Location = new System.Drawing.Point(0, 36);
            this.assignLeavepanel.Name = "assignLeavepanel";
            this.assignLeavepanel.Size = new System.Drawing.Size(942, 591);
            this.assignLeavepanel.TabIndex = 1;
            this.assignLeavepanel.UseCustomBackColor = true;
            this.assignLeavepanel.VerticalScrollbarBarColor = true;
            this.assignLeavepanel.VerticalScrollbarHighlightOnWheel = false;
            this.assignLeavepanel.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(642, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "&Assign";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(27, 86);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(309, 23);
            this.txtEmployeeName.TabIndex = 56;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.White;
            this.txtComment.Depth = 0;
            this.txtComment.Hint = "";
            this.txtComment.Location = new System.Drawing.Point(27, 277);
            this.txtComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.Size = new System.Drawing.Size(716, 23);
            this.txtComment.TabIndex = 55;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 255);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Comment";
            this.metroLabel1.UseStyleColors = true;
            // 
            // ToDateTime
            // 
            this.ToDateTime.Location = new System.Drawing.Point(434, 171);
            this.ToDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(309, 29);
            this.ToDateTime.TabIndex = 53;
            // 
            // FromDateTime
            // 
            this.FromDateTime.Location = new System.Drawing.Point(27, 171);
            this.FromDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(309, 29);
            this.FromDateTime.TabIndex = 52;
            // 
            // comboLeaveType
            // 
            this.comboLeaveType.FormattingEnabled = true;
            this.comboLeaveType.ItemHeight = 23;
            this.comboLeaveType.Items.AddRange(new object[] {
            "Community Leave AU",
            "Medical AU",
            "Paternity AU",
            "Parent Leave CA",
            "PTO CA",
            "Vacation DE",
            "Caretaker Leave US",
            "Childcare US",
            "FMLA US",
            "Maternity US"});
            this.comboLeaveType.Location = new System.Drawing.Point(434, 85);
            this.comboLeaveType.Name = "comboLeaveType";
            this.comboLeaveType.Size = new System.Drawing.Size(309, 29);
            this.comboLeaveType.TabIndex = 51;
            this.comboLeaveType.UseSelectable = true;
            // 
            // ValidUptoLabel
            // 
            this.ValidUptoLabel.AutoSize = true;
            this.ValidUptoLabel.Location = new System.Drawing.Point(434, 149);
            this.ValidUptoLabel.Name = "ValidUptoLabel";
            this.ValidUptoLabel.Size = new System.Drawing.Size(38, 19);
            this.ValidUptoLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ValidUptoLabel.TabIndex = 49;
            this.ValidUptoLabel.Text = "Upto";
            this.ValidUptoLabel.UseStyleColors = true;
            // 
            // ValidFromLabel
            // 
            this.ValidFromLabel.AutoSize = true;
            this.ValidFromLabel.Location = new System.Drawing.Point(27, 149);
            this.ValidFromLabel.Name = "ValidFromLabel";
            this.ValidFromLabel.Size = new System.Drawing.Size(41, 19);
            this.ValidFromLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ValidFromLabel.TabIndex = 48;
            this.ValidFromLabel.Text = "From";
            this.ValidFromLabel.UseStyleColors = true;
            // 
            // LeaveTypeLabel
            // 
            this.LeaveTypeLabel.AutoSize = true;
            this.LeaveTypeLabel.Location = new System.Drawing.Point(434, 63);
            this.LeaveTypeLabel.Name = "LeaveTypeLabel";
            this.LeaveTypeLabel.Size = new System.Drawing.Size(73, 19);
            this.LeaveTypeLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LeaveTypeLabel.TabIndex = 47;
            this.LeaveTypeLabel.Text = "Leave Type";
            this.LeaveTypeLabel.UseStyleColors = true;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(27, 63);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 46;
            this.EmployeeNameLabel.Text = "Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // metroPanel
            // 
            this.metroPanel.BackColor = System.Drawing.Color.White;
            this.metroPanel.Controls.Add(this.txtEmployeeName);
            this.metroPanel.Controls.Add(this.metroLabel1);
            this.metroPanel.Controls.Add(this.btnSave);
            this.metroPanel.Controls.Add(this.ValidFromLabel);
            this.metroPanel.Controls.Add(this.LeaveTypeLabel);
            this.metroPanel.Controls.Add(this.EmployeeNameLabel);
            this.metroPanel.Controls.Add(this.ValidUptoLabel);
            this.metroPanel.Controls.Add(this.txtComment);
            this.metroPanel.Controls.Add(this.comboLeaveType);
            this.metroPanel.Controls.Add(this.FromDateTime);
            this.metroPanel.Controls.Add(this.ToDateTime);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(63, 48);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(809, 478);
            this.metroPanel.TabIndex = 59;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // AssignLeaveDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignLeavepanel);
            this.Controls.Add(this.AssignLeaveLink);
            this.Name = "AssignLeaveDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.AssignLeaveDashboardControl_Load);
            this.assignLeavepanel.ResumeLayout(false);
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink AssignLeaveLink;
        private MetroFramework.Controls.MetroPanel assignLeavepanel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime ToDateTime;
        private MetroFramework.Controls.MetroDateTime FromDateTime;
        private MetroFramework.Controls.MetroComboBox comboLeaveType;
        private MetroFramework.Controls.MetroLabel ValidUptoLabel;
        private MetroFramework.Controls.MetroLabel ValidFromLabel;
        private MetroFramework.Controls.MetroLabel LeaveTypeLabel;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MetroFramework.Controls.MetroPanel metroPanel;
    }
}
