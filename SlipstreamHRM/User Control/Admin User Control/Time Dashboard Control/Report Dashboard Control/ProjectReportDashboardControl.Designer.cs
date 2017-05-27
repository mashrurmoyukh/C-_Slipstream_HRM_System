namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.Report_Dashboard_Control
{
    partial class ProjectReportDashboardControl
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
            this.ProjectReportsLink = new MetroFramework.Controls.MetroLink();
            this.projectReportPanel = new MetroFramework.Controls.MetroPanel();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.fromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.toDateTime = new MetroFramework.Controls.MetroDateTime();
            this.fromLabel = new MetroFramework.Controls.MetroLabel();
            this.toLabel = new MetroFramework.Controls.MetroLabel();
            this.idLabel = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.projectReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectReportsLink
            // 
            this.ProjectReportsLink.BackColor = System.Drawing.Color.SteelBlue;
            this.ProjectReportsLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectReportsLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ProjectReportsLink.ForeColor = System.Drawing.Color.White;
            this.ProjectReportsLink.Location = new System.Drawing.Point(0, 0);
            this.ProjectReportsLink.Name = "ProjectReportsLink";
            this.ProjectReportsLink.Size = new System.Drawing.Size(937, 39);
            this.ProjectReportsLink.TabIndex = 3;
            this.ProjectReportsLink.Text = "Project Reports";
            this.ProjectReportsLink.UseCustomBackColor = true;
            this.ProjectReportsLink.UseCustomForeColor = true;
            this.ProjectReportsLink.UseSelectable = true;
            // 
            // projectReportPanel
            // 
            this.projectReportPanel.Controls.Add(this.btnSave);
            this.projectReportPanel.Controls.Add(this.txtID);
            this.projectReportPanel.Controls.Add(this.idLabel);
            this.projectReportPanel.Controls.Add(this.toLabel);
            this.projectReportPanel.Controls.Add(this.fromLabel);
            this.projectReportPanel.Controls.Add(this.toDateTime);
            this.projectReportPanel.Controls.Add(this.fromDateTime);
            this.projectReportPanel.Controls.Add(this.projectDataGridView);
            this.projectReportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectReportPanel.HorizontalScrollbarBarColor = true;
            this.projectReportPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.projectReportPanel.HorizontalScrollbarSize = 10;
            this.projectReportPanel.Location = new System.Drawing.Point(0, 39);
            this.projectReportPanel.Name = "projectReportPanel";
            this.projectReportPanel.Size = new System.Drawing.Size(937, 543);
            this.projectReportPanel.TabIndex = 4;
            this.projectReportPanel.VerticalScrollbarBarColor = true;
            this.projectReportPanel.VerticalScrollbarHighlightOnWheel = false;
            this.projectReportPanel.VerticalScrollbarSize = 10;
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AllowUserToAddRows = false;
            this.projectDataGridView.AllowUserToDeleteRows = false;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Location = new System.Drawing.Point(3, 165);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.ReadOnly = true;
            this.projectDataGridView.Size = new System.Drawing.Size(931, 375);
            this.projectDataGridView.TabIndex = 4;
            this.projectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataGridView_CellClick);
            // 
            // fromDateTime
            // 
            this.fromDateTime.Location = new System.Drawing.Point(140, 62);
            this.fromDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDateTime.Name = "fromDateTime";
            this.fromDateTime.Size = new System.Drawing.Size(210, 29);
            this.fromDateTime.TabIndex = 5;
            // 
            // toDateTime
            // 
            this.toDateTime.Location = new System.Drawing.Point(140, 111);
            this.toDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDateTime.Name = "toDateTime";
            this.toDateTime.Size = new System.Drawing.Size(210, 29);
            this.toDateTime.TabIndex = 6;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(50, 72);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 19);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(69, 121);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 19);
            this.toLabel.TabIndex = 8;
            this.toLabel.Text = "To:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(31, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(69, 19);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "Project ID:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(140, 21);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(210, 23);
            this.txtID.TabIndex = 10;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(389, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProjectReportDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.projectReportPanel);
            this.Controls.Add(this.ProjectReportsLink);
            this.Name = "ProjectReportDashboardControl";
            this.Size = new System.Drawing.Size(937, 582);
            this.Load += new System.EventHandler(this.ProjectReportDashboardControl_Load);
            this.projectReportPanel.ResumeLayout(false);
            this.projectReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink ProjectReportsLink;
        private MetroFramework.Controls.MetroPanel projectReportPanel;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private MetroFramework.Controls.MetroDateTime toDateTime;
        private MetroFramework.Controls.MetroDateTime fromDateTime;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel idLabel;
        private MetroFramework.Controls.MetroLabel toLabel;
        private MetroFramework.Controls.MetroLabel fromLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}
