namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class NewsShowForm
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
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.SubjectLabel = new MetroFramework.Controls.MetroLabel();
            this.publishedLabel = new MetroFramework.Controls.MetroLabel();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DescriptionLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 178);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SubjectLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SubjectLabel.Location = new System.Drawing.Point(22, 83);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(75, 25);
            this.SubjectLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject";
            this.SubjectLabel.UseStyleColors = true;
            // 
            // publishedLabel
            // 
            this.publishedLabel.AutoSize = true;
            this.publishedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.publishedLabel.Location = new System.Drawing.Point(22, 153);
            this.publishedLabel.Name = "publishedLabel";
            this.publishedLabel.Size = new System.Drawing.Size(38, 19);
            this.publishedLabel.TabIndex = 8;
            this.publishedLabel.Text = "Date";
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(597, 1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(22, 111);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ReadOnly = true;
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(619, 23);
            this.txtSubject.TabIndex = 12;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(319, 319);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(22, 206);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(619, 321);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewsShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 539);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.publishedLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectLabel);
            this.MaximizeBox = false;
            this.Name = "NewsShowForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NewsShowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroLabel SubjectLabel;
        private MetroFramework.Controls.MetroLabel publishedLabel;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroTextBox txtDescription;
    }
}