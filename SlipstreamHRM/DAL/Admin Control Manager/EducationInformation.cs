using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.DAL.Admin_Control_Manager
{
    class EducationInformation
    {
        private SqlConnection Connection;
        private string _educationLevel;

        public EducationInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string EducationLevel
        {
            set
            {
                this._educationLevel = value;
            }
            get
            {
                return _educationLevel;
            }
        }

        public void AddEducation()
        {
            try
            {
                Connection.Open();
                //SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("INSERT INTO EducationInformation (EducationLevel) VALUES (@educationLevel)", new { _educationLevel }), Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO EducationInformation (EducationLevel) VALUES ('" + _educationLevel.ToString() + "')", Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Education", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void EditEducation(int _educationID)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE EducationInformation SET EducationLevel = '{0}' WHERE EducationID = {1}", _educationLevel, _educationID), Connection);
                Adapter.SelectCommand.ExecuteNonQuery();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Successfull;
                popup.TitleText = "Data Saved";
                popup.ContentText = "Data Sucessfully Saved";
                popup.ShowCloseButton = false;
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Education", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
