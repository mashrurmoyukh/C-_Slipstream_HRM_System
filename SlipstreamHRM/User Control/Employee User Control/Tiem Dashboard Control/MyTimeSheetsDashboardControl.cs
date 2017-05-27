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
    public partial class MyTimeSheetsDashboardControl : UserControl
    {
        private MyTimeSheetsDashboardControl _instance;
        private string _userName;
        private SqlConnection Connection;

        public MyTimeSheetsDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyTimeSheetsDashboardControl(_userName);
                return _instance;
            }
        }

        public MyTimeSheetsDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void MyTimeSheetsDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyEmployeeAttendanceDataShow();
        }

        public void MyEmployeeAttendanceDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CustomerName, Project, ProjectAdmin, StartDate, EndDate FROM ProjectInformation WHERE ProjectAdmin IN (SELECT EmployeeName FROM UserInformation WHERE Username = '" + _userName + "')", Connection);
                DataTable ProjectInfoTable = new DataTable();
                Adapter.Fill(ProjectInfoTable);
                myTimesheetDataGridView.DataSource = ProjectInfoTable;

                myTimesheetDataGridView.Columns[0].HeaderText = "Customer Name";
                myTimesheetDataGridView.Columns[1].HeaderText = "Project Name";
                myTimesheetDataGridView.Columns[2].HeaderText = "Project Admin";
                myTimesheetDataGridView.Columns[3].HeaderText = "From";
                myTimesheetDataGridView.Columns[4].HeaderText = "To";

                myTimesheetDataGridView.Columns[0].Width = 256;
                myTimesheetDataGridView.Columns[1].Width = 256;
                myTimesheetDataGridView.Columns[2].Width = 256;
                myTimesheetDataGridView.Columns[3].Width = 256;
                myTimesheetDataGridView.Columns[4].Width = 256;

                myTimesheetDataGridView.BackgroundColor = Color.White;
                myTimesheetDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myTimesheetDataGridView.Cursor = Cursors.Hand;

                myTimesheetDataGridView.AllowUserToAddRows = false;
                myTimesheetDataGridView.AllowUserToDeleteRows = false;
                myTimesheetDataGridView.AllowUserToOrderColumns = true;
                myTimesheetDataGridView.ReadOnly = true;
                myTimesheetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myTimesheetDataGridView.MultiSelect = false;
                myTimesheetDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myTimesheetDataGridView.AllowUserToResizeColumns = false;
                myTimesheetDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myTimesheetDataGridView.AllowUserToResizeRows = false;
                myTimesheetDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myTimesheetDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myTimesheetDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myTimesheetDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myTimesheetDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myTimesheetDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myTimesheetDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myTimesheetDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myTimesheetDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Timesheet Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
