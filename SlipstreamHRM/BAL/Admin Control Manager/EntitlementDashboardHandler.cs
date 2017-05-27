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
    class EntitlementDashboardHandler
    {
        private SqlConnection Connection;

        public EntitlementDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void deleteEntitlement(int id)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM EntitlementsInformation WHERE EntitlementID = '" + id + "'", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Delted";
                popup.ContentText = "Data Sucessfully Deleted";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entitlement Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }     
        }
    }
}
