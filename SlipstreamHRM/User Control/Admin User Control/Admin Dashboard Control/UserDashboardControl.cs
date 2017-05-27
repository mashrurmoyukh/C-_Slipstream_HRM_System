using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using SlipstreamHRM.DAL;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class UserDashboardControl : UserControl
    {
        private UserDashboardControl _instance;

        public UserDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private UserInformation userInformation;
        private UserDashboardHandler userDashboardHandler;

        public UserDashboardControl()
        {
            InitializeComponent();
        }

        private void UserDashboardControl_Load(object sender, EventArgs e)
        {
            userInformation = new UserInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            UserDataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            userDashboardHandler = new UserDashboardHandler();
            userDashboardHandler.AddUserForm();
            UserDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (userDataGridView.Rows.Count != 0 && userDataGridView.Rows != null)
            {
                userDashboardHandler = new UserDashboardHandler();
                string userName = userDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (userName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userDashboardHandler.DeleteUser(userName);
                    }
                }               
            }
            UserDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {                  
            if (userDataGridView.Rows.Count != 0 && userDataGridView.Rows != null)
            {
                string LogInId= " ";
                string a, b, c, d, f;
                a = userInformation.Username = userDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                b = userInformation.Userrole = userDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                c = userInformation.Employeename = userDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                d = userInformation.Status = userDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                f = userInformation.Region = userDataGridView.SelectedRows[0].Cells[4].Value.ToString();

                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select ID From LogInInfo Where Username = '{0}'", userInformation.Username), Connection);
                DataTable LogInInfomationTable = new DataTable();
                Adapter.Fill(LogInInfomationTable);
                Connection.Close();

                foreach (DataRow row in LogInInfomationTable.Rows)
                {
                    LogInId = row["ID"].ToString();
                }

                if (!string.IsNullOrEmpty(userInformation.Username))
                {
                    userDashboardHandler = new UserDashboardHandler();
                    userDashboardHandler.EditUserForm(a,b,c,d,f, LogInId);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UserDataShow();
        }

        public void UserDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Username as 'User Name', UserRole as 'User Role', EmployeeName as 'Employee Name', Status as 'Status', Region as 'Region' FROM UserInformation ORDER BY Username ASC", Connection);
                DataTable UserInfoTable = new DataTable();
                Adapter.Fill(UserInfoTable);
                userDataGridView.DataSource = UserInfoTable;

                userDataGridView.Columns[0].Width = 180;
                userDataGridView.Columns[1].Width = 180;
                userDataGridView.Columns[2].Width = 180;
                userDataGridView.Columns[3].Width = 178;
                userDataGridView.Columns[4].Width = 175;

                userDataGridView.BackgroundColor = Color.White;
                userDataGridView.BorderStyle = BorderStyle.Fixed3D;
                userDataGridView.Cursor = Cursors.Hand;

                userDataGridView.AllowUserToAddRows = false;
                userDataGridView.AllowUserToDeleteRows = false;
                userDataGridView.AllowUserToOrderColumns = true;
                userDataGridView.ReadOnly = true;
                userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                userDataGridView.MultiSelect = false;
                userDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                userDataGridView.AllowUserToResizeColumns = false;
                userDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                userDataGridView.AllowUserToResizeRows = false;
                userDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                userDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                userDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                userDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                userDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                userDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                userDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
