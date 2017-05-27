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
using SlipstreamHRM.Forms;
using SlipstreamHRM.DAL;
namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class NationalitiesDashboardControl : UserControl
    {
        private NationalitiesDashboardControl _instance;

        public NationalitiesDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NationalitiesDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private RegionInformation regionInformation;
        private string regionID;


        public NationalitiesDashboardControl()
        {
            InitializeComponent();
        }

        public void dataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT RegionName as 'Region Name' FROM RegionInformation", Connection);
                DataTable RegionInfoTable = new DataTable();
                Adapter.Fill(RegionInfoTable);
                regionDataGridView.DataSource = RegionInfoTable;
                regionDataGridView.Columns[0].Width = 880;
                regionDataGridView.BackgroundColor = Color.White;
                regionDataGridView.BorderStyle = BorderStyle.Fixed3D;
                regionDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                regionDataGridView.AllowUserToAddRows = false;
                regionDataGridView.AllowUserToDeleteRows = false;
                regionDataGridView.AllowUserToOrderColumns = true;
                regionDataGridView.ReadOnly = true;
                regionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                regionDataGridView.MultiSelect = false;
                regionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                regionDataGridView.AllowUserToResizeColumns = false;
                regionDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                regionDataGridView.AllowUserToResizeRows = false;
                regionDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                regionDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                regionDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                regionDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                regionDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                regionDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                regionDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                regionDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                regionDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Region Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void NationalitiesDashboardControl_Load(object sender, EventArgs e)
        {
            regionInformation = new RegionInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            dataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            using (RegionAddEditForm regionAddEditForm = new RegionAddEditForm(null, null))
            {
                regionAddEditForm.ShowDialog();
            }
            dataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            string regionName = regionDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                if (regionName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("DELETE FROM RegionInformation WHERE RegionID IN(SELECT RegionID FROM RegionInformation WHERE RegionName = '" + regionName + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        //MessageBox.Show(this, "Data Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Region Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (regionDataGridView.Rows.Count != 0 && regionDataGridView.Rows != null)
            {
                regionInformation.Regionname = regionDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(regionInformation.Regionname))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select RegionID From RegionInformation Where Regionname='{0}'", regionInformation.Regionname), Connection);
                        DataTable RegionInfomationTable = new DataTable();
                        Adapter.Fill(RegionInfomationTable);

                        foreach (DataRow row in RegionInfomationTable.Rows)
                        {
                            regionID = Convert.ToString(row["RegionID"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Region Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                    finally
                    {
                        Connection.Close();
                    }

                    using (RegionAddEditForm regionAddEditForm = new RegionAddEditForm(regionID, regionInformation.Regionname))
                    {
                        regionAddEditForm.ShowDialog();
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
