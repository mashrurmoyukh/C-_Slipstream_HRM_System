using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;
using System.Data.SqlClient;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class DisciplineCaseForm : MaterialSkin.Controls.MaterialForm
    {
        public DisciplineCaseForm()
        {
            InitializeComponent();
        }

        private DisciplineCaseInformation disciplineCaseInformation;
        private SqlConnection Connection;

        private void DisciplineCaseForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            disciplineCaseInformation = new DisciplineCaseInformation();
            autoSuggestEmpName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            disciplineCaseInformation.EmployeeName = txtEmployeeName.Text;
            disciplineCaseInformation.CaseName = txtCaseName.Text;
            disciplineCaseInformation.Description = txtCaseDescription.Text;
            if(!string.IsNullOrEmpty(disciplineCaseInformation.EmployeeName) && !string.IsNullOrEmpty(disciplineCaseInformation.CaseName))
            {
                disciplineCaseInformation.createDisciplineCase();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Input Employee or Case Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(this, ex.Message, "Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
