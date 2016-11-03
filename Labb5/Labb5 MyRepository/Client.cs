using Labb4_MyRepository.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository
{
    class Client
    {
        internal void Start()
        {
            var pets = new PetController();
            var books = new BookController();
            var loop = true;

            while(loop)
            {
                UI.PrintStartMenu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        books.CallBookMenu();
                        break;

                    case ConsoleKey.D2:
                        pets.CallPetMenu();
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
