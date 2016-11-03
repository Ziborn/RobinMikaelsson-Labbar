using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.DataStores.Repositories
{
    class ListRepositoriesPets : IRepositoriesPets
    {
        public Pet[] GetPets()
        {
            return MyLists.Pets.ToArray();
        }
        public void AddPet(Pet newPet)
        {
            MyLists.Pets.Add(newPet);
        }
        public void RemovePet(Pet removePet)
        {
            MyLists.Pets.Remove(removePet);
        }
    }
}
