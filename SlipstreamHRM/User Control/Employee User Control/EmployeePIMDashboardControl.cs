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
    public partial class EmployeePIMDashboardControl : UserControl
    {
        private EmployeePIMDashboardControl _instance;
        private SqlConnection Connection;
        private string _userName;

        public EmployeePIMDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeePIMDashboardControl(_userName);
                return _instance;
            }
        }

        public EmployeePIMDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void EmployeePIMDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyEmployeeList();
        }

        public void MyEmployeeList()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Name FROM EmployeeInformation WHERE Supervisor IN ( SELECT EmployeeName FROM UserInformation WHERE Username = '" + _userName + "')", Connection);
                DataTable MyEmployeeInfoTable = new DataTable();
                Adapter.Fill(MyEmployeeInfoTable);
                myEmployeeListDataGridView.DataSource = MyEmployeeInfoTable;

                myEmployeeListDataGridView.Columns[0].HeaderText = "Employee Name";

                myEmployeeListDataGridView.Columns[0].Width = 210;

                myEmployeeListDataGridView.BackgroundColor = Color.White;
                myEmployeeListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myEmployeeListDataGridView.Cursor = Cursors.Hand;

                myEmployeeListDataGridView.AllowUserToAddRows = false;
                myEmployeeListDataGridView.AllowUserToDeleteRows = false;
                myEmployeeListDataGridView.AllowUserToOrderColumns = true;
                myEmployeeListDataGridView.ReadOnly = true;
                myEmployeeListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myEmployeeListDataGridView.MultiSelect = false;
                myEmployeeListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myEmployeeListDataGridView.AllowUserToResizeColumns = false;
                myEmployeeListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myEmployeeListDataGridView.AllowUserToResizeRows = false;
                myEmployeeListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myEmployeeListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myEmployeeListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myEmployeeListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myEmployeeListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myEmployeeListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myEmployeeListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myEmployeeListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myEmployeeListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
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

        private void myEmployeeListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myEmployeeListDataGridView.Rows.Count != 0 && myEmployeeListDataGridView.Rows != null)
            {
                pimPanel.Visible = true;
                string EMPNAME = myEmployeeListDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    Connection.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From EmployeeInformation Where Name ='{0}'", EMPNAME), Connection);
                    DataTable EmployeeInfomationTable = new DataTable();
                    Adapter.Fill(EmployeeInfomationTable);

                    foreach (DataRow row in EmployeeInfomationTable.Rows)
                    {
                        txtEmpID.Text = row["EmployeeID"].ToString();
                        txtEmployeeName.Text = row["Name"].ToString();
                        txtNickName.Text = row["NickName"].ToString();
                        txtJobTitle.Text = row["JobTitle"].ToString();
                        txtSubUnit.Text = row["SubUnit"].ToString();
                        txtEmpStatus.Text = row["EmploymentStatus"].ToString();
                        txtLocation.Text = row["Location"].ToString();
                        txtWorkShit.Text = row["WorkShift"].ToString();
                        txtMarriedStatus.Text = row["MarriedStatus"].ToString();
                        txtCountry.Text = row["Country"].ToString();
                        txtGender.Text = row["Gender"].ToString();
                        txtSmoker.Text = row["Smoker"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Employee Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
            }  
        }
    }
}
