using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine($"{TriangleArea(width, heigth)}");
        }

        static double TriangleArea(double width, double heigth)
        {
            double area = width * heigth / 2;
            return area;
        }
    }
}
