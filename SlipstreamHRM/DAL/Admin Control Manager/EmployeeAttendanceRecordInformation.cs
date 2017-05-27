using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.DAL.Admin_Control_Manager
{
    class EmployeeAttendanceRecordInformation
    {
        private string _userName;
        private DateTime _inDate;
        private DateTime _outDate;
        private float _totalHour;
        private SqlConnection Connection;

        public EmployeeAttendanceRecordInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string UserName
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

        public DateTime InDate
        {
            set
            {
                this._inDate = value;
            }
            get
            {
                return _inDate;
            }
        }

        public DateTime OutDate
        {
            set
            {
                this._outDate = value;
            }
            get
            {
                return _outDate;
            }
        }

        public float TotalHour
        {
            set
            {
                this._totalHour = value;
            }
            get
            {
                return _totalHour;
            }
        }

        public void PunchIn(string _empName)
        {
            string empName = "";
            string today = Convert.ToString(DateTime.Now);
            today = today.Substring(0, 9);
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("Select EmployeeName From EmployeeTimeAttendanceRecord Where (InRecord LIKE '%"+ today +"%')", Connection);
                DataTable EmployeeName = new DataTable();
                Adapter.Fill(EmployeeName);

                foreach (DataRow rows in EmployeeName.Rows)
                {
                    empName = rows["EmployeeName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "In Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            if (empName == _empName)
            {
                MessageBox.Show("Already Punched In", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlDataAdapter Adapter2 = new SqlDataAdapter("INSERT INTO EmployeeTimeAttendanceRecord (EmployeeName, InRecord) VALUES ('" + _empName + "', '" + Convert.ToString(_inDate) + "')", Connection);
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
                    MessageBox.Show(ex.Message, "Punch In Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void PunchOut(string _empName)
        {
            string empName = "";
            string today = Convert.ToString(DateTime.Now);
            today = today.Substring(0, 9);
            string inDate = "";
            string outDate = "";
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("Select EmployeeName, InRecord, OutRecord From EmployeeTimeAttendanceRecord Where (InRecord LIKE '%" + today + "%')", Connection);
                DataTable EmployeeName = new DataTable();
                Adapter.Fill(EmployeeName);

                foreach (DataRow rows in EmployeeName.Rows)
                {
                    empName = rows["EmployeeName"].ToString();
                    inDate = rows["InRecord"].ToString();
                    outDate = rows["OutRecord"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "In Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            if (!string.IsNullOrEmpty(inDate))
            {
                if (string.IsNullOrEmpty(outDate))
                {
                    double duration = (_outDate - _inDate).TotalHours;
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("UPDATE EmployeeTimeAttendanceRecord SET OutRecord = '{0}', TotalDuration = '{3}' WHERE (EmployeeName = '{1}' AND InRecord LIKE '%{2}%')", _outDate, empName, today, (float.Parse(duration.ToString()))), Connection);
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
                        MessageBox.Show(ex.Message, "Update Punch Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Already Punch Out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Puch In First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
