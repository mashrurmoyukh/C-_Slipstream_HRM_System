using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class EmploymentStatusInformation
    {
        private string _employmentStatus;

        public string EmploymentStatus
        {
            set
            {
                this._employmentStatus = value;
            }
            get
            {
                return _employmentStatus;
            }
        }
    }
}
