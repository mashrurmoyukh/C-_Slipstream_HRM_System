using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control;
using SlipstreamHRM.User_Control.Admin_User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class OrganizationDashboardControl : UserControl
    {
        private OrganizationDashboardControl _instance;

        public OrganizationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrganizationDashboardControl();
                return _instance;
            }
        }

        public OrganizationDashboardControl()
        {
            InitializeComponent();
        }

        private void OrganizationDashboardControl_Load(object sender, EventArgs e)
        {
            generalInformationDashboardShow();
            locationInformationDashboardShow();
        }

        public void generalInformationDashboardShow()
        {
            GeneralInformationDashboardControl generalInformationDashboardControl = new GeneralInformationDashboardControl();

            if (!organizationTabPage1.Controls.Contains(generalInformationDashboardControl.Instance))
            {
                organizationTabPage1.Controls.Add(generalInformationDashboardControl.Instance);
                generalInformationDashboardControl.Instance.Dock = DockStyle.Fill;
                generalInformationDashboardControl.Instance.BringToFront();
            }
            else
                generalInformationDashboardControl.Instance.BringToFront();
        }

        public void locationInformationDashboardShow()
        {
            LocationInformationDashboardControl locationInformationDashboardControl = new LocationInformationDashboardControl();

            if (!organizationTabPage2.Controls.Contains(locationInformationDashboardControl.Instance))
            {
                organizationTabPage2.Controls.Add(locationInformationDashboardControl.Instance);
                locationInformationDashboardControl.Instance.Dock = DockStyle.Fill;
                locationInformationDashboardControl.Instance.BringToFront();
            }
            else
                locationInformationDashboardControl.Instance.BringToFront();
        }
    }
}
