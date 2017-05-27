namespace SlipstreamHRM.User_Control
{
    partial class PIMDashboardControl
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
            this.PIMPanel = new MetroFramework.Controls.MetroPanel();
            this.PIMDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.BulkUpdateTile = new MetroFramework.Controls.MetroTile();
            this.AddEmployeeTile = new MetroFramework.Controls.MetroTile();
            this.EmployeeListTile = new MetroFramework.Controls.MetroTile();
            this.PIMDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIMPanel
            // 
            this.PIMPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIMPanel.HorizontalScrollbarBarColor = true;
            this.PIMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PIMPanel.HorizontalScrollbarSize = 10;
            this.PIMPanel.Location = new System.Drawing.Point(219, 23);
            this.PIMPanel.Name = "PIMPanel";
            this.PIMPanel.Size = new System.Drawing.Size(945, 627);
            this.PIMPanel.TabIndex = 11;
            this.PIMPanel.VerticalScrollbarBarColor = true;
            this.PIMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.PIMPanel.VerticalScrollbarSize = 10;
            // 
            // PIMDashboardPanel
            // 
            this.PIMDashboardPanel.Controls.Add(this.PIMPanel);
            this.PIMDashboardPanel.Controls.Add(this.materialDivider1);
            this.PIMDashboardPanel.Controls.Add(this.BulkUpdateTile);
            this.PIMDashboardPanel.Controls.Add(this.AddEmployeeTile);
            this.PIMDashboardPanel.Controls.Add(this.EmployeeListTile);
            this.PIMDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIMDashboardPanel.HorizontalScrollbarBarColor = true;
            this.PIMDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PIMDashboardPanel.HorizontalScrollbarSize = 10;
            this.PIMDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.PIMDashboardPanel.Name = "PIMDashboardPanel";
            this.PIMDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.PIMDashboardPanel.TabIndex = 1;
            this.PIMDashboardPanel.VerticalScrollbarBarColor = true;
            this.PIMDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.PIMDashboardPanel.VerticalScrollbarSize = 10;
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
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // BulkUpdateTile
            // 
            this.BulkUpdateTile.ActiveControl = null;
            this.BulkUpdateTile.Location = new System.Drawing.Point(3, 277);
            this.BulkUpdateTile.Name = "BulkUpdateTile";
            this.BulkUpdateTile.Size = new System.Drawing.Size(210, 118);
            this.BulkUpdateTile.TabIndex = 5;
            this.BulkUpdateTile.Text = "Bulk Update";
            this.BulkUpdateTile.TileImage = global::SlipstreamHRM.Properties.Resources.Bulk_Update_Icon;
            this.BulkUpdateTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BulkUpdateTile.UseSelectable = true;
            this.BulkUpdateTile.UseTileImage = true;
            this.BulkUpdateTile.Click += new System.EventHandler(this.BulkUpdateTile_Click);
            // 
            // AddEmployeeTile
            // 
            this.AddEmployeeTile.ActiveControl = null;
            this.AddEmployeeTile.Location = new System.Drawing.Point(3, 153);
            this.AddEmployeeTile.Name = "AddEmployeeTile";
            this.AddEmployeeTile.Size = new System.Drawing.Size(210, 118);
            this.AddEmployeeTile.TabIndex = 4;
            this.AddEmployeeTile.Text = "Add Employee";
            this.AddEmployeeTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Employee_Icon;
            this.AddEmployeeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddEmployeeTile.UseSelectable = true;
            this.AddEmployeeTile.UseTileImage = true;
            this.AddEmployeeTile.Click += new System.EventHandler(this.AddEmployeeTile_Click);
            // 
            // EmployeeListTile
            // 
            this.EmployeeListTile.ActiveControl = null;
            this.EmployeeListTile.Location = new System.Drawing.Point(3, 29);
            this.EmployeeListTile.Name = "EmployeeListTile";
            this.EmployeeListTile.Size = new System.Drawing.Size(210, 118);
            this.EmployeeListTile.TabIndex = 3;
            this.EmployeeListTile.Text = "Employee List";
            this.EmployeeListTile.TileImage = global::SlipstreamHRM.Properties.Resources.Employee_List_Icon;
            this.EmployeeListTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeListTile.UseSelectable = true;
            this.EmployeeListTile.UseTileImage = true;
            this.EmployeeListTile.Click += new System.EventHandler(this.EmployeeListTile_Click);
            // 
            // PIMDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PIMDashboardPanel);
            this.Name = "PIMDashboardControl";
            this.Size = new System.Drawing.Size(1164, 650);
            this.PIMDashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PIMPanel;
        private MetroFramework.Controls.MetroPanel PIMDashboardPanel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroTile BulkUpdateTile;
        private MetroFramework.Controls.MetroTile AddEmployeeTile;
        private MetroFramework.Controls.MetroTile EmployeeListTile;
    }
}
