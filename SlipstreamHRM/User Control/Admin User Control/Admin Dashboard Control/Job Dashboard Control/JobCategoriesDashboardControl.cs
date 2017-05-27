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
using SlipstreamHRM.Forms.Admin_Control_Form;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    public partial class JobCategoriesDashboardControl : UserControl
    {
        private JobCategoriesDashboardControl _instance;

        public JobCategoriesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobCategoriesDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private JobCategoryInformation jobCategoryInformation;
        private string jobCategoryID;

        public JobCategoriesDashboardControl()
        {
            InitializeComponent();
        }

        private void JobCategoriesDashboardControl_Load(object sender, EventArgs e)
        {
            jobCategoryInformation = new JobCategoryInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            dataShow();
        }

        public void dataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT JobCategory as 'Job Category' FROM JobCategoryInformation", Connection);
                DataTable JobCategoryInfoTable = new DataTable();
                Adapter.Fill(JobCategoryInfoTable);
                employmentStatusDataGridView.DataSource = JobCategoryInfoTable;
                employmentStatusDataGridView.Columns[0].Width = 880;
                employmentStatusDataGridView.BackgroundColor = Color.White;
                employmentStatusDataGridView.BorderStyle = BorderStyle.Fixed3D;
                employmentStatusDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                employmentStatusDataGridView.AllowUserToAddRows = false;
                employmentStatusDataGridView.AllowUserToDeleteRows = false;
                employmentStatusDataGridView.AllowUserToOrderColumns = true;
                employmentStatusDataGridView.ReadOnly = true;
                employmentStatusDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                employmentStatusDataGridView.MultiSelect = false;
                employmentStatusDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                employmentStatusDataGridView.AllowUserToResizeColumns = false;
                employmentStatusDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                employmentStatusDataGridView.AllowUserToResizeRows = false;
                employmentStatusDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                employmentStatusDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                employmentStatusDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                employmentStatusDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                employmentStatusDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                employmentStatusDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                employmentStatusDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                employmentStatusDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                employmentStatusDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Category Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            using (JobCategoryAddEditForm jobCategoryAddEditForm = new JobCategoryAddEditForm(null, null))
            {
                jobCategoryAddEditForm.ShowDialog();
            }
            dataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (employmentStatusDataGridView.Rows.Count != 0 && employmentStatusDataGridView.Rows != null)
            {
                string jobCategoryName = employmentStatusDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    if (jobCategoryName != null)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Connection.Open();
                            SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM JobCategoryInformation WHERE JobCategoryID IN(SELECT JobCategoryID FROM JobCategoryInformation WHERE JobCategory = '" + jobCategoryName + "')", Connection);
                            Adapter.SelectCommand.ExecuteNonQuery();
                            //MessageBox.Show(this, "Data Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Job Category Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
                dataShow();
            }
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (employmentStatusDataGridView.Rows.Count != 0 && employmentStatusDataGridView.Rows != null)
            {
                jobCategoryInformation.JobCategory = employmentStatusDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(jobCategoryInformation.JobCategory))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select JobCategoryID From JobCategoryInformation Where JobCategory='{0}'", jobCategoryInformation.JobCategory), Connection);
                        DataTable JobCategoryInfomationTable = new DataTable();
                        Adapter.Fill(JobCategoryInfomationTable);

                        foreach (DataRow row in JobCategoryInfomationTable.Rows)
                        {
                            jobCategoryID = Convert.ToString(row["JobCategoryID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Job Category Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }

                    using (JobCategoryAddEditForm jobCategoryAddEditForm = new JobCategoryAddEditForm(jobCategoryID, jobCategoryInformation.JobCategory))
                    {
                        jobCategoryAddEditForm.ShowDialog();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dataShow();
        }
    }
}
