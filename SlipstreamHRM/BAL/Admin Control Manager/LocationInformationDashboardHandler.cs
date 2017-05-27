using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.DAL.Admin_Control_Manager;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class LocationInformationDashboardHandler
    {
        private SqlConnection Connection;

        public LocationInformationDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void AddLocation(string name, string country)
        {
            LocationInformation locationInformation = new LocationInformation();
            locationInformation.LocationName = name;
            locationInformation.Country = country;

            locationInformation.AddLocationInformation();
        }

        public void DeleteLocation(string name)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM LocationInformation WHERE LocationID IN(SELECT LocationID FROM LocationInformation WHERE Location = '" + name + "')", Connection);
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
                MessageBox.Show(ex.Message, "Location Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }           
        }
    }
}
