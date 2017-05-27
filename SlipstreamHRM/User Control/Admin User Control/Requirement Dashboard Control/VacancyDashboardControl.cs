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

namespace SlipstreamHRM.User_Control.Admin_User_Control.Requirement_Dashboard_Control
{
    public partial class VacancyDashboardControl : UserControl
    {
        private VacancyDashboardControl _instance;
        private SqlConnection Connection;
        private VacancyDashboardHandler vacancyDashboardHandler;

        public VacancyDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VacancyDashboardControl();
                return _instance;
            }
        }

        public VacancyDashboardControl()
        {
            InitializeComponent();
        }

        private void VacanciesDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            vacancyDashboardHandler = new VacancyDashboardHandler();
            autoSuggestEmpName();
            fillJobTitleComboBox();
            VacancyDataShow();
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
                MessageBox.Show(this, ex.Message, "Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillJobTitleComboBox()
        {
            try
            {
                string _JobTitleName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From JobTitleInformation ORDER BY JobTitle"), Connection);
                DataTable JobTitleInfomationTable = new DataTable();
                Adapter.Fill(JobTitleInfomationTable);

                foreach (DataRow row in JobTitleInfomationTable.Rows)
                {
                    _JobTitleName = row["JobTitle"].ToString();
                    comboJobTitle.Items.Add(_JobTitleName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "JobTitle Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmployeeName.Text) && !string.IsNullOrEmpty(txtNumberofPosition.Text) && !string.IsNullOrEmpty(txtVacancyName.Text) && !string.IsNullOrEmpty(comboJobTitle.Text))
            {
                vacancyDashboardHandler.AddVacancy(txtEmployeeName.Text, txtNumberofPosition.Text, txtVacancyName.Text, comboJobTitle.Text, txtDscription.Text);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give All Input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VacancyDataShow();
        }

        public void VacancyDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT JobTitle AS 'Job Title', HiringManager AS 'Hiring Manager', VacancyName AS 'Vacancy Name', NumberofPosition AS 'Number of Position' FROM VacanciesInformation", Connection);
                DataTable VacancyInfoTable = new DataTable();
                Adapter.Fill(VacancyInfoTable);
                vacancyListDataGridView.DataSource = VacancyInfoTable;

                vacancyListDataGridView.Columns[0].Width = 220;
                vacancyListDataGridView.Columns[1].Width = 220;
                vacancyListDataGridView.Columns[2].Width = 240;
                vacancyListDataGridView.Columns[3].Width = 220;

                vacancyListDataGridView.BackgroundColor = Color.White;
                vacancyListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                vacancyListDataGridView.Cursor = Cursors.Hand;

                vacancyListDataGridView.AllowUserToAddRows = false;
                vacancyListDataGridView.AllowUserToDeleteRows = false;
                vacancyListDataGridView.AllowUserToOrderColumns = true;
                vacancyListDataGridView.ReadOnly = true;
                vacancyListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                vacancyListDataGridView.MultiSelect = false;
                vacancyListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                vacancyListDataGridView.AllowUserToResizeColumns = false;
                vacancyListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                vacancyListDataGridView.AllowUserToResizeRows = false;
                vacancyListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                vacancyListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                vacancyListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                vacancyListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                vacancyListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                vacancyListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                vacancyListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                vacancyListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                vacancyListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vacancy Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
