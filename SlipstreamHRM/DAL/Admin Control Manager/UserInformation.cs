using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data;

namespace SlipstreamHRM.DAL
{
    class UserInformation
    {
        private SqlConnection  Connection;
        private string _userName;
        private string _userRole;
        private string _employeeName;
        private string _status;
        private string _region;
        private string _password;
        private string _confirmPassword;
        private bool check;

        public UserInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string Username
        {
            set
            {
                this._userName = value;
            }
            get
            {
                return _userName;
            }
        }

        public string Userrole
        {
            set
            {
                this._userRole = value;
            }
            get
            {
                return _userRole;
            }
        }

        public string Employeename
        {
            set
            {
                this._employeeName = value;
            }
            get
            {
                return _employeeName;
            }
        }

        public string Status
        {
            set
            {
                this._status = value;
            }
            get
            {
                return _status;
            }
        }

        public string Region
        {
            set
            {
                this._region = value;
            }
            get
            {
                return _region;
            }
        }

        public string Password
        {
            set
            {
                this._password = value;
            }
            get
            {
                return _password;
            }
        }

        public string ConfirmPassword
        {
            set
            {
                this._confirmPassword = value;
            }
            get
            {
                return _confirmPassword;
            }
        }

        public bool Check
        {
            get
            {
                return check;
            }
        }

        public void AddUser()
        {
            Connection.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select Count(*) From UserInformation Where Username COLLATE Latin1_General_CS_AS = '{0}'", _userName), Connection);
            DataTable UserInformationTable = new DataTable();
            Adapter.Fill(UserInformationTable);

            if (UserInformationTable.Rows[0][0].ToString() == "1")
            {
                Connection.Close();
                MessageBox.Show("Username Exist", "Save User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connection.Close();
                try
                {
                    Connection.Open();
                    SqlDataAdapter Adapter1 = new SqlDataAdapter("INSERT INTO UserInformation (Username, UserRole, EmployeeName, Status, Region) VALUES ('" + _userName + "','" + _userRole + "','" + _employeeName + "','" + _status + "','" + _region + "')", Connection);
                    Adapter1.SelectCommand.ExecuteNonQuery();
                    SqlDataAdapter Adapter2 = new SqlDataAdapter("INSERT INTO LogInInfo (Username, Password) VALUES ('" + _userName + "','" + _confirmPassword + "')", Connection);
                    Adapter2.SelectCommand.ExecuteNonQuery();
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.Successfull;
                    popup.TitleText = "Data Saved";
                    popup.ContentText = "Data Sucessfully Saved";
                    popup.ShowCloseButton = false;
                    popup.Popup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    this.check = true;
                    Connection.Close();
                }
            }
            
            
        }

        public void EditUser(int _userID)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("UPDATE UserInformation SET Username = '{0}', UserRole = '{1}', EmployeeName = '{2}', Status = '{3}', Region = '{4}' WHERE UserID = {5}", _userName, _userRole, _employeeName, _status, _region, _userID), Connection);
                Adapter1.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                this.check = true;
                Connection.Close();
            }        
        }

        public void EditUserWithPassword(int _userID, int LogInID)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("UPDATE UserInformation SET Username = '{0}', UserRole = '{1}', EmployeeName = '{2}', Status = '{3}', Region = '{4}' WHERE UserID = {5}", _userName, _userRole, _employeeName, _status, _region, _userID), Connection);
                Adapter1.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("UPDATE LogInInfo SET Username = '{0}', Password = '{1}' WHERE ID = {2}", _userName, _confirmPassword, LogInID), Connection);
                Adapter2.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                this.check = true;
                Connection.Close();
            }                                  
        }
    }
}
