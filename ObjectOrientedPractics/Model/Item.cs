using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private static int _count = 0;

        private readonly int _id = _count++;
        private string _name;
        private string _info;
        private float _cost;

        ValueValidator Validator = new ValueValidator();
        public Item(string name, string info, float cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            set
            {
                _name = Validator.AssertStringOnLength(value, 200, Name);
            }
            get
            {
                return _name;
            }
        }

        public string Info
        {
            set
            {
                _info = Validator.AssertStringOnLength(value, 1000, Info);
            }
            get
            {
                return _info;
            }
        }

        public float Cost
        {
            set
            {
                if (value <0 || value > 100000)
                {
                    throw new ArgumentException("Your price is wrong, check it");
                }
                else
                {
                    _cost = value; 
                }
            }
            get
            {
                return _cost;
            }
        }

    }
}
