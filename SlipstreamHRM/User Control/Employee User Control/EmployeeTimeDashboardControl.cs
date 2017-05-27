using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.BAL.User_Control_Manager;
using SlipstreamHRM.User_Control.Employee_User_Control.Tiem_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    public partial class EmployeeTimeDashboardControl : UserControl
    {
        private EmployeeTimeDashboardControl _instance;
        private string _userName;
        private PunchInOutDashboardHandler punchInOutDashboardHandler;

        public EmployeeTimeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeTimeDashboardControl(_userName);
                return _instance;
            }
        }

        public EmployeeTimeDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void EmployeeTimeDashboardControl_Load(object sender, EventArgs e)
        {
            punchInOutDashboardHandler = new PunchInOutDashboardHandler();
            dateLink.Text = DateTime.Now.ToLongDateString();
            timeLink.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPunchIn_Click(object sender, EventArgs e)
        {
            punchInOutDashboardHandler.punchIn(_userName, DateTime.Now);
        }

        private void btnPunchOut_Click(object sender, EventArgs e)
        {
            punchInOutDashboardHandler.punchOut(_userName, DateTime.Now);
        }

        private void MyAttendanceItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MyAttendanceDashboardControl myAttendanceDashboardControl = new MyAttendanceDashboardControl(_userName);

            if (!employeeTimePanel.Controls.Contains(myAttendanceDashboardControl.Instance))
            {
                employeeTimePanel.Controls.Add(myAttendanceDashboardControl.Instance);
                myAttendanceDashboardControl.Instance.Dock = DockStyle.Fill;
                myAttendanceDashboardControl.Instance.BringToFront();
            }
            else
                myAttendanceDashboardControl.Instance.BringToFront();
        }

        private void MyEmployeeAttendanceItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MyEmployeeAttendanceDashboardControl myEmployeeAttendanceDashboardControl = new MyEmployeeAttendanceDashboardControl(_userName);

            if (!employeeTimePanel.Controls.Contains(myEmployeeAttendanceDashboardControl.Instance))
            {
                employeeTimePanel.Controls.Add(myEmployeeAttendanceDashboardControl.Instance);
                myEmployeeAttendanceDashboardControl.Instance.Dock = DockStyle.Fill;
                myEmployeeAttendanceDashboardControl.Instance.BringToFront();
            }
            else
                myEmployeeAttendanceDashboardControl.Instance.BringToFront();
        }

        private void MyTimeSheetsItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MyTimeSheetsDashboardControl myTimeSheetsDashboardControl = new MyTimeSheetsDashboardControl(_userName);

            if (!employeeTimePanel.Controls.Contains(myTimeSheetsDashboardControl.Instance))
            {
                employeeTimePanel.Controls.Add(myTimeSheetsDashboardControl.Instance);
                myTimeSheetsDashboardControl.Instance.Dock = DockStyle.Fill;
                myTimeSheetsDashboardControl.Instance.BringToFront();
            }
            else
                myTimeSheetsDashboardControl.Instance.BringToFront();
        }
    }
}
