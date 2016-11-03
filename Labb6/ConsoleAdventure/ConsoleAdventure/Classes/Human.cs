using ConsoleAdventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.Classes
{
    class Human : INonPlayerCharacter
    {
        
        public string Description { get; set; }
        public string Dialouge { get; set; }
        
        public string NpcDescription()
        {
            return "In the room there is " + Description;
        }

        public string Speak()
        {
            return Dialouge;
        }
    }
}
