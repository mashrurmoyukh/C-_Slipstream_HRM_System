using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class RegionInformation
    {
        private string _regionName;

        public string Regionname
        {
            set
            {
                this._regionName = value;
            }
            get
            {
                return _regionName;
            }
        }
    }
}
