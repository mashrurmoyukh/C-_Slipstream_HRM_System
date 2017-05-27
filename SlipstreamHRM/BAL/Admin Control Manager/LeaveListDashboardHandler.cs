using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.Forms.Admin_Control_Form;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class LeaveListDashboardHandler
    {
        public void SelectAction(int leaveID)
        {
            using (LeaveActionForm leaveActionForm = new LeaveActionForm(leaveID))
            {
                leaveActionForm.ShowDialog();
            }
        }
    }
}
