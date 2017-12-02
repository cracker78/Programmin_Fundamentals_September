using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            double miles = double.Parse(Console.ReadLine());

            double kilometrs = miles*1.60934;

            Console.WriteLine($"{kilometrs:F2}");


        }
    }
}
