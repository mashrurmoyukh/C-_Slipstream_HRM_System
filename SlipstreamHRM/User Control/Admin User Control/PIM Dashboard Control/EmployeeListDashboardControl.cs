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

namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    public partial class EmployeeListDashboardControl : UserControl
    {
        private EmployeeListDashboardControl _instance;

        public EmployeeListDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeListDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private EmployeeListDashboardHandler employeeListDashboardHandler;

        public EmployeeListDashboardControl()
        {
            InitializeComponent();
        }

        private void EmployeeListDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            EmployeDataShow();
        }

        public void EmployeDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeID, Name, JobTitle, EmploymentStatus, Subunit, Location, Supervisor FROM EmployeeInformation ORDER BY EmployeeID ASC", Connection);
                DataTable EmployeeInfoTable = new DataTable();
                Adapter.Fill(EmployeeInfoTable);
                employeeDataGridView.DataSource = EmployeeInfoTable;

                employeeDataGridView.Columns[0].HeaderText = "ID";
                employeeDataGridView.Columns[1].HeaderText = "Name";
                employeeDataGridView.Columns[2].HeaderText = "Job Title";
                employeeDataGridView.Columns[3].HeaderText = "Employment Status";
                employeeDataGridView.Columns[4].HeaderText = "Sub Unit";
                employeeDataGridView.Columns[5].HeaderText = "Location";
                employeeDataGridView.Columns[6].HeaderText = "Supervisor";

                employeeDataGridView.Columns[0].Width = 50;
                employeeDataGridView.Columns[1].Width = 150;
                employeeDataGridView.Columns[2].Width = 130;
                employeeDataGridView.Columns[3].Width = 130;
                employeeDataGridView.Columns[4].Width = 150;
                employeeDataGridView.Columns[5].Width = 140;
                employeeDataGridView.Columns[6].Width = 140;

                employeeDataGridView.BackgroundColor = Color.White;
                employeeDataGridView.BorderStyle = BorderStyle.Fixed3D;
                employeeDataGridView.Cursor = Cursors.Hand;

                employeeDataGridView.AllowUserToAddRows = false;
                employeeDataGridView.AllowUserToDeleteRows = false;
                employeeDataGridView.AllowUserToOrderColumns = true;
                employeeDataGridView.ReadOnly = true;
                employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                employeeDataGridView.MultiSelect = false;
                employeeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                employeeDataGridView.AllowUserToResizeColumns = false;
                employeeDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                employeeDataGridView.AllowUserToResizeRows = false;
                employeeDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                employeeDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                employeeDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                employeeDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                employeeDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                employeeDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                employeeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                employeeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                employeeDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
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

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.Rows.Count != 0 && employeeDataGridView.Rows != null)
            {
                employeeListDashboardHandler = new EmployeeListDashboardHandler();
                string employeeID = employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (employeeID != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        employeeListDashboardHandler.DeleteEmployee(employeeID);
                    }
                }
            }
            EmployeDataShow();
        }
    }
}
