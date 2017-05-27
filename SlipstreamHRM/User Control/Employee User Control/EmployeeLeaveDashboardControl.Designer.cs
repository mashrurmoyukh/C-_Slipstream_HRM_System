namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeeLeaveDashboardControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeaveDashboardControl));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.LeaveDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.leavePanel = new MetroFramework.Controls.MetroPanel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.applyTile = new DevExpress.XtraEditors.TileItem();
            this.myLeaveTile = new DevExpress.XtraEditors.TileItem();
            this.entitlementsTile = new DevExpress.XtraEditors.TileItem();
            this.LeaveDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeaveDashboardPanel
            // 
            this.LeaveDashboardPanel.BackColor = System.Drawing.Color.White;
            this.LeaveDashboardPanel.Controls.Add(this.leavePanel);
            this.LeaveDashboardPanel.Controls.Add(this.tileControl1);
            this.LeaveDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeaveDashboardPanel.HorizontalScrollbarBarColor = true;
            this.LeaveDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LeaveDashboardPanel.HorizontalScrollbarSize = 10;
            this.LeaveDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.LeaveDashboardPanel.Name = "LeaveDashboardPanel";
            this.LeaveDashboardPanel.Size = new System.Drawing.Size(1326, 492);
            this.LeaveDashboardPanel.TabIndex = 0;
            this.LeaveDashboardPanel.UseCustomBackColor = true;
            this.LeaveDashboardPanel.VerticalScrollbarBarColor = true;
            this.LeaveDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LeaveDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // leavePanel
            // 
            this.leavePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leavePanel.HorizontalScrollbarBarColor = true;
            this.leavePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leavePanel.HorizontalScrollbarSize = 10;
            this.leavePanel.Location = new System.Drawing.Point(279, 0);
            this.leavePanel.Name = "leavePanel";
            this.leavePanel.Size = new System.Drawing.Size(1047, 492);
            this.leavePanel.TabIndex = 3;
            this.leavePanel.VerticalScrollbarBarColor = true;
            this.leavePanel.VerticalScrollbarHighlightOnWheel = false;
            this.leavePanel.VerticalScrollbarSize = 10;
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(279, 492);
            this.tileControl1.TabIndex = 2;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.applyTile);
            this.tileGroup2.Items.Add(this.myLeaveTile);
            this.tileGroup2.Items.Add(this.entitlementsTile);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // applyTile
            // 
            this.applyTile.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.applyTile.AppearanceItem.Selected.Options.UseBorderColor = true;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Apply";
            this.applyTile.Elements.Add(tileItemElement4);
            this.applyTile.Id = 0;
            this.applyTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.applyTile.Name = "applyTile";
            this.applyTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.applyTile_ItemClick);
            // 
            // myLeaveTile
            // 
            this.myLeaveTile.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.myLeaveTile.AppearanceItem.Selected.Options.UseBorderColor = true;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "My Leave";
            this.myLeaveTile.Elements.Add(tileItemElement5);
            this.myLeaveTile.Id = 1;
            this.myLeaveTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.myLeaveTile.Name = "myLeaveTile";
            this.myLeaveTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.myLeaveTile_ItemClick);
            // 
            // entitlementsTile
            // 
            this.entitlementsTile.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.entitlementsTile.AppearanceItem.Selected.Options.UseBorderColor = true;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement6.Text = "Entitlements";
            this.entitlementsTile.Elements.Add(tileItemElement6);
            this.entitlementsTile.Id = 2;
            this.entitlementsTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.entitlementsTile.Name = "entitlementsTile";
            this.entitlementsTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.entitlementsTile_ItemClick);
            // 
            // EmployeeLeaveDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LeaveDashboardPanel);
            this.Name = "EmployeeLeaveDashboardControl";
            this.Size = new System.Drawing.Size(1326, 492);
            this.LeaveDashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel LeaveDashboardPanel;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem applyTile;
        private DevExpress.XtraEditors.TileItem myLeaveTile;
        private DevExpress.XtraEditors.TileItem entitlementsTile;
        private MetroFramework.Controls.MetroPanel leavePanel;
    }
}
