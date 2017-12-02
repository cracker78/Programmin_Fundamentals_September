using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 1;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{currentNumber}");
                sum = sum+currentNumber;
                currentNumber += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
