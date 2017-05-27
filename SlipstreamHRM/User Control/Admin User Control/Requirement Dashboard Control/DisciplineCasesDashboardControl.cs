using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.BAL.Admin_Control_Manager;
using System.Data.SqlClient;

namespace SlipstreamHRM.User_Control.Requirement_Dashboard_Control
{
    public partial class DisciplineCasesDashboardControl : UserControl
    {
        private DisciplineCasesDashboardControl _instance;

        public DisciplineCasesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DisciplineCasesDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private DisciplineCaseDashboardHandler disciplineCaseDashboardHandler;

        public DisciplineCasesDashboardControl()
        {
            InitializeComponent();
        }

        private void DisciplineCasesDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            disciplineCaseDashboardHandler = new DisciplineCaseDashboardHandler();
            DisciplineCaseDataShow();
        }

        public void DisciplineCaseDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DisciplineID, EmployeeName, CaseName, Description, CreatedBy, CreatedOn FROM DisciplineCaseInformation WHERE Status = 1 ORDER BY EmployeeName ASC", Connection);
                DataTable EmployeeInfoTable = new DataTable();
                Adapter.Fill(EmployeeInfoTable);
                disciplineCaseDataGridView.DataSource = EmployeeInfoTable;

                disciplineCaseDataGridView.Columns[0].HeaderText = "ID";
                disciplineCaseDataGridView.Columns[1].HeaderText = "Employee Name";
                disciplineCaseDataGridView.Columns[2].HeaderText = "Case Name";
                disciplineCaseDataGridView.Columns[3].HeaderText = "Description";
                disciplineCaseDataGridView.Columns[4].HeaderText = "Created By";
                disciplineCaseDataGridView.Columns[5].HeaderText = "Created On";

                disciplineCaseDataGridView.Columns[0].Width = 30;
                disciplineCaseDataGridView.Columns[1].Width = 135;
                disciplineCaseDataGridView.Columns[2].Width = 160;
                disciplineCaseDataGridView.Columns[3].Width = 350;
                disciplineCaseDataGridView.Columns[4].Width = 100;
                disciplineCaseDataGridView.Columns[5].Width = 120;

                disciplineCaseDataGridView.BackgroundColor = Color.White;
                disciplineCaseDataGridView.BorderStyle = BorderStyle.Fixed3D;
                disciplineCaseDataGridView.Cursor = Cursors.Hand;

                disciplineCaseDataGridView.AllowUserToAddRows = false;
                disciplineCaseDataGridView.AllowUserToDeleteRows = false;
                disciplineCaseDataGridView.AllowUserToOrderColumns = true;
                disciplineCaseDataGridView.ReadOnly = true;
                disciplineCaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                disciplineCaseDataGridView.MultiSelect = false;
                disciplineCaseDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                disciplineCaseDataGridView.AllowUserToResizeColumns = false;
                disciplineCaseDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                disciplineCaseDataGridView.AllowUserToResizeRows = false;
                disciplineCaseDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                disciplineCaseDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                disciplineCaseDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                disciplineCaseDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                disciplineCaseDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                disciplineCaseDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                disciplineCaseDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                disciplineCaseDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                disciplineCaseDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
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

        private void AddTile_Click(object sender, EventArgs e)
        {
            disciplineCaseDashboardHandler.AddDisciplineCase();
            DisciplineCaseDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (disciplineCaseDataGridView.Rows.Count != 0 && disciplineCaseDataGridView.Rows != null)
            {
                disciplineCaseDashboardHandler = new DisciplineCaseDashboardHandler();
                int disciplineID = Convert.ToInt32(disciplineCaseDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (disciplineID.ToString() != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to Make the progress clear?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        disciplineCaseDashboardHandler.EditDisciplineCase(disciplineID);
                    }
                }
            }
            DisciplineCaseDataShow();
        }
    }
}
