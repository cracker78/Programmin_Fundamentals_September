using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Pyranid(num);
        }

        private static void Pyranid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
