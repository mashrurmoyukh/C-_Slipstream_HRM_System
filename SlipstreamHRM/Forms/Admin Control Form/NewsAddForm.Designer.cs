namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class NewsAddForm
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
            this.SubjectLabel = new MetroFramework.Controls.MetroLabel();
            this.txtSubject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnPublish = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(33, 124);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(54, 19);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Depth = 0;
            this.txtSubject.Hint = "";
            this.txtSubject.Location = new System.Drawing.Point(90, 120);
            this.txtSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.Size = new System.Drawing.Size(567, 23);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.UseSystemPasswordChar = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 176);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(77, 19);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description:";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(291, 291);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(94, 176);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(563, 293);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.SystemColors.Control;
            this.btnPublish.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnPublish.Location = new System.Drawing.Point(556, 492);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(101, 32);
            this.btnPublish.TabIndex = 46;
            this.btnPublish.Text = "&Publish";
            this.btnPublish.UseSelectable = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // NewsAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 548);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.SubjectLabel);
            this.MaximizeBox = false;
            this.Name = "NewsAddForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel SubjectLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubject;
        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroButton btnPublish;
    }
}