namespace SlipstreamHRM.Forms
{
    partial class JobTitleAddEditForm
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
            this.JobTitelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtJobTile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.JobDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtJobDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // JobTitelLabel
            // 
            this.JobTitelLabel.AutoSize = true;
            this.JobTitelLabel.Depth = 0;
            this.JobTitelLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.JobTitelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JobTitelLabel.Location = new System.Drawing.Point(32, 107);
            this.JobTitelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.JobTitelLabel.Name = "JobTitelLabel";
            this.JobTitelLabel.Size = new System.Drawing.Size(67, 19);
            this.JobTitelLabel.TabIndex = 0;
            this.JobTitelLabel.Text = "Job Tile:";
            // 
            // txtJobTile
            // 
            this.txtJobTile.Depth = 0;
            this.txtJobTile.Hint = "";
            this.txtJobTile.Location = new System.Drawing.Point(173, 103);
            this.txtJobTile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJobTile.Name = "txtJobTile";
            this.txtJobTile.PasswordChar = '\0';
            this.txtJobTile.SelectedText = "";
            this.txtJobTile.SelectionLength = 0;
            this.txtJobTile.SelectionStart = 0;
            this.txtJobTile.Size = new System.Drawing.Size(282, 23);
            this.txtJobTile.TabIndex = 1;
            this.txtJobTile.UseSystemPasswordChar = false;
            // 
            // JobDescriptionLabel
            // 
            this.JobDescriptionLabel.AutoSize = true;
            this.JobDescriptionLabel.Depth = 0;
            this.JobDescriptionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.JobDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JobDescriptionLabel.Location = new System.Drawing.Point(32, 146);
            this.JobDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.JobDescriptionLabel.Name = "JobDescriptionLabel";
            this.JobDescriptionLabel.Size = new System.Drawing.Size(119, 19);
            this.JobDescriptionLabel.TabIndex = 2;
            this.JobDescriptionLabel.Text = "Job Description:";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtJobDescription.CustomButton.Image = null;
            this.txtJobDescription.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtJobDescription.CustomButton.Name = "";
            this.txtJobDescription.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.txtJobDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJobDescription.CustomButton.TabIndex = 1;
            this.txtJobDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJobDescription.CustomButton.UseSelectable = true;
            this.txtJobDescription.CustomButton.Visible = false;
            this.txtJobDescription.Lines = new string[0];
            this.txtJobDescription.Location = new System.Drawing.Point(173, 146);
            this.txtJobDescription.MaxLength = 32767;
            this.txtJobDescription.Multiline = true;
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.PasswordChar = '\0';
            this.txtJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJobDescription.SelectedText = "";
            this.txtJobDescription.SelectionLength = 0;
            this.txtJobDescription.SelectionStart = 0;
            this.txtJobDescription.ShortcutsEnabled = true;
            this.txtJobDescription.Size = new System.Drawing.Size(282, 123);
            this.txtJobDescription.TabIndex = 3;
            this.txtJobDescription.UseSelectable = true;
            this.txtJobDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJobDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // JobTitleAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.JobDescriptionLabel);
            this.Controls.Add(this.txtJobTile);
            this.Controls.Add(this.JobTitelLabel);
            this.MinimizeBox = false;
            this.Name = "JobTitleAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Title Add/Edit";
            this.Load += new System.EventHandler(this.JobTitleAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel JobTitelLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJobTile;
        private MaterialSkin.Controls.MaterialLabel JobDescriptionLabel;
        private MetroFramework.Controls.MetroTextBox txtJobDescription;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}