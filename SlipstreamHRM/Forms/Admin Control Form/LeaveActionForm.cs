using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class LeaveActionForm : MaterialSkin.Controls.MaterialForm
    {
        private int LeaveId;
        public LeaveActionForm(int leaveID)
        {
            InitializeComponent();
            this.LeaveId = leaveID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cancelRadioButton.Checked || approveRadioButton.Checked || rejectRadioButton.Checked)
            {
                LeaveListInformation leaveListInformation = new LeaveListInformation();
                leaveListInformation.LeaveId = LeaveId;

                if (cancelRadioButton.Checked)
                {
                    leaveListInformation.SelectedAction = cancelRadioButton.Text.ToString();
                    leaveListInformation.assignSelectedAction();
                }

                else if (approveRadioButton.Checked)
                {
                    leaveListInformation.SelectedAction = approveRadioButton.Text.ToString();
                    leaveListInformation.assignSelectedAction();
                }

                else
                {
                    leaveListInformation.SelectedAction = rejectRadioButton.Text;
                    leaveListInformation.assignSelectedAction();
                }
                this.Close();            
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Select Action", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
