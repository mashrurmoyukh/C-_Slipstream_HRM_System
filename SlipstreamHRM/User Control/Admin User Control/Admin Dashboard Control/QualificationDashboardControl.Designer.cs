namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    partial class QualificationDashboardControl
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
            this.QualificationLink = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.QualificationTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.QualificationTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.QualificationTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QualificationLink
            // 
            this.QualificationLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.QualificationLink.Location = new System.Drawing.Point(0, 0);
            this.QualificationLink.Name = "QualificationLink";
            this.QualificationLink.Size = new System.Drawing.Size(942, 23);
            this.QualificationLink.TabIndex = 0;
            this.QualificationLink.Text = "Qualification";
            this.QualificationLink.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.QualificationTabPage1);
            this.metroTabControl1.Controls.Add(this.QualificationTabPage2);
            this.metroTabControl1.Controls.Add(this.QualificationTabPage3);
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
            // QualificationTabPage1
            // 
            this.QualificationTabPage1.HorizontalScrollbarBarColor = true;
            this.QualificationTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage1.HorizontalScrollbarSize = 10;
            this.QualificationTabPage1.Location = new System.Drawing.Point(4, 41);
            this.QualificationTabPage1.Name = "QualificationTabPage1";
            this.QualificationTabPage1.Size = new System.Drawing.Size(934, 559);
            this.QualificationTabPage1.TabIndex = 0;
            this.QualificationTabPage1.Text = "Skills";
            this.QualificationTabPage1.VerticalScrollbarBarColor = true;
            this.QualificationTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage1.VerticalScrollbarSize = 10;
            // 
            // QualificationTabPage2
            // 
            this.QualificationTabPage2.HorizontalScrollbarBarColor = true;
            this.QualificationTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage2.HorizontalScrollbarSize = 10;
            this.QualificationTabPage2.Location = new System.Drawing.Point(4, 41);
            this.QualificationTabPage2.Name = "QualificationTabPage2";
            this.QualificationTabPage2.Size = new System.Drawing.Size(934, 559);
            this.QualificationTabPage2.TabIndex = 1;
            this.QualificationTabPage2.Text = "Education";
            this.QualificationTabPage2.VerticalScrollbarBarColor = true;
            this.QualificationTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage2.VerticalScrollbarSize = 10;
            // 
            // QualificationTabPage3
            // 
            this.QualificationTabPage3.HorizontalScrollbarBarColor = true;
            this.QualificationTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage3.HorizontalScrollbarSize = 10;
            this.QualificationTabPage3.Location = new System.Drawing.Point(4, 41);
            this.QualificationTabPage3.Name = "QualificationTabPage3";
            this.QualificationTabPage3.Size = new System.Drawing.Size(934, 559);
            this.QualificationTabPage3.TabIndex = 2;
            this.QualificationTabPage3.Text = "Language";
            this.QualificationTabPage3.VerticalScrollbarBarColor = true;
            this.QualificationTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.QualificationTabPage3.VerticalScrollbarSize = 10;
            // 
            // QualificationDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.QualificationLink);
            this.Name = "QualificationDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink QualificationLink;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage QualificationTabPage1;
        private MetroFramework.Controls.MetroTabPage QualificationTabPage2;
        private MetroFramework.Controls.MetroTabPage QualificationTabPage3;
    }
}
