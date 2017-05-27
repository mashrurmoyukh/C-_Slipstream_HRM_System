namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class EmploymentStatusAddEditForm
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
            this.txtEmploymentStatus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmploymentStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtEmploymentStatus
            // 
            this.txtEmploymentStatus.Depth = 0;
            this.txtEmploymentStatus.Hint = "";
            this.txtEmploymentStatus.Location = new System.Drawing.Point(162, 98);
            this.txtEmploymentStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmploymentStatus.Name = "txtEmploymentStatus";
            this.txtEmploymentStatus.PasswordChar = '\0';
            this.txtEmploymentStatus.SelectedText = "";
            this.txtEmploymentStatus.SelectionLength = 0;
            this.txtEmploymentStatus.SelectionStart = 0;
            this.txtEmploymentStatus.Size = new System.Drawing.Size(257, 23);
            this.txtEmploymentStatus.TabIndex = 0;
            this.txtEmploymentStatus.UseSystemPasswordChar = false;
            // 
            // EmploymentStatusLabel
            // 
            this.EmploymentStatusLabel.AutoSize = true;
            this.EmploymentStatusLabel.Depth = 0;
            this.EmploymentStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EmploymentStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmploymentStatusLabel.Location = new System.Drawing.Point(12, 102);
            this.EmploymentStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmploymentStatusLabel.Name = "EmploymentStatusLabel";
            this.EmploymentStatusLabel.Size = new System.Drawing.Size(144, 19);
            this.EmploymentStatusLabel.TabIndex = 1;
            this.EmploymentStatusLabel.Text = "Employment Status:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EmploymentStatusAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 207);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.EmploymentStatusLabel);
            this.Controls.Add(this.txtEmploymentStatus);
            this.MaximizeBox = false;
            this.Name = "EmploymentStatusAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employment Status Add/Edit";
            this.Load += new System.EventHandler(this.EmploymentStatusAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmploymentStatus;
        private MaterialSkin.Controls.MaterialLabel EmploymentStatusLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}