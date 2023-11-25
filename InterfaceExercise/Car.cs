using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfStereingWheels { get; set; }
        public string ColorOfPaint { get; set; }
        public bool Have4Doors { get; set; }
        public string Logo { get; set; }
        public string CEOName { get; set; }
        public bool GoesFast { get; set; }
        public double TopSpeed { get; set; }
    }
}
