namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.ProjectInfo_Dashboard_Control
{
    partial class CustomerDashboardControl
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
            this.customerPanel = new MetroFramework.Controls.MetroPanel();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.CustomerLink = new MetroFramework.Controls.MetroLink();
            this.customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerPanel
            // 
            this.customerPanel.Controls.Add(this.CustomerLink);
            this.customerPanel.Controls.Add(this.AddTile);
            this.customerPanel.Controls.Add(this.customerDataGridView);
            this.customerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerPanel.HorizontalScrollbarBarColor = true;
            this.customerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.customerPanel.HorizontalScrollbarSize = 10;
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(937, 582);
            this.customerPanel.TabIndex = 0;
            this.customerPanel.VerticalScrollbarBarColor = true;
            this.customerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.customerPanel.VerticalScrollbarSize = 10;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 147);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.Size = new System.Drawing.Size(931, 432);
            this.customerDataGridView.TabIndex = 2;
            // 
            // AddTile
            // 
            this.AddTile.ActiveControl = null;
            this.AddTile.Location = new System.Drawing.Point(841, 57);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 3;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // CustomerLink
            // 
            this.CustomerLink.BackColor = System.Drawing.Color.SteelBlue;
            this.CustomerLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CustomerLink.ForeColor = System.Drawing.Color.White;
            this.CustomerLink.Location = new System.Drawing.Point(0, 0);
            this.CustomerLink.Name = "CustomerLink";
            this.CustomerLink.Size = new System.Drawing.Size(937, 39);
            this.CustomerLink.TabIndex = 4;
            this.CustomerLink.Text = "Customer";
            this.CustomerLink.UseCustomBackColor = true;
            this.CustomerLink.UseCustomForeColor = true;
            this.CustomerLink.UseSelectable = true;
            // 
            // CustomerDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerPanel);
            this.Name = "CustomerDashboardControl";
            this.Size = new System.Drawing.Size(937, 582);
            this.Load += new System.EventHandler(this.CustomerDashboardControl_Load);
            this.customerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel customerPanel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private MetroFramework.Controls.MetroTile AddTile;
        private MetroFramework.Controls.MetroLink CustomerLink;
    }
}
