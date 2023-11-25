using InterfaceExercise;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            Car car1 = new Car() { CEOName = "Bob", ColorOfPaint = "Red", GoesFast = true, Have4Doors = true, Logo = "It's Pretty bad", NumberOfStereingWheels = 1, NumberOfWheels = 4, TopSpeed = 120, };
            Truck truck1 = new Truck() { NumberOfWheels = 4, NumberOfStereingWheels = 1, Logo = "BAD LOGO HERE", Have4Doors = true, ColorOfPaint = "Blue", CEOName = "Doug", HasBed = true, WhatTonTruck = .75 };
            SUV suv1 = new SUV() { NumberOfWheels = 4, CEOName = "Randy", ColorOfPaint = "Black", Have4Doors = true, Logo = "SUV...vroom vroom", NumberOfStereingWheels = 1, HasHatchBack = true, NumberOfSeats = 8 };
                   List<ICompany> vehicleList = new List<ICompany>() { truck1, suv1, car1 };
            foreach (var item in vehicleList)
            {
                Console.WriteLine($"CEO Name = {item.CEOName}");
                Console.WriteLine($"Logo = {item.Logo}");
                if (item is Car car)
                {
                    Console.WriteLine($"Does it goes fast = {car.GoesFast}");
                    Console.WriteLine($" Top Speed = {car.TopSpeed}");
                }
                if (item is Truck truck)
                {
                    Console.WriteLine($"How Heavy it can hold = {truck.WhatTonTruck}");
                    Console.WriteLine($" It Has a Bed = {truck.HasBed}");
                }
                if (item is SUV sUV)
                {
                    Console.WriteLine($"Does it have a Hatch Back =  {sUV.HasHatchBack}");
                    Console.WriteLine($"Number of seats = {sUV.NumberOfSeats}" );
                }
            }

        }
    }
}
