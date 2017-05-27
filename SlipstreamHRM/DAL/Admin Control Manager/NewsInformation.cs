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
    class NewsInformation
    {
        private SqlConnection Connection;
        private string _subject;
        private string _description;
        private string _publishedDate;

        public NewsInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string Subject
        {
            set
            {
                this._subject = value;
            }
            get
            {
                return _subject;
            }
        }

        public string Description
        {
            set
            {
                this._description = value;
            }
            get
            {
                return _description;
            }
        }

        public string PublishedDate
        {
            set
            {
                this._publishedDate = value;
            }
            get
            {
                return _publishedDate;
            }
        }

        public void AddNews()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO NewsInformation (Subject, Description, PublishedDate) VALUES ('" + _subject+ "','" + _description+ "','" + _publishedDate + "')", Connection);
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
                MessageBox.Show(ex.Message, "Save News", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
