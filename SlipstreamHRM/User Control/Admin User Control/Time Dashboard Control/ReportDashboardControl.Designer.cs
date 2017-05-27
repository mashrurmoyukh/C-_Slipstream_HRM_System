namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    partial class ReportDashboardControl
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
            this.ReportLink = new MetroFramework.Controls.MetroLink();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.reportTabControl = new MetroFramework.Controls.MetroTabControl();
            this.reportTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportLink
            // 
            this.ReportLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ReportLink.Location = new System.Drawing.Point(0, 0);
            this.ReportLink.Name = "ReportLink";
            this.ReportLink.Size = new System.Drawing.Size(945, 23);
            this.ReportLink.TabIndex = 4;
            this.ReportLink.Text = "Report";
            this.ReportLink.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(937, 582);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Project Reports";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(937, 582);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attendance Reports";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // reportTabControl
            // 
            this.reportTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.reportTabControl.Controls.Add(this.metroTabPage1);
            this.reportTabControl.Controls.Add(this.metroTabPage3);
            this.reportTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.reportTabControl.Location = new System.Drawing.Point(0, 23);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 1;
            this.reportTabControl.Size = new System.Drawing.Size(945, 627);
            this.reportTabControl.TabIndex = 3;
            this.reportTabControl.UseSelectable = true;
            // 
            // ReportDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportTabControl);
            this.Controls.Add(this.ReportLink);
            this.Name = "ReportDashboardControl";
            this.Size = new System.Drawing.Size(945, 650);
            this.reportTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink ReportLink;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl reportTabControl;
    }
}
