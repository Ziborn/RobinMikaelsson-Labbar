using Labb_15_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface.Classes
{
    class Button : IPushable
    {
        public string Push()
        {
            return "When you push the button you hear an explosion..";
        }
    }
}
