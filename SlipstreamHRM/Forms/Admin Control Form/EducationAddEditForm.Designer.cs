namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class EducationAddEditForm
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
            this.txtEducation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LevelofEducation = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtEducation
            // 
            this.txtEducation.Depth = 0;
            this.txtEducation.Hint = "";
            this.txtEducation.Location = new System.Drawing.Point(213, 139);
            this.txtEducation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.PasswordChar = '\0';
            this.txtEducation.SelectedText = "";
            this.txtEducation.SelectionLength = 0;
            this.txtEducation.SelectionStart = 0;
            this.txtEducation.Size = new System.Drawing.Size(285, 23);
            this.txtEducation.TabIndex = 6;
            this.txtEducation.UseSystemPasswordChar = false;
            // 
            // LevelofEducation
            // 
            this.LevelofEducation.AutoSize = true;
            this.LevelofEducation.Depth = 0;
            this.LevelofEducation.Font = new System.Drawing.Font("Roboto", 11F);
            this.LevelofEducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LevelofEducation.Location = new System.Drawing.Point(49, 143);
            this.LevelofEducation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelofEducation.Name = "LevelofEducation";
            this.LevelofEducation.Size = new System.Drawing.Size(137, 19);
            this.LevelofEducation.TabIndex = 5;
            this.LevelofEducation.Text = "Level of Education:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EducationAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.LevelofEducation);
            this.MaximizeBox = false;
            this.Name = "EducationAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducationAddEdit";
            this.Load += new System.EventHandler(this.EducationAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtEducation;
        private MaterialSkin.Controls.MaterialLabel LevelofEducation;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}