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
using Tulpep.NotificationWindow;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control
{
    public partial class GeneralInformationDashboardControl : UserControl
    {
        private GeneralInformationDashboardControl _instance;

        public GeneralInformationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GeneralInformationDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private OrganizationInformation organizationInformation;

        public GeneralInformationDashboardControl()
        {
            InitializeComponent();
        }

        private void GeneralInformationDashboardControl_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            organizationInformation = new OrganizationInformation();
            OganizationInformationShow();
            fillRegionComboBox();        
        }

        public void OganizationInformationShow()
        {           
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * From OrganizationInformation"), Connection);
                DataTable OrganizationInfomationTable = new DataTable();
                Adapter.Fill(OrganizationInfomationTable);

                foreach (DataRow row in OrganizationInfomationTable.Rows)
                {
                    organizationInformation.OrganizationName = row["OrganizationName"].ToString();
                    organizationInformation.TaxID = row["TaxID"].ToString();
                    organizationInformation.NumberofEmployess = Convert.ToInt32(row["NumberofEmployees"]);
                    organizationInformation.RgistrationNumber = row["RegistrationNumber"].ToString();
                    organizationInformation.Phone = row["Phone"].ToString();
                    organizationInformation.Fax = row["Fax"].ToString();
                    organizationInformation.Email = row["Email"].ToString();
                    organizationInformation.AddressStreet1 = row["AddressStreet1"].ToString();
                    organizationInformation.AddressStreet2 = row["AddressStreet2"].ToString();
                    organizationInformation.City = row["City"].ToString();
                    organizationInformation.State = row["State"].ToString();
                    organizationInformation.ZipPostalCode = row["ZipCode"].ToString();
                    organizationInformation.Country = row["Country"].ToString();
                    organizationInformation.Note = row["Note"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "User Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            txtOrganizationName.Text = organizationInformation.OrganizationName;
            txtTaxID.Text = organizationInformation.TaxID;
            txtNumberofEmployees.Text = Convert.ToString(organizationInformation.NumberofEmployess);
            txtRegistrationNumber.Text = organizationInformation.RgistrationNumber;
            txtPhone.Text = organizationInformation.Phone;
            txtFax.Text = organizationInformation.Fax;
            txtEmail.Text = organizationInformation.Email;
            txtAddressStreet1.Text = organizationInformation.AddressStreet1;
            txtAddressStreet2.Text = organizationInformation.AddressStreet2;
            txtCity.Text = organizationInformation.City;
            txtState.Text = organizationInformation.State;
            txtZIPPostalCode.Text = organizationInformation.ZipPostalCode;
            comboxCountry.Text = organizationInformation.Country;
            txtNote.Text = organizationInformation.Note;
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
                comboxCountry.Text = organizationInformation.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a,b,d,ea,f,g,h,i,j,k,l,m,ca;
            int c;
            a = organizationInformation.OrganizationName = txtOrganizationName.Text;
            b = organizationInformation.TaxID = txtTaxID.Text;
            c = organizationInformation.NumberofEmployess = Convert.ToInt32(txtNumberofEmployees.Text);
            ca = organizationInformation.RgistrationNumber = txtRegistrationNumber.Text;
            d = organizationInformation.Phone = txtPhone.Text;
            ea = organizationInformation.Fax = txtFax.Text;
            f = organizationInformation.Email = txtEmail.Text;
            g = organizationInformation.AddressStreet1 = txtAddressStreet1.Text;
            h = organizationInformation.AddressStreet2 = txtAddressStreet2.Text;
            i = organizationInformation.City = txtCity.Text;
            j = organizationInformation.State = txtState.Text;
            k = organizationInformation.ZipPostalCode = txtZIPPostalCode.Text;
            l = organizationInformation.Country = comboxCountry.Text;
            m = organizationInformation.Note = txtNote.Text;
            try
            {
                if (!string.IsNullOrEmpty(organizationInformation.OrganizationName))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("UPDATE OrganizationInformation SET OrganizationName = '{0}', TaxID = '{1}', NumberofEmployees = '{2}', Phone = '{3}'", a, b, c, d), Connection);
                        Adapter1.SelectCommand.ExecuteNonQuery();
                        SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("UPDATE OrganizationInformation SET Fax = '{0}', Email = '{1}', AddressStreet1 = '{2}', AddressStreet2 = '{3}'", ea, f, g, h), Connection);
                        Adapter2.SelectCommand.ExecuteNonQuery();
                        SqlDataAdapter Adapter3 = new SqlDataAdapter(string.Format("UPDATE OrganizationInformation SET City = '{0}', State = '{1}', ZipCode = '{2}', Country = '{3}', Note = '{4}', RegistrationNumber = '{5}'", i, j, k, l, m,ca), Connection);
                        Adapter3.SelectCommand.ExecuteNonQuery();
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Properties.Resources.Successfull;
                        popup.TitleText = "Organization Information Save";
                        popup.ContentText = "Organization Information Successfully Updated";
                        popup.ShowCloseButton = false;
                        popup.Popup();
                        
                    }                 
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Oragnization Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Update General Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
            OganizationInformationShow();
        }
    }
}
