namespace SlipstreamHRM.User_Control.Employee_User_Control.Tiem_Dashboard_Control
{
    partial class MyTimeSheetsDashboardControl
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
            this.myTimesheetDataGridView = new System.Windows.Forms.DataGridView();
            this.MyTimeSheetsLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.myTimesheetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myTimesheetDataGridView
            // 
            this.myTimesheetDataGridView.AllowUserToAddRows = false;
            this.myTimesheetDataGridView.AllowUserToDeleteRows = false;
            this.myTimesheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTimesheetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTimesheetDataGridView.Location = new System.Drawing.Point(0, 39);
            this.myTimesheetDataGridView.Name = "myTimesheetDataGridView";
            this.myTimesheetDataGridView.ReadOnly = true;
            this.myTimesheetDataGridView.Size = new System.Drawing.Size(1326, 291);
            this.myTimesheetDataGridView.TabIndex = 3;
            // 
            // MyTimeSheetsLink
            // 
            this.MyTimeSheetsLink.BackColor = System.Drawing.Color.SteelBlue;
            this.MyTimeSheetsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyTimeSheetsLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.MyTimeSheetsLink.ForeColor = System.Drawing.Color.White;
            this.MyTimeSheetsLink.Location = new System.Drawing.Point(0, 0);
            this.MyTimeSheetsLink.Name = "MyTimeSheetsLink";
            this.MyTimeSheetsLink.Size = new System.Drawing.Size(1326, 39);
            this.MyTimeSheetsLink.TabIndex = 2;
            this.MyTimeSheetsLink.Text = "My Timesheets";
            this.MyTimeSheetsLink.UseCustomBackColor = true;
            this.MyTimeSheetsLink.UseCustomForeColor = true;
            this.MyTimeSheetsLink.UseSelectable = true;
            // 
            // MyTimeSheetsDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTimesheetDataGridView);
            this.Controls.Add(this.MyTimeSheetsLink);
            this.Name = "MyTimeSheetsDashboardControl";
            this.Size = new System.Drawing.Size(1326, 330);
            this.Load += new System.EventHandler(this.MyTimeSheetsDashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myTimesheetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myTimesheetDataGridView;
        private MetroFramework.Controls.MetroLink MyTimeSheetsLink;
    }
}
