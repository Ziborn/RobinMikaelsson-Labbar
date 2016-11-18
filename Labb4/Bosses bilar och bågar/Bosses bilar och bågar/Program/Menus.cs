using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosses_bilar_och_bågar
{
    class Menus : Vehiclemanager
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("**Bosses bilar och bågar**");
            Console.WriteLine("\n1. List all vehicles");
            Console.WriteLine("2. Manage vehicles");
            Console.WriteLine("3. Exit");
        }

        public void EditVehiclesMenu()
        {
            bool loop = false;

            while (!loop)
            {
                Console.Clear();
                Console.WriteLine("**Manage vehicles**");
                Console.WriteLine("\n1. New Cars");
                Console.WriteLine("2. Used Cars");
                Console.WriteLine("3. New bikes");
                Console.WriteLine("4. Used bikes");
                Console.WriteLine("5. Back");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        NewCarMenu();
                        break;
                    case ConsoleKey.D2:
                        OldCarMenu();
                        break;
                    case ConsoleKey.D3:
                        NewBikeMenu();
                        break;
                    case ConsoleKey.D4:
                        OldBikeMenu();
                        break;
                    case ConsoleKey.D5:
                        loop = true;
                        break;

                }
            }
        }
        public void NewCarMenu()
        {
            bool loop = false;

            while (!loop)
            {
                Console.Clear();
                Console.WriteLine("**New cars**");
                Console.WriteLine("\n1. Add new car");
                Console.WriteLine("2. Sell new car");
                Console.WriteLine("3. Add more carmodels");
                Console.WriteLine("4. Back");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        AddNewCar();
                        break;
                    case ConsoleKey.D2:
                        SellNewCar();
                        break;
                    case ConsoleKey.D3:
                        ChangeQuantityCar();
                        break;
                    case ConsoleKey.D4:
                        loop = true;
                        break;
                }
            }
        }
        public void OldCarMenu()
        {
            bool loop = false;

            while (!loop)
            {
                Console.Clear();
                Console.WriteLine("**Used cars**");
                Console.WriteLine("\n1. Add used car");
                Console.WriteLine("2. Sell used car");
                Console.WriteLine("3. Back");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        AddOldCar();
                        break;
                    case ConsoleKey.D2:
                        SellOldCar();
                        break;
                    case ConsoleKey.D3:
                        loop = true;
                        break;
                }
            }
        }
        public void NewBikeMenu()
        {
            bool loop = false;

            while (!loop)
            {
                Console.Clear();
                Console.WriteLine("**New bikes**");
                Console.WriteLine("\n1. Add new bike");
                Console.WriteLine("2. Sell new bike");
                Console.WriteLine("3. Add more bikemodels");
                Console.WriteLine("4. Back");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        AddNewBike();
                        break;
                    case ConsoleKey.D2:
                        SellNewBike();
                        break;
                    case ConsoleKey.D3:
                        ChangeQuantityBike();
                        break;
                    case ConsoleKey.D4:
                        loop = true;
                        break;
                }
            }
        }
        public void OldBikeMenu()
        {
            bool loop = false;

            while (!loop)
            {
                Console.Clear();
                Console.WriteLine("**Used bikes**");
                Console.WriteLine("\n1. Add used bike");
                Console.WriteLine("2. Sell used bike");
                Console.WriteLine("3. Back");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        AddOldBike();
                        break;
                    case ConsoleKey.D2:
                        SellOldBike();
                        break;
                    case ConsoleKey.D3:
                        loop = true;
                        break;
                }
            }
        }
    }
}
