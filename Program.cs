using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise1
{
    class Program:TempConverter
    {
        static void Main(string[] args)
        {

            Console.WriteLine("These are the conversions!");

            var celsius = TempConverter.FahrenheitToCelsius(68);

            Console.WriteLine($"What is your Fahrenheit temperature?\n This coverts to {celsius} degrees celsius!");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(25);

            Console.WriteLine($"What is your Celsius temperature?\n This coverts to {fahrenheit} degrees fahreheit!");
        }
    }
}
