namespace SlipstreamHRM.User_Control
{
    partial class AdminDashboardControl
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
            this.adminDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.adminPanel = new MetroFramework.Controls.MetroPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.NationalitiesTile = new MetroFramework.Controls.MetroTile();
            this.QualificationTile = new MetroFramework.Controls.MetroTile();
            this.OrganizationTile = new MetroFramework.Controls.MetroTile();
            this.JobTile = new MetroFramework.Controls.MetroTile();
            this.UserManagementTile = new MetroFramework.Controls.MetroTile();
            this.adminDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminDashboardPanel
            // 
            this.adminDashboardPanel.Controls.Add(this.adminPanel);
            this.adminDashboardPanel.Controls.Add(this.materialDivider1);
            this.adminDashboardPanel.Controls.Add(this.NationalitiesTile);
            this.adminDashboardPanel.Controls.Add(this.QualificationTile);
            this.adminDashboardPanel.Controls.Add(this.OrganizationTile);
            this.adminDashboardPanel.Controls.Add(this.JobTile);
            this.adminDashboardPanel.Controls.Add(this.UserManagementTile);
            this.adminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDashboardPanel.HorizontalScrollbarBarColor = true;
            this.adminDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.HorizontalScrollbarSize = 10;
            this.adminDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardPanel.Name = "adminDashboardPanel";
            this.adminDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.adminDashboardPanel.TabIndex = 0;
            this.adminDashboardPanel.VerticalScrollbarBarColor = true;
            this.adminDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // adminPanel
            // 
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminPanel.HorizontalScrollbarBarColor = true;
            this.adminPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminPanel.HorizontalScrollbarSize = 10;
            this.adminPanel.Location = new System.Drawing.Point(222, 23);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(942, 627);
            this.adminPanel.TabIndex = 9;
            this.adminPanel.VerticalScrollbarBarColor = true;
            this.adminPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminPanel.VerticalScrollbarSize = 10;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1164, 23);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // NationalitiesTile
            // 
            this.NationalitiesTile.ActiveControl = null;
            this.NationalitiesTile.Location = new System.Drawing.Point(3, 525);
            this.NationalitiesTile.Name = "NationalitiesTile";
            this.NationalitiesTile.Size = new System.Drawing.Size(210, 118);
            this.NationalitiesTile.TabIndex = 7;
            this.NationalitiesTile.Text = "Nationalities";
            this.NationalitiesTile.TileImage = global::SlipstreamHRM.Properties.Resources.Nationalities_Logo_White;
            this.NationalitiesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NationalitiesTile.UseSelectable = true;
            this.NationalitiesTile.UseTileImage = true;
            this.NationalitiesTile.Click += new System.EventHandler(this.NationalitiesTile_Click);
            // 
            // QualificationTile
            // 
            this.QualificationTile.ActiveControl = null;
            this.QualificationTile.Location = new System.Drawing.Point(3, 401);
            this.QualificationTile.Name = "QualificationTile";
            this.QualificationTile.Size = new System.Drawing.Size(210, 118);
            this.QualificationTile.TabIndex = 6;
            this.QualificationTile.Text = "Qualification";
            this.QualificationTile.TileImage = global::SlipstreamHRM.Properties.Resources.Qualification_Inco_White;
            this.QualificationTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QualificationTile.UseSelectable = true;
            this.QualificationTile.UseTileImage = true;
            this.QualificationTile.Click += new System.EventHandler(this.QualificationTile_Click);
            // 
            // OrganizationTile
            // 
            this.OrganizationTile.ActiveControl = null;
            this.OrganizationTile.Location = new System.Drawing.Point(3, 277);
            this.OrganizationTile.Name = "OrganizationTile";
            this.OrganizationTile.Size = new System.Drawing.Size(210, 118);
            this.OrganizationTile.TabIndex = 5;
            this.OrganizationTile.Text = "Organization";
            this.OrganizationTile.TileImage = global::SlipstreamHRM.Properties.Resources.Organization_Logo_White;
            this.OrganizationTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrganizationTile.UseSelectable = true;
            this.OrganizationTile.UseTileImage = true;
            this.OrganizationTile.Click += new System.EventHandler(this.OrganizationTile_Click);
            // 
            // JobTile
            // 
            this.JobTile.ActiveControl = null;
            this.JobTile.Location = new System.Drawing.Point(3, 153);
            this.JobTile.Name = "JobTile";
            this.JobTile.Size = new System.Drawing.Size(210, 118);
            this.JobTile.TabIndex = 4;
            this.JobTile.Text = "Job";
            this.JobTile.TileImage = global::SlipstreamHRM.Properties.Resources.Job_Logo_White;
            this.JobTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JobTile.UseSelectable = true;
            this.JobTile.UseTileImage = true;
            this.JobTile.Click += new System.EventHandler(this.JobTile_Click);
            // 
            // UserManagementTile
            // 
            this.UserManagementTile.ActiveControl = null;
            this.UserManagementTile.Location = new System.Drawing.Point(3, 29);
            this.UserManagementTile.Name = "UserManagementTile";
            this.UserManagementTile.Size = new System.Drawing.Size(210, 118);
            this.UserManagementTile.TabIndex = 3;
            this.UserManagementTile.Text = "User Management";
            this.UserManagementTile.TileImage = global::SlipstreamHRM.Properties.Resources.User_Management_Logo_White;
            this.UserManagementTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserManagementTile.UseSelectable = true;
            this.UserManagementTile.UseTileImage = true;
            this.UserManagementTile.Click += new System.EventHandler(this.UserManagementTile_Click);
            // 
            // AdminDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminDashboardPanel);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(1164, 650);
            this.adminDashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel adminDashboardPanel;
        private MetroFramework.Controls.MetroTile UserManagementTile;
        private MetroFramework.Controls.MetroTile NationalitiesTile;
        private MetroFramework.Controls.MetroTile QualificationTile;
        private MetroFramework.Controls.MetroTile OrganizationTile;
        private MetroFramework.Controls.MetroTile JobTile;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroPanel adminPanel;
    }
}
