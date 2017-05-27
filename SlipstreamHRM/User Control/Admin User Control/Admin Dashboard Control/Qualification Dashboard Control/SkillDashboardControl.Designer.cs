namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    partial class SkillDashboardControl
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
            this.SkillPanel = new MetroFramework.Controls.MetroPanel();
            this.skillDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.SkillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SkillPanel
            // 
            this.SkillPanel.Controls.Add(this.skillDataGridView);
            this.SkillPanel.Controls.Add(this.DeleteTile);
            this.SkillPanel.Controls.Add(this.EditTile);
            this.SkillPanel.Controls.Add(this.AddTile);
            this.SkillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkillPanel.HorizontalScrollbarBarColor = true;
            this.SkillPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SkillPanel.HorizontalScrollbarSize = 10;
            this.SkillPanel.Location = new System.Drawing.Point(0, 0);
            this.SkillPanel.Name = "SkillPanel";
            this.SkillPanel.Size = new System.Drawing.Size(934, 559);
            this.SkillPanel.TabIndex = 0;
            this.SkillPanel.VerticalScrollbarBarColor = true;
            this.SkillPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SkillPanel.VerticalScrollbarSize = 10;
            // 
            // skillDataGridView
            // 
            this.skillDataGridView.AllowUserToAddRows = false;
            this.skillDataGridView.AllowUserToDeleteRows = false;
            this.skillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skillDataGridView.Location = new System.Drawing.Point(3, 93);
            this.skillDataGridView.Name = "skillDataGridView";
            this.skillDataGridView.ReadOnly = true;
            this.skillDataGridView.Size = new System.Drawing.Size(928, 463);
            this.skillDataGridView.TabIndex = 22;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(838, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 21;
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
            this.EditTile.TabIndex = 20;
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
            this.AddTile.TabIndex = 19;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // SkillDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkillPanel);
            this.Name = "SkillDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.SkillDashboardControl_Load_1);
            this.SkillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel SkillPanel;
        private System.Windows.Forms.DataGridView skillDataGridView;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
    }
}
