namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    partial class LeaveListDashboardControl
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
            this.LeaveListLink = new MetroFramework.Controls.MetroLink();
            this.leaveListPanel = new MetroFramework.Controls.MetroPanel();
            this.toLabel = new MetroFramework.Controls.MetroLabel();
            this.fromLabel = new MetroFramework.Controls.MetroLabel();
            this.leaveTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.employeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SelectActionTile = new MetroFramework.Controls.MetroTile();
            this.leaveListDataGridView = new System.Windows.Forms.DataGridView();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.txtLeaveType = new MetroFramework.Controls.MetroTextBox();
            this.txtFrom = new MetroFramework.Controls.MetroTextBox();
            this.txtTo = new MetroFramework.Controls.MetroTextBox();
            this.leaveListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaveListLink
            // 
            this.LeaveListLink.BackColor = System.Drawing.Color.SteelBlue;
            this.LeaveListLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeaveListLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LeaveListLink.ForeColor = System.Drawing.Color.White;
            this.LeaveListLink.Location = new System.Drawing.Point(0, 0);
            this.LeaveListLink.Name = "LeaveListLink";
            this.LeaveListLink.Size = new System.Drawing.Size(942, 39);
            this.LeaveListLink.TabIndex = 0;
            this.LeaveListLink.Text = "Leave List";
            this.LeaveListLink.UseCustomBackColor = true;
            this.LeaveListLink.UseCustomForeColor = true;
            this.LeaveListLink.UseSelectable = true;
            // 
            // leaveListPanel
            // 
            this.leaveListPanel.BackColor = System.Drawing.Color.White;
            this.leaveListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaveListPanel.Controls.Add(this.txtTo);
            this.leaveListPanel.Controls.Add(this.txtFrom);
            this.leaveListPanel.Controls.Add(this.txtLeaveType);
            this.leaveListPanel.Controls.Add(this.txtEmployeeName);
            this.leaveListPanel.Controls.Add(this.toLabel);
            this.leaveListPanel.Controls.Add(this.fromLabel);
            this.leaveListPanel.Controls.Add(this.leaveTypeLabel);
            this.leaveListPanel.Controls.Add(this.employeeNameLabel);
            this.leaveListPanel.Controls.Add(this.SelectActionTile);
            this.leaveListPanel.Controls.Add(this.leaveListDataGridView);
            this.leaveListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaveListPanel.HorizontalScrollbarBarColor = true;
            this.leaveListPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leaveListPanel.HorizontalScrollbarSize = 10;
            this.leaveListPanel.Location = new System.Drawing.Point(0, 39);
            this.leaveListPanel.Name = "leaveListPanel";
            this.leaveListPanel.Size = new System.Drawing.Size(942, 588);
            this.leaveListPanel.TabIndex = 1;
            this.leaveListPanel.VerticalScrollbarBarColor = true;
            this.leaveListPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leaveListPanel.VerticalScrollbarSize = 10;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(343, 112);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 19);
            this.toLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.toLabel.TabIndex = 9;
            this.toLabel.Text = "To";
            this.toLabel.UseStyleColors = true;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(25, 112);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(41, 19);
            this.fromLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.fromLabel.TabIndex = 8;
            this.fromLabel.Text = "From";
            this.fromLabel.UseStyleColors = true;
            // 
            // leaveTypeLabel
            // 
            this.leaveTypeLabel.AutoSize = true;
            this.leaveTypeLabel.Location = new System.Drawing.Point(343, 32);
            this.leaveTypeLabel.Name = "leaveTypeLabel";
            this.leaveTypeLabel.Size = new System.Drawing.Size(73, 19);
            this.leaveTypeLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.leaveTypeLabel.TabIndex = 7;
            this.leaveTypeLabel.Text = "Leave Type";
            this.leaveTypeLabel.UseStyleColors = true;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(25, 32);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(107, 19);
            this.employeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.employeeNameLabel.TabIndex = 6;
            this.employeeNameLabel.Text = "Employee Name";
            this.employeeNameLabel.UseStyleColors = true;
            // 
            // SelectActionTile
            // 
            this.SelectActionTile.ActiveControl = null;
            this.SelectActionTile.Location = new System.Drawing.Point(822, 75);
            this.SelectActionTile.Name = "SelectActionTile";
            this.SelectActionTile.Size = new System.Drawing.Size(100, 93);
            this.SelectActionTile.Style = MetroFramework.MetroColorStyle.Red;
            this.SelectActionTile.TabIndex = 3;
            this.SelectActionTile.Text = "Select Action";
            this.SelectActionTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SelectActionTile.TileImage = global::SlipstreamHRM.Properties.Resources.Select_Action_Icon;
            this.SelectActionTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectActionTile.UseSelectable = true;
            this.SelectActionTile.UseStyleColors = true;
            this.SelectActionTile.UseTileImage = true;
            this.SelectActionTile.Click += new System.EventHandler(this.SelectActionTile_Click);
            // 
            // leaveListDataGridView
            // 
            this.leaveListDataGridView.AllowUserToAddRows = false;
            this.leaveListDataGridView.AllowUserToDeleteRows = false;
            this.leaveListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveListDataGridView.Location = new System.Drawing.Point(3, 184);
            this.leaveListDataGridView.Name = "leaveListDataGridView";
            this.leaveListDataGridView.ReadOnly = true;
            this.leaveListDataGridView.Size = new System.Drawing.Size(934, 399);
            this.leaveListDataGridView.TabIndex = 2;
            this.leaveListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveListDataGridView_CellClick);
            // 
            // txtEmployeeName
            // 
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(25, 63);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(279, 23);
            this.txtEmployeeName.TabIndex = 12;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLeaveType
            // 
            // 
            // 
            // 
            this.txtLeaveType.CustomButton.Image = null;
            this.txtLeaveType.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtLeaveType.CustomButton.Name = "";
            this.txtLeaveType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLeaveType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLeaveType.CustomButton.TabIndex = 1;
            this.txtLeaveType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLeaveType.CustomButton.UseSelectable = true;
            this.txtLeaveType.CustomButton.Visible = false;
            this.txtLeaveType.Lines = new string[0];
            this.txtLeaveType.Location = new System.Drawing.Point(343, 63);
            this.txtLeaveType.MaxLength = 32767;
            this.txtLeaveType.Name = "txtLeaveType";
            this.txtLeaveType.PasswordChar = '\0';
            this.txtLeaveType.ReadOnly = true;
            this.txtLeaveType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLeaveType.SelectedText = "";
            this.txtLeaveType.SelectionLength = 0;
            this.txtLeaveType.SelectionStart = 0;
            this.txtLeaveType.ShortcutsEnabled = true;
            this.txtLeaveType.Size = new System.Drawing.Size(279, 23);
            this.txtLeaveType.TabIndex = 13;
            this.txtLeaveType.UseSelectable = true;
            this.txtLeaveType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLeaveType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFrom
            // 
            // 
            // 
            // 
            this.txtFrom.CustomButton.Image = null;
            this.txtFrom.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtFrom.CustomButton.Name = "";
            this.txtFrom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFrom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFrom.CustomButton.TabIndex = 1;
            this.txtFrom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFrom.CustomButton.UseSelectable = true;
            this.txtFrom.CustomButton.Visible = false;
            this.txtFrom.Lines = new string[0];
            this.txtFrom.Location = new System.Drawing.Point(25, 145);
            this.txtFrom.MaxLength = 32767;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.ReadOnly = true;
            this.txtFrom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFrom.SelectedText = "";
            this.txtFrom.SelectionLength = 0;
            this.txtFrom.SelectionStart = 0;
            this.txtFrom.ShortcutsEnabled = true;
            this.txtFrom.Size = new System.Drawing.Size(279, 23);
            this.txtFrom.TabIndex = 14;
            this.txtFrom.UseSelectable = true;
            this.txtFrom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFrom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTo
            // 
            // 
            // 
            // 
            this.txtTo.CustomButton.Image = null;
            this.txtTo.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtTo.CustomButton.Name = "";
            this.txtTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTo.CustomButton.TabIndex = 1;
            this.txtTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTo.CustomButton.UseSelectable = true;
            this.txtTo.CustomButton.Visible = false;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(343, 145);
            this.txtTo.MaxLength = 32767;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.ReadOnly = true;
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.ShortcutsEnabled = true;
            this.txtTo.Size = new System.Drawing.Size(279, 23);
            this.txtTo.TabIndex = 15;
            this.txtTo.UseSelectable = true;
            this.txtTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LeaveListDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leaveListPanel);
            this.Controls.Add(this.LeaveListLink);
            this.Name = "LeaveListDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.LeaveListDashboardControl_Load);
            this.leaveListPanel.ResumeLayout(false);
            this.leaveListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink LeaveListLink;
        private MetroFramework.Controls.MetroPanel leaveListPanel;
        private System.Windows.Forms.DataGridView leaveListDataGridView;
        private MetroFramework.Controls.MetroTile SelectActionTile;
        private MetroFramework.Controls.MetroLabel toLabel;
        private MetroFramework.Controls.MetroLabel fromLabel;
        private MetroFramework.Controls.MetroLabel leaveTypeLabel;
        private MetroFramework.Controls.MetroLabel employeeNameLabel;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroTextBox txtLeaveType;
        private MetroFramework.Controls.MetroTextBox txtFrom;
        private MetroFramework.Controls.MetroTextBox txtTo;
    }
}
