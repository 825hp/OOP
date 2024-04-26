using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class PriorityOrder: Order
    {
        public DateTime DateTime { get; set; }
        //public TimeInterval time_Interval { get; set; }
        public string time_Interval { get; set; }

        public PriorityOrder(DateTime dateTime, string timeInterval)
        
        {
            DateTime = dateTime;
            time_Interval = timeInterval;
            //time_Interval = timeInterval;
        }
    }
    
}
