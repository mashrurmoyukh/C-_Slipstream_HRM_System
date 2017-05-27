namespace SlipstreamHRM.Forms
{
    partial class RegionAddEditForm
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
            this.txtRegionName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegionNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtRegionName
            // 
            this.txtRegionName.Depth = 0;
            this.txtRegionName.Hint = "";
            this.txtRegionName.Location = new System.Drawing.Point(150, 108);
            this.txtRegionName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.PasswordChar = '\0';
            this.txtRegionName.SelectedText = "";
            this.txtRegionName.SelectionLength = 0;
            this.txtRegionName.SelectionStart = 0;
            this.txtRegionName.Size = new System.Drawing.Size(257, 23);
            this.txtRegionName.TabIndex = 3;
            this.txtRegionName.UseSystemPasswordChar = false;
            // 
            // RegionNameLabel
            // 
            this.RegionNameLabel.AutoSize = true;
            this.RegionNameLabel.Depth = 0;
            this.RegionNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RegionNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegionNameLabel.Location = new System.Drawing.Point(12, 113);
            this.RegionNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegionNameLabel.Name = "RegionNameLabel";
            this.RegionNameLabel.Size = new System.Drawing.Size(103, 19);
            this.RegionNameLabel.TabIndex = 4;
            this.RegionNameLabel.Text = "Region Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RegionAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 230);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.RegionNameLabel);
            this.MaximizeBox = false;
            this.Name = "RegionAddEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Region Add/Edit ";
            this.Load += new System.EventHandler(this.RegionAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtRegionName;
        private MaterialSkin.Controls.MaterialLabel RegionNameLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}