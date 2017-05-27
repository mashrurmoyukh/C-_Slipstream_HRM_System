namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class JobCategoryAddEditForm
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
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.JobCategoryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtJobCategory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // JobCategoryLabel
            // 
            this.JobCategoryLabel.AutoSize = true;
            this.JobCategoryLabel.Depth = 0;
            this.JobCategoryLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.JobCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JobCategoryLabel.Location = new System.Drawing.Point(9, 102);
            this.JobCategoryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.JobCategoryLabel.Name = "JobCategoryLabel";
            this.JobCategoryLabel.Size = new System.Drawing.Size(102, 19);
            this.JobCategoryLabel.TabIndex = 9;
            this.JobCategoryLabel.Text = "Job Category:";
            // 
            // txtJobCategory
            // 
            this.txtJobCategory.Depth = 0;
            this.txtJobCategory.Hint = "";
            this.txtJobCategory.Location = new System.Drawing.Point(159, 98);
            this.txtJobCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtJobCategory.Name = "txtJobCategory";
            this.txtJobCategory.PasswordChar = '\0';
            this.txtJobCategory.SelectedText = "";
            this.txtJobCategory.SelectionLength = 0;
            this.txtJobCategory.SelectionStart = 0;
            this.txtJobCategory.Size = new System.Drawing.Size(271, 23);
            this.txtJobCategory.TabIndex = 8;
            this.txtJobCategory.UseSystemPasswordChar = false;
            // 
            // JobCategoryAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 202);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.JobCategoryLabel);
            this.Controls.Add(this.txtJobCategory);
            this.MaximizeBox = false;
            this.Name = "JobCategoryAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Category Add/Edit";
            this.Load += new System.EventHandler(this.JobCategoryAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MaterialSkin.Controls.MaterialLabel JobCategoryLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtJobCategory;
    }
}