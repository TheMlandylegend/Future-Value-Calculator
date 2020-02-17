using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    [Serializable()]
     public abstract class Vehicle : ICloneable
    {
        
       
        string model; // Model of the Vehicle
        string color;
        int year; // year of the vehicle
        int currentMileage; // Current mileage the car has
        int passengers; // Amount of passengers
        double wholeSalePrice;
        double retailPrice;
        public abstract object Clone();

        public Vehicle(string model,string color, int year, int currentMileage, int passengers, double wholeSalePrice,
            double retailPrice)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.currentMileage = currentMileage;
            this.passengers = passengers;
            this.wholeSalePrice = wholeSalePrice;
            this.retailPrice=  retailPrice;
        }


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public int CurrentMileage
        {
            get { return this.currentMileage; }
            set { this.currentMileage = value; }
        }

        public int Passengers
        {
            get { return this.passengers; }
            set { this.passengers = value; }
        }
      
        public double RetailPrice
        {
            get
            {
                return retailPrice;
            }

            set
            {
                retailPrice = value;
            }
        }

        public double WholeSalePrice
        {
            get
            {
                return wholeSalePrice = retailPrice * 0.7;
            }

            set
            {
                wholeSalePrice = value;
            }
        }
    }
}
