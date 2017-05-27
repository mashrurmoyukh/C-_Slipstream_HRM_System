namespace SlipstreamHRM.User_Control.Employee_User_Control.Tiem_Dashboard_Control
{
    partial class MyAttendanceDashboardControl
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
            this.MyAttendanceLink = new MetroFramework.Controls.MetroLink();
            this.myAttendanceListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myAttendanceListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyAttendanceLink
            // 
            this.MyAttendanceLink.BackColor = System.Drawing.Color.SteelBlue;
            this.MyAttendanceLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyAttendanceLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.MyAttendanceLink.ForeColor = System.Drawing.Color.White;
            this.MyAttendanceLink.Location = new System.Drawing.Point(0, 0);
            this.MyAttendanceLink.Name = "MyAttendanceLink";
            this.MyAttendanceLink.Size = new System.Drawing.Size(1326, 38);
            this.MyAttendanceLink.TabIndex = 1;
            this.MyAttendanceLink.Text = "My Attendance";
            this.MyAttendanceLink.UseCustomBackColor = true;
            this.MyAttendanceLink.UseCustomForeColor = true;
            this.MyAttendanceLink.UseSelectable = true;
            // 
            // myAttendanceListDataGridView
            // 
            this.myAttendanceListDataGridView.AllowUserToAddRows = false;
            this.myAttendanceListDataGridView.AllowUserToDeleteRows = false;
            this.myAttendanceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myAttendanceListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myAttendanceListDataGridView.Location = new System.Drawing.Point(0, 38);
            this.myAttendanceListDataGridView.Name = "myAttendanceListDataGridView";
            this.myAttendanceListDataGridView.ReadOnly = true;
            this.myAttendanceListDataGridView.Size = new System.Drawing.Size(1326, 292);
            this.myAttendanceListDataGridView.TabIndex = 2;
            // 
            // MyAttendanceDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myAttendanceListDataGridView);
            this.Controls.Add(this.MyAttendanceLink);
            this.Name = "MyAttendanceDashboardControl";
            this.Size = new System.Drawing.Size(1326, 330);
            this.Load += new System.EventHandler(this.MyAttendanceDashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAttendanceListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink MyAttendanceLink;
        private System.Windows.Forms.DataGridView myAttendanceListDataGridView;
    }
}
