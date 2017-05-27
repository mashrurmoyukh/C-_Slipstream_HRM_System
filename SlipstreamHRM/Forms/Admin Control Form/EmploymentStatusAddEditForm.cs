using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class EmploymentStatusAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private EmploymentStatusInformation employmentStatusInformation;
        private string EmploymentStatusID;

        public EmploymentStatusAddEditForm(string employmentStatusID, string employmentStatusName)
        {
            InitializeComponent();
            this.EmploymentStatusID = employmentStatusID;
            this.Text = "Add Employment Status";
            if (!string.IsNullOrEmpty(EmploymentStatusID))
            {
                this.Text = "Edit Employment Status";
                txtEmploymentStatus.Text = employmentStatusName;
            }
        }

        private void EmploymentStatusAddEditForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            employmentStatusInformation = new EmploymentStatusInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _employmentStatusID = Convert.ToInt32(EmploymentStatusID);
            employmentStatusInformation.EmploymentStatus = txtEmploymentStatus.Text;

            if (string.IsNullOrEmpty(EmploymentStatusID))
            {
                try
                {
                    if (!string.IsNullOrEmpty(employmentStatusInformation.EmploymentStatus))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO EmploymentStatusInformation (EmploymentStatus) VALUES ('" + employmentStatusInformation.EmploymentStatus + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Employment Status Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }

            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(employmentStatusInformation.EmploymentStatus))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE EmploymentStatusInformation SET EmploymentStatus = '{0}' WHERE EmploymentStatusID = '{1}'", employmentStatusInformation.EmploymentStatus, _employmentStatusID), Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Employment Status Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Edit Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                    this.Close();
                }
            }
        }
    }
}
