using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class OrganizationInformation
    {
        private string _organizationName;
        private string _taxID;
        private string _rgistrationNumber;
        private int _numberofEmployess;
        private string _phone;
        private string _fax;
        private string _email;
        private string _addressStreet1;
        private string _addressStreet2;
        private string _city;
        private string _state;
        private string _zipPostalCode;
        private string _country;
        private string _note;

        public string OrganizationName
        {
            set
            {
                this._organizationName = value;
            }
            get
            {
                return _organizationName;
            }
        }

        public string TaxID
        {
            set
            {
                this._taxID = value;
            }
            get
            {
                return _taxID;
            }
        }

        public string RgistrationNumber
        {
            set
            {
                this._rgistrationNumber = value;
            }
            get
            {
                return _rgistrationNumber;
            }
        }

        public int NumberofEmployess
        {
            set
            {
                this._numberofEmployess = value;
            }
            get
            {
                return _numberofEmployess;
            }
        }

        public string Phone
        {
            set
            {
                this._phone = value;
            }
            get
            {
                return _phone;
            }
        }

        public string Fax
        {
            set
            {
                this._fax = value;
            }
            get
            {
                return _fax;
            }
        }

        public string Email
        {
            set
            {
                this._email = value;
            }
            get
            {
                return _email;
            }
        }

        public string AddressStreet1
        {
            set
            {
                this._addressStreet1 = value;
            }
            get
            {
                return _addressStreet1;
            }
        }

        public string AddressStreet2
        {
            set
            {
                this._addressStreet2 = value;
            }
            get
            {
                return _addressStreet2;
            }
        }

        public string City
        {
            set
            {
                this._city = value;
            }
            get
            {
                return _city;
            }
        }

        public string State
        {
            set
            {
                this._state = value;
            }
            get
            {
                return _state;
            }
        }

        public string ZipPostalCode
        {
            set
            {
                this._zipPostalCode = value;
            }
            get
            {
                return _zipPostalCode;
            }
        }

        public string Country
        {
            set
            {
                this._country = value;
            }
            get
            {
                return _country;
            }
        }

        public string Note
        {
            set
            {
                this._note = value;
            }
            get
            {
                return _note;
            }
        }
    }
}
