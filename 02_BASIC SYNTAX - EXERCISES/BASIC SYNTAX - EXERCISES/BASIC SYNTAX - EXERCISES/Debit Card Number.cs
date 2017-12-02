using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_SYNTAX___EXERCISES
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberTree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne:D4} {numberTwo:D4} {numberTree:D4} {numberFour:D4}");

        }
    }
}
