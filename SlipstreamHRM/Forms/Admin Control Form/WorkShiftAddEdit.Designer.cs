namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    partial class WorkShiftAddEdit
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
            this.txtWorkShift = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.WorkShiftLabel = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxFrom = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxTo = new MetroFramework.Controls.MetroComboBox();
            this.txtHoursPerDay = new MetroFramework.Controls.MetroTextBox();
            this.FromLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ToLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HoursPerDayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtWorkShift
            // 
            this.txtWorkShift.Depth = 0;
            this.txtWorkShift.Hint = "";
            this.txtWorkShift.Location = new System.Drawing.Point(148, 100);
            this.txtWorkShift.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWorkShift.Name = "txtWorkShift";
            this.txtWorkShift.PasswordChar = '\0';
            this.txtWorkShift.SelectedText = "";
            this.txtWorkShift.SelectionLength = 0;
            this.txtWorkShift.SelectionStart = 0;
            this.txtWorkShift.Size = new System.Drawing.Size(266, 23);
            this.txtWorkShift.TabIndex = 0;
            this.txtWorkShift.UseSystemPasswordChar = false;
            // 
            // WorkShiftLabel
            // 
            this.WorkShiftLabel.AutoSize = true;
            this.WorkShiftLabel.Depth = 0;
            this.WorkShiftLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.WorkShiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkShiftLabel.Location = new System.Drawing.Point(33, 104);
            this.WorkShiftLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkShiftLabel.Name = "WorkShiftLabel";
            this.WorkShiftLabel.Size = new System.Drawing.Size(83, 19);
            this.WorkShiftLabel.TabIndex = 1;
            this.WorkShiftLabel.Text = "Work Shift:";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.ItemHeight = 23;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "0.00",
            "1.00",
            "2.00",
            "3.00",
            "4.00",
            "5.00",
            "6.00",
            "7.00",
            "8.00",
            "9.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00",
            "20.00",
            "21.00",
            "22.00",
            "23.00",
            "24.00"});
            this.comboBoxFrom.Location = new System.Drawing.Point(148, 159);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(266, 29);
            this.comboBoxFrom.TabIndex = 3;
            this.comboBoxFrom.UseSelectable = true;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.ItemHeight = 23;
            this.comboBoxTo.Items.AddRange(new object[] {
            "0.00",
            "1.00",
            "2.00",
            "3.00",
            "4.00",
            "5.00",
            "6.00",
            "7.00",
            "8.00",
            "9.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00",
            "20.00",
            "21.00",
            "22.00",
            "23.00",
            "24.00"});
            this.comboBoxTo.Location = new System.Drawing.Point(148, 222);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(266, 29);
            this.comboBoxTo.TabIndex = 5;
            this.comboBoxTo.UseSelectable = true;
            // 
            // txtHoursPerDay
            // 
            // 
            // 
            // 
            this.txtHoursPerDay.CustomButton.Image = null;
            this.txtHoursPerDay.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.txtHoursPerDay.CustomButton.Name = "";
            this.txtHoursPerDay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoursPerDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoursPerDay.CustomButton.TabIndex = 1;
            this.txtHoursPerDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoursPerDay.CustomButton.UseSelectable = true;
            this.txtHoursPerDay.CustomButton.Visible = false;
            this.txtHoursPerDay.Lines = new string[0];
            this.txtHoursPerDay.Location = new System.Drawing.Point(148, 288);
            this.txtHoursPerDay.MaxLength = 32767;
            this.txtHoursPerDay.Name = "txtHoursPerDay";
            this.txtHoursPerDay.PasswordChar = '\0';
            this.txtHoursPerDay.ReadOnly = true;
            this.txtHoursPerDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoursPerDay.SelectedText = "";
            this.txtHoursPerDay.SelectionLength = 0;
            this.txtHoursPerDay.SelectionStart = 0;
            this.txtHoursPerDay.ShortcutsEnabled = true;
            this.txtHoursPerDay.Size = new System.Drawing.Size(266, 23);
            this.txtHoursPerDay.TabIndex = 6;
            this.txtHoursPerDay.UseSelectable = true;
            this.txtHoursPerDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoursPerDay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Depth = 0;
            this.FromLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FromLabel.Location = new System.Drawing.Point(33, 169);
            this.FromLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(48, 19);
            this.FromLabel.TabIndex = 7;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Depth = 0;
            this.ToLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToLabel.Location = new System.Drawing.Point(33, 232);
            this.ToLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(31, 19);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To:";
            // 
            // HoursPerDayLabel
            // 
            this.HoursPerDayLabel.AutoSize = true;
            this.HoursPerDayLabel.Depth = 0;
            this.HoursPerDayLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.HoursPerDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HoursPerDayLabel.Location = new System.Drawing.Point(33, 292);
            this.HoursPerDayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HoursPerDayLabel.Name = "HoursPerDayLabel";
            this.HoursPerDayLabel.Size = new System.Drawing.Size(109, 19);
            this.HoursPerDayLabel.TabIndex = 9;
            this.HoursPerDayLabel.Text = "Hours Per Day:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WorkShiftAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 428);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.HoursPerDayLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.txtHoursPerDay);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.WorkShiftLabel);
            this.Controls.Add(this.txtWorkShift);
            this.MaximizeBox = false;
            this.Name = "WorkShiftAddEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Shift Add/Edit";
            this.Load += new System.EventHandler(this.WorkShiftAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtWorkShift;
        private MaterialSkin.Controls.MaterialLabel WorkShiftLabel;
        private MetroFramework.Controls.MetroComboBox comboBoxFrom;
        private MetroFramework.Controls.MetroComboBox comboBoxTo;
        private MetroFramework.Controls.MetroTextBox txtHoursPerDay;
        private MaterialSkin.Controls.MaterialLabel FromLabel;
        private MaterialSkin.Controls.MaterialLabel ToLabel;
        private MaterialSkin.Controls.MaterialLabel HoursPerDayLabel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}