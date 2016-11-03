using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.DataStores.Repositories
{
    interface IRepositoriesPets
    {
        Pet[] GetPets();
        void AddPet(Pet newPet);
        void RemovePet(Pet removePet);
    }
}
