namespace SlipstreamHRM.User_Control.Employee_User_Control.Tiem_Dashboard_Control
{
    partial class MyEmployeeAttendanceDashboardControl
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
            this.MyEmployeeAttendanceLink = new MetroFramework.Controls.MetroLink();
            this.myEmployeeAttendanceDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeAttendanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyEmployeeAttendanceLink
            // 
            this.MyEmployeeAttendanceLink.BackColor = System.Drawing.Color.SteelBlue;
            this.MyEmployeeAttendanceLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyEmployeeAttendanceLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.MyEmployeeAttendanceLink.ForeColor = System.Drawing.Color.White;
            this.MyEmployeeAttendanceLink.Location = new System.Drawing.Point(0, 0);
            this.MyEmployeeAttendanceLink.Name = "MyEmployeeAttendanceLink";
            this.MyEmployeeAttendanceLink.Size = new System.Drawing.Size(1326, 39);
            this.MyEmployeeAttendanceLink.TabIndex = 0;
            this.MyEmployeeAttendanceLink.Text = "My Employee Attendance";
            this.MyEmployeeAttendanceLink.UseCustomBackColor = true;
            this.MyEmployeeAttendanceLink.UseCustomForeColor = true;
            this.MyEmployeeAttendanceLink.UseSelectable = true;
            // 
            // myEmployeeAttendanceDataGridView
            // 
            this.myEmployeeAttendanceDataGridView.AllowUserToAddRows = false;
            this.myEmployeeAttendanceDataGridView.AllowUserToDeleteRows = false;
            this.myEmployeeAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myEmployeeAttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myEmployeeAttendanceDataGridView.Location = new System.Drawing.Point(0, 39);
            this.myEmployeeAttendanceDataGridView.Name = "myEmployeeAttendanceDataGridView";
            this.myEmployeeAttendanceDataGridView.ReadOnly = true;
            this.myEmployeeAttendanceDataGridView.Size = new System.Drawing.Size(1326, 291);
            this.myEmployeeAttendanceDataGridView.TabIndex = 1;
            // 
            // MyEmployeeAttendanceDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myEmployeeAttendanceDataGridView);
            this.Controls.Add(this.MyEmployeeAttendanceLink);
            this.Name = "MyEmployeeAttendanceDashboardControl";
            this.Size = new System.Drawing.Size(1326, 330);
            this.Load += new System.EventHandler(this.MyEmployeeAttendanceDashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeAttendanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink MyEmployeeAttendanceLink;
        private System.Windows.Forms.DataGridView myEmployeeAttendanceDataGridView;
    }
}
