using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Leave_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class LeaveDashboardControl : UserControl
    {
        private LeaveDashboardControl _instance;

        public LeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LeaveDashboardControl();
                return _instance;
            }
        }

        public LeaveDashboardControl()
        {
            InitializeComponent();
        }

        private void EntitelmentsTile_Click(object sender, EventArgs e)
        {
            EntitelmentsDashboardControl entitelmentsDashboardControl = new EntitelmentsDashboardControl();

            if (!leavePanel.Controls.Contains(entitelmentsDashboardControl.Instance))
            {
                leavePanel.Controls.Add(entitelmentsDashboardControl.Instance);
                entitelmentsDashboardControl.Instance.Dock = DockStyle.Fill;
                entitelmentsDashboardControl.Instance.BringToFront();
            }
            else
                entitelmentsDashboardControl.Instance.BringToFront();
        }

        private void LeaveAssignTile_Click(object sender, EventArgs e)
        {
            AssignLeaveDashboardControl aignLeaveDashboardControl = new AssignLeaveDashboardControl();

            if (!leavePanel.Controls.Contains(aignLeaveDashboardControl.Instance))
            {
                leavePanel.Controls.Add(aignLeaveDashboardControl.Instance);
                aignLeaveDashboardControl.Instance.Dock = DockStyle.Fill;
                aignLeaveDashboardControl.Instance.BringToFront();
            }
            else
                aignLeaveDashboardControl.Instance.BringToFront();
        }

        private void LeaveListTile_Click(object sender, EventArgs e)
        {
            LeaveListDashboardControl leaveListDashboardControl = new LeaveListDashboardControl();

            if (!leavePanel.Controls.Contains(leaveListDashboardControl.Instance))
            {
                leavePanel.Controls.Add(leaveListDashboardControl.Instance);
                leaveListDashboardControl.Instance.Dock = DockStyle.Fill;
                leaveListDashboardControl.Instance.BringToFront();
            }
            else
                leaveListDashboardControl.Instance.BringToFront();
        }
    }
}
