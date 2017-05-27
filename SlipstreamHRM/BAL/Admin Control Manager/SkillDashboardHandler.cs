using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.Forms;
using System.Data.SqlClient;
using System.Data;
using Tulpep.NotificationWindow;
using SlipstreamHRM.Forms.Admin_Control_Form;
using System.Windows.Forms;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class SkillDashboardHandler
    {
        private SqlConnection Connection;
        private string skillID;

        public SkillDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddSkillForm()
        {
            using (SkillAddEditForm skillAddEditForm = new SkillAddEditForm(null, null, null))
            {
                skillAddEditForm.ShowDialog();
            }
        }

        public void DeleteSkill(string Skill)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM SkillInformation WHERE SkillID IN(SELECT SkillID FROM SkillInformation WHERE Skill = '" + Skill + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Skill Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EditSkillrForm(string Skill, string Description)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select SkillID From SkillInformation Where Skill='{0}'", Skill), Connection);
                DataTable SkillInfomationTable = new DataTable();
                Adapter.Fill(SkillInfomationTable);

                foreach (DataRow row in SkillInfomationTable.Rows)
                {
                    skillID = Convert.ToString(row["SkillID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Skill Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            using (SkillAddEditForm skillAddEditForm = new SkillAddEditForm(skillID, Skill, Description))
            {
                skillAddEditForm.ShowDialog();
            }
        }
    }
}
