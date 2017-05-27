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

namespace SlipstreamHRM.User_Control.Employee_User_Control.Tiem_Dashboard_Control
{
    public partial class MyEmployeeAttendanceDashboardControl : UserControl
    {
        private MyEmployeeAttendanceDashboardControl _instance;
        private string _userName;
        private SqlConnection Connection;

        public MyEmployeeAttendanceDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyEmployeeAttendanceDashboardControl(_userName);
                return _instance;
            }
        }

        public MyEmployeeAttendanceDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void MyEmployeeAttendanceDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyTimeSheetsShow();
        }

        public void MyTimeSheetsShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName, InRecord, OutRecord, TotalDuration FROM EmployeeTimeAttendanceRecord WHERE EmployeeName IN (SELECT Name FROM EmployeeInformation WHERE Supervisor IN ( SELECT EmployeeName FROM UserInformation WHERE Username = '" + _userName + "'))", Connection);
                DataTable LeaveInfoTable = new DataTable();
                Adapter.Fill(LeaveInfoTable);
                myEmployeeAttendanceDataGridView.DataSource = LeaveInfoTable;

                myEmployeeAttendanceDataGridView.Columns[0].HeaderText = "Employee Name";
                myEmployeeAttendanceDataGridView.Columns[1].HeaderText = "Puch In";
                myEmployeeAttendanceDataGridView.Columns[2].HeaderText = "Punch Out";
                myEmployeeAttendanceDataGridView.Columns[3].HeaderText = "Total Duration";

                myEmployeeAttendanceDataGridView.Columns[0].Width = 320;
                myEmployeeAttendanceDataGridView.Columns[1].Width = 320;
                myEmployeeAttendanceDataGridView.Columns[2].Width = 320;
                myEmployeeAttendanceDataGridView.Columns[3].Width = 320; 

                myEmployeeAttendanceDataGridView.BackgroundColor = Color.White;
                myEmployeeAttendanceDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myEmployeeAttendanceDataGridView.Cursor = Cursors.Hand;

                myEmployeeAttendanceDataGridView.AllowUserToAddRows = false;
                myEmployeeAttendanceDataGridView.AllowUserToDeleteRows = false;
                myEmployeeAttendanceDataGridView.AllowUserToOrderColumns = true;
                myEmployeeAttendanceDataGridView.ReadOnly = true;
                myEmployeeAttendanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myEmployeeAttendanceDataGridView.MultiSelect = false;
                myEmployeeAttendanceDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myEmployeeAttendanceDataGridView.AllowUserToResizeColumns = false;
                myEmployeeAttendanceDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myEmployeeAttendanceDataGridView.AllowUserToResizeRows = false;
                myEmployeeAttendanceDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myEmployeeAttendanceDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myEmployeeAttendanceDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myEmployeeAttendanceDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myEmployeeAttendanceDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myEmployeeAttendanceDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myEmployeeAttendanceDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myEmployeeAttendanceDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myEmployeeAttendanceDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Employee Attendance Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
