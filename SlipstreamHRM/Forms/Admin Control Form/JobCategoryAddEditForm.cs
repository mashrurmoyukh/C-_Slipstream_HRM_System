using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class JobCategoryAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private JobCategoryInformation jobCategoryInformation;
        private string JobCategoryID;

        public JobCategoryAddEditForm(string jobCategoryID, string jobCategoryName)
        {
            InitializeComponent();
            this.JobCategoryID = jobCategoryID;
            this.Text = "Add Job Category";
            if (!string.IsNullOrEmpty(jobCategoryID))
            {
                this.Text = "Edit Job Category";
                txtJobCategory.Text = jobCategoryName;
            }
        }

        private void JobCategoryAddEditForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            jobCategoryInformation = new JobCategoryInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _jobCategoryID = Convert.ToInt32(JobCategoryID);
            jobCategoryInformation.JobCategory = txtJobCategory.Text;

            if (string.IsNullOrEmpty(JobCategoryID))
            {
                try
                {
                    if (!string.IsNullOrEmpty(jobCategoryInformation.JobCategory))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO JobCategoryInformation (JobCategory) VALUES ('" + jobCategoryInformation.JobCategory + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Job Category Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }

            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(jobCategoryInformation.JobCategory))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE JobCategoryInformation SET JobCategory = '{0}' WHERE JobCategoryID = '{1}'", jobCategoryInformation.JobCategory, _jobCategoryID), Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Job Category Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Edit Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }
        }
    }
}
