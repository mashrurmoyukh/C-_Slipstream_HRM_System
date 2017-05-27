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

namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.Report_Dashboard_Control
{
    public partial class AttendanceReportDashboardControl : UserControl
    {
        private AttendanceReportDashboardControl _instance;
        private SqlConnection Connection;

        public AttendanceReportDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AttendanceReportDashboardControl();
                return _instance;
            }
        }

        public AttendanceReportDashboardControl()
        {
            InitializeComponent();
        }

        private void AttendanceReportDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyEmployeeAttendanceDataShow();
        }

        public void MyEmployeeAttendanceDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName, InRecord, OutRecord, TotalDuration FROM EmployeeTimeAttendanceRecord", Connection);
                DataTable LeaveInfoTable = new DataTable();
                Adapter.Fill(LeaveInfoTable);
                attendanceListDataGridView.DataSource = LeaveInfoTable;

                attendanceListDataGridView.Columns[0].HeaderText = "Employee Name";
                attendanceListDataGridView.Columns[1].HeaderText = "Puch In";
                attendanceListDataGridView.Columns[2].HeaderText = "Punch Out";
                attendanceListDataGridView.Columns[3].HeaderText = "Total Duration";

                attendanceListDataGridView.Columns[0].Width = 230;
                attendanceListDataGridView.Columns[1].Width = 225;
                attendanceListDataGridView.Columns[2].Width = 225;
                attendanceListDataGridView.Columns[3].Width = 220;

                attendanceListDataGridView.BackgroundColor = Color.White;
                attendanceListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                attendanceListDataGridView.Cursor = Cursors.Hand;

                attendanceListDataGridView.AllowUserToAddRows = false;
                attendanceListDataGridView.AllowUserToDeleteRows = false;
                attendanceListDataGridView.AllowUserToOrderColumns = true;
                attendanceListDataGridView.ReadOnly = true;
                attendanceListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                attendanceListDataGridView.MultiSelect = false;
                attendanceListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                attendanceListDataGridView.AllowUserToResizeColumns = false;
                attendanceListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                attendanceListDataGridView.AllowUserToResizeRows = false;
                attendanceListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                attendanceListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                attendanceListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                attendanceListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                attendanceListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                attendanceListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                attendanceListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                attendanceListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                attendanceListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
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
