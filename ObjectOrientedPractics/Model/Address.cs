using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        string _index;
        string _country;
        string _city;
        string _street;
        string _building;
        string _apartment;

        ValueValidator Validator = new ValueValidator();

        public Address()
        {
            Index = "000000";
            Country = "-";
            City = "-";
            Street = "-";
            Building = "-";
            Apartment = "-";
        }
        public Address(string _index,  string _country, string _city, string _street, string _building, string _apartment)
        {
            Index = _index;
            Country = _country;
            City = _city;
            Street = _street;
            Building = _building;
            Apartment = _apartment;

        }
        public string Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value.Length != 6 || int.Parse(value)<0)
                {
                    throw new Exception("Index != 6 цифр");
                }
                try
                {
                    int.Parse(value);
                    _index = value;
                }
                catch
                {
                    throw new Exception("Не удалось преобразовать Index В Int");
                }
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = Validator.AssertStringOnLength(value, 50, "Country");
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = Validator.AssertStringOnLength(value, 50, "City");
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = Validator.AssertStringOnLength(value, 100, "Street");
            }
        }

        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                _building = Validator.AssertStringOnLength(value, 10, "Building");
            }
        }

        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = Validator.AssertStringOnLength(value, 10, "Apartment");
            }
        }
    }
}
