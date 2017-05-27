using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class WorkShiftInformation
    {
        private string _workShift;
        private float _from;
        private float _to;
        private float _hoursPerDay;

        public string WorkShift
        {
            set
            {
                this._workShift = value;
            }
            get
            {
                return _workShift;
            }
        }

        public float From
        {
            set
            {
                this._from = value;
            }
            get
            {
                return _from;
            }
        }

        public float To
        {
            set
            {
                this._to = value;
            }
            get
            {
                return _to;
            }
        }

        public float HoursPerDay
        {
            set
            {
                this._hoursPerDay = value;
            }
            get
            {
                return _hoursPerDay;
            }
        }
    }
}
