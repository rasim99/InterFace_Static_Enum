namespace TemperatureConverter_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initalize: Console.WriteLine("Choose Changeing scala-to-scala : 1-Celsi-Fahrenheit 2-Fahrenheit-Celsi");
            int chooseChangeScala= Convert.ToInt32(Console.ReadLine());
            switch (chooseChangeScala)
            {
                case 1:
                    Console.WriteLine("enter celsi temperature");
                    double celsi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{celsi}Celsi  is ====>>>>  {Math.Round(TemperatureConverter.ChangeCelsiusToFahrenheit(celsi),1)} Fahrenheiit");
                    break;
                    case 2:
                    Console.WriteLine("enter fahrenheit temperature");
                    int fahrenheit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{fahrenheit} Fahrenhit is ====>> {Math.Round(TemperatureConverter.ChangeFahrenheitToCelsius(fahrenheit),1)} Celsi");

                    break;
                default:
                    Console.WriteLine("wroong choosing");
                    goto Initalize;
            }

            
           ;
        }
    }
}
