using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control;

namespace SlipstreamHRM.Forms
{
    public partial class AdminControlManager : MetroFramework.Forms.MetroForm
    {
        public AdminControlManager(string txt)
        {
            InitializeComponent();
            this.Text = "                Welcome " + txt+ "!";
            HomeDashboardShow();
        }

        public void HomeDashboardShow()
        {
            if (!adminDashboardPanel.Controls.Contains(HomeDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(HomeDashboardControl.Instance);
                HomeDashboardControl.Instance.Dock = DockStyle.Fill;
                HomeDashboardControl.Instance.BringToFront();
            }
            else
                HomeDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Home";
        }

        private void AdminTile_Click(object sender, EventArgs e)
        {
            if (!adminDashboardPanel.Controls.Contains(AdminDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(AdminDashboardControl.Instance);
                AdminDashboardControl.Instance.Dock = DockStyle.Fill;
                AdminDashboardControl.Instance.BringToFront();
            }
            else
                AdminDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Admin";
        }

        private void adminHomeLink_Click(object sender, EventArgs e)
        {
            HomeDashboardShow();
        }

        private void AdminControlManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
