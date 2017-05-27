namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class CustomerAddForm
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
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CustomerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtDescription.Location = new System.Drawing.Point(128, 153);
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
            this.txtDescription.TabIndex = 10;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Hint = "";
            this.txtCustomerName.Location = new System.Drawing.Point(128, 97);
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.Size = new System.Drawing.Size(317, 23);
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.UseSystemPasswordChar = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 153);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(90, 19);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Depth = 0;
            this.CustomerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CustomerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CustomerLabel.Location = new System.Drawing.Point(23, 101);
            this.CustomerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(79, 19);
            this.CustomerLabel.TabIndex = 7;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 425);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CustomerLabel);
            this.MaximizeBox = false;
            this.Name = "CustomerAddForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustomerAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCustomerName;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
        private MaterialSkin.Controls.MaterialLabel CustomerLabel;
    }
}