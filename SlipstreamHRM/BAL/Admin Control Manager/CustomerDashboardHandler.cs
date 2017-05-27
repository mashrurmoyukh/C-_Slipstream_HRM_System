using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.Forms;
using SlipstreamHRM.Forms.Admin_Control_Form;
using System.Windows.Forms;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class CustomerDashboardHandler
    {
        public void AddCustomerForm()
        {
            using (CustomerAddForm customerAddForm = new CustomerAddForm())
            {
                customerAddForm.ShowDialog();
            }
        }
    }
}
