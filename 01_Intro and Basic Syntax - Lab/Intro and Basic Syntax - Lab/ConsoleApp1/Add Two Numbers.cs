using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;

            Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
        }
    }
}
