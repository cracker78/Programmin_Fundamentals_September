using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HeaderAndFooter(num);
            Body(num);
            HeaderAndFooter(num);

        }

        private static void Body(int num)
        {
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < num - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void HeaderAndFooter(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"--");
            }

            Console.WriteLine();
        }
    }
}
