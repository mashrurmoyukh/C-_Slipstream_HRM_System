using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.DAL;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class ApplyDashboardHandler
    {
        private LeaveInformation leaveInformation = new LeaveInformation();

        public void ApplyLeave(string EmployeeName, string LeaveType, DateTime From, DateTime To, string Comments)
        {
            leaveInformation.EmpName = EmployeeName;
            leaveInformation.LeaveType = LeaveType;
            leaveInformation.From = From;
            leaveInformation.To = To;
            leaveInformation.Comment = Comments;

            leaveInformation.AddLeave();
        }

        public void AsignLeave(string EmployeeName, string LeaveType, DateTime From, DateTime To, string Comments)
        {
            leaveInformation.EmpName = EmployeeName;
            leaveInformation.LeaveType = LeaveType;
            leaveInformation.From = From;
            leaveInformation.To = To;
            leaveInformation.Comment = Comments;

            leaveInformation.AssignLeave();
        }
    }
}
