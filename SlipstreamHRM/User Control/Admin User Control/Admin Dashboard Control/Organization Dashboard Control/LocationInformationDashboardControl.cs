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

namespace SlipstreamHRM.User_Control.Admin_User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control
{
    public partial class LocationInformationDashboardControl : UserControl
    {
        private SqlConnection Connection;
        private LocationInformationDashboardHandler locationInformationDashboardHandler;
        private LocationInformationDashboardControl _instance;

        public LocationInformationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LocationInformationDashboardControl();
                return _instance;
            }
        }

        public LocationInformationDashboardControl()
        {
            InitializeComponent();
        }

        private void LocationInformationDashboardControl_Load(object sender, EventArgs e)
        {
            locationInformationDashboardHandler = new LocationInformationDashboardHandler();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            fillRegionComboBox();
            LocationDataShow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLocationName.Text))
            {
                locationInformationDashboardHandler.AddLocation(txtLocationName.Text, comboxCountry.Text);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Input Location Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LocationDataShow();
        }

        public void LocationDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Location AS 'Location Name', Country FROM LocationInformation ORDER BY Location", Connection);
                DataTable LocationTitleInfoTable = new DataTable();
                Adapter.Fill(LocationTitleInfoTable);
                locationDataGridView.DataSource = LocationTitleInfoTable;

                locationDataGridView.Columns[0].Width = 205;
                locationDataGridView.Columns[1].Width = 680;

                locationDataGridView.BackgroundColor = Color.White;
                locationDataGridView.BorderStyle = BorderStyle.Fixed3D;
                locationDataGridView.Cursor = Cursors.Hand;

                // Set property values appropriate for read-only display and 
                // limited interactivity. 
                locationDataGridView.AllowUserToAddRows = false;
                locationDataGridView.AllowUserToDeleteRows = false;
                locationDataGridView.AllowUserToOrderColumns = true;
                locationDataGridView.ReadOnly = true;
                locationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                locationDataGridView.MultiSelect = false;
                locationDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                locationDataGridView.AllowUserToResizeColumns = false;
                locationDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                locationDataGridView.AllowUserToResizeRows = false;
                locationDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Set the selection background color for all the cells.
                locationDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                locationDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                locationDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                // Set the background color for all rows and for alternating rows. 
                // The value for alternating rows overrides the value for all rows. 
                locationDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                locationDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                // Set the row and column header styles.
                locationDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                locationDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                locationDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Job Title Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void fillRegionComboBox()
        {
            try
            {
                string _RegionName;
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From RegionInformation ORDER BY RegionName"), Connection);
                DataTable RegionInfomationTable = new DataTable();
                Adapter.Fill(RegionInfomationTable);

                foreach (DataRow row in RegionInfomationTable.Rows)
                {
                    _RegionName = row["RegionName"].ToString();
                    comboxCountry.Items.Add(_RegionName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Region Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (locationDataGridView.Rows.Count != 0 && locationDataGridView.Rows != null)
            {
                string locationInformationName = locationDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (locationInformationName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        locationInformationDashboardHandler.DeleteLocation(locationInformationName);
                    }
                }
            }
            LocationDataShow();
        }
    }
}
