using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;
using SlipstreamHRM.Forms;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    public partial class JobTitleDashboardControl : UserControl
    {
        private JobTitleDashboardControl _instance;

        public JobTitleDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobTitleDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private JobTitleInformation jobTitleInformation;
        private JobTitleDashboardHandler jobTitleDashboardHandler;

        public JobTitleDashboardControl()
        {
            InitializeComponent();
        }       

        private void JobTitleDashboardControl_Load(object sender, EventArgs e)
        {
            jobTitleInformation = new JobTitleInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            JobTileDataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            jobTitleDashboardHandler = new JobTitleDashboardHandler();
            jobTitleDashboardHandler.AddJobTitleForm();
            JobTileDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (jobTitleDataGridView.Rows.Count != 0 && jobTitleDataGridView.Rows != null)
            {
                jobTitleDashboardHandler= new JobTitleDashboardHandler();
                string jobTitleName = jobTitleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (jobTitleName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        jobTitleDashboardHandler.DeleteJobTitle(jobTitleName);
                    }
                }
            }
            JobTileDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (jobTitleDataGridView.Rows.Count != 0 && jobTitleDataGridView.Rows != null)
            {
                jobTitleInformation.JobTitleName = jobTitleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                jobTitleInformation.JobTitleDescription = jobTitleDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                if (!string.IsNullOrEmpty(jobTitleInformation.JobTitleName))
                {
                    jobTitleDashboardHandler = new JobTitleDashboardHandler();
                    jobTitleDashboardHandler.EditJobTitleForm(jobTitleInformation.JobTitleName, jobTitleInformation.JobTitleDescription);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            JobTileDataShow();
        }

        public void JobTileDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT JobTitle as 'Job Title', JobTitleDescription as 'Job Description' FROM JobTitleInformation ORDER BY JobTitle", Connection);
                DataTable JobTitleInfoTable = new DataTable();
                Adapter.Fill(JobTitleInfoTable);
                jobTitleDataGridView.DataSource = JobTitleInfoTable;
                jobTitleDataGridView.Columns[0].Width = 205;
                jobTitleDataGridView.Columns[1].Width = 680;
                jobTitleDataGridView.BackgroundColor = Color.White;
                jobTitleDataGridView.BorderStyle = BorderStyle.Fixed3D;
                jobTitleDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                jobTitleDataGridView.AllowUserToAddRows = false;
                jobTitleDataGridView.AllowUserToDeleteRows = false;
                jobTitleDataGridView.AllowUserToOrderColumns = true;
                jobTitleDataGridView.ReadOnly = true;
                jobTitleDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                jobTitleDataGridView.MultiSelect = false;
                jobTitleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                jobTitleDataGridView.AllowUserToResizeColumns = false;
                jobTitleDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                jobTitleDataGridView.AllowUserToResizeRows = false;
                jobTitleDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                jobTitleDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                jobTitleDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                jobTitleDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                jobTitleDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                jobTitleDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                jobTitleDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                jobTitleDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                jobTitleDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Title Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
