using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Event
    {
        public string Location { get; set; }
        public string BookingName { get; set; }
        
        public virtual string info()
        {
            return String.Format(". Name: {0} | Location: {1}  | ", BookingName, Location);
        }
    }
}