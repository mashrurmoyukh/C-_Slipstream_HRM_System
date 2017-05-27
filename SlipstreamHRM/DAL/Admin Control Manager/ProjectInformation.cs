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
    class ProjectInformation
    {
        private string _customer;
        private string _project;
        private string _adimnProject;
        private SqlConnection Connection;

        public ProjectInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string Customer
        {
            set
            {
                this._customer = value;
            }
            get
            {
                return _customer;
            }
        }

        public string AdminProject
        {
            set
            {
                this._adimnProject = value;
            }
            get
            {
                return _adimnProject;
            }
        }

        public string Project
        {
            set
            {
                this._project = value;
            }
            get
            {
                return _project;
            }
        }

        public void AddProject()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO ProjectInformation (CustomerName, Project, ProjectAdmin) VALUES ('" + _customer + "','" + _project + "','"+_adimnProject+"')", Connection);
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
                MessageBox.Show(ex.Message, "Save Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
