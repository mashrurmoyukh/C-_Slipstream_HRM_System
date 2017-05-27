namespace SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control
{
    partial class EntitlementsDashboardControl
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
            this.entitlementsPanel = new MetroFramework.Controls.MetroPanel();
            this.EntitlementsLink = new MetroFramework.Controls.MetroLink();
            this.myEntitlementsListDataGridView = new System.Windows.Forms.DataGridView();
            this.entitlementsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myEntitlementsListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // entitlementsPanel
            // 
            this.entitlementsPanel.Controls.Add(this.myEntitlementsListDataGridView);
            this.entitlementsPanel.Controls.Add(this.EntitlementsLink);
            this.entitlementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entitlementsPanel.HorizontalScrollbarBarColor = true;
            this.entitlementsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.entitlementsPanel.HorizontalScrollbarSize = 10;
            this.entitlementsPanel.Location = new System.Drawing.Point(0, 0);
            this.entitlementsPanel.Name = "entitlementsPanel";
            this.entitlementsPanel.Size = new System.Drawing.Size(1047, 492);
            this.entitlementsPanel.TabIndex = 0;
            this.entitlementsPanel.VerticalScrollbarBarColor = true;
            this.entitlementsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.entitlementsPanel.VerticalScrollbarSize = 10;
            // 
            // EntitlementsLink
            // 
            this.EntitlementsLink.BackColor = System.Drawing.Color.SteelBlue;
            this.EntitlementsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntitlementsLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.EntitlementsLink.ForeColor = System.Drawing.Color.White;
            this.EntitlementsLink.Location = new System.Drawing.Point(0, 0);
            this.EntitlementsLink.Name = "EntitlementsLink";
            this.EntitlementsLink.Size = new System.Drawing.Size(1047, 39);
            this.EntitlementsLink.TabIndex = 3;
            this.EntitlementsLink.Text = "Entilements";
            this.EntitlementsLink.UseCustomBackColor = true;
            this.EntitlementsLink.UseCustomForeColor = true;
            this.EntitlementsLink.UseSelectable = true;
            // 
            // myEntitlementsListDataGridView
            // 
            this.myEntitlementsListDataGridView.AllowUserToAddRows = false;
            this.myEntitlementsListDataGridView.AllowUserToDeleteRows = false;
            this.myEntitlementsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myEntitlementsListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myEntitlementsListDataGridView.Location = new System.Drawing.Point(0, 39);
            this.myEntitlementsListDataGridView.Name = "myEntitlementsListDataGridView";
            this.myEntitlementsListDataGridView.ReadOnly = true;
            this.myEntitlementsListDataGridView.Size = new System.Drawing.Size(1047, 453);
            this.myEntitlementsListDataGridView.TabIndex = 4;
            // 
            // EntitlementsDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entitlementsPanel);
            this.Name = "EntitlementsDashboardControl";
            this.Size = new System.Drawing.Size(1047, 492);
            this.Load += new System.EventHandler(this.EntitlementsDashboardControl_Load);
            this.entitlementsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myEntitlementsListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel entitlementsPanel;
        private MetroFramework.Controls.MetroLink EntitlementsLink;
        private System.Windows.Forms.DataGridView myEntitlementsListDataGridView;
    }
}
