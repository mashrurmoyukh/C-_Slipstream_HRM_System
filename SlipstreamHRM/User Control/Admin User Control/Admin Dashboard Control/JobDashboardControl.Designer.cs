namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    partial class JobDashboardControl
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
            this.JobLink = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.jobTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.jobTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.jobTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.jobTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JobLink
            // 
            this.JobLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.JobLink.Location = new System.Drawing.Point(0, 0);
            this.JobLink.Name = "JobLink";
            this.JobLink.Size = new System.Drawing.Size(942, 23);
            this.JobLink.TabIndex = 0;
            this.JobLink.Text = "Job";
            this.JobLink.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.jobTabPage1);
            this.metroTabControl1.Controls.Add(this.jobTabPage2);
            this.metroTabControl1.Controls.Add(this.jobTabPage3);
            this.metroTabControl1.Controls.Add(this.jobTabPage4);
            this.metroTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 23);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(942, 604);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // jobTabPage1
            // 
            this.jobTabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.jobTabPage1.HorizontalScrollbarBarColor = true;
            this.jobTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.jobTabPage1.HorizontalScrollbarSize = 10;
            this.jobTabPage1.Location = new System.Drawing.Point(4, 41);
            this.jobTabPage1.Name = "jobTabPage1";
            this.jobTabPage1.Size = new System.Drawing.Size(934, 559);
            this.jobTabPage1.TabIndex = 0;
            this.jobTabPage1.Text = "Job Titles";
            this.jobTabPage1.VerticalScrollbarBarColor = true;
            this.jobTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.jobTabPage1.VerticalScrollbarSize = 10;
            // 
            // jobTabPage2
            // 
            this.jobTabPage2.HorizontalScrollbarBarColor = true;
            this.jobTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.jobTabPage2.HorizontalScrollbarSize = 10;
            this.jobTabPage2.Location = new System.Drawing.Point(4, 41);
            this.jobTabPage2.Name = "jobTabPage2";
            this.jobTabPage2.Size = new System.Drawing.Size(934, 559);
            this.jobTabPage2.TabIndex = 1;
            this.jobTabPage2.Text = "Employment Status";
            this.jobTabPage2.VerticalScrollbarBarColor = true;
            this.jobTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.jobTabPage2.VerticalScrollbarSize = 10;
            // 
            // jobTabPage3
            // 
            this.jobTabPage3.HorizontalScrollbarBarColor = true;
            this.jobTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.jobTabPage3.HorizontalScrollbarSize = 10;
            this.jobTabPage3.Location = new System.Drawing.Point(4, 41);
            this.jobTabPage3.Name = "jobTabPage3";
            this.jobTabPage3.Size = new System.Drawing.Size(934, 559);
            this.jobTabPage3.TabIndex = 2;
            this.jobTabPage3.Text = "Job Categories";
            this.jobTabPage3.VerticalScrollbarBarColor = true;
            this.jobTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.jobTabPage3.VerticalScrollbarSize = 10;
            // 
            // jobTabPage4
            // 
            this.jobTabPage4.HorizontalScrollbarBarColor = true;
            this.jobTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.jobTabPage4.HorizontalScrollbarSize = 10;
            this.jobTabPage4.Location = new System.Drawing.Point(4, 41);
            this.jobTabPage4.Name = "jobTabPage4";
            this.jobTabPage4.Size = new System.Drawing.Size(934, 559);
            this.jobTabPage4.TabIndex = 3;
            this.jobTabPage4.Text = "Work Shifts";
            this.jobTabPage4.VerticalScrollbarBarColor = true;
            this.jobTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.jobTabPage4.VerticalScrollbarSize = 10;
            // 
            // JobDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.JobLink);
            this.Name = "JobDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.JobDashboardControl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink JobLink;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage jobTabPage2;
        private MetroFramework.Controls.MetroTabPage jobTabPage3;
        private MetroFramework.Controls.MetroTabPage jobTabPage4;
        private MetroFramework.Controls.MetroTabPage jobTabPage1;
    }
}
