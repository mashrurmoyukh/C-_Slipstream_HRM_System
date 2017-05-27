namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class SkillAddEditForm
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
            this.SkillLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtSkill = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Depth = 0;
            this.SkillLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.SkillLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SkillLabel.Location = new System.Drawing.Point(28, 111);
            this.SkillLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(42, 19);
            this.SkillLabel.TabIndex = 0;
            this.SkillLabel.Text = "Skill:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(28, 159);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(90, 19);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description:";
            // 
            // txtSkill
            // 
            this.txtSkill.Depth = 0;
            this.txtSkill.Hint = "";
            this.txtSkill.Location = new System.Drawing.Point(152, 107);
            this.txtSkill.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.PasswordChar = '\0';
            this.txtSkill.SelectedText = "";
            this.txtSkill.SelectionLength = 0;
            this.txtSkill.SelectionStart = 0;
            this.txtSkill.Size = new System.Drawing.Size(276, 23);
            this.txtSkill.TabIndex = 2;
            this.txtSkill.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(141, 141);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(152, 155);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(317, 146);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SkillAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 385);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSkill);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SkillLabel);
            this.MaximizeBox = false;
            this.Name = "SkillAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkillAddEdit";
            this.Load += new System.EventHandler(this.SkillAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel SkillLabel;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSkill;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}