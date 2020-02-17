using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VehicleLibrary
{
    [Serializable()]
    public class Car : Vehicle
    {
        public Car(string model, string color, int year, int currentMileage, int passengers,
                   double wholeSalePrice,
                   double retailPrice)
                   : base(model, color, year, currentMileage, passengers, wholeSalePrice, retailPrice)
       
        {

        }

        public String AutomobileInfo()
        {
            return "The model is " + Model + "\nthe color is " + Color
                + "\nthe year is " + Year + "\nthe current mileage is " + CurrentMileage
                     + "\nthe amount of seats is " + Passengers + "\nthe whole Sale value"
                     + WholeSalePrice + "\nthe Retail Price " + RetailPrice;

        }


        public override string ToString()
        {
            return this.AutomobileInfo();
        }
        public override object Clone()
        {
           Car newVehicle = new Car(Model, Color, Year, CurrentMileage, Passengers,
                WholeSalePrice, RetailPrice);

            return newVehicle;
        }

          
        }
}
