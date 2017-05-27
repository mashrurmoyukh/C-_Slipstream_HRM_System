namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class ProjectAddForm
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
            this.ProjectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CustomerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ProjectAdminLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProjectAdmin = new System.Windows.Forms.TextBox();
            this.txtProject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Depth = 0;
            this.ProjectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProjectLabel.Location = new System.Drawing.Point(85, 171);
            this.ProjectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(61, 19);
            this.ProjectLabel.TabIndex = 13;
            this.ProjectLabel.Text = "Project:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Depth = 0;
            this.CustomerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CustomerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomerLabel.Location = new System.Drawing.Point(23, 111);
            this.CustomerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(123, 19);
            this.CustomerLabel.TabIndex = 12;
            this.CustomerLabel.Text = "Customer Name:";
            // 
            // ProjectAdminLabel
            // 
            this.ProjectAdminLabel.AutoSize = true;
            this.ProjectAdminLabel.Depth = 0;
            this.ProjectAdminLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProjectAdminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProjectAdminLabel.Location = new System.Drawing.Point(38, 230);
            this.ProjectAdminLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProjectAdminLabel.Name = "ProjectAdminLabel";
            this.ProjectAdminLabel.Size = new System.Drawing.Size(108, 19);
            this.ProjectAdminLabel.TabIndex = 17;
            this.ProjectAdminLabel.Text = "Project Admin:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.Location = new System.Drawing.Point(174, 111);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(270, 20);
            this.txtCustomerName.TabIndex = 18;
            // 
            // txtProjectAdmin
            // 
            this.txtProjectAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProjectAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjectAdmin.Location = new System.Drawing.Point(174, 229);
            this.txtProjectAdmin.Name = "txtProjectAdmin";
            this.txtProjectAdmin.Size = new System.Drawing.Size(270, 20);
            this.txtProjectAdmin.TabIndex = 19;
            // 
            // txtProject
            // 
            this.txtProject.Depth = 0;
            this.txtProject.Hint = "";
            this.txtProject.Location = new System.Drawing.Point(174, 171);
            this.txtProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProject.Name = "txtProject";
            this.txtProject.PasswordChar = '\0';
            this.txtProject.SelectedText = "";
            this.txtProject.SelectionLength = 0;
            this.txtProject.SelectionStart = 0;
            this.txtProject.Size = new System.Drawing.Size(270, 23);
            this.txtProject.TabIndex = 20;
            this.txtProject.UseSystemPasswordChar = false;
            // 
            // ProjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 367);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtProjectAdmin);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.ProjectAdminLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.CustomerLabel);
            this.MaximizeBox = false;
            this.Name = "ProjectAddForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.ProjectAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MaterialSkin.Controls.MaterialLabel ProjectLabel;
        private MaterialSkin.Controls.MaterialLabel CustomerLabel;
        private MaterialSkin.Controls.MaterialLabel ProjectAdminLabel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProjectAdmin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProject;
    }
}