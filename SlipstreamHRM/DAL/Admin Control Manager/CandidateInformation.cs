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
    class CandidateInformation
    {
        private SqlConnection Connection;
        private string _fullName;
        private string _comment;
        private string _vacancyName;
        private string _email;
        private string _contactNo;

        public CandidateInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string FullName
        {
            set
            {
                this._fullName = value;
            }
            get
            {
                return _fullName;
            }
        }

        public string Comment
        {
            set
            {
                this._comment = value;
            }
            get
            {
                return _comment;
            }
        }

        public string ContactNo
        {
            set
            {
                this._contactNo = value;
            }
            get
            {
                return _contactNo;
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

        public string Email
        {
            set
            {
                this._email = value;
            }
            get
            {
                return _email;
            }
        }

        public void AddCandidate()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO CandidateInformation (CandidateName, JobVacancy, Email, ContactNo, Comment) VALUES ('" + _fullName + "', '" + _vacancyName + "', '" + _email + "', '" + _contactNo + "', '" + _comment + "')", Connection);
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
                MessageBox.Show(ex.Message, "Save Candidate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
