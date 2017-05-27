namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class LanguageAddEditForm
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
            this.txtLanguage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LanguageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtLanguage
            // 
            this.txtLanguage.Depth = 0;
            this.txtLanguage.Hint = "";
            this.txtLanguage.Location = new System.Drawing.Point(139, 123);
            this.txtLanguage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.PasswordChar = '\0';
            this.txtLanguage.SelectedText = "";
            this.txtLanguage.SelectionLength = 0;
            this.txtLanguage.SelectionStart = 0;
            this.txtLanguage.Size = new System.Drawing.Size(285, 23);
            this.txtLanguage.TabIndex = 4;
            this.txtLanguage.UseSystemPasswordChar = false;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Depth = 0;
            this.LanguageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LanguageLabel.Location = new System.Drawing.Point(60, 127);
            this.LanguageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(53, 19);
            this.LanguageLabel.TabIndex = 3;
            this.LanguageLabel.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(349, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LanguageAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.LanguageLabel);
            this.MaximizeBox = false;
            this.Name = "LanguageAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageAddEdit";
            this.Load += new System.EventHandler(this.LanguageAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLanguage;
        private MaterialSkin.Controls.MaterialLabel LanguageLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}