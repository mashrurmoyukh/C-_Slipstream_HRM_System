namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    partial class EntitelmentsDashboardControl
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
            this.EntitelmentsLink = new MetroFramework.Controls.MetroLink();
            this.EntitelmentsTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.AddEntitlementsLink = new MetroFramework.Controls.MetroLink();
            this.txtTotalDays = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.txtComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.FromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.comboLeaveType = new MetroFramework.Controls.MetroComboBox();
            this.TotalDaysLabel = new MetroFramework.Controls.MetroLabel();
            this.ValidUptoLabel = new MetroFramework.Controls.MetroLabel();
            this.ValidFromLabel = new MetroFramework.Controls.MetroLabel();
            this.LeaveTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.entitlementListDataGridView = new System.Windows.Forms.DataGridView();
            this.EntitlementsLink = new MetroFramework.Controls.MetroLink();
            this.EntitelmentsTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entitlementListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EntitelmentsLink
            // 
            this.EntitelmentsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntitelmentsLink.Location = new System.Drawing.Point(0, 0);
            this.EntitelmentsLink.Name = "EntitelmentsLink";
            this.EntitelmentsLink.Size = new System.Drawing.Size(942, 23);
            this.EntitelmentsLink.TabIndex = 0;
            this.EntitelmentsLink.Text = "Entitelments";
            this.EntitelmentsLink.UseSelectable = true;
            // 
            // EntitelmentsTabControl
            // 
            this.EntitelmentsTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.EntitelmentsTabControl.Controls.Add(this.metroTabPage1);
            this.EntitelmentsTabControl.Controls.Add(this.metroTabPage2);
            this.EntitelmentsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntitelmentsTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.EntitelmentsTabControl.Location = new System.Drawing.Point(0, 23);
            this.EntitelmentsTabControl.Name = "EntitelmentsTabControl";
            this.EntitelmentsTabControl.SelectedIndex = 1;
            this.EntitelmentsTabControl.Size = new System.Drawing.Size(942, 604);
            this.EntitelmentsTabControl.TabIndex = 1;
            this.EntitelmentsTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.btnSave);
            this.metroTabPage1.Controls.Add(this.AddEntitlementsLink);
            this.metroTabPage1.Controls.Add(this.txtTotalDays);
            this.metroTabPage1.Controls.Add(this.txtEmployeeName);
            this.metroTabPage1.Controls.Add(this.txtComment);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.ToDateTime);
            this.metroTabPage1.Controls.Add(this.FromDateTime);
            this.metroTabPage1.Controls.Add(this.comboLeaveType);
            this.metroTabPage1.Controls.Add(this.TotalDaysLabel);
            this.metroTabPage1.Controls.Add(this.ValidUptoLabel);
            this.metroTabPage1.Controls.Add(this.ValidFromLabel);
            this.metroTabPage1.Controls.Add(this.LeaveTypeLabel);
            this.metroTabPage1.Controls.Add(this.EmployeeNameLabel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(934, 559);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add Entitelments";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(720, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEntitlementsLink
            // 
            this.AddEntitlementsLink.BackColor = System.Drawing.Color.SteelBlue;
            this.AddEntitlementsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEntitlementsLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AddEntitlementsLink.ForeColor = System.Drawing.Color.White;
            this.AddEntitlementsLink.Location = new System.Drawing.Point(0, 0);
            this.AddEntitlementsLink.Name = "AddEntitlementsLink";
            this.AddEntitlementsLink.Size = new System.Drawing.Size(934, 39);
            this.AddEntitlementsLink.TabIndex = 20;
            this.AddEntitlementsLink.Text = "Add Entitlements";
            this.AddEntitlementsLink.UseCustomBackColor = true;
            this.AddEntitlementsLink.UseCustomForeColor = true;
            this.AddEntitlementsLink.UseSelectable = true;
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.Depth = 0;
            this.txtTotalDays.Hint = "";
            this.txtTotalDays.Location = new System.Drawing.Point(32, 278);
            this.txtTotalDays.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.PasswordChar = '\0';
            this.txtTotalDays.SelectedText = "";
            this.txtTotalDays.SelectionLength = 0;
            this.txtTotalDays.SelectionStart = 0;
            this.txtTotalDays.Size = new System.Drawing.Size(258, 23);
            this.txtTotalDays.TabIndex = 19;
            this.txtTotalDays.UseSystemPasswordChar = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(32, 102);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(258, 23);
            this.txtEmployeeName.TabIndex = 18;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComment
            // 
            this.txtComment.Depth = 0;
            this.txtComment.Hint = "";
            this.txtComment.Location = new System.Drawing.Point(32, 374);
            this.txtComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.Size = new System.Drawing.Size(637, 23);
            this.txtComment.TabIndex = 17;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 332);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Comment";
            this.metroLabel1.UseStyleColors = true;
            // 
            // ToDateTime
            // 
            this.ToDateTime.Location = new System.Drawing.Point(411, 187);
            this.ToDateTime.MinimumSize = new System.Drawing.Size(4, 29);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(258, 29);
            this.ToDateTime.TabIndex = 15;
            // 
            // FromDateTime
            // 
            this.FromDateTime.Location = new System.Drawing.Point(32, 187);
            this.FromDateTime.MinimumSize = new System.Drawing.Size(4, 29);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(258, 29);
            this.FromDateTime.TabIndex = 14;
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
            this.comboLeaveType.Location = new System.Drawing.Point(411, 102);
            this.comboLeaveType.Name = "comboLeaveType";
            this.comboLeaveType.Size = new System.Drawing.Size(258, 29);
            this.comboLeaveType.TabIndex = 8;
            this.comboLeaveType.UseSelectable = true;
            // 
            // TotalDaysLabel
            // 
            this.TotalDaysLabel.AutoSize = true;
            this.TotalDaysLabel.Location = new System.Drawing.Point(32, 256);
            this.TotalDaysLabel.Name = "TotalDaysLabel";
            this.TotalDaysLabel.Size = new System.Drawing.Size(67, 19);
            this.TotalDaysLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.TotalDaysLabel.TabIndex = 6;
            this.TotalDaysLabel.Text = "Total Days";
            this.TotalDaysLabel.UseStyleColors = true;
            // 
            // ValidUptoLabel
            // 
            this.ValidUptoLabel.AutoSize = true;
            this.ValidUptoLabel.Location = new System.Drawing.Point(411, 165);
            this.ValidUptoLabel.Name = "ValidUptoLabel";
            this.ValidUptoLabel.Size = new System.Drawing.Size(69, 19);
            this.ValidUptoLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ValidUptoLabel.TabIndex = 5;
            this.ValidUptoLabel.Text = "Valid Upto";
            this.ValidUptoLabel.UseStyleColors = true;
            // 
            // ValidFromLabel
            // 
            this.ValidFromLabel.AutoSize = true;
            this.ValidFromLabel.Location = new System.Drawing.Point(32, 165);
            this.ValidFromLabel.Name = "ValidFromLabel";
            this.ValidFromLabel.Size = new System.Drawing.Size(72, 19);
            this.ValidFromLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ValidFromLabel.TabIndex = 4;
            this.ValidFromLabel.Text = "Valid From";
            this.ValidFromLabel.UseStyleColors = true;
            // 
            // LeaveTypeLabel
            // 
            this.LeaveTypeLabel.AutoSize = true;
            this.LeaveTypeLabel.Location = new System.Drawing.Point(411, 79);
            this.LeaveTypeLabel.Name = "LeaveTypeLabel";
            this.LeaveTypeLabel.Size = new System.Drawing.Size(73, 19);
            this.LeaveTypeLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LeaveTypeLabel.TabIndex = 3;
            this.LeaveTypeLabel.Text = "Leave Type";
            this.LeaveTypeLabel.UseStyleColors = true;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(32, 79);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 2;
            this.EmployeeNameLabel.Text = "Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.DeleteTile);
            this.metroTabPage2.Controls.Add(this.entitlementListDataGridView);
            this.metroTabPage2.Controls.Add(this.EntitlementsLink);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(934, 559);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Entitelments List";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(838, 43);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 23;
            this.DeleteTile.Text = "Delete";
            this.DeleteTile.TileImage = global::SlipstreamHRM.Properties.Resources.Felete_Icon;
            this.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteTile.UseSelectable = true;
            this.DeleteTile.UseStyleColors = true;
            this.DeleteTile.UseTileImage = true;
            this.DeleteTile.Click += new System.EventHandler(this.DeleteTile_Click);
            // 
            // entitlementListDataGridView
            // 
            this.entitlementListDataGridView.AllowUserToAddRows = false;
            this.entitlementListDataGridView.AllowUserToDeleteRows = false;
            this.entitlementListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entitlementListDataGridView.Location = new System.Drawing.Point(3, 131);
            this.entitlementListDataGridView.Name = "entitlementListDataGridView";
            this.entitlementListDataGridView.ReadOnly = true;
            this.entitlementListDataGridView.Size = new System.Drawing.Size(928, 425);
            this.entitlementListDataGridView.TabIndex = 22;
            // 
            // EntitlementsLink
            // 
            this.EntitlementsLink.BackColor = System.Drawing.Color.SteelBlue;
            this.EntitlementsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntitlementsLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.EntitlementsLink.ForeColor = System.Drawing.Color.White;
            this.EntitlementsLink.Location = new System.Drawing.Point(0, 0);
            this.EntitlementsLink.Name = "EntitlementsLink";
            this.EntitlementsLink.Size = new System.Drawing.Size(934, 37);
            this.EntitlementsLink.TabIndex = 21;
            this.EntitlementsLink.Text = "Entitlements List";
            this.EntitlementsLink.UseCustomBackColor = true;
            this.EntitlementsLink.UseCustomForeColor = true;
            this.EntitlementsLink.UseSelectable = true;
            // 
            // EntitelmentsDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EntitelmentsTabControl);
            this.Controls.Add(this.EntitelmentsLink);
            this.Name = "EntitelmentsDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.EntitelmentsDashboardControl_Load);
            this.EntitelmentsTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entitlementListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink EntitelmentsLink;
        private MetroFramework.Controls.MetroTabControl EntitelmentsTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel TotalDaysLabel;
        private MetroFramework.Controls.MetroLabel ValidUptoLabel;
        private MetroFramework.Controls.MetroLabel ValidFromLabel;
        private MetroFramework.Controls.MetroLabel LeaveTypeLabel;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MetroFramework.Controls.MetroComboBox comboLeaveType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime ToDateTime;
        private MetroFramework.Controls.MetroDateTime FromDateTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalDays;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroLink AddEntitlementsLink;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLink EntitlementsLink;
        private System.Windows.Forms.DataGridView entitlementListDataGridView;
        private MetroFramework.Controls.MetroTile DeleteTile;
    }
}
