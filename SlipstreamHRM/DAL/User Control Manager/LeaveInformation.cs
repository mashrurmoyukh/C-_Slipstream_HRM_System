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
    class LeaveInformation
    {
        private SqlConnection Connection;

        string _empName;
        string _leaveType;
        DateTime _from;
        DateTime _to;
        string _comment;

        public LeaveInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string EmpName
        {
            set
            {
                this._empName = value;
            }
            get
            {
                return _empName;
            }
        }

        public string LeaveType
        {
            set
            {
                this._leaveType = value;
            }
            get
            {
                return _leaveType;
            }
        }

        public DateTime From
        {
            set
            {
                this._from = value;
            }
            get
            {
                return _from;
            }
        }

        public DateTime To
        {
            set
            {
                this._to = value;
            }
            get
            {
                return _to;
            }
        }

        public string Comment
        {
            set
            {
                this._comment = value;
            }
            get
            {
                return _comment;
            }
        }

        public void AddLeave()
        {
            string _status = "In Progress";
            string _days = (_to - _from).TotalDays.ToString();
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("INSERT INTO LeaveInformation (EmployeeName, LeaveType, StartDay, EndDay, NumberofDays, Comments, Status) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", _empName, _leaveType, _from, _to, _days, _comment, _status), Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Leave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void AssignLeave()
        {
            string _days = (_to - _from).TotalDays.ToString();
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("INSERT INTO LeaveInformation (EmployeeName, LeaveType, StartDay, EndDay, NumberofDays, Comments, Status, Action) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", _empName, _leaveType, _from, _to, _days, _comment, "Progress", "Approved"), Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Leave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
