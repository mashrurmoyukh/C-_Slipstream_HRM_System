using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class EmployeeListDashboardHandler
    {
        private SqlConnection Connection;
        private string empID;

        public EmployeeListDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void DeleteEmployee(string employeeID)
        {
            this.empID = employeeID;
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM EmployeeInformation WHERE EmployeeID = '" + empID +"'", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter Adapter1 = new SqlDataAdapter("DELETE FROM LogInInfo WHERE Username IN(SELECT Username FROM UserInformation WHERE EmpId IN(SELECT EmpID FROM UserInformation WHERE EmpID = '" + empID + "'))", Connection);
                Adapter1.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter Adapter2 = new SqlDataAdapter("DELETE FROM UserInformation WHERE EmpID = '" + empID + "'", Connection);
                Adapter2.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Delted";
                popup.ContentText = "Data Sucessfully Deleted";
                popup.ShowCloseButton = false;
                popup.Popup();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }        
        }
    }
}
