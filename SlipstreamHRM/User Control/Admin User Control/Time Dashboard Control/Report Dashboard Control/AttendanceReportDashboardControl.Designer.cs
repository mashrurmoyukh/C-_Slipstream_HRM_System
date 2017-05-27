namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.Report_Dashboard_Control
{
    partial class AttendanceReportDashboardControl
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
            this.attendanceListDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeAttendanceLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceListDataGridView
            // 
            this.attendanceListDataGridView.AllowUserToAddRows = false;
            this.attendanceListDataGridView.AllowUserToDeleteRows = false;
            this.attendanceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceListDataGridView.Location = new System.Drawing.Point(0, 39);
            this.attendanceListDataGridView.Name = "attendanceListDataGridView";
            this.attendanceListDataGridView.ReadOnly = true;
            this.attendanceListDataGridView.Size = new System.Drawing.Size(937, 543);
            this.attendanceListDataGridView.TabIndex = 3;
            // 
            // EmployeeAttendanceLink
            // 
            this.EmployeeAttendanceLink.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeAttendanceLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeAttendanceLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.EmployeeAttendanceLink.ForeColor = System.Drawing.Color.White;
            this.EmployeeAttendanceLink.Location = new System.Drawing.Point(0, 0);
            this.EmployeeAttendanceLink.Name = "EmployeeAttendanceLink";
            this.EmployeeAttendanceLink.Size = new System.Drawing.Size(937, 39);
            this.EmployeeAttendanceLink.TabIndex = 2;
            this.EmployeeAttendanceLink.Text = "Employee Attendance";
            this.EmployeeAttendanceLink.UseCustomBackColor = true;
            this.EmployeeAttendanceLink.UseCustomForeColor = true;
            this.EmployeeAttendanceLink.UseSelectable = true;
            // 
            // AttendanceReportDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attendanceListDataGridView);
            this.Controls.Add(this.EmployeeAttendanceLink);
            this.Name = "AttendanceReportDashboardControl";
            this.Size = new System.Drawing.Size(937, 582);
            this.Load += new System.EventHandler(this.AttendanceReportDashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView attendanceListDataGridView;
        private MetroFramework.Controls.MetroLink EmployeeAttendanceLink;
    }
}
