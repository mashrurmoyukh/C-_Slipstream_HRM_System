using SlipstreamHRM.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class JobTitleDashboardHandler
    {
        private SqlConnection Connection;
        private string jobTitleID;

        public JobTitleDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddJobTitleForm()
        {
            using (JobTitleAddEditForm jobTitleAddEditForm = new JobTitleAddEditForm(null, null, null))
            {
                jobTitleAddEditForm.ShowDialog();
            }
        }

        public void DeleteJobTitle(string JobTitle)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM JobTitleInformation WHERE JobTitleID IN(SELECT JobTitleID FROM JobTitleInformation WHERE JobTitle = '" + JobTitle + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Title Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Data Delted";
            popup.ContentText = "Data Sucessfully Deleted";
            popup.ShowCloseButton = false;
            popup.Popup();
        }

        public void EditJobTitleForm(string JobName, string JobDescription)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select JobTitleID From JobTitleInformation Where JobTitle ='{0}'", JobName), Connection);
                DataTable JobTitleInfoTable = new DataTable();
                Adapter.Fill(JobTitleInfoTable);

                foreach (DataRow row in JobTitleInfoTable.Rows)
                {
                    jobTitleID = Convert.ToString(row["JobTitleID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "JobTitle Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            using (JobTitleAddEditForm jobTitleAddEditForm = new JobTitleAddEditForm(jobTitleID, JobName, JobDescription))
            {
                jobTitleAddEditForm.ShowDialog();
            }
        }
    }
}
