using Labb_15_Interface.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_15_Interface
{
    class Runtime
    {
        public void Start()
        {
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Pushables");
                Console.WriteLine("2. Vehicles");
                Console.WriteLine("3. Exit");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Pushables();
                        break;
                    case ConsoleKey.D2:
                        Vechicles();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
        public void Pushables()
        {
            Button button = new Button();
            Boulder boulder = new Boulder();
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Button");
                Console.WriteLine("2. Boulder");
                Console.WriteLine("3. Return");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(button.Push());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine(boulder.Push());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
        public void Vechicles()
        {
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Bicycle");
                Console.WriteLine("3. Spaceship");
                Console.WriteLine("4. Return");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        CarMenu();
                        break;
                    case ConsoleKey.D2:
                        BicycleMenu();
                        break;
                    case ConsoleKey.D3:
                        SpaceshipMenu();
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                }
            }
        }
        public void CarMenu()
        {
            Car car = new Car();
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Unlock");
                Console.WriteLine("4. Lock");
                Console.WriteLine("5. Return");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(car.Start());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine(car.Stop());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine(car.Unlock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine(car.Lock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
        public void BicycleMenu()
        {
            Bicycle bicycle = new Bicycle();
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Unlock");
                Console.WriteLine("4. Lock");
                Console.WriteLine("5. Return");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(bicycle.Start());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine(bicycle.Stop());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine(bicycle.Unlock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine(bicycle.Lock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
        public void SpaceshipMenu()
        {
            Spaceship spaceship = new Spaceship();
            var loop = true;
            
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Unlock");
                Console.WriteLine("4. Lock");
                Console.WriteLine("5. Return");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(spaceship.Start());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine(spaceship.Stop());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine(spaceship.Unlock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine(spaceship.Lock());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
    }
}
