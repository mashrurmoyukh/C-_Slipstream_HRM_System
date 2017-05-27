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
using SlipstreamHRM.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    public partial class EmployeePersonalInformationDashboardControl : UserControl
    {
        private EmployeePersonalInformationDashboardControl _instance;

        public EmployeePersonalInformationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeePersonalInformationDashboardControl(_userName);
                return _instance;
            }
        }

        private SqlConnection Connection;
        private string _userName;
        private EmployeePersonalInformation employeePersonalInformation;


        public EmployeePersonalInformationDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void EmployeePersonalInformationDashboardControl_Load(object sender, EventArgs e)
        {
            employeePersonalInformation = new EmployeePersonalInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            fillRegionComboBox();
            EmployeePersonalInformationShow();
        }

        public void EmployeePersonalInformationShow()
        {
            string EmpName = "";
            string EmpID = "";
            string Gender = "";
            string NickName = "";
            string Smoker = "";
            string MarriedStatus = "";
            string Country = "";
            string MilitaryService = "";
            string LicenseExpireDate = "";
            string DOB = "";

            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmployeeID, Name, NickName, Gender, Smoker, MarriedStatus, Country, MilitaryService, LicenseExpireDate, DOB FROM EmployeeInformation WHERE Name IN (SELECT EmployeeName FROM Userinformation WHERE Username = '"+_userName+"')"), Connection);
                DataTable EmployeeInfomationTable = new DataTable();
                Adapter.Fill(EmployeeInfomationTable);

                foreach (DataRow row in EmployeeInfomationTable.Rows)
                {
                    EmpName = row["Name"].ToString();
                    EmpID = row["EmployeeID"].ToString();
                    Gender = row["Gender"].ToString();
                    NickName = row["NickName"].ToString();
                    Smoker = row["Smoker"].ToString();
                    MarriedStatus = row["MarriedStatus"].ToString();
                    Country = row["Country"].ToString();
                    MilitaryService = row["MilitaryService"].ToString();
                    LicenseExpireDate = row["LicenseExpireDate"].ToString();
                    DOB = row["DOB"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            txtEmployeeID.Text = EmpID;
            txtName.Text = EmpName;
            txtNickName.Text = NickName;
            txtMilitaryService.Text = MilitaryService;
            txtDOB.Text = DOB;
            comboMarriedStatus.Text = MarriedStatus;
            comboNationality.Text = Country;
            comboGender.Text = Gender;
            comboSmoker.Text = Smoker;
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
                    comboNationality.Items.Add(_RegionName);
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
            }
        }

        private void ChangePasswordLink_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changePasswordForm = new ChangePasswordForm(_userName))
            {
                changePasswordForm.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeePersonalInformation.EmpId = txtEmployeeID.Text;
            employeePersonalInformation.Name = txtName.Text;
            employeePersonalInformation.NickName = txtNickName.Text;
            employeePersonalInformation.Smoker = comboSmoker.Text;
            employeePersonalInformation.Country = comboNationality.Text;
            employeePersonalInformation.MarriedStatus = comboMarriedStatus.Text;
            employeePersonalInformation.Gender = comboGender.Text;
            employeePersonalInformation.DOB = txtDOB.Text;
            employeePersonalInformation.DrivingLicenseExpire = Convert.ToString(LicenseExpireDateTime.Text.ToString());
            employeePersonalInformation.MilitarySerivce = txtMilitaryService.Text;

            employeePersonalInformation.UpdatePersonalInfo();
        }
    }
}
