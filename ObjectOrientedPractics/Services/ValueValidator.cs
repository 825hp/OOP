using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ValueValidator
    {
        public string AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value == null || value == "")
            {
                throw new ArgumentException($"{propertyName} должен быть не пустым");

            }
            else if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть не пустым");
            }
            else
            {
                return value;
            }
        }
    }
}
