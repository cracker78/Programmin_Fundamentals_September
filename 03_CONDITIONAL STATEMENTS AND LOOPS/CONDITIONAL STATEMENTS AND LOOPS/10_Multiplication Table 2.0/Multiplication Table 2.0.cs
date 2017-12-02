using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());


            do
            {
                int sum = number * secondNumber;
                Console.WriteLine($"{number} X {secondNumber} = {sum}");
                secondNumber++;
            }
            while (secondNumber<=10);

        }
    }
}
