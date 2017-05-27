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
    class LanguageDashboardHandler
    {
        private SqlConnection Connection;
        private string languageID;

        public LanguageDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddLanguageForm()
        {
            using (LanguageAddEditForm languageAddEditForm = new LanguageAddEditForm(null, null))
            {
                languageAddEditForm.ShowDialog();
            }
        }

        public void DeleteLanguage(string Language)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM LanguageInformation WHERE LanguageID IN(SELECT LanguageID FROM LanguageInformation WHERE Language = '" + Language + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Language Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EditLanguageForm(string Language)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select LanguageID From LanguageInformation Where Language = '{0}'", Language), Connection);
                DataTable LanguageInfomationTable = new DataTable();
                Adapter.Fill(LanguageInfomationTable);

                foreach (DataRow row in LanguageInfomationTable.Rows)
                {
                    languageID = Convert.ToString(row["LanguageID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Language Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            using (LanguageAddEditForm languageAddEditForm = new LanguageAddEditForm(languageID, Language))
            {
                languageAddEditForm.ShowDialog();
            }
        }
    }
}
