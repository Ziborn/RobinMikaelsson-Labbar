using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosses_bilar_och_bågar
{
    class Vehiclemanager
    {
        public List<NewCar> newCarList = new List<NewCar>
        {
            new NewCar {Model = "A6", NewCarSmell = true, Manufacturer = "Audi", Price = 599875, Quantity = 7, Transmission = "Manual", Color = "Blue", Year = 2017},
            new NewCar {Model = "XC90", NewCarSmell = true, Manufacturer = "Volvo", Price = 485995, Quantity = 2, Transmission = "Automatic", Color = "Silver", Year = 2017},
            new NewCar {Model = "M3", NewCarSmell = true, Manufacturer = "BMW", Price = 685995, Quantity = 1, Transmission = "Automatic", Color = "Black", Year = 2017}
        };
        public List<NewBike> newBikeList = new List<NewBike>
        {
            new NewBike {Model = "F4RR", Manufacturer = "Mv Agusta", ABS = true, CC = 1000, Price = 269000, Quantity = 1, Year = 2017, Color = "Black" },
            new NewBike {Model = "ZX10R", Manufacturer = "Kawasaki", ABS = true, CC = 1000, Price = 189000, Quantity = 5, Year = 2017, Color = "Green" },
            new NewBike {Model = "S1000RR", Manufacturer = "BMW", ABS = true, CC = 1000, Price = 195000, Quantity = 3, Year = 2017, Color = "White/blue" }
        };
        public List<OldCar> oldCarList = new List<OldCar>
        {
            new OldCar {Model = "V70", Manufacturer = "Volvo", Mileage = 17000, Price = 40000, Color = "Red", Year = 2004, Transmission = "Manual", Quantity = 1 },
            new OldCar {Model = "Octavia", Manufacturer = "Skoda", Mileage = 16000, Price = 35000, Color = "Yellow", Year = 2005, Transmission = "Manual", Quantity = 1 },
            new OldCar {Model = "A4", Manufacturer = "Audi", Mileage = 21000, Price = 25000, Color = "White", Year = 2002, Transmission = "Manual", Quantity = 1 }
        };
        public List<OldBike> oldBikeList = new List<OldBike>
        {
            new OldBike {Model = "Daytona", Manufacturer = "Trumph", Mileage = 5780, CC = 675, Price = 29000, Quantity = 1, Year = 2006, Color = "Black" },
            new OldBike {Model = "Z1000", Manufacturer = "Kawasaki", Mileage = 1258, CC = 1000, Price = 79000, Quantity = 1, Year = 2010, Color = "White" },
            new OldBike {Model = "Fireblade", Manufacturer = "Honda", Mileage = 6778, CC = 1000, Price = 59000, Quantity = 1, Year = 2006, Color = "Purple" }
        };

        public void AddNewCar()
        {
            Console.Clear();
            NewCar newCar = new NewCar();
            Console.WriteLine("Enter the information to the new car");
            Console.Write("Model: ");
            newCar.Model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            newCar.Manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            newCar.Price = int.Parse(Console.ReadLine());
            Console.Write("Transmission type: ");
            newCar.Transmission = Console.ReadLine();
            Console.Write("Color: ");
            newCar.Color = Console.ReadLine();
            Console.Write("Modelyear: ");
            newCar.Year = int.Parse(Console.ReadLine());
            newCar.Quantity = 0;

            newCarList.Add(newCar);

            Console.WriteLine("\nNew car has been added!");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

        }

        public void AddOldCar()
        {
            Console.Clear();
            OldCar oldCar = new OldCar();
            Console.WriteLine("**Enter the information to the used car**");
            Console.Write("Model: ");
            oldCar.Model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            oldCar.Manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            oldCar.Price = int.Parse(Console.ReadLine());
            Console.Write("Transmission type: ");
            oldCar.Transmission = Console.ReadLine();
            Console.Write("Color: ");
            oldCar.Color = Console.ReadLine();
            Console.Write("Modelyear: ");
            oldCar.Year = int.Parse(Console.ReadLine());
            Console.Write("Mileage: ");
            oldCar.Mileage = int.Parse(Console.ReadLine());
            oldCar.Quantity = 1;

            oldCarList.Add(oldCar);

            Console.WriteLine("\nUsed car has been added!");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();


        }

        public void AddNewBike()
        {
            Console.Clear();
            NewBike newBike = new NewBike();
            Console.WriteLine("**Enter the information to the new bike**");
            Console.Write("Model: ");
            newBike.Model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            newBike.Manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            newBike.Price = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            newBike.Color = Console.ReadLine();
            Console.Write("CC: ");
            newBike.CC = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            newBike.Year = int.Parse(Console.ReadLine());
            newBike.Quantity = 0;

            newBikeList.Add(newBike);

            Console.WriteLine("\nNew bike has been added!");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

        }

        public void AddOldBike()
        {
            Console.Clear();
            OldBike oldBike = new OldBike();
            Console.WriteLine("**Enter the information to the used bike**");
            Console.Write("Model: ");
            oldBike.Model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            oldBike.Manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            oldBike.Price = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            oldBike.Color = Console.ReadLine();
            Console.Write("Year: ");
            oldBike.Year = int.Parse(Console.ReadLine());
            Console.Write("Mileage: ");
            oldBike.Mileage = int.Parse(Console.ReadLine());
            oldBike.Quantity = 1;

            oldBikeList.Add(oldBike);

            Console.WriteLine("\nUsed bike has been added!");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        public void SellNewCar()
        {
            Console.Clear();
            ShowNewCars();
            Console.Write("\nType in the model to sell: ");
            string sellNewCar = Console.ReadLine();
            var newCarTosell = newCarList.SingleOrDefault(newCar => String.Equals(newCar.Manufacturer + " " + newCar.Model, sellNewCar));

            Console.WriteLine("\n1. Sell all cars");
            Console.WriteLine("2. Sell specific number of cars");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    newCarList.Remove(newCarTosell);
                    Console.WriteLine("All cars have been sold!");
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("Enter number of cars to remove: ");
                    int removeNumber = int.Parse(Console.ReadLine());
                    newCarTosell.Quantity -= removeNumber;
                    Console.WriteLine(removeNumber + " car(s) have been sold!");
                    Console.ReadLine();
                    break;
            }

        }

        public void SellOldCar()
        {
            Console.Clear();
            ShowOldCars();
            Console.Write("\nType in the model to sell: ");
            string sellOldCar = Console.ReadLine();
            var OldCarToSell = oldCarList.SingleOrDefault(oldCar => string.Equals(oldCar.Model, sellOldCar));

            Console.WriteLine("\n1. Sell all cars");
            Console.WriteLine("2. Sell specific number of cars");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    oldCarList.Remove(OldCarToSell);
                    Console.WriteLine("\nAll cars have been sold!");
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("Enter number of cars to remove: ");
                    int removeNumber = int.Parse(Console.ReadLine());
                    OldCarToSell.Quantity -= removeNumber;
                    Console.WriteLine(removeNumber + " car(s) have been sold!");
                    Console.ReadLine();
                    break;
            }
        }

        public void SellNewBike()
        {
            Console.Clear();
            ShowNewBikes();
            Console.Write("\nType in the model to sell: ");
            string sellNewBike = Console.ReadLine();
            var newBikeToSell = newBikeList.SingleOrDefault(newBike => String.Equals(newBike.Model, sellNewBike));

            Console.WriteLine("\n1. Sell all bikes");
            Console.WriteLine("2. Sell specific number of bikes");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    newBikeList.Remove(newBikeToSell);
                    Console.WriteLine("\nAll bikes have been sold!");
                    break;
                case ConsoleKey.D2:
                    Console.Write("Enter number of bikes to remove: ");
                    int removeNumber = int.Parse(Console.ReadLine());
                    newBikeToSell.Quantity -= removeNumber;
                    Console.WriteLine(removeNumber + " bike(s) have been sold!");
                    Console.ReadLine();
                    break;
            }
        }

        public void SellOldBike()
        {
            Console.Clear();
            ShowOldBikes();
            Console.Write("\nType in the model to sell: ");
            string sellOldBike = Console.ReadLine();
            var oldBikeToSell = oldBikeList.SingleOrDefault(oldBike => String.Equals(oldBike.Model, sellOldBike));

            Console.WriteLine("\n1. Sell all bikes");
            Console.WriteLine("2. Sell specific number of bikes");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    oldBikeList.Remove(oldBikeToSell);
                    Console.WriteLine("\nAll bikes have been sold!");
                    break;
                case ConsoleKey.D2:
                    Console.Write("Enter number of bikes to remove: ");
                    int removeNumber = int.Parse(Console.ReadLine());
                    oldBikeToSell.Quantity -= removeNumber;
                    Console.WriteLine(removeNumber + " bike(s) have been sold!");
                    Console.ReadLine();
                    break;
            }
        }

        public void ShowNewCars()
        {
            Console.Clear();
            Console.WriteLine("**New cars**");
            Console.WriteLine("");
            int i = 1;
            foreach (var newCar in newCarList)
            {
                Console.WriteLine("{0}. Carmodel: {1} {2} | Year: {3} | Quantity: {4} | Price: {5} kr | Transmission: {6} | Color: {7}"  
                    , i, newCar.Manufacturer, newCar.Model, newCar.Year, newCar.Quantity, newCar.Price, newCar.Transmission, newCar.Color);
                i++;

            }
        }

        public void ShowOldCars()
        {
            Console.WriteLine("\n**Used cars**");
            Console.WriteLine("");
            int o = 1;
            foreach (var oldCar in oldCarList)
            {
                Console.WriteLine("{0}. Carmodel: {1} {2} | Year: {3} | Quantity: {4} | Mileage: {5} | Transmission: {6} | Color: {7} | Price: {8} kr"
                    , o, oldCar.Manufacturer, oldCar.Model, oldCar.Year, oldCar.Quantity, oldCar.Mileage, oldCar.Transmission, oldCar.Color, oldCar.Price);
                o++;
            }
        }

        public void ShowNewBikes()
        {
            Console.WriteLine("\n**New bikes**");
            Console.WriteLine("");
            int p = 1;
            foreach (var newBike in newBikeList)
            {
                Console.WriteLine("{0}. Bikemodel: {1} {2} | Year: {3} | Quantity: {4} | CC: {5} | Color: {6} | Price: {7} kr"
                    , p, newBike.Manufacturer, newBike.Model, newBike.Year, newBike.Quantity, newBike.CC, newBike.Color, newBike.Price);
                p++;
            }
        }

        public void ShowOldBikes()
        {
            Console.WriteLine("\n**Used bikes**");
            Console.WriteLine("");
            int a = 1;
            foreach (var oldBike in oldBikeList)
            {
                Console.WriteLine("{0}. Bikemodel: {1} {2} | Year: {3} | Quantity: {4} | Mileage: {5} | CC: {6} | Color: {7} | Price: {8}"
                    , a, oldBike.Manufacturer, oldBike.Model, oldBike.Year, oldBike.Quantity, oldBike.Mileage, oldBike.CC, oldBike.Color, oldBike.Price);
                a++;
            }
            bool loop = false;

            while (!loop)
            {
                Console.WriteLine("\nPress ENTER to return...");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Enter:
                        loop = true;
                        break;

                }
            }

        }

        public void ChangeQuantityCar()
        {
            Console.Clear();
            ShowNewCars();
            Console.Write("\nType in the model to add: ");
            string addNewCar = Console.ReadLine();
            var addCar = newCarList.Find(newCar => String.Equals(newCar.Manufacturer + " " + newCar.Model, addNewCar));
            if (addCar != null)
            {
                Console.Write("Enter number of cars to add: ");
                int addNumber = int.Parse(Console.ReadLine());
                addCar.Quantity += addNumber;
                Console.WriteLine(addNumber + " cars have been added!");
            }
            else
                 Console.WriteLine("The car was not found!");
                Console.ReadLine();
        }

        public void ChangeQuantityBike()
        {
            Console.Clear();
            ShowNewBikes();
            Console.Write("\nType in the model to add: ");
            string addNewBike = Console.ReadLine();
            var addBike = newBikeList.Find(newBike => String.Equals(newBike.Manufacturer + " " + newBike.Model, addNewBike));
            if (addBike != null)
            {
                Console.Write("Enter number of bikes to add: ");
                int addNumber = int.Parse(Console.ReadLine());
                addBike.Quantity += addNumber;
                Console.WriteLine(addNumber + " bikes have been added!");
            }
            else
            Console.WriteLine("Bike was not found!");
            Console.ReadLine();
        }

    }

}

