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
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    public partial class LeaveListDashboardControl : UserControl
    {
        private SqlConnection Connection;
        private LeaveListDashboardControl _instance;

        public LeaveListDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LeaveListDashboardControl();
                return _instance;
            }
        }

        public LeaveListDashboardControl()
        {
            InitializeComponent();
            
        }

        private void LeaveListDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            LeaveDataShow();
        }

        public void LeaveDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT LeaveID, EmployeeName, LeaveType, StartDay, EndDay, NumberofDays, Status FROM LeaveInformation WHERE Status = 'In Progress'", Connection);
                DataTable LeaveInfoTable = new DataTable();
                Adapter.Fill(LeaveInfoTable);
                leaveListDataGridView.DataSource = LeaveInfoTable;

                leaveListDataGridView.Columns[0].HeaderText = "ID";
                leaveListDataGridView.Columns[1].HeaderText = "Employee Name";
                leaveListDataGridView.Columns[2].HeaderText = "Leave Type";
                leaveListDataGridView.Columns[3].HeaderText = "From";
                leaveListDataGridView.Columns[4].HeaderText = "To";
                leaveListDataGridView.Columns[5].HeaderText = "Number of Days";
                leaveListDataGridView.Columns[6].HeaderText = "Status";

                leaveListDataGridView.Columns[0].Width = 30;
                leaveListDataGridView.Columns[1].Width = 150;
                leaveListDataGridView.Columns[2].Width = 160;
                leaveListDataGridView.Columns[3].Width = 150;
                leaveListDataGridView.Columns[4].Width = 150;
                leaveListDataGridView.Columns[5].Width = 120;
                leaveListDataGridView.Columns[6].Width = 130;

                leaveListDataGridView.BackgroundColor = Color.White;
                leaveListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                leaveListDataGridView.Cursor = Cursors.Hand;

                leaveListDataGridView.AllowUserToAddRows = false;
                leaveListDataGridView.AllowUserToDeleteRows = false;
                leaveListDataGridView.AllowUserToOrderColumns = true;
                leaveListDataGridView.ReadOnly = true;
                leaveListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                leaveListDataGridView.MultiSelect = false;
                leaveListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                leaveListDataGridView.AllowUserToResizeColumns = false;
                leaveListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                leaveListDataGridView.AllowUserToResizeRows = false;
                leaveListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                leaveListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                leaveListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                leaveListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                leaveListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                leaveListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                leaveListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                leaveListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                leaveListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void leaveListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeName.Text = leaveListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtLeaveType.Text = leaveListDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtFrom.Text = leaveListDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtTo.Text = leaveListDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void SelectActionTile_Click(object sender, EventArgs e)
        {
            if (leaveListDataGridView.Rows.Count != 0 && leaveListDataGridView.Rows != null)
            {
                LeaveListDashboardHandler leaveListDashboardHandler = new LeaveListDashboardHandler();

                int leaveID = Convert.ToInt32(leaveListDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (leaveID.ToString() != null)
                {
                    leaveListDashboardHandler.SelectAction(leaveID);
                }
            }
            LeaveDataShow();
        }
    }
}
