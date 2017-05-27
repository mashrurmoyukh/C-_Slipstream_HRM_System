using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    public partial class BulkUpdateDashboardControl : UserControl
    {
        private BulkUpdateDashboardControl _instance;

        public BulkUpdateDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BulkUpdateDashboardControl();
                return _instance;
            }
        }

        int count = 1;
        private SqlConnection Connection;
        private EmployeeBulkUpdateDashboardHandler employeeBulkUpdateHandler;

        public BulkUpdateDashboardControl()
        {
            InitializeComponent();
        }

        private void BulkUpdateDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            employeeBulkUpdateHandler = new EmployeeBulkUpdateDashboardHandler();
            autoSuggestEmpName();
            autoSuggestSupervisorName();
            fillLocationComboBox();
            fillJobTitleComboBox();
            fillWorkShiftComboBox();
            fillEmployeeStatusComboBox();
        }

        private void SelectEmployeesHavingLink_Click(object sender, EventArgs e)
        {
            if (count % 2 == 1)
            {
                pictureBox.Image = Properties.Resources.DownArrow_Icon;
                BulkPanel.Hide();
                count++;
            }
            else
            {
                pictureBox.Image = Properties.Resources.UpArrow_Icon;
                BulkPanel.Show();
                count++;
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
            }
        }

        public void autoSuggestSupervisorName()
        {
            try
            {
                string _EmployeeName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmployeeName From UserInformation WHERE UserRole = 'Supervisor'  ORDER BY EmployeeName"), Connection);
                DataTable UserInfomationTable = new DataTable();
                Adapter.Fill(UserInfomationTable);

                foreach (DataRow row in UserInfomationTable.Rows)
                {
                    _EmployeeName = row["EmployeeName"].ToString();
                    txtSupervisorName.AutoCompleteCustomSource.Add(_EmployeeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Supervisor Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillLocationComboBox()
        {
            try
            {
                string _LocationName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From LocationInformation ORDER BY Location"), Connection);
                DataTable LocationInfomationTable = new DataTable();
                Adapter.Fill(LocationInfomationTable);

                foreach (DataRow row in LocationInfomationTable.Rows)
                {
                    _LocationName = row["Location"].ToString();
                    comboLocation.Items.Add(_LocationName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Location Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillJobTitleComboBox()
        {
            try
            {
                string _JobTitleName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From JobTitleInformation ORDER BY JobTitle"), Connection);
                DataTable JobTitleInfomationTable = new DataTable();
                Adapter.Fill(JobTitleInfomationTable);

                foreach (DataRow row in JobTitleInfomationTable.Rows)
                {
                    _JobTitleName = row["JobTitle"].ToString();
                    comboJobTitle.Items.Add(_JobTitleName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "JobTitle Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillWorkShiftComboBox()
        {
            try
            {
                string _WorkShiftName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From WorkShiftInformation ORDER BY WorkShift"), Connection);
                DataTable WorkShiftInfomationTable = new DataTable();
                Adapter.Fill(WorkShiftInfomationTable);

                foreach (DataRow row in WorkShiftInfomationTable.Rows)
                {
                    _WorkShiftName = row["WorkShift"].ToString();
                    comboWorkShift.Items.Add(_WorkShiftName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Work Shift Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillEmployeeStatusComboBox()
        {
            try
            {
                string _EmployeeStatusName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From EmploymentStatusInformation ORDER BY EmploymentStatus"), Connection);
                DataTable EmployeeStatusInfomationTable = new DataTable();
                Adapter.Fill(EmployeeStatusInfomationTable);

                foreach (DataRow row in EmployeeStatusInfomationTable.Rows)
                {
                    _EmployeeStatusName = row["EmploymentStatus"].ToString();
                    comboEmployeeStatus.Items.Add(_EmployeeStatusName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Employee Status Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnBulkUpdate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                string empName = txtEmployeeName.Text.ToString();
                string supName = txtSupervisorName.Text.ToString();
                string title = comboJobTitle.Text.ToString();
                string status = comboEmployeeStatus.Text.ToString();
                string subUnit = comboSubunit.Text.ToString();
                string workShift = comboWorkShift.Text.ToString();
                string location = comboLocation.Text.ToString();
                string include = comboInclude.Text.ToString();
                DateTime joinedDate = Convert.ToDateTime(dateTimeJoined.Text);

                employeeBulkUpdateHandler.saveBulkUpdate(empName, supName, status, subUnit, title, include, location, workShift, joinedDate);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Input Employeename", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
