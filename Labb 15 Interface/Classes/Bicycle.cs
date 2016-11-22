using Labb_15_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface.Classes
{
    class Bicycle : IVehicle
    {
        public string Lock()
        {
            return "You lock the bicycle";
        }

        public string Start()
        {
            return "You start to pedal";
        }

        public string Stop()
        {
            return "You stop the bike..";
        }

        public string Unlock()
        {
            return "You take off the lock on the bike";
        }
    }
}
