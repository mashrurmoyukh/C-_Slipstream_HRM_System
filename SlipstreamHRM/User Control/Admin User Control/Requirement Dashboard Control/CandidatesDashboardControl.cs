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
    public partial class CandidatesDashboardControl : UserControl
    {
        private CandidatesDashboardControl _instance;
        private SqlConnection Connection;
        private CandidateDashboardHandler candidateDashboardHandler;

        public CandidatesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CandidatesDashboardControl();
                return _instance;
            }
        }

        public CandidatesDashboardControl()
        {
            InitializeComponent();
        }

        private void CandidatesDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            candidateDashboardHandler = new CandidateDashboardHandler();
            fillJobVacancyComboBox();
            CandidateDataShow();
        }

        public void fillJobVacancyComboBox()
        {
            try
            {
                string _JobVacancyName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From VacanciesInformation"), Connection);
                DataTable JobVacancyInfomationTable = new DataTable();
                Adapter.Fill(JobVacancyInfomationTable);

                foreach (DataRow row in JobVacancyInfomationTable.Rows)
                {
                    _JobVacancyName = row["VacancyName"].ToString();
                    comboJobVacancy.Items.Add(_JobVacancyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Job Vacancy  Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtContactNo.Text) && !string.IsNullOrEmpty(comboJobVacancy.Text))
            {
                candidateDashboardHandler.AddCandidate(txtFullName.Text, txtEmail.Text, txtContactNo.Text, txtComment.Text, comboJobVacancy.Text);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give All Input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CandidateDataShow();
        }

        public void CandidateDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CandidateName AS 'Candidate Name', Email AS 'Email', ContactNo AS 'Contact No', JobVacancy AS 'Job Vacancy' FROM CandidateInformation", Connection);
                DataTable CandidateInfoTable = new DataTable();
                Adapter.Fill(CandidateInfoTable);
                candidateListDataGridView.DataSource = CandidateInfoTable;

                candidateListDataGridView.Columns[0].Width = 220;
                candidateListDataGridView.Columns[1].Width = 220;
                candidateListDataGridView.Columns[2].Width = 240;
                candidateListDataGridView.Columns[3].Width = 220;

                candidateListDataGridView.BackgroundColor = Color.White;
                candidateListDataGridView.BorderStyle = BorderStyle.Fixed3D;
                candidateListDataGridView.Cursor = Cursors.Hand;

                candidateListDataGridView.AllowUserToAddRows = false;
                candidateListDataGridView.AllowUserToDeleteRows = false;
                candidateListDataGridView.AllowUserToOrderColumns = true;
                candidateListDataGridView.ReadOnly = true;
                candidateListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                candidateListDataGridView.MultiSelect = false;
                candidateListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                candidateListDataGridView.AllowUserToResizeColumns = false;
                candidateListDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                candidateListDataGridView.AllowUserToResizeRows = false;
                candidateListDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                candidateListDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                candidateListDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                candidateListDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                candidateListDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                candidateListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                candidateListDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                candidateListDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                candidateListDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Candidate Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
