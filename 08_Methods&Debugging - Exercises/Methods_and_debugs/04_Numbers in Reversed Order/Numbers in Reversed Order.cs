using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Array[] result = input.Split(new char[''], input);

            input.Reverse();

            Console.WriteLine(input);
        }
    }
}
