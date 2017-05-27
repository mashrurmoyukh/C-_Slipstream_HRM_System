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
    public partial class EntitlementsDashboardControl : UserControl
    {
        private EntitlementsDashboardControl _instance;
        private SqlConnection Connection;
        private string _userName;

        public EntitlementsDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EntitlementsDashboardControl(_userName);
                return _instance;
            }
        }

        public EntitlementsDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void EntitlementsDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            MyEntitlementsDataShow();
        }

        public void MyEntitlementsDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName AS 'Employee Name', ValidFrom AS 'Valid From', ValidUpto AS 'Valid Upto', TotalDays AS 'Total Days', EntitlementType AS 'Entitlement Type' FROM EntitlementsInformation WHERE EmployeeName in (SELECT EmployeeName FROM UserInformation WHERE Username = '" + _userName + "')", Connection);
                DataTable EntitlementsInfoTable = new DataTable();
                Adapter.Fill(EntitlementsInfoTable);
                myEntitlementsListDataGridView.DataSource = EntitlementsInfoTable;

                myEntitlementsListDataGridView.Columns[0].Width = 200;
                myEntitlementsListDataGridView.Columns[1].Width = 200;
                myEntitlementsListDataGridView.Columns[2].Width = 200;
                myEntitlementsListDataGridView.Columns[3].Width = 200;
                myEntitlementsListDataGridView.Columns[4].Width = 200;

                myEntitlementsListDataGridView.BackgroundColor = Color.White;
                myEntitlementsListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                myEntitlementsListDataGridView.Cursor = Cursors.Hand;

                myEntitlementsListDataGridView.AllowUserToAddRows = false;
                myEntitlementsListDataGridView.AllowUserToDeleteRows = false;
                myEntitlementsListDataGridView.AllowUserToOrderColumns = true;
                myEntitlementsListDataGridView.ReadOnly = true;
                myEntitlementsListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                myEntitlementsListDataGridView.MultiSelect = false;
                myEntitlementsListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                myEntitlementsListDataGridView.AllowUserToResizeColumns = false;
                myEntitlementsListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                myEntitlementsListDataGridView.AllowUserToResizeRows = false;
                myEntitlementsListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                myEntitlementsListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                myEntitlementsListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                myEntitlementsListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                myEntitlementsListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                myEntitlementsListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                myEntitlementsListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                myEntitlementsListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                myEntitlementsListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entitlements Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
