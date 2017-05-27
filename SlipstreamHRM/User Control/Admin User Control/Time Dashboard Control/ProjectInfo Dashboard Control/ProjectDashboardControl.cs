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

namespace SlipstreamHRM.User_Control.Admin_User_Control.Time_Dashboard_Control.ProjectInfo_Dashboard_Control
{
    public partial class ProjectDashboardControl : UserControl
    {
        private ProjectDashboardControl _instance;
        private SqlConnection Connection;
        private ProjectDashboadHandler projectDashboadHandler;

        public ProjectDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectDashboardControl();
                return _instance;
            }
        }

        public ProjectDashboardControl()
        {
            InitializeComponent();
        }

        private void ProjectDashboardControl_Load(object sender, EventArgs e)
        {
            projectDashboadHandler = new ProjectDashboadHandler();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            ProjectDataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            projectDashboadHandler.AddProjectForm();
            ProjectDataShow();
        }

        public void ProjectDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CustomerName as 'Customer Name', Project, ProjectAdmin as 'Project Admin' FROM ProjectInformation ORDER BY CustomerName ASC", Connection);
                DataTable ProjectInfoTable = new DataTable();
                Adapter.Fill(ProjectInfoTable);
                projectDataGridView.DataSource = ProjectInfoTable;

                projectDataGridView.Columns[0].Width = 300;
                projectDataGridView.Columns[1].Width = 300;
                projectDataGridView.Columns[2].Width = 300;

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
                MessageBox.Show(ex.Message, "Customer Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
