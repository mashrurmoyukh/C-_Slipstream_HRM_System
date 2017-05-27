using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;
using SlipstreamHRM.BAL.Admin_Control_Manager;
using System.Data.SqlClient;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    public partial class EducationDashboardControl : UserControl
    {
        private EducationDashboardControl _instance;

        public EducationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EducationDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private EducationInformation educationInformation;
        private EducationDashboardHandler educationDashboardHandler;

        public EducationDashboardControl()
        {
            InitializeComponent();
        }

        private void EducationDashboardControl_Load(object sender, EventArgs e)
        {
            educationInformation = new EducationInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            EducationDataShow();
        }

        public void EducationDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EducationLevel as 'Education Level' FROM EducationInformation ORDER BY EducationLevel ASC", Connection);
                DataTable EducationInfoTable = new DataTable();
                Adapter.Fill(EducationInfoTable);
                educationDataGridView.DataSource = EducationInfoTable;

                educationDataGridView.Columns[0].Width = 880;

                educationDataGridView.BackgroundColor = Color.White;
                educationDataGridView.BorderStyle = BorderStyle.Fixed3D;
                educationDataGridView.Cursor = Cursors.Hand;

                educationDataGridView.AllowUserToAddRows = false;
                educationDataGridView.AllowUserToDeleteRows = false;
                educationDataGridView.AllowUserToOrderColumns = true;
                educationDataGridView.ReadOnly = true;
                educationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                educationDataGridView.MultiSelect = false;
                educationDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                educationDataGridView.AllowUserToResizeColumns = false;
                educationDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                educationDataGridView.AllowUserToResizeRows = false;
                educationDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                educationDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                educationDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                educationDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                educationDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                educationDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                educationDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                educationDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                educationDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Education Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            educationDashboardHandler = new EducationDashboardHandler();
            educationDashboardHandler.AddEducationForm();
            EducationDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (educationDataGridView.Rows.Count != 0 && educationDataGridView.Rows != null)
            {
                educationInformation.EducationLevel= educationDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(educationInformation.EducationLevel))
                {
                    educationDashboardHandler = new EducationDashboardHandler();
                    educationDashboardHandler.EditEducationForm(educationInformation.EducationLevel);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            EducationDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (educationDataGridView.Rows.Count != 0 && educationDataGridView.Rows != null)
            {
                educationDashboardHandler = new EducationDashboardHandler();
                string educationLevel = educationDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (educationLevel != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        educationDashboardHandler.DeleteEducation(educationLevel);
                    }
                }
            }
            EducationDataShow();
        }
    }
}
