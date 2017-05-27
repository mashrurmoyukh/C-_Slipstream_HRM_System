namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class LeaveActionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.approveRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.cancelRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.rejectRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.rejectRadioButton);
            this.groupBox1.Controls.Add(this.cancelRadioButton);
            this.groupBox1.Controls.Add(this.approveRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Action";
            // 
            // approveRadioButton
            // 
            this.approveRadioButton.AutoSize = true;
            this.approveRadioButton.Location = new System.Drawing.Point(6, 29);
            this.approveRadioButton.Name = "approveRadioButton";
            this.approveRadioButton.Size = new System.Drawing.Size(68, 15);
            this.approveRadioButton.TabIndex = 0;
            this.approveRadioButton.Text = "Approve";
            this.approveRadioButton.UseSelectable = true;
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.AutoSize = true;
            this.cancelRadioButton.Location = new System.Drawing.Point(6, 69);
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Size = new System.Drawing.Size(59, 15);
            this.cancelRadioButton.TabIndex = 1;
            this.cancelRadioButton.Text = "Cancel";
            this.cancelRadioButton.UseSelectable = true;
            // 
            // rejectRadioButton
            // 
            this.rejectRadioButton.AutoSize = true;
            this.rejectRadioButton.Location = new System.Drawing.Point(6, 109);
            this.rejectRadioButton.Name = "rejectRadioButton";
            this.rejectRadioButton.Size = new System.Drawing.Size(55, 15);
            this.rejectRadioButton.TabIndex = 2;
            this.rejectRadioButton.Text = "Reject";
            this.rejectRadioButton.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(285, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Select";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LeaveActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 240);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "LeaveActionForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Action";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rejectRadioButton;
        private MetroFramework.Controls.MetroRadioButton cancelRadioButton;
        private MetroFramework.Controls.MetroRadioButton approveRadioButton;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}