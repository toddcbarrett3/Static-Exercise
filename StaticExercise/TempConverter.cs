using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static void FahrenheitToCelcius(double fahrenheit)
        {
            var celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit is equal to {celcius} degrees Celcius");
        }
        public static void CelsiusToFahrenheit(double celsius)
        {
            var fahrenheit = celsius * 9 / 5 +32;
            Console.WriteLine($"{celsius} degrees Fahrenheit is equal to {fahrenheit} degrees Celcius");
        }
    }
}
