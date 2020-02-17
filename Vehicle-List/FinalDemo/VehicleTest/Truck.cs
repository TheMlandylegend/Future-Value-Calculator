using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    [Serializable()]
    public class Pickup : Car
    {
      public Pickup(string model, String color, int year, int currentMileage, int passengers,
            double wholeSalePrice,
            double retailPrice) : base(model, color, year, currentMileage, passengers,
                 wholeSalePrice,
             retailPrice)
      
        {

        }
    }
}
