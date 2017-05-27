using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class VacancyDashboardHandler
    {
        public void AddVacancy(string a, string b, string c, string d, string e)
        {
            VacancyInformation vacancyInformation = new VacancyInformation();
            vacancyInformation.HiringManager = a;
            vacancyInformation.NOP = Convert.ToInt32(b);
            vacancyInformation.VacancyName = c;
            vacancyInformation.JobTitle = d;
            vacancyInformation.Description = e;

            vacancyInformation.AddVacancy();
        }
    }
}
