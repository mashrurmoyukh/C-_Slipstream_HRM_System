namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    partial class JobTitleDashboardControl
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
            this.jobTitelPanel = new MetroFramework.Controls.MetroPanel();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.jobTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.jobTitelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobTitelPanel
            // 
            this.jobTitelPanel.Controls.Add(this.DeleteTile);
            this.jobTitelPanel.Controls.Add(this.EditTile);
            this.jobTitelPanel.Controls.Add(this.AddTile);
            this.jobTitelPanel.Controls.Add(this.jobTitleDataGridView);
            this.jobTitelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTitelPanel.HorizontalScrollbarBarColor = true;
            this.jobTitelPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.jobTitelPanel.HorizontalScrollbarSize = 10;
            this.jobTitelPanel.Location = new System.Drawing.Point(0, 0);
            this.jobTitelPanel.Name = "jobTitelPanel";
            this.jobTitelPanel.Size = new System.Drawing.Size(934, 559);
            this.jobTitelPanel.TabIndex = 0;
            this.jobTitelPanel.VerticalScrollbarBarColor = true;
            this.jobTitelPanel.VerticalScrollbarHighlightOnWheel = false;
            this.jobTitelPanel.VerticalScrollbarSize = 10;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(838, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 14;
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
            this.EditTile.Location = new System.Drawing.Point(739, 3);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(93, 84);
            this.EditTile.TabIndex = 13;
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
            this.AddTile.Location = new System.Drawing.Point(640, 3);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 12;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // jobTitleDataGridView
            // 
            this.jobTitleDataGridView.AllowUserToAddRows = false;
            this.jobTitleDataGridView.AllowUserToDeleteRows = false;
            this.jobTitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobTitleDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jobTitleDataGridView.Location = new System.Drawing.Point(3, 93);
            this.jobTitleDataGridView.Name = "jobTitleDataGridView";
            this.jobTitleDataGridView.ReadOnly = true;
            this.jobTitleDataGridView.Size = new System.Drawing.Size(928, 463);
            this.jobTitleDataGridView.TabIndex = 11;
            // 
            // JobTitleDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobTitelPanel);
            this.Name = "JobTitleDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.JobTitleDashboardControl_Load);
            this.jobTitelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobTitleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel jobTitelPanel;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView jobTitleDataGridView;
    }
}
