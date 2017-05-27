using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Leave_Dashboard_Control
{
    public partial class AssignLeaveDashboardControl : UserControl
    {
        private AssignLeaveDashboardControl _instance;
        private SqlConnection Connection;
        private ApplyDashboardHandler applyDashboardHandler;

        public AssignLeaveDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AssignLeaveDashboardControl();
                return _instance;
            }
        }

        public AssignLeaveDashboardControl()
        {
            InitializeComponent();
        }

        private void AssignLeaveDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            applyDashboardHandler = new ApplyDashboardHandler();
            autoSuggestEmpName();
        }

        public void autoSuggestEmpName()
        {
            try
            {
                string _EmployeeName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From EmployeeInformation ORDER BY Name"), Connection);
                DataTable EmployeeInfomationTable = new DataTable();
                Adapter.Fill(EmployeeInfomationTable);

                foreach (DataRow row in EmployeeInfomationTable.Rows)
                {
                    _EmployeeName = row["Name"].ToString();
                    txtEmployeeName.AutoCompleteCustomSource.Add(_EmployeeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Employe Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmpName = txtEmployeeName.Text;
            string LeaveType = comboLeaveType.Text.ToString();
            DateTime From = Convert.ToDateTime(FromDateTime.Text);
            DateTime To = Convert.ToDateTime(ToDateTime.Text);
            string Comment = txtComment.Text.ToString();

            if (!string.IsNullOrEmpty(EmpName) && !string.IsNullOrEmpty(LeaveType))
            {
                if(!string.IsNullOrEmpty(From.ToString()) && !string.IsNullOrEmpty(To.ToString()))
                {
                    applyDashboardHandler.AsignLeave(EmpName, LeaveType, From, To, Comment);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input FROM/TO", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Enput leave Type/User Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
