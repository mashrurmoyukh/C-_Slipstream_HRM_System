using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    public partial class AddEmployeeDashboardControl : UserControl
    {
        private AddEmployeeDashboardControl _instance;

        public AddEmployeeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddEmployeeDashboardControl();
                return _instance;
            }
        }

        public AddEmployeeDashboardControl()
        {
            InitializeComponent();
        }

        private void AddEmployeeDashboardControl_Load(object sender, EventArgs e)
        {
            logInPanel.Hide();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked ==  true)
            {
                logInPanel.Show();
            }
            else
            {
                logInPanel.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeInformation employeeInformation = new EmployeeInformation();
            employeeInformation.FirstName = txtFirstName.Text;
            employeeInformation.LastName = txtLastName.Text;
            employeeInformation.MiddleName = txtMiddleName.Text;
            employeeInformation.EmployeeId = txtEmployeeID.Text;
            employeeInformation.Username = txtUsername.Text;
            employeeInformation.Password = txtPassword.Text;
            employeeInformation.ConfirmPassword = txtConfirmPassword.Text;
            employeeInformation.Status = statusComboBox.Text;
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                if (metroToggle1.Checked == true)
                {
                    if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text) && !string.IsNullOrEmpty(statusComboBox.Text))
                    {
                        if (txtPassword.Text == txtConfirmPassword.Text)
                        {
                            employeeInformation.AddEmployeeWithUsername();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Password Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Give Userinfo input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    employeeInformation.AddEmployee();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give all input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
    }
}
