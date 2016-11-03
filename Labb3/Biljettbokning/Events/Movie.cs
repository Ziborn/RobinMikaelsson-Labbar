using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Movie : Event
    {
        public string MovieName { get; set; }
        public int MoviePrice { get; set; }
        public string MovieTime { get; set; }
        public override string info()
        {
            return String.Format("{0} Movie: {1} | Price: {2} | Time: {3} | ",
            base.info(), MovieName, MoviePrice, MovieTime);
        }
    }
}