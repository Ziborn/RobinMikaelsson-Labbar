using Labb_15_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface.Classes
{
    class Car : IVehicle
    {
        public string Lock()
        {
            return "The car is locked";
        }

        public string Start()
        {
            return "The car starts..";
        }

        public string Stop()
        {
            return "The car stops..";
        }

        public string Unlock()
        {
            return "The car is unlocked";
        }
    }
}
