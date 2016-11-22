using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface.Interfaces
{
    interface IVehicle
    {
        string Start();
        string Stop();
        string Lock();
        string Unlock();
    }
}
