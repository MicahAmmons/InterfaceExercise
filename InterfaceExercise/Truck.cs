using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public double WhatTonTruck { get; set; }
        public bool HasBed { get; set; }
        public string Logo { get; set; }
        public string CEOName { get; set; }
        public int NumberOfWheels { get; set ; }
        public int NumberOfStereingWheels { get; set ; }
        public string ColorOfPaint { get; set; }
        public bool Have4Doors { get; set; }
    }
}

//In each of your Car, Truck, and SUV classes

/* Create 2 members that are specific to each class
 * Example for Car: public bool HasTrunk { get; set; }
 * Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */