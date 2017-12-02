using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] result = numbers.Reverse().ToArray(); 

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
