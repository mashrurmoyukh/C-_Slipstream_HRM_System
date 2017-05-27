using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.BAL.Admin_Control_Manager;
using System.Data.SqlClient;

namespace SlipstreamHRM.User_Control.Employee_User_Control.Leave_Dashboard_Control
{
    public partial class ApplyDashboardControl : UserControl
    {
        private ApplyDashboardControl _instance;
        private SqlConnection Connection;
        private string _userName;
        private ApplyDashboardHandler applyDashboardHandler;

        public ApplyDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ApplyDashboardControl(_userName);
                return _instance;
            }
        }

        public ApplyDashboardControl(string userName)
        {
            InitializeComponent();
            this._userName = userName;
        }

        private void ApplyDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            applyDashboardHandler = new ApplyDashboardHandler();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string EmpName = "";
            string LeaveType = comboLeaveType.Text.ToString();
            DateTime From = Convert.ToDateTime(FromDateTime.Text);
            DateTime To = Convert.ToDateTime(ToDateTime.Text);
            string Comment = txtComment.Text.ToString();
                      
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmployeeName From UserInformation Where Username='{0}'", _userName), Connection);
                DataTable UserInfomationTable = new DataTable();
                Adapter.Fill(UserInfomationTable);
                foreach (DataRow row in UserInfomationTable.Rows)
                {
                    EmpName = row["EmployeeName"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Leave Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            if (!string.IsNullOrEmpty(LeaveType))
            {
                if(!string.IsNullOrEmpty(From.ToString()) && !string.IsNullOrEmpty(To.ToString()))
                {
                    applyDashboardHandler.ApplyLeave(EmpName, LeaveType, From, To, Comment);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input FROM/TO", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Input Leave Type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }       
    }
}
