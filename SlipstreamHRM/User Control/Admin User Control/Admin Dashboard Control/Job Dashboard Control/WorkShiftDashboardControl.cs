using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using SlipstreamHRM.DAL;
using SlipstreamHRM.Forms.Admin_Control_Form;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Job_Dashboard_Control
{
    public partial class WorkShiftDashboardControl : UserControl
    {
        private WorkShiftDashboardControl _instance;

        public WorkShiftDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WorkShiftDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private WorkShiftInformation workShiftInformation;
        private string workShiftID;

        public WorkShiftDashboardControl()
        {
            InitializeComponent();
        }

        private void WorkShiftDashboardControl_Load(object sender, EventArgs e)
        {
            workShiftInformation = new WorkShiftInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            dataShow();
        }

        public void dataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT WorkShift as 'Work Shift', CAST(HoursPerDay AS numeric(10,2)) AS 'Hours Per Day', CAST(StartHour AS numeric(10,2)) AS 'From', CAST(EndHour AS numeric(10,2)) AS 'To' From WorkShiftInformation", Connection);
                DataTable WorkShiftInfoTable = new DataTable();
                Adapter.Fill(WorkShiftInfoTable);
                workShiftDataGridView.DataSource = WorkShiftInfoTable;
                workShiftDataGridView.Columns[0].Width = 225;
                workShiftDataGridView.Columns[1].Width = 220;
                workShiftDataGridView.Columns[2].Width = 220;
                workShiftDataGridView.Columns[3].Width = 220;
                workShiftDataGridView.BackgroundColor = Color.White;
                workShiftDataGridView.BorderStyle = BorderStyle.Fixed3D;
                workShiftDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                workShiftDataGridView.AllowUserToAddRows = false;
                workShiftDataGridView.AllowUserToDeleteRows = false;
                workShiftDataGridView.AllowUserToOrderColumns = true;
                workShiftDataGridView.ReadOnly = true;
                workShiftDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                workShiftDataGridView.MultiSelect = false;
                workShiftDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                workShiftDataGridView.AllowUserToResizeColumns = false;
                workShiftDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                workShiftDataGridView.AllowUserToResizeRows = false;
                workShiftDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                workShiftDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                workShiftDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                workShiftDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                workShiftDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                workShiftDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                workShiftDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                workShiftDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                workShiftDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Work Shift Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            using (WorkShiftAddEdit workShiftAddEdit = new WorkShiftAddEdit(null, null, 0, 0, 0))
            {
                workShiftAddEdit.ShowDialog();
            }
            dataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (workShiftDataGridView.Rows.Count != 0 && workShiftDataGridView.Rows != null)
            {
                string workShift = workShiftDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    if (workShift != null)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Connection.Open();
                            SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM WorkShiftInformation WHERE WorkShiftID IN(SELECT WorkShiftID FROM WorkShiftInformation WHERE WorkShift = '" + workShift + "')", Connection);
                            Adapter.SelectCommand.ExecuteNonQuery();
                            //MessageBox.Show(this, "Data Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Work Shift Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }

            }
            dataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (workShiftDataGridView.Rows.Count != 0 && workShiftDataGridView.Rows != null)
            {
                workShiftInformation.WorkShift = workShiftDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                workShiftInformation.HoursPerDay = float.Parse(workShiftDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                workShiftInformation.From = float.Parse(workShiftDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                workShiftInformation.To = float.Parse(workShiftDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                if (!string.IsNullOrEmpty(workShiftInformation.WorkShift))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select WorkShiftID From WorkShiftInformation Where WorkShift='{0}'", workShiftInformation.WorkShift), Connection);
                        DataTable WorkShiftInfomationTable = new DataTable();
                        Adapter.Fill(WorkShiftInfomationTable);

                        foreach (DataRow row in WorkShiftInfomationTable.Rows)
                        {
                            workShiftID = Convert.ToString(row["WorkShiftID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Work Shift Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }

                    using (WorkShiftAddEdit workShiftAddEdit = new WorkShiftAddEdit(workShiftID, workShiftInformation.WorkShift, workShiftInformation.HoursPerDay, workShiftInformation.From, workShiftInformation.To))
                    {
                        workShiftAddEdit.ShowDialog();
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
