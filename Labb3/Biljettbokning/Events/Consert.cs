using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biljettbokning
{
    public class Consert : Event
    {
        public string ConsertArtist { get; set; }
        public string ConsertGenre { get; set; }
        public int ConsertPrice { get; set; }
        public override string info()
        { 
            return String.Format("{0} Consert: {1} | Genre: {2} | Price: {3} | ",
            base.info(), ConsertArtist, ConsertGenre, ConsertPrice );
        }
    }
}