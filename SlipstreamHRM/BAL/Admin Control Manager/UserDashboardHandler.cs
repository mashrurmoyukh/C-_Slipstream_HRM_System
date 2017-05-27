using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.Forms.Admin_Control_Form;
using SlipstreamHRM.Forms;
using System.Data.SqlClient;
using System.Data;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class UserDashboardHandler
    {
        private SqlConnection Connection;
        private string userID;

        public UserDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddUserForm()
        {
            using (UserAddEditForm userAddEditForm = new UserAddEditForm(null, null, null, null, null, null, null))
            {
                userAddEditForm.ShowDialog();
            }
        }

        public void DeleteUser(string Username)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM LogInInfo WHERE Username IN(SELECT Username FROM UserInformation WHERE Username = '" + Username + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter Adapter1 = new SqlDataAdapter("DELETE FROM UserInformation WHERE UserID IN(SELECT UserID FROM UserInformation WHERE UserName = '" + Username + "')", Connection);
                Adapter1.SelectCommand.ExecuteNonQuery();        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Data Delted";
            popup.ContentText = "Data Sucessfully Deleted";
            popup.ShowCloseButton = false;
            popup.Popup();
        }

        public void EditUserForm(string Username, string Userrole, string Employeename, string Status, string Region, string LogInId)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select UserID From UserInformation Where Username='{0}'", Username), Connection);
                DataTable UserInfomationTable = new DataTable();
                Adapter.Fill(UserInfomationTable);

                foreach (DataRow row in UserInfomationTable.Rows)
                {
                    userID = Convert.ToString(row["UserID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            using (UserAddEditForm userAddEditForm = new UserAddEditForm(userID, Username, Userrole, Employeename, Status, Region, LogInId))
            {
                userAddEditForm.ShowDialog();
            }
        }
    }
}
