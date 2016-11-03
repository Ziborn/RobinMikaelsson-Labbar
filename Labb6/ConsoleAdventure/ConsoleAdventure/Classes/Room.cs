using ConsoleAdventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.Classes
{
    class Room : IEnviroment
    {
        public string Enviroment { get; set; }
        public string Size { get; set; }
        public string Item { get; set; }
        public string ItemAction { get; set; }

        public string ObserveEnviroment()
        {
            return "The size of the room is " + Size + ", " + Enviroment + " There is a " + Item + " in the room";
        }

        public string ItemInteraction()
        {
            return ItemAction;
        }
    }
}
