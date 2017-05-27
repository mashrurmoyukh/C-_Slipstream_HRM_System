namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    partial class DisciplineCasesDashboardControl
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
            this.DisciplineCasesLink = new MetroFramework.Controls.MetroLink();
            this.disciplinePanel = new MetroFramework.Controls.MetroPanel();
            this.EditTile = new MetroFramework.Controls.MetroTile();
            this.disciplineCaseDataGridView = new System.Windows.Forms.DataGridView();
            this.AddTile = new MetroFramework.Controls.MetroTile();
            this.disciplinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineCaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisciplineCasesLink
            // 
            this.DisciplineCasesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisciplineCasesLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.DisciplineCasesLink.Location = new System.Drawing.Point(0, 0);
            this.DisciplineCasesLink.Name = "DisciplineCasesLink";
            this.DisciplineCasesLink.Size = new System.Drawing.Size(945, 46);
            this.DisciplineCasesLink.TabIndex = 0;
            this.DisciplineCasesLink.Text = "Disciplinary Cases";
            this.DisciplineCasesLink.UseSelectable = true;
            // 
            // disciplinePanel
            // 
            this.disciplinePanel.Controls.Add(this.EditTile);
            this.disciplinePanel.Controls.Add(this.disciplineCaseDataGridView);
            this.disciplinePanel.Controls.Add(this.AddTile);
            this.disciplinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disciplinePanel.HorizontalScrollbarBarColor = true;
            this.disciplinePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.HorizontalScrollbarSize = 10;
            this.disciplinePanel.Location = new System.Drawing.Point(0, 46);
            this.disciplinePanel.Name = "disciplinePanel";
            this.disciplinePanel.Size = new System.Drawing.Size(945, 581);
            this.disciplinePanel.TabIndex = 1;
            this.disciplinePanel.VerticalScrollbarBarColor = true;
            this.disciplinePanel.VerticalScrollbarHighlightOnWheel = false;
            this.disciplinePanel.VerticalScrollbarSize = 10;
            // 
            // EditTile
            // 
            this.EditTile.ActiveControl = null;
            this.EditTile.Location = new System.Drawing.Point(716, 6);
            this.EditTile.Name = "EditTile";
            this.EditTile.Size = new System.Drawing.Size(226, 84);
            this.EditTile.TabIndex = 20;
            this.EditTile.Text = "Made Progress Clear";
            this.EditTile.TileImage = global::SlipstreamHRM.Properties.Resources.Edit_Icon;
            this.EditTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditTile.UseSelectable = true;
            this.EditTile.UseStyleColors = true;
            this.EditTile.UseTileImage = true;
            this.EditTile.Click += new System.EventHandler(this.EditTile_Click);
            // 
            // disciplineCaseDataGridView
            // 
            this.disciplineCaseDataGridView.AllowUserToAddRows = false;
            this.disciplineCaseDataGridView.AllowUserToDeleteRows = false;
            this.disciplineCaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplineCaseDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disciplineCaseDataGridView.Location = new System.Drawing.Point(3, 96);
            this.disciplineCaseDataGridView.Name = "disciplineCaseDataGridView";
            this.disciplineCaseDataGridView.ReadOnly = true;
            this.disciplineCaseDataGridView.Size = new System.Drawing.Size(939, 482);
            this.disciplineCaseDataGridView.TabIndex = 19;
            // 
            // AddTile
            // 
            this.AddTile.ActiveControl = null;
            this.AddTile.Location = new System.Drawing.Point(617, 6);
            this.AddTile.Name = "AddTile";
            this.AddTile.Size = new System.Drawing.Size(93, 84);
            this.AddTile.TabIndex = 16;
            this.AddTile.Text = "Add";
            this.AddTile.TileImage = global::SlipstreamHRM.Properties.Resources.Add_Icon;
            this.AddTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTile.UseSelectable = true;
            this.AddTile.UseTileImage = true;
            this.AddTile.Click += new System.EventHandler(this.AddTile_Click);
            // 
            // DisciplineCasesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disciplinePanel);
            this.Controls.Add(this.DisciplineCasesLink);
            this.Name = "DisciplineCasesDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.DisciplineCasesDashboardControl_Load);
            this.disciplinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disciplineCaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink DisciplineCasesLink;
        private MetroFramework.Controls.MetroPanel disciplinePanel;
        private MetroFramework.Controls.MetroTile AddTile;
        private System.Windows.Forms.DataGridView disciplineCaseDataGridView;
        private MetroFramework.Controls.MetroTile EditTile;
    }
}
