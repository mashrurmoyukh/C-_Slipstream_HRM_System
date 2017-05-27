using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.DAL.Admin_Control_Manager
{
    class EmployeePersonalInformation
    {
        private SqlConnection Connection;
        private string _name;
        private string _empId;
        private string _country;
        private string _marriedStatus;
        private string _drivingLicenseExpire;
        private string _gender;
        private string _dob;
        private string _nickName;
        private string _militaryService;
        private string _smoker;

        public EmployeePersonalInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string Name
        {
            set
            {
                this._name = value;
            }
            get
            {
                return _name;
            }
        }

        public string EmpId
        {
            set
            {
                this._empId = value;
            }
            get
            {
                return _empId;
            }
        }

        public string NickName
        {
            set
            {
                this._nickName = value;
            }
            get
            {
                return _nickName;
            }
        }

        public string DOB
        {
            set
            {
                this._dob = value;
            }
            get
            {
                return _dob;
            }
        }

        public string MilitarySerivce
        {
            set
            {
                this._militaryService = value;
            }
            get
            {
                return _militaryService;
            }
        }

        public string MarriedStatus
        {
            set
            {
                this._marriedStatus = value;
            }
            get
            {
                return _marriedStatus;
            }
        }

        public string DrivingLicenseExpire
        {
            set
            {
                this._drivingLicenseExpire = value;
            }
            get
            {
                return _drivingLicenseExpire;
            }
        }

        public string Country
        {
            set
            {
                this._country = value;
            }
            get
            {
                return _country;
            }
        }

        public string Smoker
        {
            set
            {
                this._smoker = value;
            }
            get
            {
                return _smoker;
            }
        }

        public string Gender
        {
            set
            {
                this._gender = value;
            }
            get
            {
                return _gender;
            }
        }

        public void UpdatePersonalInfo()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE EmployeeInformation SET Name = '{1}', NickName = '{2}', Gender = '{3}', Dob = '{4}', Smoker = '{5}', Country = '{6}', MilitaryService = '{7}', LicenseExpireDate = '{8}', MarriedStatus = '{9}' WHERE EmployeeID = '{0}'", _empId, _name, _nickName, _gender, _dob, _smoker, _country, _militaryService, _drivingLicenseExpire, _marriedStatus), Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Updated";
                popup.ContentText = "Data Sucessfully Updated";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
