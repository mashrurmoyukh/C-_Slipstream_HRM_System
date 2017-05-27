namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    partial class EmploymentStatusDashboardControl
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
            this.employmentStatusPanel = new MetroFramework.Controls.MetroPanel();
            this.employmentStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.employmentStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employmentStatusPanel
            // 
            this.employmentStatusPanel.Controls.Add(this.employmentStatusDataGridView);
            this.employmentStatusPanel.Controls.Add(this.DeleteTile);
            this.employmentStatusPanel.Controls.Add(this.EditTile);
            this.employmentStatusPanel.Controls.Add(this.AddTile);
            this.employmentStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employmentStatusPanel.HorizontalScrollbarBarColor = true;
            this.employmentStatusPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.employmentStatusPanel.HorizontalScrollbarSize = 10;
            this.employmentStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.employmentStatusPanel.Name = "employmentStatusPanel";
            this.employmentStatusPanel.Size = new System.Drawing.Size(934, 559);
            this.employmentStatusPanel.TabIndex = 0;
            this.employmentStatusPanel.VerticalScrollbarBarColor = true;
            this.employmentStatusPanel.VerticalScrollbarHighlightOnWheel = false;
            this.employmentStatusPanel.VerticalScrollbarSize = 10;
            // 
            // employmentStatusDataGridView
            // 
            this.employmentStatusDataGridView.AllowUserToAddRows = false;
            this.employmentStatusDataGridView.AllowUserToDeleteRows = false;
            this.employmentStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employmentStatusDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employmentStatusDataGridView.Location = new System.Drawing.Point(4, 93);
            this.employmentStatusDataGridView.Name = "employmentStatusDataGridView";
            this.employmentStatusDataGridView.ReadOnly = true;
            this.employmentStatusDataGridView.Size = new System.Drawing.Size(928, 463);
            this.employmentStatusDataGridView.TabIndex = 18;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(839, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 17;
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
            this.EditTile.Location = new System.Drawing.Point(740, 3);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(93, 84);
            this.EditTile.TabIndex = 16;
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
            this.AddTile.Location = new System.Drawing.Point(641, 3);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 15;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // EmploymentStatusDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employmentStatusPanel);
            this.Name = "EmploymentStatusDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.EmploymentStatusDashboardControl_Load);
            this.employmentStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employmentStatusDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel employmentStatusPanel;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView employmentStatusDataGridView;
    }
}
