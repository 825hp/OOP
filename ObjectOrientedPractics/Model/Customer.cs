using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс Покупателя
    /// </summary>
    internal class Customer
    {
        private static int _count = 1;
        private readonly int _id = _count++;

        private string _fullname;
        private Address _address;

        ValueValidator Validator = new ValueValidator();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="fullname">ФИО</param>
        /// <param name="address">Адрес</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Свойство Id
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Свойство ФИО
        /// </summary>
        public string Fullname
        {
            set
            {
                _fullname = Validator.AssertStringOnLength(value, 200, "Fullname");
            }
            get
            {
                return _fullname;
            }
        }

        /// <summary>
        /// Свойство Адреса
        /// </summary>
        public Address Address
        {
            set
            {
                _address = value; 
                
            }
            get
            {
                return _address;
            }
        }


    }
}
