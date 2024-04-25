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
        OrderStatus _orderStatus = 0;
        Address _address;
        Cart _cart = new Cart();
        string fullname;

        //public Order(DateTime date, Address address, Cart cart)
        //{
        //    Cart2 = cart;
        //    Date = date;
        //    Address = address;
        //}
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }   
        }
        public OrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set { _orderStatus = value; }   
        }
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
        
    }

}
