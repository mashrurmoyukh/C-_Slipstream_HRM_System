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

namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.ProjectInfo_Dashboard_Control
{
    public partial class CustomerDashboardControl : UserControl
    {
        private CustomerDashboardControl _instance;
        private CustomerDashboardHandler customerDashboardHandler;
        private SqlConnection Connection;

        public CustomerDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerDashboardControl();
                return _instance;
            }
        }

        public CustomerDashboardControl()
        {
            InitializeComponent();
        }

        private void CustomerDashboardControl_Load(object sender, EventArgs e)
        {
            customerDashboardHandler = new CustomerDashboardHandler();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            CustomerDataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            customerDashboardHandler.AddCustomerForm();
            CustomerDataShow();
        }

        public void CustomerDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Customer, Description FROM CustomerInformation ORDER BY Customer ASC", Connection);
                DataTable CustomerInfoTable = new DataTable();
                Adapter.Fill(CustomerInfoTable);
                customerDataGridView.DataSource = CustomerInfoTable;

                customerDataGridView.Columns[0].Width = 200;
                customerDataGridView.Columns[1].Width = 700;

                customerDataGridView.BackgroundColor = Color.White;
                customerDataGridView.BorderStyle = BorderStyle.Fixed3D;
                customerDataGridView.Cursor = Cursors.Hand;

                customerDataGridView.AllowUserToAddRows = false;
                customerDataGridView.AllowUserToDeleteRows = false;
                customerDataGridView.AllowUserToOrderColumns = true;
                customerDataGridView.ReadOnly = true;
                customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                customerDataGridView.MultiSelect = false;
                customerDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                customerDataGridView.AllowUserToResizeColumns = false;
                customerDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                customerDataGridView.AllowUserToResizeRows = false;
                customerDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                customerDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                customerDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                customerDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                customerDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                customerDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                customerDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                customerDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                customerDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
