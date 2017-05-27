using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    public partial class EmployeeLeaveDashboardControl : UserControl
    {
        private EmployeeLeaveDashboardControl _instance;
        private string _userName;

        public EmployeeLeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeLeaveDashboardControl(_userName);
                return _instance;
            }
        }


        public EmployeeLeaveDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }


        private void applyTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ApplyDashboardControl applyDashboardControl = new ApplyDashboardControl(_userName);

            if (!leavePanel.Controls.Contains(applyDashboardControl.Instance))
            {
                leavePanel.Controls.Add(applyDashboardControl.Instance);
                applyDashboardControl.Instance.Dock = DockStyle.Fill;
                applyDashboardControl.Instance.BringToFront();
            }
            else
                applyDashboardControl.Instance.BringToFront();
        }

        private void myLeaveTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MyLeaveDashboardControl myLeaveDashboardControl = new MyLeaveDashboardControl(_userName);

            if (!leavePanel.Controls.Contains(myLeaveDashboardControl.Instance))
            {
                leavePanel.Controls.Add(myLeaveDashboardControl.Instance);
                myLeaveDashboardControl.Instance.Dock = DockStyle.Fill;
                myLeaveDashboardControl.Instance.BringToFront();
            }
            else
                myLeaveDashboardControl.Instance.BringToFront();
        }

        private void entitlementsTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EntitlementsDashboardControl entitlementsDashboardControl = new EntitlementsDashboardControl(_userName);

            if (!leavePanel.Controls.Contains(entitlementsDashboardControl.Instance))
            {
                leavePanel.Controls.Add(entitlementsDashboardControl.Instance);
                entitlementsDashboardControl.Instance.Dock = DockStyle.Fill;
                entitlementsDashboardControl.Instance.BringToFront();
            }
            else
                entitlementsDashboardControl.Instance.BringToFront();
        }
    }
}
