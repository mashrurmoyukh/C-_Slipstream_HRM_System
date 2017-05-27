namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    partial class EmployeeTimeDashboardControl
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTimeDashboardControl));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.DateLabel = new MetroFramework.Controls.MetroPanel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.MyTimeSheetsItem = new DevExpress.XtraEditors.TileItem();
            this.MyAttendanceItem = new DevExpress.XtraEditors.TileItem();
            this.MyEmployeeAttendanceItem = new DevExpress.XtraEditors.TileItem();
            this.punchInOutPanel = new MetroFramework.Controls.MetroPanel();
            this.btnPunchOut = new MetroFramework.Controls.MetroButton();
            this.btnPunchIn = new MetroFramework.Controls.MetroButton();
            this.timeLink = new MetroFramework.Controls.MetroLink();
            this.dateLink = new MetroFramework.Controls.MetroLink();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.employeeTimePanel = new MetroFramework.Controls.MetroPanel();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DateLabel.SuspendLayout();
            this.punchInOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Controls.Add(this.tileControl1);
            this.DateLabel.Controls.Add(this.punchInOutPanel);
            this.DateLabel.Controls.Add(this.employeeTimePanel);
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.HorizontalScrollbarBarColor = true;
            this.DateLabel.HorizontalScrollbarHighlightOnWheel = false;
            this.DateLabel.HorizontalScrollbarSize = 10;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(1326, 492);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.UseCustomBackColor = true;
            this.DateLabel.VerticalScrollbarBarColor = true;
            this.DateLabel.VerticalScrollbarHighlightOnWheel = false;
            this.DateLabel.VerticalScrollbarSize = 10;
            // 
            // tileControl1
            // 
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(3, 3);
            this.tileControl1.MaxId = 11;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1044, 150);
            this.tileControl1.TabIndex = 5;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.MyTimeSheetsItem);
            this.tileGroup2.Items.Add(this.MyAttendanceItem);
            this.tileGroup2.Items.Add(this.MyEmployeeAttendanceItem);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // MyTimeSheetsItem
            // 
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "My Timesheets";
            this.MyTimeSheetsItem.Elements.Add(tileItemElement1);
            this.MyTimeSheetsItem.Id = 7;
            this.MyTimeSheetsItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.MyTimeSheetsItem.Name = "MyTimeSheetsItem";
            this.MyTimeSheetsItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.MyTimeSheetsItem_ItemClick);
            // 
            // MyAttendanceItem
            // 
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "My Attendance";
            this.MyAttendanceItem.Elements.Add(tileItemElement2);
            this.MyAttendanceItem.Id = 8;
            this.MyAttendanceItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.MyAttendanceItem.Name = "MyAttendanceItem";
            this.MyAttendanceItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.MyAttendanceItem_ItemClick);
            // 
            // MyEmployeeAttendanceItem
            // 
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Employee Attendance";
            this.MyEmployeeAttendanceItem.Elements.Add(tileItemElement3);
            this.MyEmployeeAttendanceItem.Id = 9;
            this.MyEmployeeAttendanceItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.MyEmployeeAttendanceItem.Name = "MyEmployeeAttendanceItem";
            this.MyEmployeeAttendanceItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.MyEmployeeAttendanceItem_ItemClick);
            // 
            // punchInOutPanel
            // 
            this.punchInOutPanel.BackColor = System.Drawing.Color.Transparent;
            this.punchInOutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.punchInOutPanel.Controls.Add(this.btnPunchOut);
            this.punchInOutPanel.Controls.Add(this.btnPunchIn);
            this.punchInOutPanel.Controls.Add(this.timeLink);
            this.punchInOutPanel.Controls.Add(this.dateLink);
            this.punchInOutPanel.Controls.Add(this.TimeLabel);
            this.punchInOutPanel.Controls.Add(this.metroLabel1);
            this.punchInOutPanel.HorizontalScrollbarBarColor = true;
            this.punchInOutPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.punchInOutPanel.HorizontalScrollbarSize = 10;
            this.punchInOutPanel.Location = new System.Drawing.Point(1061, 3);
            this.punchInOutPanel.Name = "punchInOutPanel";
            this.punchInOutPanel.Size = new System.Drawing.Size(262, 150);
            this.punchInOutPanel.TabIndex = 2;
            this.punchInOutPanel.UseCustomBackColor = true;
            this.punchInOutPanel.VerticalScrollbarBarColor = true;
            this.punchInOutPanel.VerticalScrollbarHighlightOnWheel = false;
            this.punchInOutPanel.VerticalScrollbarSize = 10;
            // 
            // btnPunchOut
            // 
            this.btnPunchOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnPunchOut.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnPunchOut.Location = new System.Drawing.Point(147, 94);
            this.btnPunchOut.Name = "btnPunchOut";
            this.btnPunchOut.Size = new System.Drawing.Size(101, 32);
            this.btnPunchOut.TabIndex = 47;
            this.btnPunchOut.Text = "Punch Out";
            this.btnPunchOut.UseSelectable = true;
            this.btnPunchOut.Click += new System.EventHandler(this.btnPunchOut_Click);
            // 
            // btnPunchIn
            // 
            this.btnPunchIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnPunchIn.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnPunchIn.Location = new System.Drawing.Point(16, 94);
            this.btnPunchIn.Name = "btnPunchIn";
            this.btnPunchIn.Size = new System.Drawing.Size(101, 32);
            this.btnPunchIn.TabIndex = 46;
            this.btnPunchIn.Text = "Punch In";
            this.btnPunchIn.UseSelectable = true;
            this.btnPunchIn.Click += new System.EventHandler(this.btnPunchIn_Click);
            // 
            // timeLink
            // 
            this.timeLink.Location = new System.Drawing.Point(58, 43);
            this.timeLink.Name = "timeLink";
            this.timeLink.Size = new System.Drawing.Size(190, 23);
            this.timeLink.TabIndex = 6;
            this.timeLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeLink.UseCustomBackColor = true;
            this.timeLink.UseSelectable = true;
            // 
            // dateLink
            // 
            this.dateLink.Location = new System.Drawing.Point(55, 12);
            this.dateLink.Name = "dateLink";
            this.dateLink.Size = new System.Drawing.Size(193, 23);
            this.dateLink.TabIndex = 5;
            this.dateLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLink.UseCustomBackColor = true;
            this.dateLink.UseSelectable = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(16, 47);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(38, 19);
            this.TimeLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.UseCustomBackColor = true;
            this.TimeLabel.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Date";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // employeeTimePanel
            // 
            this.employeeTimePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeTimePanel.HorizontalScrollbarBarColor = true;
            this.employeeTimePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.employeeTimePanel.HorizontalScrollbarSize = 10;
            this.employeeTimePanel.Location = new System.Drawing.Point(0, 162);
            this.employeeTimePanel.Name = "employeeTimePanel";
            this.employeeTimePanel.Size = new System.Drawing.Size(1326, 330);
            this.employeeTimePanel.TabIndex = 4;
            this.employeeTimePanel.VerticalScrollbarBarColor = true;
            this.employeeTimePanel.VerticalScrollbarHighlightOnWheel = false;
            this.employeeTimePanel.VerticalScrollbarSize = 10;
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Timesheets";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Timesheets";
            // 
            // EmployeeTimeDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateLabel);
            this.Name = "EmployeeTimeDashboardControl";
            this.Size = new System.Drawing.Size(1326, 492);
            this.Load += new System.EventHandler(this.EmployeeTimeDashboardControl_Load);
            this.DateLabel.ResumeLayout(false);
            this.punchInOutPanel.ResumeLayout(false);
            this.punchInOutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel DateLabel;
        private MetroFramework.Controls.MetroPanel punchInOutPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink dateLink;
        private MetroFramework.Controls.MetroLabel TimeLabel;
        private MetroFramework.Controls.MetroLink timeLink;
        private MetroFramework.Controls.MetroButton btnPunchOut;
        private MetroFramework.Controls.MetroButton btnPunchIn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private MetroFramework.Controls.MetroPanel employeeTimePanel;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem MyTimeSheetsItem;
        private DevExpress.XtraEditors.TileItem MyAttendanceItem;
        private DevExpress.XtraEditors.TileItem MyEmployeeAttendanceItem;
    }
}
