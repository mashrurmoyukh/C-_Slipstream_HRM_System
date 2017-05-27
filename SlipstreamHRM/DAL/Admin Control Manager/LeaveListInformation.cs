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
    class LeaveListInformation
    {
        private string _selectedAction;
        private int _leaveId;

        private SqlConnection Connection;

        public LeaveListInformation()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public string SelectedAction
        {
            set
            {
                this._selectedAction = value;
            }
            get
            {
                return _selectedAction;
            }
        }

        public int LeaveId
        {
            set
            {
                this._leaveId = value;
            }
            get
            {
                return _leaveId;
            }
        }

        public void assignSelectedAction()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE LeaveInformation SET Action = '{0}', Status = '{1}' WHERE LeaveID = {2}", _selectedAction, "Progress Clear", _leaveId), Connection);
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
                MessageBox.Show(ex.Message, "Update Leave List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
