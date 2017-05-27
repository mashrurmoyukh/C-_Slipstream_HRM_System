namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    partial class CandidatesDashboardControl
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
            this.CandidatesLink = new MetroFramework.Controls.MetroLink();
            this.candidatePanel = new MetroFramework.Controls.MetroPanel();
            this.AddCandidatesLink = new MetroFramework.Controls.MetroLink();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailLabel = new MetroFramework.Controls.MetroLabel();
            this.txtContactNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ContactNoLabel = new MetroFramework.Controls.MetroLabel();
            this.JobVacancyLabel = new MetroFramework.Controls.MetroLabel();
            this.comboJobVacancy = new MetroFramework.Controls.MetroComboBox();
            this.txtComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CommentLabel = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.CandidateListLabel = new MetroFramework.Controls.MetroLabel();
            this.candidateListDataGridView = new System.Windows.Forms.DataGridView();
            this.candidatePanel.SuspendLayout();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidatesLink
            // 
            this.CandidatesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.CandidatesLink.Location = new System.Drawing.Point(0, 0);
            this.CandidatesLink.Name = "CandidatesLink";
            this.CandidatesLink.Size = new System.Drawing.Size(945, 23);
            this.CandidatesLink.TabIndex = 0;
            this.CandidatesLink.Text = "Candidates";
            this.CandidatesLink.UseSelectable = true;
            // 
            // candidatePanel
            // 
            this.candidatePanel.BackColor = System.Drawing.Color.White;
            this.candidatePanel.Controls.Add(this.candidateListDataGridView);
            this.candidatePanel.Controls.Add(this.CandidateListLabel);
            this.candidatePanel.Controls.Add(this.metroPanel);
            this.candidatePanel.Controls.Add(this.AddCandidatesLink);
            this.candidatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candidatePanel.HorizontalScrollbarBarColor = true;
            this.candidatePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.candidatePanel.HorizontalScrollbarSize = 10;
            this.candidatePanel.Location = new System.Drawing.Point(0, 23);
            this.candidatePanel.Name = "candidatePanel";
            this.candidatePanel.Size = new System.Drawing.Size(945, 604);
            this.candidatePanel.TabIndex = 1;
            this.candidatePanel.VerticalScrollbarBarColor = true;
            this.candidatePanel.VerticalScrollbarHighlightOnWheel = false;
            this.candidatePanel.VerticalScrollbarSize = 10;
            // 
            // AddCandidatesLink
            // 
            this.AddCandidatesLink.BackColor = System.Drawing.Color.SteelBlue;
            this.AddCandidatesLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCandidatesLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AddCandidatesLink.ForeColor = System.Drawing.Color.White;
            this.AddCandidatesLink.Location = new System.Drawing.Point(0, 0);
            this.AddCandidatesLink.Name = "AddCandidatesLink";
            this.AddCandidatesLink.Size = new System.Drawing.Size(945, 27);
            this.AddCandidatesLink.TabIndex = 2;
            this.AddCandidatesLink.Text = "Add Candidate";
            this.AddCandidatesLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCandidatesLink.UseCustomBackColor = true;
            this.AddCandidatesLink.UseCustomForeColor = true;
            this.AddCandidatesLink.UseSelectable = true;
            // 
            // metroPanel
            // 
            this.metroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel.Controls.Add(this.btnSave);
            this.metroPanel.Controls.Add(this.txtComment);
            this.metroPanel.Controls.Add(this.CommentLabel);
            this.metroPanel.Controls.Add(this.comboJobVacancy);
            this.metroPanel.Controls.Add(this.JobVacancyLabel);
            this.metroPanel.Controls.Add(this.txtContactNo);
            this.metroPanel.Controls.Add(this.ContactNoLabel);
            this.metroPanel.Controls.Add(this.txtEmail);
            this.metroPanel.Controls.Add(this.txtFullName);
            this.metroPanel.Controls.Add(this.NameLabel);
            this.metroPanel.Controls.Add(this.EmailLabel);
            this.metroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(0, 27);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(945, 222);
            this.metroPanel.TabIndex = 3;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(364, 41);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(278, 23);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Depth = 0;
            this.txtFullName.Hint = "";
            this.txtFullName.Location = new System.Drawing.Point(55, 41);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.Size = new System.Drawing.Size(278, 23);
            this.txtFullName.TabIndex = 28;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 19);
            this.NameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "Full Name";
            this.NameLabel.UseStyleColors = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(364, 19);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.UseStyleColors = true;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Depth = 0;
            this.txtContactNo.Hint = "";
            this.txtContactNo.Location = new System.Drawing.Point(55, 105);
            this.txtContactNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.SelectionLength = 0;
            this.txtContactNo.SelectionStart = 0;
            this.txtContactNo.Size = new System.Drawing.Size(278, 23);
            this.txtContactNo.TabIndex = 31;
            this.txtContactNo.UseSystemPasswordChar = false;
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(55, 83);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(76, 19);
            this.ContactNoLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ContactNoLabel.TabIndex = 30;
            this.ContactNoLabel.Text = "Contact No";
            this.ContactNoLabel.UseStyleColors = true;
            // 
            // JobVacancyLabel
            // 
            this.JobVacancyLabel.AutoSize = true;
            this.JobVacancyLabel.Location = new System.Drawing.Point(364, 83);
            this.JobVacancyLabel.Name = "JobVacancyLabel";
            this.JobVacancyLabel.Size = new System.Drawing.Size(75, 19);
            this.JobVacancyLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.JobVacancyLabel.TabIndex = 32;
            this.JobVacancyLabel.Text = "JobVacancy";
            this.JobVacancyLabel.UseStyleColors = true;
            // 
            // comboJobVacancy
            // 
            this.comboJobVacancy.FormattingEnabled = true;
            this.comboJobVacancy.ItemHeight = 23;
            this.comboJobVacancy.Location = new System.Drawing.Point(364, 105);
            this.comboJobVacancy.Name = "comboJobVacancy";
            this.comboJobVacancy.Size = new System.Drawing.Size(278, 29);
            this.comboJobVacancy.TabIndex = 33;
            this.comboJobVacancy.UseSelectable = true;
            // 
            // txtComment
            // 
            this.txtComment.Depth = 0;
            this.txtComment.Hint = "";
            this.txtComment.Location = new System.Drawing.Point(55, 173);
            this.txtComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.Size = new System.Drawing.Size(587, 23);
            this.txtComment.TabIndex = 35;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(55, 151);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(68, 19);
            this.CommentLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.CommentLabel.TabIndex = 34;
            this.CommentLabel.Text = "Comment";
            this.CommentLabel.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(819, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CandidateListLabel
            // 
            this.CandidateListLabel.AutoSize = true;
            this.CandidateListLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CandidateListLabel.Location = new System.Drawing.Point(409, 252);
            this.CandidateListLabel.Name = "CandidateListLabel";
            this.CandidateListLabel.Size = new System.Drawing.Size(103, 19);
            this.CandidateListLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.CandidateListLabel.TabIndex = 50;
            this.CandidateListLabel.Text = "Candidate List";
            this.CandidateListLabel.UseStyleColors = true;
            // 
            // candidateListDataGridView
            // 
            this.candidateListDataGridView.AllowUserToAddRows = false;
            this.candidateListDataGridView.AllowUserToDeleteRows = false;
            this.candidateListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.candidateListDataGridView.Location = new System.Drawing.Point(0, 274);
            this.candidateListDataGridView.Name = "candidateListDataGridView";
            this.candidateListDataGridView.ReadOnly = true;
            this.candidateListDataGridView.Size = new System.Drawing.Size(945, 330);
            this.candidateListDataGridView.TabIndex = 51;
            // 
            // CandidatesDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.candidatePanel);
            this.Controls.Add(this.CandidatesLink);
            this.Name = "CandidatesDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.CandidatesDashboardControl_Load);
            this.candidatePanel.ResumeLayout(false);
            this.candidatePanel.PerformLayout();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink CandidatesLink;
        private MetroFramework.Controls.MetroPanel candidatePanel;
        private MetroFramework.Controls.MetroLink AddCandidatesLink;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFullName;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private MetroFramework.Controls.MetroLabel EmailLabel;
        private MetroFramework.Controls.MetroLabel JobVacancyLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactNo;
        private MetroFramework.Controls.MetroLabel ContactNoLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComment;
        private MetroFramework.Controls.MetroLabel CommentLabel;
        private MetroFramework.Controls.MetroComboBox comboJobVacancy;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel CandidateListLabel;
        private System.Windows.Forms.DataGridView candidateListDataGridView;
    }
}
