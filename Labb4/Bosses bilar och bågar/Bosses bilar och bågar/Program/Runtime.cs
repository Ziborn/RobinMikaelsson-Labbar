using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosses_bilar_och_bågar
{
    class Runtime : Menus
    {
        public void Start()
        {
            bool loop = true;

            while (loop)
            {

                MainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        ShowNewCars();
                        ShowOldCars();
                        ShowNewBikes();
                        ShowOldBikes();
                        break;
                    case ConsoleKey.D2:
                        EditVehiclesMenu();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }

            }
        }
    }
}
