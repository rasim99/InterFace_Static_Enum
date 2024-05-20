using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter_Task
{
    internal static class TemperatureConverter
    {
        public static double ChangeCelsiusToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double ChangeFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
