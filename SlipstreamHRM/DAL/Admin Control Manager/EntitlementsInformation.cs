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
    class EntitlementsInformation
    {
        private SqlConnection Connection;

        string _empName;
        string _leaveType;
        string _from;
        string _to;
        string _comment;
        int _totalDays;

        public EntitlementsInformation()
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

        public string From
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

        public string To
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

        public int TotalDays
        {
            set
            {
                this._totalDays = value;
            }
            get
            {
                return _totalDays;
            }
        }

        public void AddEntitlements()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("INSERT INTO EntitlementsInformation (EmployeeName, ValidFrom, ValidUpto, TotalDays, EntitlementType, Comment) VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}')", _empName, _from, _to, _totalDays, _leaveType, _comment), Connection);
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
                MessageBox.Show(ex.Message, "Save Entitlements", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
