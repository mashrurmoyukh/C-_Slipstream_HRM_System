namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    partial class OrganizationDashboardControl
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
            this.OrganizationLink = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.organizationTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.organizationTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationLink
            // 
            this.OrganizationLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrganizationLink.Location = new System.Drawing.Point(0, 0);
            this.OrganizationLink.Name = "OrganizationLink";
            this.OrganizationLink.Size = new System.Drawing.Size(942, 23);
            this.OrganizationLink.TabIndex = 0;
            this.OrganizationLink.Text = "Organization";
            this.OrganizationLink.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.organizationTabPage1);
            this.metroTabControl1.Controls.Add(this.organizationTabPage2);
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
            // organizationTabPage1
            // 
            this.organizationTabPage1.BackColor = System.Drawing.Color.White;
            this.organizationTabPage1.HorizontalScrollbarBarColor = true;
            this.organizationTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.organizationTabPage1.HorizontalScrollbarSize = 10;
            this.organizationTabPage1.Location = new System.Drawing.Point(4, 41);
            this.organizationTabPage1.Name = "organizationTabPage1";
            this.organizationTabPage1.Size = new System.Drawing.Size(934, 559);
            this.organizationTabPage1.TabIndex = 0;
            this.organizationTabPage1.Text = "General Information";
            this.organizationTabPage1.VerticalScrollbarBarColor = true;
            this.organizationTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.organizationTabPage1.VerticalScrollbarSize = 10;
            // 
            // organizationTabPage2
            // 
            this.organizationTabPage2.HorizontalScrollbarBarColor = true;
            this.organizationTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.organizationTabPage2.HorizontalScrollbarSize = 10;
            this.organizationTabPage2.Location = new System.Drawing.Point(4, 41);
            this.organizationTabPage2.Name = "organizationTabPage2";
            this.organizationTabPage2.Size = new System.Drawing.Size(934, 559);
            this.organizationTabPage2.TabIndex = 1;
            this.organizationTabPage2.Text = "Locations";
            this.organizationTabPage2.VerticalScrollbarBarColor = true;
            this.organizationTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.organizationTabPage2.VerticalScrollbarSize = 10;
            // 
            // OrganizationDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.OrganizationLink);
            this.Name = "OrganizationDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.OrganizationDashboardControl_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink OrganizationLink;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage organizationTabPage1;
        private MetroFramework.Controls.MetroTabPage organizationTabPage2;
    }
}
