using Labb_13_Events_och_Delegater.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_13_Events_och_Delegater.Classes.Delegate;

namespace Labb_13_Events_och_Delegater.Filters
{
    class McFilter
    {
        
        public static bool isManufacturerTriumph(Motorcycle motorcycle)
        {
            return motorcycle.Manufacturer == "Triumph";
        }
        public static bool isMcYearNew(Motorcycle motorcycle)
        {
            return motorcycle.Year > 2010;
        }
        public static bool isMcTypeSport(Motorcycle motorcycle)
        {
            return motorcycle.Type == "Sport";
        }
        public static bool isMcYearOld(Motorcycle motorcycle)
        {
            return motorcycle.Year < 2010;
        }
        public static bool isMcTypeTouring(Motorcycle motorcycle)
        {
            return motorcycle.Type == "Touring";
        }
    }
}
