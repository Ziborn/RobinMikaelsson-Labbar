using Labb_13_Events_och_Delegater.Classes;
using Labb_13_Events_och_Delegater.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_13_Events_och_Delegater.Classes.Delegate;

namespace Labb_13_Events_och_Delegater
{
    class Runtime : McManager
    {
        Menu Menus = new Menu();
        McManager manager = new McManager();

        public void Start()
        {
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.MainMenu();

                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        ShowMcList();
                        break;
                    case ConsoleKey.D2:
                        AddMc();
                        break;
                    case ConsoleKey.D3:
                        StartFilter();
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }
        public void StartFilter()
        {
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.FilterMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        manager.PrintWhere(isMcTypeSportFilter);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        manager.PrintWhere(isMcTypeTouringFilter);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        manager.PrintWhere(isMcYearNewFilter);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        manager.PrintWhere(isMcYearOldFilter);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        manager.PrintWhere(isManufacturerTriumphFilter);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        loop = false;
                        break;
                }
            }
        }
    }
}
