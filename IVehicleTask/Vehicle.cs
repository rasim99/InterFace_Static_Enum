using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicleTask
{
    internal abstract class Vehicle
    {
        protected Vehicle(string make, string model, string banType, int maxSpeed)
        {
            Make = make;
            Model = model;
            BanType = banType;
            MaxSpeed = maxSpeed;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string BanType { get; set; }
        public int MaxSpeed { get; set; }
    }
}
