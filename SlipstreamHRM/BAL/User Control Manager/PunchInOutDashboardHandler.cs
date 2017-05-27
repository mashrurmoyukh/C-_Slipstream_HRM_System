using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.BAL.User_Control_Manager
{
    class PunchInOutDashboardHandler
    {
        private SqlConnection Connection;
        private EmployeeAttendanceRecordInformation employeeAttendanceRecordInformation;

        public PunchInOutDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            employeeAttendanceRecordInformation = new EmployeeAttendanceRecordInformation();
        }

        public void punchIn(string userName, DateTime nowDateTime)
        {
            string empName = "";
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmployeeName From UserInformation Where Username='{0}'", userName), Connection);
                DataTable UserInfomationTable = new DataTable();
                Adapter.Fill(UserInfomationTable);

                foreach (DataRow row in UserInfomationTable.Rows)
                {
                    empName = row["EmployeeName"].ToString();
                }

                employeeAttendanceRecordInformation.InDate = nowDateTime;
                employeeAttendanceRecordInformation.PunchIn(empName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Punch In Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void punchOut(string userName, DateTime nowDateTime)
        {
            string empName = "";
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmployeeName From UserInformation Where Username='{0}'", userName), Connection);
                DataTable UserInfomationTable = new DataTable();
                Adapter.Fill(UserInfomationTable);

                foreach (DataRow row in UserInfomationTable.Rows)
                {
                    empName = row["EmployeeName"].ToString();
                }

                employeeAttendanceRecordInformation.OutDate = nowDateTime;
                employeeAttendanceRecordInformation.PunchOut(empName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Punch Out Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
