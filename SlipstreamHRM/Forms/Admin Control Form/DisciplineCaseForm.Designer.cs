namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class DisciplineCaseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCaseName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.txtCaseDescription = new MetroFramework.Controls.MetroTextBox();
            this.EmployeeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CaseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtCaseName
            // 
            this.txtCaseName.Depth = 0;
            this.txtCaseName.Hint = "";
            this.txtCaseName.Location = new System.Drawing.Point(344, 126);
            this.txtCaseName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCaseName.Name = "txtCaseName";
            this.txtCaseName.PasswordChar = '\0';
            this.txtCaseName.SelectedText = "";
            this.txtCaseName.SelectionLength = 0;
            this.txtCaseName.SelectionStart = 0;
            this.txtCaseName.Size = new System.Drawing.Size(321, 23);
            this.txtCaseName.TabIndex = 0;
            this.txtCaseName.UseSystemPasswordChar = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtEmployeeName.CustomButton.Image = null;
            this.txtEmployeeName.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.txtEmployeeName.CustomButton.Name = "";
            this.txtEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployeeName.CustomButton.TabIndex = 1;
            this.txtEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployeeName.CustomButton.UseSelectable = true;
            this.txtEmployeeName.CustomButton.Visible = false;
            this.txtEmployeeName.Lines = new string[0];
            this.txtEmployeeName.Location = new System.Drawing.Point(52, 126);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(229, 23);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.UseSelectable = true;
            this.txtEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCaseDescription
            // 
            // 
            // 
            // 
            this.txtCaseDescription.CustomButton.Image = null;
            this.txtCaseDescription.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtCaseDescription.CustomButton.Name = "";
            this.txtCaseDescription.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtCaseDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCaseDescription.CustomButton.TabIndex = 1;
            this.txtCaseDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCaseDescription.CustomButton.UseSelectable = true;
            this.txtCaseDescription.CustomButton.Visible = false;
            this.txtCaseDescription.Lines = new string[0];
            this.txtCaseDescription.Location = new System.Drawing.Point(52, 218);
            this.txtCaseDescription.MaxLength = 32767;
            this.txtCaseDescription.Multiline = true;
            this.txtCaseDescription.Name = "txtCaseDescription";
            this.txtCaseDescription.PasswordChar = '\0';
            this.txtCaseDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCaseDescription.SelectedText = "";
            this.txtCaseDescription.SelectionLength = 0;
            this.txtCaseDescription.SelectionStart = 0;
            this.txtCaseDescription.ShortcutsEnabled = true;
            this.txtCaseDescription.Size = new System.Drawing.Size(375, 121);
            this.txtCaseDescription.TabIndex = 2;
            this.txtCaseDescription.UseSelectable = true;
            this.txtCaseDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCaseDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(52, 95);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(113, 19);
            this.EmployeeNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "*Employee Name";
            this.EmployeeNameLabel.UseStyleColors = true;
            // 
            // CaseNameLabel
            // 
            this.CaseNameLabel.AutoSize = true;
            this.CaseNameLabel.Location = new System.Drawing.Point(344, 95);
            this.CaseNameLabel.Name = "CaseNameLabel";
            this.CaseNameLabel.Size = new System.Drawing.Size(83, 19);
            this.CaseNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.CaseNameLabel.TabIndex = 4;
            this.CaseNameLabel.Text = "*Case Name";
            this.CaseNameLabel.UseStyleColors = true;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(52, 183);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(74, 19);
            this.DescriptionLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(564, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DisciplineCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 375);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CaseNameLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.txtCaseDescription);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtCaseName);
            this.MaximizeBox = false;
            this.Name = "DisciplineCaseForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Discipline Case";
            this.Load += new System.EventHandler(this.DisciplineCaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCaseName;
        private MetroFramework.Controls.MetroTextBox txtEmployeeName;
        private MetroFramework.Controls.MetroTextBox txtCaseDescription;
        private MetroFramework.Controls.MetroLabel EmployeeNameLabel;
        private MetroFramework.Controls.MetroLabel CaseNameLabel;
        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}