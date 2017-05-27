namespace SlipstreamHRM.User_Control.Admin_User_Control.Requirement_Dashboard_Control
{
    partial class VacancyDashboardControl
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
            this.vacanciesPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtNumberofPosition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtVacancyName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDscription = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.vacancyNameLabel = new MetroFramework.Controls.MetroLabel();
            this.numberofPositionLabel = new MetroFramework.Controls.MetroLabel();
            this.comboJobTitle = new MetroFramework.Controls.MetroComboBox();
            this.JobTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.VacancyLink = new MetroFramework.Controls.MetroLink();
            this.vacancyListDataGridView = new System.Windows.Forms.DataGridView();
            this.VacancyListLabel = new MetroFramework.Controls.MetroLabel();
            this.vacanciesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vacanciesPanel
            // 
            this.vacanciesPanel.BackColor = System.Drawing.Color.White;
            this.vacanciesPanel.Controls.Add(this.VacancyListLabel);
            this.vacanciesPanel.Controls.Add(this.vacancyListDataGridView);
            this.vacanciesPanel.Controls.Add(this.btnSave);
            this.vacanciesPanel.Controls.Add(this.txtNumberofPosition);
            this.vacanciesPanel.Controls.Add(this.txtVacancyName);
            this.vacanciesPanel.Controls.Add(this.txtDscription);
            this.vacanciesPanel.Controls.Add(this.DescriptionLabel);
            this.vacanciesPanel.Controls.Add(this.vacancyNameLabel);
            this.vacanciesPanel.Controls.Add(this.numberofPositionLabel);
            this.vacanciesPanel.Controls.Add(this.comboJobTitle);
            this.vacanciesPanel.Controls.Add(this.JobTitleLabel);
            this.vacanciesPanel.Controls.Add(this.txtEmployeeName);
            this.vacanciesPanel.Controls.Add(this.EmployeeNameLabel);
            this.vacanciesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vacanciesPanel.HorizontalScrollbarBarColor = true;
            this.vacanciesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.vacanciesPanel.HorizontalScrollbarSize = 10;
            this.vacanciesPanel.Location = new System.Drawing.Point(0, 23);
            this.vacanciesPanel.Name = "vacanciesPanel";
            this.vacanciesPanel.Size = new System.Drawing.Size(945, 604);
            this.vacanciesPanel.TabIndex = 3;
            this.vacanciesPanel.VerticalScrollbarBarColor = true;
            this.vacanciesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.vacanciesPanel.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(816, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNumberofPosition
            // 
            this.txtNumberofPosition.Depth = 0;
            this.txtNumberofPosition.Hint = "";
            this.txtNumberofPosition.Location = new System.Drawing.Point(333, 148);
            this.txtNumberofPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumberofPosition.Name = "txtNumberofPosition";
            this.txtNumberofPosition.PasswordChar = '\0';
            this.txtNumberofPosition.SelectedText = "";
            this.txtNumberofPosition.SelectionLength = 0;
            this.txtNumberofPosition.SelectionStart = 0;
            this.txtNumberofPosition.Size = new System.Drawing.Size(278, 23);
            this.txtNumberofPosition.TabIndex = 25;
            this.txtNumberofPosition.UseSystemPasswordChar = false;
            // 
            // txtVacancyName
            // 
            this.txtVacancyName.Depth = 0;
            this.txtVacancyName.Hint = "";
            this.txtVacancyName.Location = new System.Drawing.Point(24, 148);
            this.txtVacancyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVacancyName.Name = "txtVacancyName";
            this.txtVacancyName.PasswordChar = '\0';
            this.txtVacancyName.SelectedText = "";
            this.txtVacancyName.SelectionLength = 0;
            this.txtVacancyName.SelectionStart = 0;
            this.txtVacancyName.Size = new System.Drawing.Size(278, 23);
            this.txtVacancyName.TabIndex = 24;
            this.txtVacancyName.UseSystemPasswordChar = false;
            // 
            // txtDscription
            // 
            this.txtDscription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDscription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDscription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDscription.CustomButton.Image = null;
            this.txtDscription.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.txtDscription.CustomButton.Name = "";
            this.txtDscription.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtDscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDscription.CustomButton.TabIndex = 1;
            this.txtDscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDscription.CustomButton.UseSelectable = true;
            this.txtDscription.CustomButton.Visible = false;
            this.txtDscription.Lines = new string[0];
            this.txtDscription.Location = new System.Drawing.Point(639, 47);
            this.txtDscription.MaxLength = 32767;
            this.txtDscription.Multiline = true;
            this.txtDscription.Name = "txtDscription";
            this.txtDscription.PasswordChar = '\0';
            this.txtDscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDscription.SelectedText = "";
            this.txtDscription.SelectionLength = 0;
            this.txtDscription.SelectionStart = 0;
            this.txtDscription.ShortcutsEnabled = true;
            this.txtDscription.Size = new System.Drawing.Size(278, 124);
            this.txtDscription.TabIndex = 23;
            this.txtDscription.UseSelectable = true;
            this.txtDscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(639, 19);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(74, 19);
            this.DescriptionLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.DescriptionLabel.TabIndex = 22;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.UseStyleColors = true;
            // 
            // vacancyNameLabel
            // 
            this.vacancyNameLabel.AutoSize = true;
            this.vacancyNameLabel.Location = new System.Drawing.Point(24, 126);
            this.vacancyNameLabel.Name = "vacancyNameLabel";
            this.vacancyNameLabel.Size = new System.Drawing.Size(94, 19);
            this.vacancyNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.vacancyNameLabel.TabIndex = 20;
            this.vacancyNameLabel.Text = "Vacancy Name";
            this.vacancyNameLabel.UseStyleColors = true;
            // 
            // numberofPositionLabel
            // 
            this.numberofPositionLabel.AutoSize = true;
            this.numberofPositionLabel.Location = new System.Drawing.Point(333, 126);
            this.numberofPositionLabel.Name = "numberofPositionLabel";
            this.numberofPositionLabel.Size = new System.Drawing.Size(123, 19);
            this.numberofPositionLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.numberofPositionLabel.TabIndex = 18;
            this.numberofPositionLabel.Text = "Number of Position";
            this.numberofPositionLabel.UseStyleColors = true;
            // 
            // comboJobTitle
            // 
            this.comboJobTitle.FormattingEnabled = true;
            this.comboJobTitle.ItemHeight = 23;
            this.comboJobTitle.Location = new System.Drawing.Point(333, 47);
            this.comboJobTitle.Name = "comboJobTitle";
            this.comboJobTitle.Size = new System.Drawing.Size(278, 29);
            this.comboJobTitle.TabIndex = 17;
            this.comboJobTitle.UseSelectable = true;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(334, 19);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(58, 19);
            this.JobTitleLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.JobTitleLabel.TabIndex = 16;
            this.JobTitleLabel.Text = "Job Title";
            this.JobTitleLabel.UseStyleColors = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(24, 47);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(278, 23);
            this.txtEmployeeName.TabIndex = 15;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(24, 19);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(101, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 14;
            this.EmployeeNameLabel.Text = "Hiring Manager";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // VacancyLink
            // 
            this.VacancyLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.VacancyLink.Location = new System.Drawing.Point(0, 0);
            this.VacancyLink.Name = "VacancyLink";
            this.VacancyLink.Size = new System.Drawing.Size(945, 23);
            this.VacancyLink.TabIndex = 2;
            this.VacancyLink.Text = "Vacancy";
            this.VacancyLink.UseSelectable = true;
            // 
            // vacancyListDataGridView
            // 
            this.vacancyListDataGridView.AllowUserToAddRows = false;
            this.vacancyListDataGridView.AllowUserToDeleteRows = false;
            this.vacancyListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacancyListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vacancyListDataGridView.Location = new System.Drawing.Point(0, 230);
            this.vacancyListDataGridView.Name = "vacancyListDataGridView";
            this.vacancyListDataGridView.ReadOnly = true;
            this.vacancyListDataGridView.Size = new System.Drawing.Size(945, 374);
            this.vacancyListDataGridView.TabIndex = 48;
            // 
            // VacancyListLabel
            // 
            this.VacancyListLabel.AutoSize = true;
            this.VacancyListLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.VacancyListLabel.Location = new System.Drawing.Point(3, 205);
            this.VacancyListLabel.Name = "VacancyListLabel";
            this.VacancyListLabel.Size = new System.Drawing.Size(89, 19);
            this.VacancyListLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.VacancyListLabel.TabIndex = 49;
            this.VacancyListLabel.Text = "Vacancy List";
            this.VacancyListLabel.UseStyleColors = true;
            // 
            // VacancyDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vacanciesPanel);
            this.Controls.Add(this.VacancyLink);
            this.Name = "VacancyDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.VacanciesDashboardControl_Load);
            this.vacanciesPanel.ResumeLayout(false);
            this.vacanciesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel vacanciesPanel;
        private MetroFramework.Controls.MetroLink VacancyLink;
        private MetroFramework.Controls.MetroTextBox txtDscription;
        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroLabel vacancyNameLabel;
        private MetroFramework.Controls.MetroLabel numberofPositionLabel;
        private MetroFramework.Controls.MetroComboBox comboJobTitle;
        private MetroFramework.Controls.MetroLabel JobTitleLabel;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVacancyName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumberofPosition;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel VacancyListLabel;
        private System.Windows.Forms.DataGridView vacancyListDataGridView;
    }
}
