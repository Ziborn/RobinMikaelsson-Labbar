using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13_Events_och_Delegater.Menus
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("- Labb 13 -");
            Console.WriteLine("\n1. Show List");
            Console.WriteLine("2. Add motorcycle");
            Console.WriteLine("3. Filters");
            Console.WriteLine("4. Exit");
        }
        public void FilterMenu()
        {
            Console.WriteLine("- Filters -");
            Console.WriteLine("\n1. Sport bikes");
            Console.WriteLine("2. Touringbikes");
            Console.WriteLine("3. Bikes from 2010 - 2017");
            Console.WriteLine("4. Bikes from before 2010");
            Console.WriteLine("5. Bikes from Triumph");
            Console.WriteLine("6. Back");
        }
    }
}
