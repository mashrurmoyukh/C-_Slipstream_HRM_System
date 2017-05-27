using SlipstreamHRM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class SkillAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SkillInformation skillInformation;
        private string SkillID;

        public SkillAddEditForm(string skillID, string skill, string skillDescription)
        {
            InitializeComponent();
            this.SkillID = skillID;
            this.Text = "Add Skill";
            if (!string.IsNullOrEmpty(SkillID))
            {
                this.Text = "Edit Skill";
                txtSkill.Text = skill;
                txtDescription.Text = skillDescription;
            }
        }

        private void SkillAddEditForm_Load(object sender, EventArgs e)
        {
            skillInformation = new SkillInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _skillID = Convert.ToInt32(SkillID);
            skillInformation.Skill = txtSkill.Text;
            skillInformation.SkillDescription = txtDescription.Text;

            if (string.IsNullOrEmpty(SkillID))
            {
                if (!string.IsNullOrEmpty(skillInformation.Skill))
                {
                    skillInformation.AddSkill();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Skill Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }

            else
            {
                if (!string.IsNullOrEmpty(skillInformation.Skill))
                {
                    skillInformation.EditSkill(_skillID);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Skill Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}
