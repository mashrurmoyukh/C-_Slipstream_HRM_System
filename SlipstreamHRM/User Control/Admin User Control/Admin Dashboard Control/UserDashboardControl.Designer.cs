namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    partial class UserDashboardControl
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
            this.UserLink = new MetroFramework.Controls.MetroLink();
            this.userManagementPanel = new MetroFramework.Controls.MetroPanel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.userManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLink
            // 
            this.UserLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserLink.Location = new System.Drawing.Point(0, 0);
            this.UserLink.Name = "UserLink";
            this.UserLink.Size = new System.Drawing.Size(942, 23);
            this.UserLink.TabIndex = 0;
            this.UserLink.Text = "Users";
            this.UserLink.UseSelectable = true;
            // 
            // userManagementPanel
            // 
            this.userManagementPanel.Controls.Add(this.userDataGridView);
            this.userManagementPanel.Controls.Add(this.DeleteTile);
            this.userManagementPanel.Controls.Add(this.EditTile);
            this.userManagementPanel.Controls.Add(this.AddTile);
            this.userManagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagementPanel.HorizontalScrollbarBarColor = true;
            this.userManagementPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.userManagementPanel.HorizontalScrollbarSize = 10;
            this.userManagementPanel.Location = new System.Drawing.Point(0, 23);
            this.userManagementPanel.Name = "userManagementPanel";
            this.userManagementPanel.Size = new System.Drawing.Size(942, 604);
            this.userManagementPanel.TabIndex = 1;
            this.userManagementPanel.VerticalScrollbarBarColor = true;
            this.userManagementPanel.VerticalScrollbarHighlightOnWheel = false;
            this.userManagementPanel.VerticalScrollbarSize = 10;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userDataGridView.Location = new System.Drawing.Point(3, 93);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(936, 508);
            this.userDataGridView.TabIndex = 5;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(846, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 4;
            this.DeleteTile.Text = "Delete";
            this.DeleteTile.TileImage = global::SlipstreamHRM.Properties.Resources.Felete_Icon;
            this.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteTile.UseSelectable = true;
            this.DeleteTile.UseStyleColors = true;
            this.DeleteTile.UseTileImage = true;
            this.DeleteTile.Click += new System.EventHandler(this.DeleteTile_Click);
            // 
            // EditTile
            // 
            this.EditTile.ActiveControl = null;
            this.EditTile.Location = new System.Drawing.Point(747, 3);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(93, 84);
            this.EditTile.TabIndex = 3;
            this.EditTile.Text = "Edit";
            this.EditTile.TileImage = global::SlipstreamHRM.Properties.Resources.Edit_Icon;
            this.EditTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditTile.UseSelectable = true;
            this.EditTile.UseTileImage = true;
            this.EditTile.Click += new System.EventHandler(this.EditTile_Click);
            // 
            // AddTile
            // 
            this.AddTile.ActiveControl = null;
            this.AddTile.Location = new System.Drawing.Point(648, 3);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 2;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userManagementPanel);
            this.Controls.Add(this.UserLink);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.UserDashboardControl_Load);
            this.userManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink UserLink;
        private MetroFramework.Controls.MetroPanel userManagementPanel;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView userDataGridView;
    }
}
