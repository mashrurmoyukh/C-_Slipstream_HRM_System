using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.PIM_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class PIMDashboardControl : UserControl
    {
        private PIMDashboardControl _instance;

        public PIMDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PIMDashboardControl();
                return _instance;
            }
        }

        public PIMDashboardControl()
        {
            InitializeComponent();
        }

        private void EmployeeListTile_Click(object sender, EventArgs e)
        {
            EmployeeListDashboardControl employeeListDashboardControl = new EmployeeListDashboardControl();

            if (!PIMPanel.Controls.Contains(employeeListDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(employeeListDashboardControl.Instance);
                employeeListDashboardControl.Instance.Dock = DockStyle.Fill;
                employeeListDashboardControl.Instance.BringToFront();
            }
            else
                employeeListDashboardControl.Instance.BringToFront();
        }

        private void AddEmployeeTile_Click(object sender, EventArgs e)
        {
            AddEmployeeDashboardControl addEmployeeDashboardControl = new AddEmployeeDashboardControl();

            if (!PIMPanel.Controls.Contains(addEmployeeDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(addEmployeeDashboardControl.Instance);
                addEmployeeDashboardControl.Instance.Dock = DockStyle.Fill;
                addEmployeeDashboardControl.Instance.BringToFront();
            }
            else
                addEmployeeDashboardControl.Instance.BringToFront();
        }

        private void BulkUpdateTile_Click(object sender, EventArgs e)
        {
            BulkUpdateDashboardControl bulkUpdateDashboardControl = new BulkUpdateDashboardControl();

            if (!PIMPanel.Controls.Contains(bulkUpdateDashboardControl.Instance))
            {
                PIMPanel.Controls.Add(bulkUpdateDashboardControl.Instance);
                bulkUpdateDashboardControl.Instance.Dock = DockStyle.Fill;
                bulkUpdateDashboardControl.Instance.BringToFront();
            }
            else
                bulkUpdateDashboardControl.Instance.BringToFront();
        }
    }
}
