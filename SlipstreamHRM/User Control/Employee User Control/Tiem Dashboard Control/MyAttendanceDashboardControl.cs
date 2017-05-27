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
    public partial class MyAttendanceDashboardControl : UserControl
    {
        private MyAttendanceDashboardControl _instance;
        private string _userName;
        private SqlConnection Connection;

        public MyAttendanceDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyAttendanceDashboardControl(_userName);
                return _instance;
            }
        }

        public MyAttendanceDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void MyAttendanceDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyAttendanceDataShow();
        }

        public void MyAttendanceDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName, InRecord, OutRecord, TotalDuration FROM EmployeeTimeAttendanceRecord WHERE EmployeeName in (SELECT EmployeeName FROM UserInformation WHERE Username = '" + _userName + "')", Connection);
                DataTable LeaveInfoTable = new DataTable();
                Adapter.Fill(LeaveInfoTable);
                myAttendanceListDataGridView.DataSource = LeaveInfoTable;

                myAttendanceListDataGridView.Columns[0].HeaderText = "Employee Name";
                myAttendanceListDataGridView.Columns[1].HeaderText = "Puch In";
                myAttendanceListDataGridView.Columns[2].HeaderText = "Punch Out";
                myAttendanceListDataGridView.Columns[3].HeaderText = "Total Duration";

                myAttendanceListDataGridView.Columns[0].Width = 320;
                myAttendanceListDataGridView.Columns[1].Width = 320;
                myAttendanceListDataGridView.Columns[2].Width = 320;
                myAttendanceListDataGridView.Columns[3].Width = 320;

                myAttendanceListDataGridView.BackgroundColor = Color.White;
                myAttendanceListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myAttendanceListDataGridView.Cursor = Cursors.Hand;

                myAttendanceListDataGridView.AllowUserToAddRows = false;
                myAttendanceListDataGridView.AllowUserToDeleteRows = false;
                myAttendanceListDataGridView.AllowUserToOrderColumns = true;
                myAttendanceListDataGridView.ReadOnly = true;
                myAttendanceListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myAttendanceListDataGridView.MultiSelect = false;
                myAttendanceListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myAttendanceListDataGridView.AllowUserToResizeColumns = false;
                myAttendanceListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myAttendanceListDataGridView.AllowUserToResizeRows = false;
                myAttendanceListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myAttendanceListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myAttendanceListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myAttendanceListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myAttendanceListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myAttendanceListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myAttendanceListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myAttendanceListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myAttendanceListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Attendance Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
