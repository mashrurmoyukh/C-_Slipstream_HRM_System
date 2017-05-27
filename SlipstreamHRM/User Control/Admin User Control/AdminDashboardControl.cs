using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class AdminDashboardControl : UserControl
    {
        private AdminDashboardControl _instance;

        public AdminDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminDashboardControl();
                return _instance;
            }
        }

        public AdminDashboardControl()
        {
            InitializeComponent();
        }

        private void UserManagementTile_Click(object sender, EventArgs e)
        {
            UserDashboardControl userDashboardControl = new UserDashboardControl();

            if (!adminPanel.Controls.Contains(userDashboardControl.Instance))
            {
                adminPanel.Controls.Add(userDashboardControl.Instance);
                userDashboardControl.Instance.Dock = DockStyle.Fill;
                userDashboardControl.Instance.BringToFront();
            }
            else
                userDashboardControl.Instance.BringToFront();
        }

        private void JobTile_Click(object sender, EventArgs e)
        {
            JobDashboardControl jobDashboardControl = new JobDashboardControl();

            if (!adminPanel.Controls.Contains(jobDashboardControl.Instance))
            {
                adminPanel.Controls.Add(jobDashboardControl.Instance);
                jobDashboardControl.Instance.Dock = DockStyle.Fill;
                jobDashboardControl.Instance.BringToFront();
            }
            else
                jobDashboardControl.Instance.BringToFront();
        }

        private void OrganizationTile_Click(object sender, EventArgs e)
        {
            OrganizationDashboardControl organizationDashboardControl = new OrganizationDashboardControl();

            if (!adminPanel.Controls.Contains(organizationDashboardControl.Instance))
            {
                adminPanel.Controls.Add(organizationDashboardControl.Instance);
                organizationDashboardControl.Instance.Dock = DockStyle.Fill;
                organizationDashboardControl.Instance.BringToFront();
            }
            else
                organizationDashboardControl.Instance.BringToFront();
        }

        private void QualificationTile_Click(object sender, EventArgs e)
        {
            QualificationDashboardControl qualificationDashboardControl = new QualificationDashboardControl();
            if (!adminPanel.Controls.Contains(qualificationDashboardControl.Instance))
            {
                adminPanel.Controls.Add(qualificationDashboardControl.Instance);
                qualificationDashboardControl.Instance.Dock = DockStyle.Fill;
                qualificationDashboardControl.Instance.BringToFront();
            }
            else
                qualificationDashboardControl.Instance.BringToFront();
        }

        private void NationalitiesTile_Click(object sender, EventArgs e)
        {
            NationalitiesDashboardControl nationalitiesDashboardControl = new NationalitiesDashboardControl();

            if (!adminPanel.Controls.Contains(nationalitiesDashboardControl.Instance))
            {
                adminPanel.Controls.Add(nationalitiesDashboardControl.Instance);
                nationalitiesDashboardControl.Instance.Dock = DockStyle.Fill;
                nationalitiesDashboardControl.Instance.BringToFront();
            }
            else
                nationalitiesDashboardControl.Instance.BringToFront();
        }
    }
}
