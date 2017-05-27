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
    class DisciplineCaseInformation
    {
        private string _employeeName;
        private string _caseName;
        private string _description;

        private SqlConnection Connection;

        public DisciplineCaseInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string EmployeeName
        {
            set
            {
                this._employeeName = value;
            }
            get
            {
                return _employeeName;
            }
        }

        public string CaseName
        {
            set
            {
                this._caseName = value;
            }
            get
            {
                return _caseName;
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

        public void createDisciplineCase()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO DisciplineCaseInformation (EmployeeName, CaseName, Description, CreatedBy, CreatedOn) VALUES ('" + _employeeName + "','" + _caseName + "','" + _description + "', '" + "Admin"+ "', '" + DateTime.Now + "')", Connection);
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
                MessageBox.Show(ex.Message, "Create Discipline Case", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
