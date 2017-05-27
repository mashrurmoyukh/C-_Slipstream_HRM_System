using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class EducationAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private EducationInformation educationInformation;
        private string EducationID;

        public EducationAddEditForm(string educationID, string educationLevel)
        {
            InitializeComponent();
            this.EducationID = educationID;
            this.Text = "Add Education Level";
            if (!string.IsNullOrEmpty(EducationID))
            {
                this.Text = "Edit Education Level";
                txtEducation.Text = educationLevel;
            }
        }

        private void EducationAddEditForm_Load(object sender, EventArgs e)
        {
            educationInformation = new EducationInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _educationID = Convert.ToInt32(EducationID);
            educationInformation.EducationLevel = txtEducation.Text;

            if (string.IsNullOrEmpty(EducationID))
            {
                if (!string.IsNullOrEmpty(educationInformation.EducationLevel))
                {
                    educationInformation.AddEducation();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Education Level", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }

            else
            {
                if (!string.IsNullOrEmpty(educationInformation.EducationLevel))
                {
                    educationInformation.EditEducation(_educationID);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Education Level", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}
