using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13_Events_och_Delegater.Classes
{
    class Delegate
    {
        public delegate bool McFilters(Motorcycle motorcycle);
        public delegate void PrintMessage(string message);
    }
}
