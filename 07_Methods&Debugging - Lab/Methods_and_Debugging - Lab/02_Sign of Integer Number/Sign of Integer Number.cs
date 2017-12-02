using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {num} is {SignOfNumber(num)}.");
        }

        static string SignOfNumber(int num)
        {
            string sign;
            if (num > 0)
            {
                sign = "positive";
            }
            else if (num == 0)
            {
                sign = "zero";
            }

            else
            {
                sign = "negative";
            }

            return sign;
        }
    }
}
