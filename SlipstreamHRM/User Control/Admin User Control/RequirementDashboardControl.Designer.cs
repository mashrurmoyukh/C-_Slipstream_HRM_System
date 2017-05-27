namespace SlipstreamHRM.User_Control
{
    partial class RequirementDashboardControl
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
            this.requirementDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.requirementPanel = new MetroFramework.Controls.MetroPanel();
            this.DisciplineCasesTile = new MetroFramework.Controls.MetroTile();
            this.VacanciesTile = new MetroFramework.Controls.MetroTile();
            this.CandidatesTile = new MetroFramework.Controls.MetroTile();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.requirementDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // requirementDashboardPanel
            // 
            this.requirementDashboardPanel.Controls.Add(this.requirementPanel);
            this.requirementDashboardPanel.Controls.Add(this.DisciplineCasesTile);
            this.requirementDashboardPanel.Controls.Add(this.VacanciesTile);
            this.requirementDashboardPanel.Controls.Add(this.CandidatesTile);
            this.requirementDashboardPanel.Controls.Add(this.materialDivider1);
            this.requirementDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementDashboardPanel.HorizontalScrollbarBarColor = true;
            this.requirementDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.requirementDashboardPanel.HorizontalScrollbarSize = 10;
            this.requirementDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.requirementDashboardPanel.Name = "requirementDashboardPanel";
            this.requirementDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.requirementDashboardPanel.TabIndex = 0;
            this.requirementDashboardPanel.VerticalScrollbarBarColor = true;
            this.requirementDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.requirementDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // requirementPanel
            // 
            this.requirementPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.requirementPanel.HorizontalScrollbarBarColor = true;
            this.requirementPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.requirementPanel.HorizontalScrollbarSize = 10;
            this.requirementPanel.Location = new System.Drawing.Point(219, 23);
            this.requirementPanel.Name = "requirementPanel";
            this.requirementPanel.Size = new System.Drawing.Size(945, 627);
            this.requirementPanel.TabIndex = 14;
            this.requirementPanel.VerticalScrollbarBarColor = true;
            this.requirementPanel.VerticalScrollbarHighlightOnWheel = false;
            this.requirementPanel.VerticalScrollbarSize = 10;
            // 
            // DisciplineCasesTile
            // 
            this.DisciplineCasesTile.ActiveControl = null;
            this.DisciplineCasesTile.Location = new System.Drawing.Point(3, 277);
            this.DisciplineCasesTile.Name = "DisciplineCasesTile";
            this.DisciplineCasesTile.Size = new System.Drawing.Size(210, 118);
            this.DisciplineCasesTile.TabIndex = 13;
            this.DisciplineCasesTile.Text = "Discipline Cases";
            this.DisciplineCasesTile.TileImage = global::SlipstreamHRM.Properties.Resources.Reports_White_Icon;
            this.DisciplineCasesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisciplineCasesTile.UseSelectable = true;
            this.DisciplineCasesTile.UseTileImage = true;
            this.DisciplineCasesTile.Click += new System.EventHandler(this.DisiplineCasesTile_Click);
            // 
            // VacanciesTile
            // 
            this.VacanciesTile.ActiveControl = null;
            this.VacanciesTile.Location = new System.Drawing.Point(3, 153);
            this.VacanciesTile.Name = "VacanciesTile";
            this.VacanciesTile.Size = new System.Drawing.Size(210, 118);
            this.VacanciesTile.TabIndex = 12;
            this.VacanciesTile.Text = "Vacancies";
            this.VacanciesTile.TileImage = global::SlipstreamHRM.Properties.Resources.Vacancy_Logo;
            this.VacanciesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VacanciesTile.UseSelectable = true;
            this.VacanciesTile.UseTileImage = true;
            this.VacanciesTile.Click += new System.EventHandler(this.VacanciesTile_Click);
            // 
            // CandidatesTile
            // 
            this.CandidatesTile.ActiveControl = null;
            this.CandidatesTile.Location = new System.Drawing.Point(3, 29);
            this.CandidatesTile.Name = "CandidatesTile";
            this.CandidatesTile.Size = new System.Drawing.Size(210, 118);
            this.CandidatesTile.TabIndex = 11;
            this.CandidatesTile.Text = "Candidates";
            this.CandidatesTile.TileImage = global::SlipstreamHRM.Properties.Resources.Candidates_Icon;
            this.CandidatesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CandidatesTile.UseSelectable = true;
            this.CandidatesTile.UseTileImage = true;
            this.CandidatesTile.Click += new System.EventHandler(this.CandidatesTile_Click);
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
            // RequirementDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requirementDashboardPanel);
            this.Name = "RequirementDashboardControl";
            this.Size = new System.Drawing.Size(1164, 650);
            this.requirementDashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel requirementDashboardPanel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroTile DisciplineCasesTile;
        private MetroFramework.Controls.MetroTile VacanciesTile;
        private MetroFramework.Controls.MetroTile CandidatesTile;
        private MetroFramework.Controls.MetroPanel requirementPanel;
    }
}
