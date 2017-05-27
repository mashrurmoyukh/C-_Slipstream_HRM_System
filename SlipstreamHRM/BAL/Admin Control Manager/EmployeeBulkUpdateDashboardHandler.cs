using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class EmployeeBulkUpdateDashboardHandler
    {
        private SqlConnection Connection;
        private EmployeeBulkUpdateInformation employeeBulkUpdateInformation = new EmployeeBulkUpdateInformation();

        public EmployeeBulkUpdateDashboardHandler()
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        public void saveBulkUpdate(string EmployeeName, string SupervisorName, string EmployeeStatus, string SubUnit, string JobTitle, string Include, string Location, string WorkShift, DateTime JoinedDate)
        {
            employeeBulkUpdateInformation.EmpName = EmployeeName;
            employeeBulkUpdateInformation.Supervisorname = SupervisorName;
            employeeBulkUpdateInformation.EmpStatus = EmployeeStatus;
            employeeBulkUpdateInformation.SubUnit = SubUnit;
            employeeBulkUpdateInformation.JobTitle = JobTitle;
            employeeBulkUpdateInformation.Include = Include;
            employeeBulkUpdateInformation.Location = Location;
            employeeBulkUpdateInformation.WorkShift = WorkShift;
            employeeBulkUpdateInformation.JoinedDate = JoinedDate;
                      
            employeeBulkUpdateInformation.updateEmployee();
        }
    }
}
