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
using SlipstreamHRM.DAL.Admin_Control_Manager;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    public partial class EntitelmentsDashboardControl : UserControl
    {
        private EntitelmentsDashboardControl _instance;
        private SqlConnection Connection;
        private EntitlementsInformation entitlementsInformation;
        private EntitlementDashboardHandler entitlementDashboardHandler;

        public EntitelmentsDashboardControl Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new EntitelmentsDashboardControl();
                return _instance;
            }
        }

        public EntitelmentsDashboardControl()
        {
            InitializeComponent();
        }

        private void EntitelmentsDashboardControl_Load(object sender, EventArgs e)
        {
            entitlementsInformation = new EntitlementsInformation();
            entitlementDashboardHandler = new EntitlementDashboardHandler();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            autoSuggestEmpName();
            ProjectDataShow();
        }

        public void autoSuggestEmpName()
        {
            try
            {
                string _EmployeeName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From EmployeeInformation ORDER BY Name"), Connection);
                DataTable EmployeeInfomationTable = new DataTable();
                Adapter.Fill(EmployeeInfomationTable);

                foreach (DataRow row in EmployeeInfomationTable.Rows)
                {
                    _EmployeeName = row["Name"].ToString();
                    txtEmployeeName.AutoCompleteCustomSource.Add(_EmployeeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Project Admin Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeName.Text) && !string.IsNullOrEmpty(comboLeaveType.Text) && !string.IsNullOrEmpty(txtTotalDays.Text))
            {
                entitlementsInformation.EmpName = txtEmployeeName.Text;
                entitlementsInformation.LeaveType = comboLeaveType.Text;
                entitlementsInformation.From = FromDateTime.Text.ToString();
                entitlementsInformation.To = ToDateTime.Text.ToString();
                entitlementsInformation.TotalDays = Convert.ToInt32(txtTotalDays.Text);
                entitlementsInformation.Comment = txtComment.Text;

                entitlementsInformation.AddEntitlements();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give All input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProjectDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (entitlementListDataGridView.Rows.Count != 0 && entitlementListDataGridView.Rows != null)
            {
                string ID = entitlementListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (ID != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entitlementDashboardHandler.deleteEntitlement(Convert.ToInt32(ID));
                    }
                }
            }
            ProjectDataShow();
        }

        public void ProjectDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EntitlementID AS 'ID', EmployeeName AS 'Employee Name', ValidFrom AS 'Valid From', ValidUpto AS 'Valid Upto', TotalDays AS 'Total Days', EntitlementType AS 'Entitlement Type' FROM EntitlementsInformation ORDER BY EmployeeName ASC", Connection);
                DataTable EmployeeInfoTable = new DataTable();
                Adapter.Fill(EmployeeInfoTable);
                entitlementListDataGridView.DataSource = EmployeeInfoTable;

                entitlementListDataGridView.Columns[0].Width = 45;
                entitlementListDataGridView.Columns[1].Width = 180;
                entitlementListDataGridView.Columns[2].Width = 200;
                entitlementListDataGridView.Columns[3].Width = 200;
                entitlementListDataGridView.Columns[4].Width = 100;
                entitlementListDataGridView.Columns[5].Width = 160;

                entitlementListDataGridView.BackgroundColor = Color.White;
                entitlementListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                entitlementListDataGridView.Cursor = Cursors.Hand;

                entitlementListDataGridView.AllowUserToAddRows = false;
                entitlementListDataGridView.AllowUserToDeleteRows = false;
                entitlementListDataGridView.AllowUserToOrderColumns = true;
                entitlementListDataGridView.ReadOnly = true;
                entitlementListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                entitlementListDataGridView.MultiSelect = false;
                entitlementListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                entitlementListDataGridView.AllowUserToResizeColumns = false;
                entitlementListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                entitlementListDataGridView.AllowUserToResizeRows = false;
                entitlementListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                entitlementListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                entitlementListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                entitlementListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                entitlementListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                entitlementListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                entitlementListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                entitlementListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                entitlementListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
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
