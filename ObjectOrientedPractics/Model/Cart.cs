using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        
        public  List<Item> _items3 = new List<Item>();
        
        private double _amount;

        

        public List<Item> Items3
        {
            get
            {
                return _items3;
            }
            set
            {
                _items3 = value;
            }
        }
        

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
    }

    
}
