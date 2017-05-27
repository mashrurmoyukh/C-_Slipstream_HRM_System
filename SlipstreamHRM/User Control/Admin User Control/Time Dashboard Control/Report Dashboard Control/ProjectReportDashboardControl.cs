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
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.Report_Dashboard_Control
{
    public partial class ProjectReportDashboardControl : UserControl
    {
        private SqlConnection Connection;

        private ProjectReportDashboardControl _instance;

        public ProjectReportDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectReportDashboardControl();
                return _instance;
            }
        }

        public ProjectReportDashboardControl()
        {
            InitializeComponent();
        }

        private void ProjectReportDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            ProjectDataShow();
        }

        public void ProjectDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM ProjectInformation", Connection);
                DataTable ProjectInfoTable = new DataTable();
                Adapter.Fill(ProjectInfoTable);
                projectDataGridView.DataSource = ProjectInfoTable;

                projectDataGridView.Columns[0].HeaderText = "ID";
                projectDataGridView.Columns[1].HeaderText = "Customer Name";
                projectDataGridView.Columns[2].HeaderText = "Project Name";
                projectDataGridView.Columns[3].HeaderText = "Project Admin";
                projectDataGridView.Columns[4].HeaderText = "From";
                projectDataGridView.Columns[5].HeaderText = "To";

                projectDataGridView.Columns[0].Width = 50;
                projectDataGridView.Columns[1].Width = 150;
                projectDataGridView.Columns[2].Width = 150;
                projectDataGridView.Columns[3].Width = 150;
                projectDataGridView.Columns[4].Width = 200;
                projectDataGridView.Columns[5].Width = 200;

                projectDataGridView.BackgroundColor = Color.White;
                projectDataGridView.BorderStyle = BorderStyle.Fixed3D;
                projectDataGridView.Cursor = Cursors.Hand;

                projectDataGridView.AllowUserToAddRows = false;
                projectDataGridView.AllowUserToDeleteRows = false;
                projectDataGridView.AllowUserToOrderColumns = true;
                projectDataGridView.ReadOnly = true;
                projectDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                projectDataGridView.MultiSelect = false;
                projectDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                projectDataGridView.AllowUserToResizeColumns = false;
                projectDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                projectDataGridView.AllowUserToResizeRows = false;
                projectDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                projectDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                projectDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                projectDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                projectDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                projectDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                projectDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                projectDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                projectDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Attendance Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void projectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = projectDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (projectDataGridView.Rows.Count != 0 && projectDataGridView.Rows != null)
            {
                try
                {
                    Connection.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE ProjectInformation SET StartDate = '{0}', EndDate = '{1}' WHERE ProjectID = {2}", fromDateTime.Text, toDateTime.Text, Convert.ToInt32(txtID.Text)), Connection);
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
                    MessageBox.Show(ex.Message, "Update Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
            }
            ProjectDataShow();
        }
    }
}
