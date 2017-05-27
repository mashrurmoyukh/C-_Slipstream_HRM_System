namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.ProjectInfo_Dashboard_Control
{
    partial class ProjectDashboardControl
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
            this.ProjectPanel = new MetroFramework.Controls.MetroPanel();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectLink = new MetroFramework.Controls.MetroLink();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.Controls.Add(this.AddTile);
            this.ProjectPanel.Controls.Add(this.projectDataGridView);
            this.ProjectPanel.Controls.Add(this.ProjectLink);
            this.ProjectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectPanel.HorizontalScrollbarBarColor = true;
            this.ProjectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ProjectPanel.HorizontalScrollbarSize = 10;
            this.ProjectPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(937, 582);
            this.ProjectPanel.TabIndex = 0;
            this.ProjectPanel.VerticalScrollbarBarColor = true;
            this.ProjectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ProjectPanel.VerticalScrollbarSize = 10;
            // 
            // AddTile
            // 
            this.AddTile.ActiveControl = null;
            this.AddTile.Location = new System.Drawing.Point(841, 58);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 7;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AllowUserToAddRows = false;
            this.projectDataGridView.AllowUserToDeleteRows = false;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Location = new System.Drawing.Point(3, 148);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.ReadOnly = true;
            this.projectDataGridView.Size = new System.Drawing.Size(931, 432);
            this.projectDataGridView.TabIndex = 6;
            // 
            // ProjectLink
            // 
            this.ProjectLink.BackColor = System.Drawing.Color.SteelBlue;
            this.ProjectLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ProjectLink.ForeColor = System.Drawing.Color.White;
            this.ProjectLink.Location = new System.Drawing.Point(0, 0);
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Size = new System.Drawing.Size(937, 39);
            this.ProjectLink.TabIndex = 5;
            this.ProjectLink.Text = "Project";
            this.ProjectLink.UseCustomBackColor = true;
            this.ProjectLink.UseCustomForeColor = true;
            this.ProjectLink.UseSelectable = true;
            // 
            // ProjectDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectPanel);
            this.Name = "ProjectDashboardControl";
            this.Size = new System.Drawing.Size(937, 582);
            this.Load += new System.EventHandler(this.ProjectDashboardControl_Load);
            this.ProjectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ProjectPanel;
        private MetroFramework.Controls.MetroLink ProjectLink;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView projectDataGridView;
    }
}
