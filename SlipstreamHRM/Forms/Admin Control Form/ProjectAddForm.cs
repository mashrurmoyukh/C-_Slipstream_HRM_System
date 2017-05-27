using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class ProjectAddForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private ProjectInformation projectInformation;

        public ProjectAddForm()
        {
            InitializeComponent();
        }

        private void ProjectAddForm_Load(object sender, EventArgs e)
        {
            projectInformation = new ProjectInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            autoSuggestEmpName();
            autoSuggestCustomerName();
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
                    txtProjectAdmin.AutoCompleteCustomSource.Add(_EmployeeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Project Admin Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void autoSuggestCustomerName()
        {
            try
            {
                string _CustomerName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From CustomerInformation ORDER BY Customer"), Connection);
                DataTable EmployeeInfomationTable = new DataTable();
                Adapter.Fill(EmployeeInfomationTable);

                foreach (DataRow row in EmployeeInfomationTable.Rows)
                {
                    _CustomerName = row["Customer"].ToString();
                    txtCustomerName.AutoCompleteCustomSource.Add(_CustomerName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "_CustomerName Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtProject.Text) && !string.IsNullOrEmpty(txtProjectAdmin.Text))
            {
                projectInformation.Customer = txtCustomerName.Text.ToString();
                projectInformation.Project = txtProject.Text.ToString();
                projectInformation.AdminProject = txtProjectAdmin.Text.ToString();
                projectInformation.AddProject();
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give all the Inputs", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
