namespace SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control
{
    partial class ApplyDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applyPanel = new MetroFramework.Controls.MetroPanel();
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.txtComment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CommentLabel = new MetroFramework.Controls.MetroLabel();
            this.ToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.FromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.ToLabel = new MetroFramework.Controls.MetroLabel();
            this.FromLabel = new MetroFramework.Controls.MetroLabel();
            this.LeaveTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.comboLeaveType = new MetroFramework.Controls.MetroComboBox();
            this.ApplyLeaveLink = new MetroFramework.Controls.MetroLink();
            this.applyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyPanel
            // 
            this.applyPanel.BackColor = System.Drawing.Color.White;
            this.applyPanel.Controls.Add(this.ApplyLeaveLink);
            this.applyPanel.Controls.Add(this.btnApply);
            this.applyPanel.Controls.Add(this.txtComment);
            this.applyPanel.Controls.Add(this.CommentLabel);
            this.applyPanel.Controls.Add(this.ToDateTime);
            this.applyPanel.Controls.Add(this.FromDateTime);
            this.applyPanel.Controls.Add(this.ToLabel);
            this.applyPanel.Controls.Add(this.FromLabel);
            this.applyPanel.Controls.Add(this.LeaveTypeLabel);
            this.applyPanel.Controls.Add(this.comboLeaveType);
            this.applyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyPanel.HorizontalScrollbarBarColor = true;
            this.applyPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.applyPanel.HorizontalScrollbarSize = 10;
            this.applyPanel.Location = new System.Drawing.Point(0, 0);
            this.applyPanel.Name = "applyPanel";
            this.applyPanel.Size = new System.Drawing.Size(1047, 492);
            this.applyPanel.TabIndex = 0;
            this.applyPanel.VerticalScrollbarBarColor = true;
            this.applyPanel.VerticalScrollbarHighlightOnWheel = false;
            this.applyPanel.VerticalScrollbarSize = 10;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Control;
            this.btnApply.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnApply.Location = new System.Drawing.Point(906, 415);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(101, 32);
            this.btnApply.TabIndex = 45;
            this.btnApply.Text = "Apply";
            this.btnApply.UseSelectable = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtComment
            // 
            this.txtComment.Depth = 0;
            this.txtComment.Hint = "";
            this.txtComment.Location = new System.Drawing.Point(52, 342);
            this.txtComment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.Size = new System.Drawing.Size(955, 23);
            this.txtComment.TabIndex = 13;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(52, 300);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(68, 19);
            this.CommentLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.CommentLabel.TabIndex = 12;
            this.CommentLabel.Text = "Comment";
            this.CommentLabel.UseStyleColors = true;
            // 
            // ToDateTime
            // 
            this.ToDateTime.Location = new System.Drawing.Point(460, 202);
            this.ToDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(258, 29);
            this.ToDateTime.TabIndex = 11;
            // 
            // FromDateTime
            // 
            this.FromDateTime.Location = new System.Drawing.Point(52, 202);
            this.FromDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(258, 29);
            this.FromDateTime.TabIndex = 10;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(460, 166);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(28, 19);
            this.ToLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ToLabel.TabIndex = 7;
            this.ToLabel.Text = "*To";
            this.ToLabel.UseStyleColors = true;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(52, 166);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(47, 19);
            this.FromLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.FromLabel.TabIndex = 6;
            this.FromLabel.Text = "*From";
            this.FromLabel.UseStyleColors = true;
            // 
            // LeaveTypeLabel
            // 
            this.LeaveTypeLabel.AutoSize = true;
            this.LeaveTypeLabel.Location = new System.Drawing.Point(52, 62);
            this.LeaveTypeLabel.Name = "LeaveTypeLabel";
            this.LeaveTypeLabel.Size = new System.Drawing.Size(79, 19);
            this.LeaveTypeLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LeaveTypeLabel.TabIndex = 5;
            this.LeaveTypeLabel.Text = "*Leave Type";
            this.LeaveTypeLabel.UseStyleColors = true;
            // 
            // comboLeaveType
            // 
            this.comboLeaveType.FormattingEnabled = true;
            this.comboLeaveType.ItemHeight = 23;
            this.comboLeaveType.Items.AddRange(new object[] {
            "Community Leave AU",
            "Medical AU",
            "Paternity AU",
            "Parent Leave CA",
            "PTO CA",
            "Vacation DE",
            "Caretaker Leave US",
            "Childcare US",
            "FMLA US",
            "Maternity US"});
            this.comboLeaveType.Location = new System.Drawing.Point(52, 94);
            this.comboLeaveType.Name = "comboLeaveType";
            this.comboLeaveType.Size = new System.Drawing.Size(288, 29);
            this.comboLeaveType.TabIndex = 4;
            this.comboLeaveType.UseSelectable = true;
            // 
            // ApplyLeaveLink
            // 
            this.ApplyLeaveLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplyLeaveLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ApplyLeaveLink.Location = new System.Drawing.Point(0, 0);
            this.ApplyLeaveLink.Name = "ApplyLeaveLink";
            this.ApplyLeaveLink.Size = new System.Drawing.Size(1047, 30);
            this.ApplyLeaveLink.Style = MetroFramework.MetroColorStyle.Black;
            this.ApplyLeaveLink.TabIndex = 46;
            this.ApplyLeaveLink.Text = "Apply Leave";
            this.ApplyLeaveLink.UseSelectable = true;
            // 
            // ApplyDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.applyPanel);
            this.Name = "ApplyDashboardControl";
            this.Size = new System.Drawing.Size(1047, 492);
            this.Load += new System.EventHandler(this.ApplyDashboardControl_Load);
            this.applyPanel.ResumeLayout(false);
            this.applyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel applyPanel;
        private MetroFramework.Controls.MetroLabel LeaveTypeLabel;
        private MetroFramework.Controls.MetroComboBox comboLeaveType;
        private MetroFramework.Controls.MetroLabel ToLabel;
        private MetroFramework.Controls.MetroLabel FromLabel;
        private MetroFramework.Controls.MetroLabel CommentLabel;
        private MetroFramework.Controls.MetroDateTime ToDateTime;
        private MetroFramework.Controls.MetroDateTime FromDateTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComment;
        private MetroFramework.Controls.MetroButton btnApply;
        private MetroFramework.Controls.MetroLink ApplyLeaveLink;
    }
}
