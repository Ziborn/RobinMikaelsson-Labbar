using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bosses_bilar_och_bågar
{
    public class Cars
    {
        int quantity;

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    quantity = 0;
                else
                    quantity = value;
            }

        }
    }
}