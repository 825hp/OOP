using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items3 = new List<Item>();
        public double _amount;
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
                
                if (_items3.Count == 0)
                {
                    return 0.0;
                }
                else
                {
                    double current = 0.0;
                    for (int i = 0; i < _items3.Count; i++)
                    {
                        current += _items3[i].Cost;
                    }
                    return current;
                }
            }
        }
    }

    
}
