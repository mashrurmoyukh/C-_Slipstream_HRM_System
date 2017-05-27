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
using SlipstreamHRM.Forms.Admin_Control_Form;

namespace SlipstreamHRM.User_Control.Employee_User_Control
{
    public partial class EmployeeHomeDashboardControl : UserControl
    {
        private EmployeeHomeDashboardControl _instance;
        private SqlConnection Connection;

        public EmployeeHomeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeHomeDashboardControl();
                return _instance;
            }
        }

        public EmployeeHomeDashboardControl()
        {
            InitializeComponent();
        }

        private void EmployeeHomeDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            newsDataShow();
        }

        public void newsDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Subject FROM NewsInformation", Connection);
                DataTable NewsInfoTable = new DataTable();
                Adapter.Fill(NewsInfoTable);
                newsDataGridView.DataSource = NewsInfoTable;

                newsDataGridView.Columns[0].Width = 547;

                newsDataGridView.BackgroundColor = Color.White;
                newsDataGridView.BorderStyle = BorderStyle.Fixed3D;
                newsDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                newsDataGridView.AllowUserToAddRows = false;
                newsDataGridView.AllowUserToDeleteRows = false;
                newsDataGridView.AllowUserToOrderColumns = true;
                newsDataGridView.ReadOnly = true;
                newsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                newsDataGridView.MultiSelect = false;
                newsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                newsDataGridView.AllowUserToResizeColumns = false;
                newsDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                newsDataGridView.AllowUserToResizeRows = false;
                newsDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                newsDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                newsDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                newsDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                newsDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                newsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                newsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                newsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                newsDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "News Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (newsDataGridView.Rows.Count != 0 && newsDataGridView.Rows != null)
            {
                string subjectName = newsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (subjectName != null)
                {
                    using (NewsShowForm newsShowForm = new NewsShowForm(subjectName))
                    {
                        newsShowForm.ShowDialog();
                    }
                }
            }
            newsDataShow();
        }
    }
}
