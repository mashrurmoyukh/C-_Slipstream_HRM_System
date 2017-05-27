using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;

namespace SlipstreamHRM.Forms
{
    public partial class RegionAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private RegionInformation regionInformation;
        private string RegionID;

        public RegionAddEditForm(string regionID, string regionName)
        {
            InitializeComponent();
            this.RegionID = regionID;
            this.Text = "Add Region";
            if (!string.IsNullOrEmpty(RegionID))
            {
                this.Text = "Edit Region";
                txtRegionName.Text = regionName;
            }
        }

        private void RegionAddEditForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            regionInformation = new RegionInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _regionID = Convert.ToInt32(RegionID);
            regionInformation.Regionname = txtRegionName.Text;

            if (string.IsNullOrEmpty(RegionID))
            {
                try
                {
                    if (!string.IsNullOrEmpty(regionInformation.Regionname))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO RegionInformation (Regionname) VALUES ('" + regionInformation.Regionname + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Region Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (!string.IsNullOrEmpty(regionInformation.Regionname))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE RegionInformation SET Regionname = '{0}' WHERE RegionID = '{1}'", regionInformation.Regionname, _regionID), Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Region Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
