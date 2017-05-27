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

namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    public partial class EmployeeDisciplineDashboardControl : UserControl
    {
        private EmployeeDisciplineDashboardControl _instance;

        public EmployeeDisciplineDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeDisciplineDashboardControl(_userName);
                return _instance;
            }
        }

        private SqlConnection Connection;
        private string _userName;

        public EmployeeDisciplineDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void EmployeeDisciplineDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            disciplineCaseDataGridView.Visible = false;
            DataGridViewStyle();
        }        

        public void DisciplineCaseDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DisciplineID, EmployeeName, CaseName, Description, CreatedBy, CreatedOn FROM DisciplineCaseInformation WHERE Status = 1 ORDER BY EmployeeName ASC", Connection);
                DataTable DisciplineInfoTable = new DataTable();
                Adapter.Fill(DisciplineInfoTable);
                disciplineCaseDataGridView.DataSource = DisciplineInfoTable;

                disciplineCaseDataGridView.Columns[0].HeaderText = "ID";
                disciplineCaseDataGridView.Columns[1].HeaderText = "Employee Name";
                disciplineCaseDataGridView.Columns[2].HeaderText = "Case Name";
                disciplineCaseDataGridView.Columns[3].HeaderText = "Description";
                disciplineCaseDataGridView.Columns[4].HeaderText = "Created By";
                disciplineCaseDataGridView.Columns[5].HeaderText = "Created On";

                disciplineCaseDataGridView.Columns[0].Width = 50;
                disciplineCaseDataGridView.Columns[1].Width = 150;
                disciplineCaseDataGridView.Columns[2].Width = 170;
                disciplineCaseDataGridView.Columns[3].Width = 305;
                disciplineCaseDataGridView.Columns[4].Width = 150;
                disciplineCaseDataGridView.Columns[5].Width = 140;
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

        public void UserDisciplineCaseDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT DisciplineID, EmployeeName, CaseName, Description, CreatedBy, CreatedOn FROM DisciplineCaseInformation WHERE EmployeeName in (SELECT EmployeeName FROM UserInformation WHERE Username = '"+_userName+"')", Connection);
                DataTable DisciplineInfoTable = new DataTable();
                Adapter.Fill(DisciplineInfoTable);
                disciplineCaseDataGridView.DataSource = DisciplineInfoTable;

                disciplineCaseDataGridView.Columns[0].HeaderText = "ID";
                disciplineCaseDataGridView.Columns[1].HeaderText = "Employee Name";
                disciplineCaseDataGridView.Columns[2].HeaderText = "Case Name";
                disciplineCaseDataGridView.Columns[3].HeaderText = "Description";
                disciplineCaseDataGridView.Columns[4].HeaderText = "Created By";
                disciplineCaseDataGridView.Columns[5].HeaderText = "Created On";

                disciplineCaseDataGridView.Columns[0].Width = 50;
                disciplineCaseDataGridView.Columns[1].Width = 150;
                disciplineCaseDataGridView.Columns[2].Width = 170;
                disciplineCaseDataGridView.Columns[3].Width = 305;
                disciplineCaseDataGridView.Columns[4].Width = 150;
                disciplineCaseDataGridView.Columns[5].Width = 140;
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

        private void AllDisciplineCaseTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            disciplineCaseDataGridView.Visible = true;
            DisciplineCaseDataShow();
        }

        private void ownDisciplineCases_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            disciplineCaseDataGridView.Visible = true;
            UserDisciplineCaseDataShow();
        }

        public void DataGridViewStyle()
        {
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
    }
}
