namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    partial class NationalitiesDashboardControl
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
            this.NationalitiesLink = new MetroFramework.Controls.MetroLink();
            this.NationalitiesPanel = new MetroFramework.Controls.MetroPanel();
            this.regionDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.NationalitiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NationalitiesLink
            // 
            this.NationalitiesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.NationalitiesLink.Location = new System.Drawing.Point(0, 0);
            this.NationalitiesLink.Name = "NationalitiesLink";
            this.NationalitiesLink.Size = new System.Drawing.Size(942, 23);
            this.NationalitiesLink.TabIndex = 0;
            this.NationalitiesLink.Text = "Nationalities";
            this.NationalitiesLink.UseSelectable = true;
            // 
            // NationalitiesPanel
            // 
            this.NationalitiesPanel.Controls.Add(this.regionDataGridView);
            this.NationalitiesPanel.Controls.Add(this.DeleteTile);
            this.NationalitiesPanel.Controls.Add(this.EditTile);
            this.NationalitiesPanel.Controls.Add(this.AddTile);
            this.NationalitiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NationalitiesPanel.HorizontalScrollbarBarColor = true;
            this.NationalitiesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.NationalitiesPanel.HorizontalScrollbarSize = 10;
            this.NationalitiesPanel.Location = new System.Drawing.Point(0, 23);
            this.NationalitiesPanel.Name = "NationalitiesPanel";
            this.NationalitiesPanel.Size = new System.Drawing.Size(942, 604);
            this.NationalitiesPanel.TabIndex = 1;
            this.NationalitiesPanel.VerticalScrollbarBarColor = true;
            this.NationalitiesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.NationalitiesPanel.VerticalScrollbarSize = 10;
            // 
            // regionDataGridView
            // 
            this.regionDataGridView.AllowUserToAddRows = false;
            this.regionDataGridView.AllowUserToDeleteRows = false;
            this.regionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regionDataGridView.Location = new System.Drawing.Point(3, 96);
            this.regionDataGridView.Name = "regionDataGridView";
            this.regionDataGridView.ReadOnly = true;
            this.regionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regionDataGridView.Size = new System.Drawing.Size(936, 505);
            this.regionDataGridView.TabIndex = 8;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(846, 6);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 7;
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
            this.EditTile.Location = new System.Drawing.Point(747, 6);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(93, 84);
            this.EditTile.TabIndex = 6;
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
            this.AddTile.Location = new System.Drawing.Point(648, 6);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 5;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // NationalitiesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NationalitiesPanel);
            this.Controls.Add(this.NationalitiesLink);
            this.Name = "NationalitiesDashboardControl";
            this.Size = new System.Drawing.Size(942, 627);
            this.Load += new System.EventHandler(this.NationalitiesDashboardControl_Load);
            this.NationalitiesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink NationalitiesLink;
        private MetroFramework.Controls.MetroPanel NationalitiesPanel;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView regionDataGridView;
    }
}
