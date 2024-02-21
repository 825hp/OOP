using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private static int _count = 0;

        private readonly int _id = _count++;
        private string _fullname;
        private string _address;

        ValueValidator Validator = new ValueValidator();
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Fullname
        {
            set
            {
                _fullname = Validator.AssertStringOnLength(value, 200, Fullname);
            }
            get
            {
                return _fullname;
            }
        }

        public string Address
        {
            set
            {
                _address = Validator.AssertStringOnLength(value, 500, Address);
            }
            get
            {
                return _address;
            }
        }


    }
}
