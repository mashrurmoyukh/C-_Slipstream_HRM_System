using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class CustomerAddForm : MaterialSkin.Controls.MaterialForm
    {
        private CustomerInformation customerInformation;

        public CustomerAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                customerInformation.Customer = txtCustomerName.Text.ToString();
                customerInformation.Description = txtDescription.Text.ToString();
                customerInformation.AddCustomer();
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Input Customer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            customerInformation = new CustomerInformation();
        }
    }
}
