namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeeHomeDashboardControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHomeDashboardControl));
            this.HomeDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.NoticePanel = new MetroFramework.Controls.MetroPanel();
            this.newsDataGridView = new System.Windows.Forms.DataGridView();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.HomeDashboardPanel.SuspendLayout();
            this.NoticePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeDashboardPanel
            // 
            this.HomeDashboardPanel.BackColor = System.Drawing.Color.White;
            this.HomeDashboardPanel.Controls.Add(this.NoticePanel);
            this.HomeDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeDashboardPanel.HorizontalScrollbarBarColor = true;
            this.HomeDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HomeDashboardPanel.HorizontalScrollbarSize = 10;
            this.HomeDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeDashboardPanel.Name = "HomeDashboardPanel";
            this.HomeDashboardPanel.Size = new System.Drawing.Size(1326, 492);
            this.HomeDashboardPanel.TabIndex = 0;
            this.HomeDashboardPanel.UseCustomBackColor = true;
            this.HomeDashboardPanel.VerticalScrollbarBarColor = true;
            this.HomeDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HomeDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // NoticePanel
            // 
            this.NoticePanel.Controls.Add(this.newsDataGridView);
            this.NoticePanel.Controls.Add(this.tileControl1);
            this.NoticePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NoticePanel.HorizontalScrollbarBarColor = true;
            this.NoticePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.NoticePanel.HorizontalScrollbarSize = 10;
            this.NoticePanel.Location = new System.Drawing.Point(0, 0);
            this.NoticePanel.Name = "NoticePanel";
            this.NoticePanel.Size = new System.Drawing.Size(592, 492);
            this.NoticePanel.TabIndex = 11;
            this.NoticePanel.VerticalScrollbarBarColor = true;
            this.NoticePanel.VerticalScrollbarHighlightOnWheel = false;
            this.NoticePanel.VerticalScrollbarSize = 10;
            // 
            // newsDataGridView
            // 
            this.newsDataGridView.AllowUserToAddRows = false;
            this.newsDataGridView.AllowUserToDeleteRows = false;
            this.newsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsDataGridView.Location = new System.Drawing.Point(0, 151);
            this.newsDataGridView.Name = "newsDataGridView";
            this.newsDataGridView.ReadOnly = true;
            this.newsDataGridView.Size = new System.Drawing.Size(592, 341);
            this.newsDataGridView.TabIndex = 4;
            // 
            // tileControl1
            // 
            this.tileControl1.BackColor = System.Drawing.Color.White;
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(592, 151);
            this.tileControl1.TabIndex = 3;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileItem3
            // 
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "See Description";
            this.tileItem3.Elements.Add(tileItemElement1);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // EmployeeHomeDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomeDashboardPanel);
            this.Name = "EmployeeHomeDashboardControl";
            this.Size = new System.Drawing.Size(1326, 492);
            this.Load += new System.EventHandler(this.EmployeeHomeDashboardControl_Load);
            this.HomeDashboardPanel.ResumeLayout(false);
            this.NoticePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel HomeDashboardPanel;
        private MetroFramework.Controls.MetroPanel NoticePanel;
        private System.Windows.Forms.DataGridView newsDataGridView;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem3;
    }
}
