using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            decimal last = number % 10;

            if (last == 0)
            {
                Console.WriteLine("zero");
            }
            else if (last == 1)
            {
                Console.WriteLine("one");
            }
            else if (last == 2)
            {
                Console.WriteLine("two");
            }
            else if (last == 3)
            {
                Console.WriteLine("three");
            }
            else if (last == 4)
            {
                Console.WriteLine("four");
            }
            else if (last == 5)
            {
                Console.WriteLine("five");
            }
            else if (last == 6)
            {
                Console.WriteLine("six");
            }
            else if (last == 7)
            {
                Console.WriteLine("seven");
            }
            else if (last == 8)
            {
                Console.WriteLine("eight");
            }
            else if (last == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
