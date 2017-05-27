namespace SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control
{
    partial class MyLeaveDashboardControl
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
            this.myLeavePanel = new MetroFramework.Controls.MetroPanel();
            this.myLeaveListDataGridView = new System.Windows.Forms.DataGridView();
            this.LeaveListLink = new MetroFramework.Controls.MetroLink();
            this.myLeavePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLeaveListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myLeavePanel
            // 
            this.myLeavePanel.Controls.Add(this.myLeaveListDataGridView);
            this.myLeavePanel.Controls.Add(this.LeaveListLink);
            this.myLeavePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myLeavePanel.HorizontalScrollbarBarColor = true;
            this.myLeavePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.myLeavePanel.HorizontalScrollbarSize = 10;
            this.myLeavePanel.Location = new System.Drawing.Point(0, 0);
            this.myLeavePanel.Name = "myLeavePanel";
            this.myLeavePanel.Size = new System.Drawing.Size(1047, 492);
            this.myLeavePanel.TabIndex = 0;
            this.myLeavePanel.VerticalScrollbarBarColor = true;
            this.myLeavePanel.VerticalScrollbarHighlightOnWheel = false;
            this.myLeavePanel.VerticalScrollbarSize = 10;
            // 
            // myLeaveListDataGridView
            // 
            this.myLeaveListDataGridView.AllowUserToAddRows = false;
            this.myLeaveListDataGridView.AllowUserToDeleteRows = false;
            this.myLeaveListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myLeaveListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myLeaveListDataGridView.Location = new System.Drawing.Point(0, 39);
            this.myLeaveListDataGridView.Name = "myLeaveListDataGridView";
            this.myLeaveListDataGridView.ReadOnly = true;
            this.myLeaveListDataGridView.Size = new System.Drawing.Size(1047, 453);
            this.myLeaveListDataGridView.TabIndex = 3;
            // 
            // LeaveListLink
            // 
            this.LeaveListLink.BackColor = System.Drawing.Color.SteelBlue;
            this.LeaveListLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeaveListLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LeaveListLink.ForeColor = System.Drawing.Color.White;
            this.LeaveListLink.Location = new System.Drawing.Point(0, 0);
            this.LeaveListLink.Name = "LeaveListLink";
            this.LeaveListLink.Size = new System.Drawing.Size(1047, 39);
            this.LeaveListLink.TabIndex = 2;
            this.LeaveListLink.Text = "Leave List";
            this.LeaveListLink.UseCustomBackColor = true;
            this.LeaveListLink.UseCustomForeColor = true;
            this.LeaveListLink.UseSelectable = true;
            // 
            // MyLeaveDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myLeavePanel);
            this.Name = "MyLeaveDashboardControl";
            this.Size = new System.Drawing.Size(1047, 492);
            this.Load += new System.EventHandler(this.MyLeaveDashboardControl_Load);
            this.myLeavePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myLeaveListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel myLeavePanel;
        private MetroFramework.Controls.MetroLink LeaveListLink;
        private System.Windows.Forms.DataGridView myLeaveListDataGridView;
    }
}
