using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var num = 0;
            var itsNumber = int.TryParse(number, out num);

            if (itsNumber)
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
