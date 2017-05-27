namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    partial class EmployeeListDashboardControl
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
            this.EmployeeListPanel = new MetroFramework.Controls.MetroPanel();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeListLink = new MetroFramework.Controls.MetroLink();
            this.EmployeeListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeListPanel
            // 
            this.EmployeeListPanel.Controls.Add(this.DeleteTile);
            this.EmployeeListPanel.Controls.Add(this.employeeDataGridView);
            this.EmployeeListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeListPanel.HorizontalScrollbarBarColor = true;
            this.EmployeeListPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.EmployeeListPanel.HorizontalScrollbarSize = 10;
            this.EmployeeListPanel.Location = new System.Drawing.Point(0, 29);
            this.EmployeeListPanel.Name = "EmployeeListPanel";
            this.EmployeeListPanel.Size = new System.Drawing.Size(945, 598);
            this.EmployeeListPanel.TabIndex = 3;
            this.EmployeeListPanel.VerticalScrollbarBarColor = true;
            this.EmployeeListPanel.VerticalScrollbarHighlightOnWheel = false;
            this.EmployeeListPanel.VerticalScrollbarSize = 10;
            // 
            // DeleteTile
            // 
            this.DeleteTile.ActiveControl = null;
            this.DeleteTile.Location = new System.Drawing.Point(847, 6);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(93, 84);
            this.DeleteTile.TabIndex = 8;
            this.DeleteTile.Text = "Delete";
            this.DeleteTile.TileImage = global::SlipstreamHRM.Properties.Resources.Felete_Icon;
            this.DeleteTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteTile.UseSelectable = true;
            this.DeleteTile.UseStyleColors = true;
            this.DeleteTile.UseTileImage = true;
            this.DeleteTile.Click += new System.EventHandler(this.DeleteTile_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(4, 93);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(936, 508);
            this.employeeDataGridView.TabIndex = 6;
            // 
            // EmployeeListLink
            // 
            this.EmployeeListLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeListLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.EmployeeListLink.Location = new System.Drawing.Point(0, 0);
            this.EmployeeListLink.Name = "EmployeeListLink";
            this.EmployeeListLink.Size = new System.Drawing.Size(945, 29);
            this.EmployeeListLink.TabIndex = 2;
            this.EmployeeListLink.Text = "Employee List";
            this.EmployeeListLink.UseSelectable = true;
            // 
            // EmployeeListDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeListPanel);
            this.Controls.Add(this.EmployeeListLink);
            this.Name = "EmployeeListDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.EmployeeListDashboardControl_Load);
            this.EmployeeListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel EmployeeListPanel;
        private MetroFramework.Controls.MetroLink EmployeeListLink;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private MetroFramework.Controls.MetroTile DeleteTile;
    }
}
