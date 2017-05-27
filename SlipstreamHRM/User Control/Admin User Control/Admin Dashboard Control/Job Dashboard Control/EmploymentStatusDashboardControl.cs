using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;
using SlipstreamHRM.Forms.Admin_Control_Form;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    public partial class EmploymentStatusDashboardControl : UserControl
    {
        private EmploymentStatusDashboardControl _instance;

        public EmploymentStatusDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmploymentStatusDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private EmploymentStatusInformation employmentStatusInformation;
        private string employmentStatusID;

        public EmploymentStatusDashboardControl()
        {
            InitializeComponent();
        }

        private void EmploymentStatusDashboardControl_Load(object sender, EventArgs e)
        {
            employmentStatusInformation = new EmploymentStatusInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            dataShow();
        }

        public void dataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmploymentStatus as 'Employement Status' FROM EmploymentStatusInformation", Connection);
                DataTable EmploymentStatusInfoTable = new DataTable();
                Adapter.Fill(EmploymentStatusInfoTable);
                employmentStatusDataGridView.DataSource = EmploymentStatusInfoTable;
                employmentStatusDataGridView.Columns[0].Width = 880;
                employmentStatusDataGridView.BackgroundColor = Color.White;
                employmentStatusDataGridView.BorderStyle = BorderStyle.Fixed3D;
                employmentStatusDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                employmentStatusDataGridView.AllowUserToAddRows = false;
                employmentStatusDataGridView.AllowUserToDeleteRows = false;
                employmentStatusDataGridView.AllowUserToOrderColumns = true;
                employmentStatusDataGridView.ReadOnly = true;
                employmentStatusDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                employmentStatusDataGridView.MultiSelect = false;
                employmentStatusDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                employmentStatusDataGridView.AllowUserToResizeColumns = false;
                employmentStatusDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                employmentStatusDataGridView.AllowUserToResizeRows = false;
                employmentStatusDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                employmentStatusDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                employmentStatusDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                employmentStatusDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                employmentStatusDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                employmentStatusDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                employmentStatusDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                employmentStatusDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                employmentStatusDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employement Status Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            using (EmploymentStatusAddEditForm employmentStatusAddEditForm = new EmploymentStatusAddEditForm(null, null))
            {
                employmentStatusAddEditForm.ShowDialog();
            }
            dataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            string employmentStatusName = employmentStatusDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                if (employmentStatusName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM EmploymentStatusInformation WHERE EmploymentStatusID IN(SELECT EmploymentStatusID FROM RegionInformation WHERE EmploymentStatus = '" + employmentStatusName + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        //MessageBox.Show(this, "Data Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employment Status Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            dataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (employmentStatusDataGridView.Rows.Count != 0 && employmentStatusDataGridView.Rows != null)
            {
                employmentStatusInformation.EmploymentStatus = employmentStatusDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(employmentStatusInformation.EmploymentStatus))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select EmploymentStatusID From EmploymentStatusInformation Where EmploymentStatus='{0}'", employmentStatusInformation.EmploymentStatus), Connection);
                        DataTable EmploymentStatusInfomationTable = new DataTable();
                        Adapter.Fill(EmploymentStatusInfomationTable);

                        foreach (DataRow row in EmploymentStatusInfomationTable.Rows)
                        {
                            employmentStatusID = Convert.ToString(row["EmploymentStatusID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Employment Status Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }

                    using (EmploymentStatusAddEditForm employmentStatusAddEditForm = new EmploymentStatusAddEditForm(employmentStatusID, employmentStatusInformation.EmploymentStatus))
                    {
                        employmentStatusAddEditForm.ShowDialog();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dataShow();
        }
    }
}
