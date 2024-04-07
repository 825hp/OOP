using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private static int _count = 1;
        private readonly int _id = _count++;
        DateTime _date;
        Address _address;
        Cart _cart;


        public int Id
        {
            get
            {
                return _id;
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set {  _date = value; }
        }
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;   
            }
        }
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }
    }

}
