namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeeDisciplineDashboardControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDisciplineDashboardControl));
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.DisciplineDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.AllDisciplineCaseTile = new DevExpress.XtraEditors.TileItem();
            this.ownDisciplineCases = new DevExpress.XtraEditors.TileItem();
            this.disciplineCaseDataGridView = new System.Windows.Forms.DataGridView();
            this.DisciplinaryCasesLink = new MetroFramework.Controls.MetroLink();
            this.disciplinePanel = new MetroFramework.Controls.MetroPanel();
            this.DisciplineDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineCaseDataGridView)).BeginInit();
            this.disciplinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineDashboardPanel
            // 
            this.DisciplineDashboardPanel.BackColor = System.Drawing.Color.White;
            this.DisciplineDashboardPanel.Controls.Add(this.disciplinePanel);
            this.DisciplineDashboardPanel.Controls.Add(this.tileControl1);
            this.DisciplineDashboardPanel.Controls.Add(this.DisciplinaryCasesLink);
            this.DisciplineDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisciplineDashboardPanel.HorizontalScrollbarBarColor = true;
            this.DisciplineDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DisciplineDashboardPanel.HorizontalScrollbarSize = 10;
            this.DisciplineDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DisciplineDashboardPanel.Name = "DisciplineDashboardPanel";
            this.DisciplineDashboardPanel.Size = new System.Drawing.Size(1326, 492);
            this.DisciplineDashboardPanel.TabIndex = 0;
            this.DisciplineDashboardPanel.UseCustomBackColor = true;
            this.DisciplineDashboardPanel.VerticalScrollbarBarColor = true;
            this.DisciplineDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DisciplineDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // tileControl1
            // 
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 30);
            this.tileControl1.MaxId = 2;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(299, 462);
            this.tileControl1.TabIndex = 24;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.AllDisciplineCaseTile);
            this.tileGroup2.Items.Add(this.ownDisciplineCases);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // AllDisciplineCaseTile
            // 
            this.AllDisciplineCaseTile.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.AllDisciplineCaseTile.AppearanceItem.Selected.Options.UseBorderColor = true;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Disciplinary Cases";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.AllDisciplineCaseTile.Elements.Add(tileItemElement3);
            this.AllDisciplineCaseTile.Id = 0;
            this.AllDisciplineCaseTile.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.AllDisciplineCaseTile.Name = "AllDisciplineCaseTile";
            this.AllDisciplineCaseTile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.AllDisciplineCaseTile_ItemClick);
            // 
            // ownDisciplineCases
            // 
            this.ownDisciplineCases.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.ownDisciplineCases.AppearanceItem.Selected.Options.UseBorderColor = true;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Your\'s Disciplinary Cases";
            this.ownDisciplineCases.Elements.Add(tileItemElement4);
            this.ownDisciplineCases.Id = 1;
            this.ownDisciplineCases.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.ownDisciplineCases.Name = "ownDisciplineCases";
            this.ownDisciplineCases.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ownDisciplineCases_ItemClick);
            // 
            // disciplineCaseDataGridView
            // 
            this.disciplineCaseDataGridView.AllowUserToAddRows = false;
            this.disciplineCaseDataGridView.AllowUserToDeleteRows = false;
            this.disciplineCaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disciplineCaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplineCaseDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disciplineCaseDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.disciplineCaseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.disciplineCaseDataGridView.Name = "disciplineCaseDataGridView";
            this.disciplineCaseDataGridView.ReadOnly = true;
            this.disciplineCaseDataGridView.Size = new System.Drawing.Size(1010, 460);
            this.disciplineCaseDataGridView.TabIndex = 23;
            this.disciplineCaseDataGridView.Visible = false;
            // 
            // DisciplinaryCasesLink
            // 
            this.DisciplinaryCasesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisciplinaryCasesLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.DisciplinaryCasesLink.Location = new System.Drawing.Point(0, 0);
            this.DisciplinaryCasesLink.Name = "DisciplinaryCasesLink";
            this.DisciplinaryCasesLink.Size = new System.Drawing.Size(1326, 30);
            this.DisciplinaryCasesLink.Style = MetroFramework.MetroColorStyle.Black;
            this.DisciplinaryCasesLink.TabIndex = 21;
            this.DisciplinaryCasesLink.Text = "Disciplinary Cases";
            this.DisciplinaryCasesLink.UseSelectable = true;
            // 
            // disciplinePanel
            // 
            this.disciplinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disciplinePanel.Controls.Add(this.disciplineCaseDataGridView);
            this.disciplinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disciplinePanel.HorizontalScrollbarBarColor = true;
            this.disciplinePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.HorizontalScrollbarSize = 10;
            this.disciplinePanel.Location = new System.Drawing.Point(299, 30);
            this.disciplinePanel.Name = "disciplinePanel";
            this.disciplinePanel.Size = new System.Drawing.Size(1027, 462);
            this.disciplinePanel.TabIndex = 25;
            this.disciplinePanel.VerticalScrollbarBarColor = true;
            this.disciplinePanel.VerticalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.VerticalScrollbarSize = 10;
            // 
            // EmployeeDisciplineDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisciplineDashboardPanel);
            this.Name = "EmployeeDisciplineDashboardControl";
            this.Size = new System.Drawing.Size(1326, 492);
            this.Load += new System.EventHandler(this.EmployeeDisciplineDashboardControl_Load);
            this.DisciplineDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disciplineCaseDataGridView)).EndInit();
            this.disciplinePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel DisciplineDashboardPanel;
        private MetroFramework.Controls.MetroLink DisciplinaryCasesLink;
        private System.Windows.Forms.DataGridView disciplineCaseDataGridView;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem AllDisciplineCaseTile;
        private DevExpress.XtraEditors.TileItem ownDisciplineCases;
        private MetroFramework.Controls.MetroPanel disciplinePanel;
    }
}
