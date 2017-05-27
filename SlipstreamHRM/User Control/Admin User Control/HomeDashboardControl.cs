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
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.User_Control
{
    public partial class HomeDashboardControl : UserControl
    {
        private HomeDashboardControl _instance;

        public HomeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;

        public HomeDashboardControl()
        {
            InitializeComponent();
        }

        private void HomeDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            emplistshow();
            newsDataShow();
        }

        public void emplistshow()
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            try
            {
                Connection.Open();
                DataTable EmployeeListCountTable = new DataTable();

                SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("SELECT COUNT(Name) AS 'TOTAL' FROM EmployeeInformation WHERE Subunit = 'Sales Department'"), Connection);
                Adapter1.Fill(EmployeeListCountTable);
                foreach(DataRow row in EmployeeListCountTable.Rows)
                {
                    a = Convert.ToInt32(row["TOTAL"]);
                }


                SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("SELECT COUNT(Name) AS 'TOTAL' FROM EmployeeInformation WHERE Subunit = 'Engineering Department'"), Connection);
                Adapter2.Fill(EmployeeListCountTable);
                foreach (DataRow row in EmployeeListCountTable.Rows)
                {
                    b = Convert.ToInt32(row["TOTAL"]);
                }

                SqlDataAdapter Adapter3 = new SqlDataAdapter(string.Format("SELECT COUNT(Name) AS 'TOTAL' FROM EmployeeInformation WHERE Subunit = 'Finance Department'"), Connection);
                Adapter3.Fill(EmployeeListCountTable);
                foreach (DataRow row in EmployeeListCountTable.Rows)
                {
                    c = Convert.ToInt32(row["TOTAL"]);
                }

                SqlDataAdapter Adapter4 = new SqlDataAdapter(string.Format("SELECT COUNT(Name) AS 'TOTAL' FROM EmployeeInformation WHERE Subunit = 'Administration Department'"), Connection);
                Adapter4.Fill(EmployeeListCountTable);
                foreach (DataRow row in EmployeeListCountTable.Rows)
                {
                    d = Convert.ToInt32(row["TOTAL"]);
                }

                SqlDataAdapter Adapter5 = new SqlDataAdapter(string.Format("SELECT COUNT(Name) AS 'TOTAL' FROM EmployeeInformation WHERE Subunit = 'IT Department'"), Connection);
                Adapter5.Fill(EmployeeListCountTable);
                foreach (DataRow row in EmployeeListCountTable.Rows)
                {
                    e = Convert.ToInt32(row["TOTAL"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            chartEmployeeList.Series["EmployeeList"].Points.AddXY("Sales Department", a);
            chartEmployeeList.Series["EmployeeList"].Points.AddXY("Engineering Department", b);
            chartEmployeeList.Series["EmployeeList"].Points.AddXY("Finance Department", c);
            chartEmployeeList.Series["EmployeeList"].Points.AddXY("Administration Department", d);
            chartEmployeeList.Series["EmployeeList"].Points.AddXY("IT Department", e);
        }

        private void AddNewsTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            using (NewsAddForm newsAddForm = new NewsAddForm())
            {
                newsAddForm.ShowDialog();
            }
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

        private void DeleteNewsTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (newsDataGridView.Rows.Count != 0 && newsDataGridView.Rows != null)
            {
                string subject = newsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    if (subject != null)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Connection.Open();
                            SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM NewsInformation WHERE NewID IN(SELECT NewID FROM NewsInformation WHERE Subject = '" + subject + "')", Connection);
                            Adapter.SelectCommand.ExecuteNonQuery();
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.Successfull;
                            popup.TitleText = "Data Delected";
                            popup.ContentText = "Data Sucessfully Deleted";
                            popup.ShowCloseButton = false;
                            popup.Popup();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "News Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
            }              
            newsDataShow();
        }
    }
}
