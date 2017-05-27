using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class JobCategoryInformation
    {
        private string _jobCategory;

        public string JobCategory
        {
            set
            {
                this._jobCategory = value;
            }
            get
            {
                return _jobCategory;
            }
        }
    }
}
