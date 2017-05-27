using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.ProjectInfo_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Time_Dashboard_Control
{
    public partial class ProjectInfoDashboardControl : UserControl
    {
        private ProjectInfoDashboardControl _instance;

        public ProjectInfoDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectInfoDashboardControl();
                return _instance;
            }
        }

        public ProjectInfoDashboardControl()
        {
            InitializeComponent();
            customerInformationDashboardShow();
            projectInformationDashboardShow();
        }

        public void customerInformationDashboardShow()
        {
            CustomerDashboardControl customerDashboardControl = new CustomerDashboardControl();

            if (!metroTabPage1.Controls.Contains(customerDashboardControl.Instance))
            {
                metroTabPage1.Controls.Add(customerDashboardControl.Instance);
                customerDashboardControl.Instance.Dock = DockStyle.Fill;
                customerDashboardControl.Instance.BringToFront();
            }
            else
                customerDashboardControl.Instance.BringToFront();
        }

        public void projectInformationDashboardShow()
        {
            ProjectDashboardControl projectDashboardControl = new ProjectDashboardControl();

            if (!metroTabPage2.Controls.Contains(projectDashboardControl.Instance))
            {
                metroTabPage2.Controls.Add(projectDashboardControl.Instance);
                projectDashboardControl.Instance.Dock = DockStyle.Fill;
                projectDashboardControl.Instance.BringToFront();
            }
            else
                projectDashboardControl.Instance.BringToFront();
        }
    }
}
