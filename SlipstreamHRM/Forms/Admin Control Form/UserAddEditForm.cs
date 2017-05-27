using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;
using MetroFramework.Forms;

namespace SlipstreamHRM.Forms
{
    public partial class UserAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private UserInformation userInformation;
        private string UserID; 
        private string RegionName;
        private string EmpName;
        private string LogInID;

        public UserAddEditForm(string userID,string userName, string userRole, string employeeName, string status, string region, string LogInId)
        {
            InitializeComponent();
            this.UserID = userID;  
            this.Text = "Add User";

            if (!string.IsNullOrEmpty(UserID))
            {
                this.Text = "Edit User";
                txtUserName.Text = userName;
                comboBoxRole.Text = userRole;
                comboBoxStatus.Text = status;
                this.RegionName = region;
                this.EmpName = employeeName;
                this.LogInID = LogInId;
                metroCheckBox.Visible = true;
                metroPanel.Visible = false;
            }
        }

        private void UserAddEditForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            userInformation = new UserInformation();
            fillRegionComboBox();
            autoSuggestEmpName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _logInID = Convert.ToInt32(LogInID);
            int _userID = Convert.ToInt32(UserID);
            userInformation.Username = txtUserName.Text;
            userInformation.Userrole = comboBoxRole.Text;
            userInformation.Employeename = txtEmployeeName.Text;
            userInformation.Status = comboBoxStatus.Text;
            userInformation.Region = comboBoxRegion.Text;
            userInformation.Password = txtPassword.Text;
            userInformation.ConfirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(UserID))
            {
                if (!string.IsNullOrEmpty(userInformation.Username) && !string.IsNullOrEmpty(userInformation.Password) && !string.IsNullOrEmpty(userInformation.ConfirmPassword))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        userInformation.AddUser();
                        if (userInformation.Check == true)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Password Doesn't matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboBoxRegion.Items.Clear();
            }

            else
            {
                if (!string.IsNullOrEmpty(userInformation.Username))
                {
                    if (metroCheckBox.Checked == true)
                    {
                        if (!string.IsNullOrEmpty(userInformation.Password) && !string.IsNullOrEmpty(userInformation.ConfirmPassword))
                        {
                            if (txtPassword.Text == txtConfirmPassword.Text)
                            {
                                userInformation.EditUserWithPassword(_userID, _logInID);
                                if (userInformation.Check == true)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Password Doesn't matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Input Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                       
                    }
                    else
                    {
                        userInformation.EditUser(_userID);
                        if (userInformation.Check == true)
                        {
                            this.Close();
                        }
                    }
                }
                    
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                comboBoxRegion.Items.Clear();
            }                  
        }

        public void fillRegionComboBox()
        {
            try
            {
                string _RegionName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From RegionInformation ORDER BY RegionName"), Connection);
                DataTable RegionInfomationTable = new DataTable();
                Adapter.Fill(RegionInfomationTable);

                foreach (DataRow row in RegionInfomationTable.Rows)
                {
                    _RegionName = row["RegionName"].ToString();
                    comboBoxRegion.Items.Add(_RegionName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Region Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
                comboBoxRegion.Text = RegionName;
            }
        }

        public void autoSuggestEmpName()
        {
            try
            {
                string _EmployeeName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From EmployeeInformation ORDER BY Name"), Connection);
                DataTable EmployeeInfomationTable = new DataTable();
                Adapter.Fill(EmployeeInfomationTable);

                foreach (DataRow row in EmployeeInfomationTable.Rows)
                {
                    _EmployeeName = row["Name"].ToString();
                    txtEmployeeName.AutoCompleteCustomSource.Add(_EmployeeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
                txtEmployeeName.Text = EmpName;
            }
        }

        private void metroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox.Checked == true)
            {
                metroPanel.Visible = true;
            }
            else
            {
                metroPanel.Visible = false;
            }
        }
    }
}
