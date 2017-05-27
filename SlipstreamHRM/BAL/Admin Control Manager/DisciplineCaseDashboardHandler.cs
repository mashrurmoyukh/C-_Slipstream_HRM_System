using SlipstreamHRM.Forms.Admin_Control_Form;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class DisciplineCaseDashboardHandler
    {
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");

        public void AddDisciplineCase()
        {
            using (DisciplineCaseForm disciplineCaseForm = new DisciplineCaseForm())
            {
                disciplineCaseForm.ShowDialog();
            }
        }

        public void EditDisciplineCase(int disciplineID)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("UPDATE DisciplineCaseInformation SET Status = 0 WHERE DisciplineID = '" + disciplineID + "'", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Discipline Case Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Data Updated";
            popup.ContentText = "Data Sucessfully Updated";
            popup.ShowCloseButton = false;
            popup.Popup();
        }
    }
}
