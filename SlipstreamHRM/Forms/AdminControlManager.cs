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
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.Forms
{
    public partial class AdminControlManager : MetroFramework.Forms.MetroForm
    {
        private string userName;
        public AdminControlManager(string txt)
        {
            InitializeComponent();
            this.Text = "                Welcome Admin!";
            this.userName = txt;
            HomeDashboardShow();
        }

        public void HomeDashboardShow()
        {
            HomeDashboardControl homeDashboardControl = new HomeDashboardControl();

            if (!adminDashboardPanel.Controls.Contains(homeDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Clear();
                adminDashboardPanel.Controls.Add(homeDashboardControl.Instance);
                homeDashboardControl.Instance.Dock = DockStyle.Fill;
                homeDashboardControl.Instance.BringToFront();
            }
            else
                homeDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Home";
        }

        private void AdminTile_Click(object sender, EventArgs e)
        {
            AdminDashboardControl adminDashboardControl = new AdminDashboardControl();

            if (!adminDashboardPanel.Controls.Contains(adminDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(adminDashboardControl.Instance);
                adminDashboardControl.Instance.Dock = DockStyle.Fill;
                adminDashboardControl.Instance.BringToFront();
            }
            else
                adminDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Admin";
        }

        private void LeaveTile_Click(object sender, EventArgs e)
        {
            LeaveDashboardControl leaveDashboardControl = new LeaveDashboardControl();

            if (!adminDashboardPanel.Controls.Contains(leaveDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(leaveDashboardControl.Instance);
                leaveDashboardControl.Instance.Dock = DockStyle.Fill;
                leaveDashboardControl.Instance.BringToFront();
            }
            else
                leaveDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Leave";
        }

        private void PimTile_Click(object sender, EventArgs e)
        {
            PIMDashboardControl pimDashboardControl = new PIMDashboardControl();

            if (!adminDashboardPanel.Controls.Contains(pimDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(pimDashboardControl.Instance);
                pimDashboardControl.Instance.Dock = DockStyle.Fill;
                pimDashboardControl.Instance.BringToFront();
            }
            else
                pimDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "PIM";
        }

        private void TimeTile_Click(object sender, EventArgs e)
        {
            TimeDashboardControl timeDashboardControl = new TimeDashboardControl();
            if (!adminDashboardPanel.Controls.Contains(timeDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(timeDashboardControl.Instance);
                timeDashboardControl.Instance.Dock = DockStyle.Fill;
                timeDashboardControl.Instance.BringToFront();
            }
            else
                timeDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Time";
        }

        private void RequirementTile_Click(object sender, EventArgs e)
        {
            RequirementDashboardControl requirementDashboardControl = new RequirementDashboardControl();

            if (!adminDashboardPanel.Controls.Contains(requirementDashboardControl.Instance))
            {
                adminDashboardPanel.Controls.Add(requirementDashboardControl.Instance);
                requirementDashboardControl.Instance.Dock = DockStyle.Fill;
                requirementDashboardControl.Instance.BringToFront();
            }
            else
                requirementDashboardControl.Instance.BringToFront();
            this.ModuleNameShowLink.Text = "Requirement";
        }

        private void adminHomeLink_Click(object sender, EventArgs e)
        {
            HomeDashboardShow();
        }

        private void AdminControlManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Log Out";
            popup.ContentText = "Successfully Loged Out";
            popup.ShowCloseButton = false;
            popup.Popup();
        }

        private void ChangePasswordLink_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changePasswordForm = new ChangePasswordForm(userName))
            {
                changePasswordForm.ShowDialog();
            }
        }
    }
}
