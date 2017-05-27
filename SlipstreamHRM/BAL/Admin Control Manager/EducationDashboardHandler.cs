using SlipstreamHRM.Forms.Admin_Control_Form;
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
    class EducationDashboardHandler
    {
        private SqlConnection Connection;
        private string educationID;

        public EducationDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddEducationForm()
        {
            using (EducationAddEditForm educationAddEditForm = new EducationAddEditForm(null, null))
            {
                educationAddEditForm.ShowDialog();
            }
        }

        public void DeleteEducation(string EducationLevel)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM EducationInformation WHERE EducationID IN(SELECT EducationID FROM EducationInformation WHERE EducationLevel = '" + EducationLevel + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Education Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EditEducationForm(string EducationLevel)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EducationID From EducationInformation Where EducationLevel = '{0}'", EducationLevel), Connection);
                DataTable EducationInfomationTable = new DataTable();
                Adapter.Fill(EducationInfomationTable);

                foreach (DataRow row in EducationInfomationTable.Rows)
                {
                    educationID = Convert.ToString(row["EducationID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Education Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            using (EducationAddEditForm educationAddEditForm = new EducationAddEditForm(educationID, EducationLevel))
            {
                educationAddEditForm.ShowDialog();
            }
        }
    }
}
