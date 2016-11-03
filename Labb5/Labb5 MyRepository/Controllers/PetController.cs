using Labb4_MyRepository.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.Controllers
{
    class PetController
    {
        private IRepositoriesPets repositoryPets = new ListRepositoriesPets();
        

        public void AddPet()
        {
            var newPet = UI.AddPet();
            repositoryPets.AddPet(newPet);
        }

        public void CallPetMenu()
        {


            var loop = true;

            while (loop)
            {
                UI.ShowPetMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        ShowPetList();
                        break;
                    case ConsoleKey.D2:
                        AddPet();
                        break;
                    case ConsoleKey.D3:
                        EditPet();
                        break;
                    case ConsoleKey.D4:
                        RemovePet();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
        public void ShowPetList()
        {
            Console.Clear();
            UI.ShowPetList(repositoryPets.GetPets());
            Console.ReadKey(true);
        }
        public void EditPet()
        {
            Console.Clear();
            var pets = repositoryPets.GetPets();
            UI.ShowPetList(pets);
            int index = UI.SelectPet(repositoryPets.GetPets()) - 1;

            UI.EditPet(pets[index]);
        }
        public void RemovePet()
        {
            var pets = repositoryPets.GetPets();
            var index = UI.SelectPet(repositoryPets.GetPets()) - 1;
            repositoryPets.RemovePet(pets[index]);
        }

    }
}

