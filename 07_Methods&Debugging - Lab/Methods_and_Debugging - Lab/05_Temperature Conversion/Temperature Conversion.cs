using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{FahrenheitToCelsius(fahrenheit):F2}");
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
