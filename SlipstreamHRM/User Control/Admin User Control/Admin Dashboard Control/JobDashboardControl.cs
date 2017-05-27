using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class JobDashboardControl : UserControl
    {
        private JobDashboardControl _instance;

        public JobDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobDashboardControl();
                return _instance;
            }
        }

        public JobDashboardControl()
        {
            InitializeComponent();
        }

        private void JobDashboardControl_Load(object sender, EventArgs e)
        {
            jobTitelDashboardLoad();
            employmentStatusDashboardLoad();
            jobCategoriesDashboardLoad();
            workShiftDashboardLoad();
        }

        public void jobTitelDashboardLoad()
        {
            JobTitleDashboardControl jobTitleDashboardControl = new JobTitleDashboardControl();

            if (!jobTabPage1.Controls.Contains(jobTitleDashboardControl.Instance))
            {
                jobTabPage1.Controls.Add(jobTitleDashboardControl.Instance);
                jobTitleDashboardControl.Instance.Dock = DockStyle.Fill;
                jobTitleDashboardControl.Instance.BringToFront();
            }
            else
                jobTitleDashboardControl.Instance.BringToFront();
        }

        public void employmentStatusDashboardLoad()
        {
            EmploymentStatusDashboardControl employmentStatusDashboardControl = new EmploymentStatusDashboardControl();

            if (!jobTabPage2.Controls.Contains(employmentStatusDashboardControl.Instance))
            {
                jobTabPage2.Controls.Add(employmentStatusDashboardControl.Instance);
                employmentStatusDashboardControl.Instance.Dock = DockStyle.Fill;
                employmentStatusDashboardControl.Instance.BringToFront();
            }
            else
                employmentStatusDashboardControl.Instance.BringToFront();
        }

        public void jobCategoriesDashboardLoad()
        {
            JobCategoriesDashboardControl jobCategoriesDashboardControl = new JobCategoriesDashboardControl();

            if (!jobTabPage3.Controls.Contains(jobCategoriesDashboardControl.Instance))
            {
                jobTabPage3.Controls.Add(jobCategoriesDashboardControl.Instance);
                jobCategoriesDashboardControl.Instance.Dock = DockStyle.Fill;
                jobCategoriesDashboardControl.Instance.BringToFront();
            }
            else
                jobCategoriesDashboardControl.Instance.BringToFront();
        }

        public void workShiftDashboardLoad()
        {
            WorkShiftDashboardControl workShiftDashboardControl = new WorkShiftDashboardControl();

            if (!jobTabPage4.Controls.Contains(workShiftDashboardControl.Instance))
            {
                jobTabPage4.Controls.Add(workShiftDashboardControl.Instance);
                workShiftDashboardControl.Instance.Dock = DockStyle.Fill;
                workShiftDashboardControl.Instance.BringToFront();
            }
            else
                workShiftDashboardControl.Instance.BringToFront();
        }
    }
}
