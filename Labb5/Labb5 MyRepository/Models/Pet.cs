using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.Models
{
    class Pet
    {
        public enum PetCategory
        {
            Cat = 1,
            Dog,
            Turtle,
            Bird,
            Hippopotatoplant
        }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public PetCategory PetType { get; set; }
    }
}
