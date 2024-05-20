namespace IVehicleTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car= new Car("BMW","X6" ,"Crossover",260);
            Bus bus= new Bus("Iveco","I20" ,"Bus",200);
            Motocycle moto= new Motocycle("Kawasaki","Nidja 100" ,"Moto",330);
            car.Start();
            car.Stop();
            car.GetDetails();
            Console.WriteLine("-------------------------------------------------");
            bus.Start();
            bus.Stop();
            bus.GetDetails();
            Console.WriteLine("-------------------------------------------------");
            moto.Start();
            moto.Stop();
            moto.GetDetails();
        }
    }
}
