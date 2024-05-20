using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicleTask
{
    internal class Motocycle : Vehicle,IVehicle
    {
        public Motocycle(string make, string model, string banType, int maxSpeed) : base(make, model, banType, maxSpeed)
        {
        }

        public void Start()
        {
            Console.WriteLine($"{Make} {Model}  Started");

        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model}  Stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Make} {Model}  MaxSpeed  {MaxSpeed}  BanType {BanType}");

        }
    }
}
