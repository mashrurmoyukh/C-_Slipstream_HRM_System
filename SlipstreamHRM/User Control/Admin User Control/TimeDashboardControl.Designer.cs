namespace SlipstreamHRM.User_Control
{
    partial class TimeDashboardControl
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
            this.timeDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.timePanel = new MetroFramework.Controls.MetroPanel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ProjectInfoTile = new MetroFramework.Controls.MetroTile();
            this.ReportTile = new MetroFramework.Controls.MetroTile();
            this.timeDashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeDashboardPanel
            // 
            this.timeDashboardPanel.Controls.Add(this.timePanel);
            this.timeDashboardPanel.Controls.Add(this.materialDivider1);
            this.timeDashboardPanel.Controls.Add(this.ProjectInfoTile);
            this.timeDashboardPanel.Controls.Add(this.ReportTile);
            this.timeDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDashboardPanel.HorizontalScrollbarBarColor = true;
            this.timeDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.timeDashboardPanel.HorizontalScrollbarSize = 10;
            this.timeDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.timeDashboardPanel.Name = "timeDashboardPanel";
            this.timeDashboardPanel.Size = new System.Drawing.Size(1164, 650);
            this.timeDashboardPanel.TabIndex = 0;
            this.timeDashboardPanel.VerticalScrollbarBarColor = true;
            this.timeDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.timeDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // timePanel
            // 
            this.timePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timePanel.HorizontalScrollbarBarColor = true;
            this.timePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.timePanel.HorizontalScrollbarSize = 10;
            this.timePanel.Location = new System.Drawing.Point(219, 23);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(945, 627);
            this.timePanel.TabIndex = 10;
            this.timePanel.VerticalScrollbarBarColor = true;
            this.timePanel.VerticalScrollbarHighlightOnWheel = false;
            this.timePanel.VerticalScrollbarSize = 10;
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
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ProjectInfoTile
            // 
            this.ProjectInfoTile.ActiveControl = null;
            this.ProjectInfoTile.Location = new System.Drawing.Point(3, 153);
            this.ProjectInfoTile.Name = "ProjectInfoTile";
            this.ProjectInfoTile.Size = new System.Drawing.Size(210, 118);
            this.ProjectInfoTile.TabIndex = 3;
            this.ProjectInfoTile.Text = "Project Info";
            this.ProjectInfoTile.TileImage = global::SlipstreamHRM.Properties.Resources.Project_Icon_White;
            this.ProjectInfoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectInfoTile.UseSelectable = true;
            this.ProjectInfoTile.UseTileImage = true;
            this.ProjectInfoTile.Click += new System.EventHandler(this.ProjectInfoTile_Click);
            // 
            // ReportTile
            // 
            this.ReportTile.ActiveControl = null;
            this.ReportTile.Location = new System.Drawing.Point(3, 29);
            this.ReportTile.Name = "ReportTile";
            this.ReportTile.Size = new System.Drawing.Size(210, 118);
            this.ReportTile.TabIndex = 2;
            this.ReportTile.Text = "Report";
            this.ReportTile.TileImage = global::SlipstreamHRM.Properties.Resources.Reports_White_Icon;
            this.ReportTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportTile.UseSelectable = true;
            this.ReportTile.UseTileImage = true;
            this.ReportTile.Click += new System.EventHandler(this.ReportTile_Click);
            // 
            // TimeDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeDashboardPanel);
            this.Name = "TimeDashboardControl";
            this.Size = new System.Drawing.Size(1164, 650);
            this.timeDashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel timeDashboardPanel;
        private MetroFramework.Controls.MetroTile ProjectInfoTile;
        private MetroFramework.Controls.MetroTile ReportTile;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroPanel timePanel;
    }
}
