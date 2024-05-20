namespace TrafficLightTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            for (int i = 0; i < 3; i++)
            {
                if (trafficLight.Color==Color.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(trafficLight.Color);

                    Console.WriteLine("-----------");
                }
                if (trafficLight.Color==Color.Green)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(trafficLight.Color);

                    Console.WriteLine("-----------");
                }
                if (trafficLight.Color==Color.Yellow)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(trafficLight.Color);

                    Console.WriteLine("-----------");
                }
                trafficLight.ChangeNextColor();


                Console.ResetColor();
            }

        }
    }
}
