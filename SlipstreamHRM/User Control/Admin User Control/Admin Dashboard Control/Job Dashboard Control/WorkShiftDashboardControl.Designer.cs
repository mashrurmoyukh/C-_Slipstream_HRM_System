namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    partial class WorkShiftDashboardControl
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
            this.workShiftPanel = new MetroFramework.Controls.MetroPanel();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.workShiftDataGridView = new System.Windows.Forms.DataGridView();
            this.workShiftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workShiftDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workShiftPanel
            // 
            this.workShiftPanel.Controls.Add(this.DeleteTile);
            this.workShiftPanel.Controls.Add(this.EditTile);
            this.workShiftPanel.Controls.Add(this.AddTile);
            this.workShiftPanel.Controls.Add(this.workShiftDataGridView);
            this.workShiftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workShiftPanel.HorizontalScrollbarBarColor = true;
            this.workShiftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.workShiftPanel.HorizontalScrollbarSize = 10;
            this.workShiftPanel.Location = new System.Drawing.Point(0, 0);
            this.workShiftPanel.Name = "workShiftPanel";
            this.workShiftPanel.Size = new System.Drawing.Size(934, 559);
            this.workShiftPanel.TabIndex = 0;
            this.workShiftPanel.VerticalScrollbarBarColor = true;
            this.workShiftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.workShiftPanel.VerticalScrollbarSize = 10;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(838, 3);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 22;
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
            this.EditTile.TabIndex = 21;
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
            this.AddTile.TabIndex = 20;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // workShiftDataGridView
            // 
            this.workShiftDataGridView.AllowUserToAddRows = false;
            this.workShiftDataGridView.AllowUserToDeleteRows = false;
            this.workShiftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workShiftDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workShiftDataGridView.Location = new System.Drawing.Point(3, 93);
            this.workShiftDataGridView.Name = "workShiftDataGridView";
            this.workShiftDataGridView.ReadOnly = true;
            this.workShiftDataGridView.Size = new System.Drawing.Size(928, 463);
            this.workShiftDataGridView.TabIndex = 19;
            // 
            // WorkShiftDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.workShiftPanel);
            this.Name = "WorkShiftDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.WorkShiftDashboardControl_Load);
            this.workShiftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workShiftDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel workShiftPanel;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile EditTile;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView workShiftDataGridView;
    }
}
