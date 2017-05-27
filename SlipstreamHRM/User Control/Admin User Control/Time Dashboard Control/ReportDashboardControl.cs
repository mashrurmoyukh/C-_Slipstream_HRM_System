using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.Report_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    public partial class ReportDashboardControl : UserControl
    {
        private ReportDashboardControl _instance;

        public ReportDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReportDashboardControl();
                return _instance;
            }
        }

        public ReportDashboardControl()
        {
            InitializeComponent();
            AttendanceReportDashboard();
            ProjectReportDashboard();
        }

        public void AttendanceReportDashboard()
        {
            AttendanceReportDashboardControl attendanceReportDashboardControl = new AttendanceReportDashboardControl();

            if (!metroTabPage1.Controls.Contains(attendanceReportDashboardControl.Instance))
            {
                metroTabPage1.Controls.Add(attendanceReportDashboardControl.Instance);
                attendanceReportDashboardControl.Instance.Dock = DockStyle.Fill;
                attendanceReportDashboardControl.Instance.BringToFront();
            }
            else
                attendanceReportDashboardControl.Instance.BringToFront();
        }

        public void ProjectReportDashboard()
        {
            ProjectReportDashboardControl projectReportDashboardControl = new ProjectReportDashboardControl();

            if (!metroTabPage3.Controls.Contains(projectReportDashboardControl.Instance))
            {
                metroTabPage3.Controls.Add(projectReportDashboardControl.Instance);
                projectReportDashboardControl.Instance.Dock = DockStyle.Fill;
                projectReportDashboardControl.Instance.BringToFront();
            }
            else
                projectReportDashboardControl.Instance.BringToFront();
        }


    }
}
