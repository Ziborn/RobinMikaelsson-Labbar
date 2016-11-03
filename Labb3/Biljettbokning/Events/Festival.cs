using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Festival : Event
    {
        public string FestivalName { get; set; }
        public string FestivalType { get; set; }
        public int FestivalPrice { get; set;}
        public override string info()
        {
            return String.Format("{0} Festival: {1} | Genre: {2} | Price: {3} | ",
            base.info(), FestivalName, FestivalType, FestivalPrice);
        }
    }
}