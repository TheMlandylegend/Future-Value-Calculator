﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDemo
{
   public class Truck : Automobile
    {
        public Truck(string model, Color color, int year, int currentMileage, int passengers) : base(model, color, year, currentMileage, passengers)
        {
        }

        public int CabSize { get; set; }
        public int BedSize { get; set; }
        public int TowingCapacity { get; set; }
        public int AllWheelDrive { get; set; }
        public int EngineType { get; set; }
    }
}
