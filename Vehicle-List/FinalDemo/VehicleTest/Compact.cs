using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VehicleLibrary
{
    [Serializable()]
    public class Compact : Car
    {


        public Compact(string model, string color, int year, int currentMileage, int passengers,
            double wholeSalePrice,
            double retailPrice) : base(model, color, year, currentMileage, passengers,
                wholeSalePrice, retailPrice)
        
        {

        }
        

    }
}
