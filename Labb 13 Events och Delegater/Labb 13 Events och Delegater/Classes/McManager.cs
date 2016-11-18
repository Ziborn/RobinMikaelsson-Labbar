using Labb_13_Events_och_Delegater.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_13_Events_och_Delegater.Classes.Delegate;

namespace Labb_13_Events_och_Delegater.Classes
{
    class McManager
    {
        
        public event PrintMessage InvalidInput;

        public McFilters isManufacturerTriumphFilter = McFilter.isManufacturerTriumph;
        public McFilters isMcYearNewFilter = McFilter.isMcYearNew;
        public McFilters isMcTypeSportFilter = McFilter.isMcTypeSport;
        public McFilters isMcYearOldFilter = McFilter.isMcYearOld;
        public McFilters isMcTypeTouringFilter = McFilter.isMcTypeTouring;

        List<Motorcycle> McList = new List<Motorcycle>
        {
            new Motorcycle {Manufacturer = "Yamaha", Model = "XJ550", Type = "Touring", Year = 1982 },
            new Motorcycle {Manufacturer = "Triumph", Model = "Tiger Sport", Type = "Touring", Year = 1999 },
            new Motorcycle {Manufacturer = "Triumph", Model = "Sprint RS", Type = "Touring", Year = 2001 },
            new Motorcycle {Manufacturer = "Triumph", Model = "Daytona", Type = "Sport", Year = 2007 },
            new Motorcycle {Manufacturer = "Triumph", Model = "Daytona", Type = "Sport", Year = 2014 },
            new Motorcycle {Manufacturer = "MV Agusta", Model = "F3800", Type = "Sport", Year = 2015 }
        };

        public void CheckYear(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
        
        public void AddMc()
        {
            bool loop = true;

            Console.Clear();
            Motorcycle motorcycle = new Motorcycle();
            Console.WriteLine("Enter the info for the MC");
            Console.Write("Manufacturer: ");
            motorcycle.Manufacturer = Console.ReadLine();
            Console.Write("Model: ");
            motorcycle.Model = Console.ReadLine();
            Console.Write("Type: ");
            motorcycle.Type = Console.ReadLine();
            while (loop)
            {
                Console.Write("Year: ");
                
                InvalidInput += CheckYear;
                int input;
                bool isValid = int.TryParse(Console.ReadLine(), out input);

                if (input < 1970)
                {
                    InvalidInput.Invoke("Choose a year between 1970-2017");
                }
                else if(input > 2017)
                {
                    InvalidInput.Invoke("Choose a year between 1970-2017");
                }
                else
                {
                    motorcycle.Year = input;
                    McList.Add(motorcycle);
                    loop = false;
                }
            }
        }
        
        public void ShowMcList()
        {
            Console.Clear();
            int i = 1;
            foreach (var motorcycle in McList)
            {
                Console.WriteLine("{0}. {1} {2} {3} ({4})", i, motorcycle.Manufacturer, motorcycle.Model, motorcycle.Year, motorcycle.Type);
                i++;
            }
            Console.ReadKey();
        }
        
        public void PrintWhere(McFilters filter)
        {
            foreach (var motorcycle in McList)
            {
                if (filter(motorcycle))
                {
                    Console.WriteLine(motorcycle.Manufacturer + " " + motorcycle.Model + " " + motorcycle.Year);
                }
            }
            Console.ReadKey();
        }
    }
}
