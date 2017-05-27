namespace SlipstreamHRM.User_Control
{
    partial class HomeDashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboardControl));
            this.HomeDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.chartEmployeeList = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NoticePanel = new MetroFramework.Controls.MetroPanel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.AddNewsTile = new DevExpress.XtraEditors.TileItem();
            this.DeleteNewsTile = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.newsDataGridView = new System.Windows.Forms.DataGridView();
            this.HomeDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeList)).BeginInit();
            this.NoticePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeDashboardPanel
            // 
            this.HomeDashboardPanel.Controls.Add(this.NoticePanel);
            this.HomeDashboardPanel.Controls.Add(this.materialDivider1);
            this.HomeDashboardPanel.Controls.Add(this.chartEmployeeList);
            this.HomeDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeDashboardPanel.HorizontalScrollbarBarColor = true;
            this.HomeDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.HomeDashboardPanel.HorizontalScrollbarSize = 10;
            this.HomeDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeDashboardPanel.Name = "HomeDashboardPanel";
            this.HomeDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.HomeDashboardPanel.TabIndex = 0;
            this.HomeDashboardPanel.VerticalScrollbarBarColor = true;
            this.HomeDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.HomeDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1164, 31);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // chartEmployeeList
            // 
            this.chartEmployeeList.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.chartEmployeeList.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartEmployeeList.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartEmployeeList.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmployeeList.Legends.Add(legend1);
            this.chartEmployeeList.Location = new System.Drawing.Point(3, 194);
            this.chartEmployeeList.Name = "chartEmployeeList";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "EmployeeList";
            this.chartEmployeeList.Series.Add(series1);
            this.chartEmployeeList.Size = new System.Drawing.Size(560, 453);
            this.chartEmployeeList.TabIndex = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Employee Distribution by Subunit";
            this.chartEmployeeList.Titles.Add(title1);
            // 
            // NoticePanel
            // 
            this.NoticePanel.Controls.Add(this.newsDataGridView);
            this.NoticePanel.Controls.Add(this.tileControl1);
            this.NoticePanel.HorizontalScrollbarBarColor = true;
            this.NoticePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.NoticePanel.HorizontalScrollbarSize = 10;
            this.NoticePanel.Location = new System.Drawing.Point(569, 194);
            this.NoticePanel.Name = "NoticePanel";
            this.NoticePanel.Size = new System.Drawing.Size(592, 453);
            this.NoticePanel.TabIndex = 10;
            this.NoticePanel.VerticalScrollbarBarColor = true;
            this.NoticePanel.VerticalScrollbarHighlightOnWheel = false;
            this.NoticePanel.VerticalScrollbarSize = 10;
            // 
            // tileControl1
            // 
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(592, 151);
            this.tileControl1.TabIndex = 3;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.AddNewsTile);
            this.tileGroup2.Items.Add(this.DeleteNewsTile);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // AddNewsTile
            // 
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Add News";
            this.AddNewsTile.Elements.Add(tileItemElement2);
            this.AddNewsTile.Id = 0;
            this.AddNewsTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.AddNewsTile.Name = "AddNewsTile";
            this.AddNewsTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.AddNewsTile_ItemClick);
            // 
            // DeleteNewsTile
            // 
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Delete News";
            this.DeleteNewsTile.Elements.Add(tileItemElement3);
            this.DeleteNewsTile.Id = 1;
            this.DeleteNewsTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.DeleteNewsTile.Name = "DeleteNewsTile";
            this.DeleteNewsTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.DeleteNewsTile_ItemClick);
            // 
            // tileItem3
            // 
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "See Description";
            this.tileItem3.Elements.Add(tileItemElement1);
            this.tileItem3.Id = 2;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Name = "tileGroup1";
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
            this.newsDataGridView.Size = new System.Drawing.Size(592, 302);
            this.newsDataGridView.TabIndex = 4;
            // 
            // HomeDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomeDashboardPanel);
            this.Name = "HomeDashboardControl";
            this.Size = new System.Drawing.Size(1164, 650);
            this.Load += new System.EventHandler(this.HomeDashboardControl_Load);
            this.HomeDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeList)).EndInit();
            this.NoticePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel HomeDashboardPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeList;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroPanel NoticePanel;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem AddNewsTile;
        private DevExpress.XtraEditors.TileItem DeleteNewsTile;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private System.Windows.Forms.DataGridView newsDataGridView;
    }
}
