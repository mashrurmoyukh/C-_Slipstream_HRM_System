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

namespace SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control
{
    public partial class MyLeaveDashboardControl : UserControl
    {
        private SqlConnection Connection;
        private MyLeaveDashboardControl _instance;
        private string _userName;

        public MyLeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyLeaveDashboardControl(_userName);
                return _instance;
            }
        }  

        public MyLeaveDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void MyLeaveDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyLeaveDataShow();
        }

        public void MyLeaveDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName, LeaveType, StartDay, EndDay, NumberofDays, Status, Action FROM LeaveInformation WHERE EmployeeName in (SELECT EmployeeName FROM UserInformation WHERE Username = '"+_userName+"')", Connection);
                DataTable LeaveInfoTable = new DataTable();
                Adapter.Fill(LeaveInfoTable);
                myLeaveListDataGridView.DataSource = LeaveInfoTable;

                myLeaveListDataGridView.Columns[0].HeaderText = "Employee Name";
                myLeaveListDataGridView.Columns[1].HeaderText = "Leave Type";
                myLeaveListDataGridView.Columns[2].HeaderText = "From";
                myLeaveListDataGridView.Columns[3].HeaderText = "To";
                myLeaveListDataGridView.Columns[4].HeaderText = "Number of Days";
                myLeaveListDataGridView.Columns[5].HeaderText = "Status";
                myLeaveListDataGridView.Columns[6].HeaderText = "Action";

                myLeaveListDataGridView.Columns[0].Width = 150;
                myLeaveListDataGridView.Columns[1].Width = 170;
                myLeaveListDataGridView.Columns[2].Width = 150;
                myLeaveListDataGridView.Columns[3].Width = 150;
                myLeaveListDataGridView.Columns[4].Width = 130;
                myLeaveListDataGridView.Columns[5].Width = 120;
                myLeaveListDataGridView.Columns[6].Width = 130;

                myLeaveListDataGridView.BackgroundColor = Color.White;
                myLeaveListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myLeaveListDataGridView.Cursor = Cursors.Hand;

                myLeaveListDataGridView.AllowUserToAddRows = false;
                myLeaveListDataGridView.AllowUserToDeleteRows = false;
                myLeaveListDataGridView.AllowUserToOrderColumns = true;
                myLeaveListDataGridView.ReadOnly = true;
                myLeaveListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myLeaveListDataGridView.MultiSelect = false;
                myLeaveListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myLeaveListDataGridView.AllowUserToResizeColumns = false;
                myLeaveListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myLeaveListDataGridView.AllowUserToResizeRows = false;
                myLeaveListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myLeaveListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myLeaveListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myLeaveListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myLeaveListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myLeaveListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myLeaveListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myLeaveListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myLeaveListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Leave Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        } 
    }
}
