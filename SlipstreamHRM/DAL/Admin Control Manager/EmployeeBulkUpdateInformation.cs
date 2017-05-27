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
    class EmployeeBulkUpdateInformation
    {
        private SqlConnection Connection;
        private string _empName;
        private string _supervisorName;
        private string _empStatus;
        private string _location;
        private string _subUnit;
        private string _include;
        private string _workShift;
        private string _jobTitle;
        private DateTime _joinedDate;

        public EmployeeBulkUpdateInformation()
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


        public string Supervisorname
        {
            set
            {
                this._supervisorName = value;
            }
            get
            {
                return _supervisorName;
            }
        }

        public string EmpStatus
        {
            set
            {
                this._empStatus = value;
            }
            get
            {
                return _empStatus;
            }
        }

        public string Location
        {
            set
            {
                this._location = value;
            }
            get
            {
                return _location;
            }
        }

        public string Include
        {
            set
            {
                this._include = value;
            }
            get
            {
                return _include;
            }
        }

        public DateTime JoinedDate
        {
            set
            {
                this._joinedDate = value;
            }
            get
            {
                return _joinedDate;
            }
        }

        public string JobTitle
        {
            set
            {
                this._jobTitle = value;
            }
            get
            {
                return _jobTitle;
            }
        }

        public string WorkShift
        {
            set
            {
                this._workShift = value;
            }
            get
            {
                return _workShift;
            }
        }

        public string SubUnit
        {
            set
            {
                this._subUnit = value;
            }
            get
            {
                return _subUnit;
            }
        }

        public void updateEmployee()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select Count(*) From EmployeeInformation Where Name COLLATE Latin1_General_CS_AS = '{0}'", _empName), Connection);
                DataTable EmployeeInformationTable = new DataTable();
                Adapter.Fill(EmployeeInformationTable);
                Connection.Close();

                if (EmployeeInformationTable.Rows[0][0].ToString() == "1")
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("Select Count(*) From UserInformation Where EmployeeName COLLATE Latin1_General_CS_AS = '{0}' AND UserRole = 'Supervisor'", _supervisorName), Connection);
                        DataTable UserInformationTable = new DataTable();
                        Adapter1.Fill(UserInformationTable);
                        Connection.Close();
                        if (UserInformationTable.Rows[0][0].ToString() == "1")
                        {
                            try
                            {
                                Connection.Open();
                                SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("UPDATE EmployeeInformation SET JobTitle = '{1}', EmploymentStatus = '{2}', Subunit = '{3}', Location = '{4}', Supervisor = '{5}', Include = '{6}', JoinedDate = '{7}', WorkShift = '{8}' WHERE Name = '{0}'", _empName, _jobTitle, _empStatus, _subUnit, _location, _supervisorName,_include, _joinedDate, _workShift), Connection);
                                Adapter2.SelectCommand.ExecuteNonQuery();
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Properties.Resources.Successfull;
                                popup.TitleText = "Data Updated";
                                popup.ContentText = "Data Sucessfully Updated";
                                popup.ShowCloseButton = false;
                                popup.Popup();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Update Bulk Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Connection.Close();
                            }
                            finally
                            {
                                Connection.Close();
                            }
                        }
                        else
                        {
                            try
                            {
                                Connection.Open();
                                SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("UPDATE EmployeeInformation SET JobTitle = '{1}', EmploymentStatus = '{2}', Subunit = '{3}', Location = '{4}', Supervisor = '{5}', Include = '{6}', JoinedDate = '{7}', WorkShift = '{8}' WHERE Name = '{0}'", _empName, _jobTitle, _empStatus, _subUnit, _location, " ", _include, _joinedDate, _workShift), Connection);
                                Adapter2.SelectCommand.ExecuteNonQuery();
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Properties.Resources.Successfull;
                                popup.TitleText = "Data Updated";
                                popup.ContentText = "Data Sucessfully Updated";
                                popup.ShowCloseButton = false;
                                popup.Popup();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Update Bulk Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Connection.Close();
                            }
                            finally
                            {
                                Connection.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Supervisor Update Bulk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }              
                }
                else
                {
                    MessageBox.Show("Employee Doesn't Exist", "Save User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bulk Update  Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
