namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    partial class ProjectInfoDashboardControl
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
            this.projectInfoTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ProjectInfoLink = new MetroFramework.Controls.MetroLink();
            this.projectInfoTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectInfoTabControl
            // 
            this.projectInfoTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.projectInfoTabControl.Controls.Add(this.metroTabPage1);
            this.projectInfoTabControl.Controls.Add(this.metroTabPage2);
            this.projectInfoTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectInfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectInfoTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.projectInfoTabControl.Location = new System.Drawing.Point(0, 23);
            this.projectInfoTabControl.Name = "projectInfoTabControl";
            this.projectInfoTabControl.SelectedIndex = 0;
            this.projectInfoTabControl.Size = new System.Drawing.Size(945, 627);
            this.projectInfoTabControl.TabIndex = 0;
            this.projectInfoTabControl.UseSelectable = true;
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
            this.metroTabPage1.Text = "Customer";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(937, 582);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Project";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // ProjectInfoLink
            // 
            this.ProjectInfoLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectInfoLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ProjectInfoLink.Location = new System.Drawing.Point(0, 0);
            this.ProjectInfoLink.Name = "ProjectInfoLink";
            this.ProjectInfoLink.Size = new System.Drawing.Size(945, 23);
            this.ProjectInfoLink.TabIndex = 2;
            this.ProjectInfoLink.Text = "Ptoject Info";
            this.ProjectInfoLink.UseSelectable = true;
            // 
            // ProjectInfoDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.projectInfoTabControl);
            this.Controls.Add(this.ProjectInfoLink);
            this.Name = "ProjectInfoDashboardControl";
            this.Size = new System.Drawing.Size(945, 650);
            this.projectInfoTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl projectInfoTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLink ProjectInfoLink;
    }
}
