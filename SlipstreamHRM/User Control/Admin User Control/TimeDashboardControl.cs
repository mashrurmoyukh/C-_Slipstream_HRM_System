using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Time_Dashboard_Control;


namespace SlipstreamHRM.User_Control
{
    public partial class TimeDashboardControl : UserControl
    {
        private TimeDashboardControl _instance;

        public TimeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TimeDashboardControl();
                return _instance;
            }
        }

        public TimeDashboardControl()
        {
            InitializeComponent();
        }

        private void ReportTile_Click(object sender, EventArgs e)
        {
            ReportDashboardControl reportDashboardControl = new ReportDashboardControl();

            if (!timePanel.Controls.Contains(reportDashboardControl.Instance))
            {
                timePanel.Controls.Add(reportDashboardControl.Instance);
                reportDashboardControl.Instance.Dock = DockStyle.Fill;
                reportDashboardControl.Instance.BringToFront();
            }
            else
                reportDashboardControl.Instance.BringToFront();
        }

        private void ProjectInfoTile_Click(object sender, EventArgs e)
        {
            ProjectInfoDashboardControl projectInfoDashboardControl = new ProjectInfoDashboardControl();

            if (!timePanel.Controls.Contains(projectInfoDashboardControl.Instance))
            {
                timePanel.Controls.Add(projectInfoDashboardControl.Instance);
                projectInfoDashboardControl.Instance.Dock = DockStyle.Fill;
                projectInfoDashboardControl.Instance.BringToFront();
            }
            else
                projectInfoDashboardControl.Instance.BringToFront();
        }
    }
}
