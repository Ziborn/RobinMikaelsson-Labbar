using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class Runtime : EventManager
    {

        public void Start()
        {
            bool loop = true;

            while (loop)
            {
                MainMenu.StartMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ShowEvents();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        BookEvent();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        ShowBookedEvents();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        loop = false;
                        break;

                }


            }
        }
    }
}

