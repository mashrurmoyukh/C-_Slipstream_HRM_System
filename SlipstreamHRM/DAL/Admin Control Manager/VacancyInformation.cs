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
    class VacancyInformation
    {
        private SqlConnection Connection;
        private string _hiringManager;
        private string _description;
        private string _jobTitle;
        private string _vacancyName;
        private int _nop;

        public VacancyInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string HiringManager
        {
            set
            {
                this._hiringManager = value;
            }
            get
            {
                return _hiringManager;
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

        public string JobTitle
        {
            set
            {
                this._jobTitle = value;
            }
            get
            {
                return _jobTitle;
            }
        }

        public string VacancyName
        {
            set
            {
                this._vacancyName = value;
            }
            get
            {
                return _vacancyName;
            }
        }

        public int NOP
        {
            set
            {
                this._nop = value;
            }
            get
            {
                return _nop;
            }
        }

        public void AddVacancy()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO VacanciesInformation (JobTitle, VacancyName, HiringManager, NumberofPosition, Description) VALUES ('" + _jobTitle + "', '" + _vacancyName + "', '" + _hiringManager + "', '" + _nop + "', '" + _description + "')", Connection);
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
                MessageBox.Show(ex.Message, "Save Job Tile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
