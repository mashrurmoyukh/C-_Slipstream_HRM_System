using SlipstreamHRM.DAL.Admin_Control_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class CandidateDashboardHandler
    {
        public void AddCandidate(string a, string b, string c, string d, string e)
        {
            CandidateInformation candidateInformation = new CandidateInformation();
            candidateInformation.FullName = a;
            candidateInformation.Email = b;
            candidateInformation.ContactNo = c;
            candidateInformation.VacancyName = e;

            candidateInformation.AddCandidate();
        }
    }
}
