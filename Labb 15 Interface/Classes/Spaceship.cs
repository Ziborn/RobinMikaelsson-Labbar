using Labb_15_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface.Classes
{
    class Spaceship : IVehicle
    {
        public string Lock()
        {
            return "The spaceship is locked..";
        }

        public string Start()
        {
            return "The spaceship starts..";
        }

        public string Stop()
        {
            return "The spaceship stops..";
        }

        public string Unlock()
        {
            return "The spaceship is unlocked";
        }
    }
}
