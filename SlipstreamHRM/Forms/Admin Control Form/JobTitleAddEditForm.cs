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

namespace SlipstreamHRM.Forms
{
    public partial class JobTitleAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private JobTitleInformation jobTileInformation;
        private string JobTitleID;

        public JobTitleAddEditForm(string jobTileID, string jobTitel, string jobTitelDescription)
        {
            InitializeComponent();
            this.Text = "Add Job Title";
            this.JobTitleID = jobTileID;
            if (!string.IsNullOrEmpty(JobTitleID))
            {
                this.Text = "Edit Job Title";
                txtJobTile.Text = jobTitel;
                txtJobDescription.Text = jobTitelDescription;
            }
        }

        private void JobTitleAddEditForm_Load(object sender, EventArgs e)
        {
            jobTileInformation = new JobTitleInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _jobTitleID = Convert.ToInt32(JobTitleID);
            jobTileInformation.JobTitleName = txtJobTile.Text;
            jobTileInformation.JobTitleDescription = txtJobDescription.Text;

            if (string.IsNullOrEmpty(JobTitleID))
            {
                if (!string.IsNullOrEmpty(jobTileInformation.JobTitleName))
                {
                    jobTileInformation.AddJobTilte();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Job Title Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }

            else
            {
                if (!string.IsNullOrEmpty(jobTileInformation.JobTitleName))
                {
                    jobTileInformation.EditJobTitle(_jobTitleID);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Job Tile Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }       
    }
}
