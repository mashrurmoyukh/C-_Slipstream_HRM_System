namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    partial class LanguageDashboardControl
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
            this.LanguagePanel = new MetroFramework.Controls.MetroPanel();
            this.languageDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.LanguagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.Controls.Add(this.languageDataGridView);
            this.LanguagePanel.Controls.Add(this.DeleteTile);
            this.LanguagePanel.Controls.Add(this.EditTile);
            this.LanguagePanel.Controls.Add(this.AddTile);
            this.LanguagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguagePanel.HorizontalScrollbarBarColor = true;
            this.LanguagePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LanguagePanel.HorizontalScrollbarSize = 10;
            this.LanguagePanel.Location = new System.Drawing.Point(0, 0);
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.Size = new System.Drawing.Size(934, 559);
            this.LanguagePanel.TabIndex = 0;
            this.LanguagePanel.VerticalScrollbarBarColor = true;
            this.LanguagePanel.VerticalScrollbarHighlightOnWheel = false;
            this.LanguagePanel.VerticalScrollbarSize = 10;
            // 
            // languageDataGridView
            // 
            this.languageDataGridView.AllowUserToAddRows = false;
            this.languageDataGridView.AllowUserToDeleteRows = false;
            this.languageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languageDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languageDataGridView.Location = new System.Drawing.Point(3, 93);
            this.languageDataGridView.Name = "languageDataGridView";
            this.languageDataGridView.ReadOnly = true;
            this.languageDataGridView.Size = new System.Drawing.Size(928, 463);
            this.languageDataGridView.TabIndex = 22;
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
            // LanguageDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LanguagePanel);
            this.Name = "LanguageDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.LanguageDashboardControl_Load);
            this.LanguagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.languageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel LanguagePanel;
        private System.Windows.Forms.DataGridView languageDataGridView;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
    }
}
