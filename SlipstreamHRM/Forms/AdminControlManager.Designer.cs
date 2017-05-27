namespace SlipstreamHRM.Forms
{
    partial class AdminControlManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminFormPanel = new MetroFramework.Controls.MetroPanel();
            this.adminDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.adminHeaderPanel = new MetroFramework.Controls.MetroPanel();
            this.ModuleNameShowLink = new MetroFramework.Controls.MetroLink();
            this.ChangePasswordLink = new MetroFramework.Controls.MetroLink();
            this.LogOutLink = new MetroFramework.Controls.MetroLink();
            this.adminHomeLink = new MetroFramework.Controls.MetroLink();
            this.adminNavigationPanel = new MetroFramework.Controls.MetroPanel();
            this.slipstreamLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.RequirementTile = new MetroFramework.Controls.MetroTile();
            this.TimeTile = new MetroFramework.Controls.MetroTile();
            this.LeaveTile = new MetroFramework.Controls.MetroTile();
            this.PimTile = new MetroFramework.Controls.MetroTile();
            this.AdminTile = new MetroFramework.Controls.MetroTile();
            this.adminFormPanel.SuspendLayout();
            this.adminHeaderPanel.SuspendLayout();
            this.adminNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.Controls.Add(this.adminDashboardPanel);
            this.adminFormPanel.Controls.Add(this.adminHeaderPanel);
            this.adminFormPanel.Controls.Add(this.adminNavigationPanel);
            this.adminFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFormPanel.HorizontalScrollbarBarColor = true;
            this.adminFormPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminFormPanel.HorizontalScrollbarSize = 10;
            this.adminFormPanel.Location = new System.Drawing.Point(20, 60);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(1326, 688);
            this.adminFormPanel.TabIndex = 0;
            this.adminFormPanel.VerticalScrollbarBarColor = true;
            this.adminFormPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminFormPanel.VerticalScrollbarSize = 10;
            // 
            // adminDashboardPanel
            // 
            this.adminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDashboardPanel.HorizontalScrollbarBarColor = true;
            this.adminDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.HorizontalScrollbarSize = 10;
            this.adminDashboardPanel.Location = new System.Drawing.Point(160, 38);
            this.adminDashboardPanel.Name = "adminDashboardPanel";
            this.adminDashboardPanel.Size = new System.Drawing.Size(1166, 650);
            this.adminDashboardPanel.TabIndex = 6;
            this.adminDashboardPanel.VerticalScrollbarBarColor = true;
            this.adminDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // adminHeaderPanel
            // 
            this.adminHeaderPanel.BackColor = System.Drawing.Color.Orchid;
            this.adminHeaderPanel.Controls.Add(this.ModuleNameShowLink);
            this.adminHeaderPanel.Controls.Add(this.ChangePasswordLink);
            this.adminHeaderPanel.Controls.Add(this.LogOutLink);
            this.adminHeaderPanel.Controls.Add(this.adminHomeLink);
            this.adminHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminHeaderPanel.HorizontalScrollbarBarColor = true;
            this.adminHeaderPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminHeaderPanel.HorizontalScrollbarSize = 10;
            this.adminHeaderPanel.Location = new System.Drawing.Point(160, 0);
            this.adminHeaderPanel.Name = "adminHeaderPanel";
            this.adminHeaderPanel.Size = new System.Drawing.Size(1166, 38);
            this.adminHeaderPanel.TabIndex = 5;
            this.adminHeaderPanel.UseCustomBackColor = true;
            this.adminHeaderPanel.VerticalScrollbarBarColor = true;
            this.adminHeaderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminHeaderPanel.VerticalScrollbarSize = 10;
            // 
            // ModuleNameShowLink
            // 
            this.ModuleNameShowLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModuleNameShowLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.ModuleNameShowLink.ForeColor = System.Drawing.Color.White;
            this.ModuleNameShowLink.Location = new System.Drawing.Point(684, 0);
            this.ModuleNameShowLink.Name = "ModuleNameShowLink";
            this.ModuleNameShowLink.Size = new System.Drawing.Size(186, 38);
            this.ModuleNameShowLink.TabIndex = 4;
            this.ModuleNameShowLink.UseCustomBackColor = true;
            this.ModuleNameShowLink.UseCustomForeColor = true;
            this.ModuleNameShowLink.UseSelectable = true;
            // 
            // ChangePasswordLink
            // 
            this.ChangePasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangePasswordLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ChangePasswordLink.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordLink.Image = global::SlipstreamHRM.Properties.Resources.Seetign_Icon_White;
            this.ChangePasswordLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordLink.ImageSize = 32;
            this.ChangePasswordLink.Location = new System.Drawing.Point(870, 0);
            this.ChangePasswordLink.Name = "ChangePasswordLink";
            this.ChangePasswordLink.Size = new System.Drawing.Size(176, 38);
            this.ChangePasswordLink.TabIndex = 3;
            this.ChangePasswordLink.Text = "   Change Password   ";
            this.ChangePasswordLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordLink.UseCustomBackColor = true;
            this.ChangePasswordLink.UseCustomForeColor = true;
            this.ChangePasswordLink.UseSelectable = true;
            this.ChangePasswordLink.Click += new System.EventHandler(this.ChangePasswordLink_Click);
            // 
            // LogOutLink
            // 
            this.LogOutLink.BackColor = System.Drawing.Color.Transparent;
            this.LogOutLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogOutLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LogOutLink.ForeColor = System.Drawing.Color.White;
            this.LogOutLink.Image = global::SlipstreamHRM.Properties.Resources.LogOutIcon;
            this.LogOutLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutLink.ImageSize = 32;
            this.LogOutLink.Location = new System.Drawing.Point(1046, 0);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(120, 38);
            this.LogOutLink.TabIndex = 4;
            this.LogOutLink.Text = "   Log Out";
            this.LogOutLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutLink.UseCustomBackColor = true;
            this.LogOutLink.UseCustomForeColor = true;
            this.LogOutLink.UseSelectable = true;
            this.LogOutLink.Click += new System.EventHandler(this.LogOutLink_Click);
            // 
            // adminHomeLink
            // 
            this.adminHomeLink.BackColor = System.Drawing.Color.Transparent;
            this.adminHomeLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminHomeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminHomeLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.adminHomeLink.ForeColor = System.Drawing.Color.White;
            this.adminHomeLink.Image = global::SlipstreamHRM.Properties.Resources.Home_Little_Icon;
            this.adminHomeLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminHomeLink.ImageSize = 32;
            this.adminHomeLink.Location = new System.Drawing.Point(6, 3);
            this.adminHomeLink.Name = "adminHomeLink";
            this.adminHomeLink.Size = new System.Drawing.Size(88, 33);
            this.adminHomeLink.TabIndex = 3;
            this.adminHomeLink.Text = "Home";
            this.adminHomeLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminHomeLink.UseCustomBackColor = true;
            this.adminHomeLink.UseCustomForeColor = true;
            this.adminHomeLink.UseSelectable = true;
            this.adminHomeLink.Click += new System.EventHandler(this.adminHomeLink_Click);
            // 
            // adminNavigationPanel
            // 
            this.adminNavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminNavigationPanel.Controls.Add(this.slipstreamLogoPictureBox);
            this.adminNavigationPanel.Controls.Add(this.RequirementTile);
            this.adminNavigationPanel.Controls.Add(this.TimeTile);
            this.adminNavigationPanel.Controls.Add(this.LeaveTile);
            this.adminNavigationPanel.Controls.Add(this.PimTile);
            this.adminNavigationPanel.Controls.Add(this.AdminTile);
            this.adminNavigationPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminNavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminNavigationPanel.HorizontalScrollbarBarColor = true;
            this.adminNavigationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminNavigationPanel.HorizontalScrollbarSize = 10;
            this.adminNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.adminNavigationPanel.Name = "adminNavigationPanel";
            this.adminNavigationPanel.Size = new System.Drawing.Size(160, 688);
            this.adminNavigationPanel.TabIndex = 3;
            this.adminNavigationPanel.TabStop = true;
            this.adminNavigationPanel.VerticalScrollbarBarColor = true;
            this.adminNavigationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminNavigationPanel.VerticalScrollbarSize = 10;
            // 
            // slipstreamLogoPictureBox
            // 
            this.slipstreamLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slipstreamLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.slipstreamLogoPictureBox.Image = global::SlipstreamHRM.Properties.Resources.Logo;
            this.slipstreamLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.slipstreamLogoPictureBox.Name = "slipstreamLogoPictureBox";
            this.slipstreamLogoPictureBox.Size = new System.Drawing.Size(158, 68);
            this.slipstreamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slipstreamLogoPictureBox.TabIndex = 5;
            this.slipstreamLogoPictureBox.TabStop = false;
            // 
            // RequirementTile
            // 
            this.RequirementTile.ActiveControl = null;
            this.RequirementTile.Location = new System.Drawing.Point(3, 566);
            this.RequirementTile.Name = "RequirementTile";
            this.RequirementTile.Size = new System.Drawing.Size(150, 117);
            this.RequirementTile.TabIndex = 11;
            this.RequirementTile.Text = "Requirement";
            this.RequirementTile.TileImage = global::SlipstreamHRM.Properties.Resources.Requirement_Icon_White1;
            this.RequirementTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RequirementTile.UseSelectable = true;
            this.RequirementTile.UseTileImage = true;
            this.RequirementTile.Click += new System.EventHandler(this.RequirementTile_Click);
            // 
            // TimeTile
            // 
            this.TimeTile.ActiveControl = null;
            this.TimeTile.Location = new System.Drawing.Point(3, 443);
            this.TimeTile.Name = "TimeTile";
            this.TimeTile.Size = new System.Drawing.Size(150, 117);
            this.TimeTile.TabIndex = 10;
            this.TimeTile.Text = "Time";
            this.TimeTile.TileImage = global::SlipstreamHRM.Properties.Resources.Time_Icon_White;
            this.TimeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeTile.UseSelectable = true;
            this.TimeTile.UseTileImage = true;
            this.TimeTile.Click += new System.EventHandler(this.TimeTile_Click);
            // 
            // LeaveTile
            // 
            this.LeaveTile.ActiveControl = null;
            this.LeaveTile.Location = new System.Drawing.Point(3, 320);
            this.LeaveTile.Name = "LeaveTile";
            this.LeaveTile.Size = new System.Drawing.Size(150, 117);
            this.LeaveTile.TabIndex = 9;
            this.LeaveTile.Text = "Leave";
            this.LeaveTile.TileImage = global::SlipstreamHRM.Properties.Resources.Leave_White_Icon;
            this.LeaveTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeaveTile.UseSelectable = true;
            this.LeaveTile.UseTileImage = true;
            this.LeaveTile.Click += new System.EventHandler(this.LeaveTile_Click);
            // 
            // PimTile
            // 
            this.PimTile.ActiveControl = null;
            this.PimTile.Location = new System.Drawing.Point(3, 197);
            this.PimTile.Name = "PimTile";
            this.PimTile.Size = new System.Drawing.Size(150, 117);
            this.PimTile.TabIndex = 8;
            this.PimTile.Text = "PIM";
            this.PimTile.TileImage = global::SlipstreamHRM.Properties.Resources.PIM_White_Icon;
            this.PimTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PimTile.UseSelectable = true;
            this.PimTile.UseTileImage = true;
            this.PimTile.Click += new System.EventHandler(this.PimTile_Click);
            // 
            // AdminTile
            // 
            this.AdminTile.ActiveControl = null;
            this.AdminTile.Location = new System.Drawing.Point(3, 74);
            this.AdminTile.Name = "AdminTile";
            this.AdminTile.Size = new System.Drawing.Size(150, 117);
            this.AdminTile.TabIndex = 7;
            this.AdminTile.Text = "Admin";
            this.AdminTile.TileImage = global::SlipstreamHRM.Properties.Resources.Admin_Icon_White;
            this.AdminTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminTile.UseSelectable = true;
            this.AdminTile.UseStyleColors = true;
            this.AdminTile.UseTileImage = true;
            this.AdminTile.Click += new System.EventHandler(this.AdminTile_Click);
            // 
            // AdminControlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.adminFormPanel);
            this.MaximizeBox = false;
            this.Name = "AdminControlManager";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminControlManager_FormClosing);
            this.adminFormPanel.ResumeLayout(false);
            this.adminHeaderPanel.ResumeLayout(false);
            this.adminNavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slipstreamLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel adminFormPanel;
        private System.Windows.Forms.PictureBox slipstreamLogoPictureBox;
        private MetroFramework.Controls.MetroLink adminHomeLink;
        private MetroFramework.Controls.MetroPanel adminNavigationPanel;
        private MetroFramework.Controls.MetroTile RequirementTile;
        private MetroFramework.Controls.MetroTile TimeTile;
        private MetroFramework.Controls.MetroTile LeaveTile;
        private MetroFramework.Controls.MetroTile PimTile;
        private MetroFramework.Controls.MetroTile AdminTile;
        private MetroFramework.Controls.MetroPanel adminDashboardPanel;
        private MetroFramework.Controls.MetroPanel adminHeaderPanel;
        private MetroFramework.Controls.MetroLink LogOutLink;
        private MetroFramework.Controls.MetroLink ChangePasswordLink;
        private MetroFramework.Controls.MetroLink ModuleNameShowLink;
    }
}