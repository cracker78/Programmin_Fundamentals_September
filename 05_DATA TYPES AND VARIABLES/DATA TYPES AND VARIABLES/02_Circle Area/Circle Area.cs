using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = radius * radius * Math.PI;

            Console.WriteLine($"{area:F12}");
        }
    }
}
