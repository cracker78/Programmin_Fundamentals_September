using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int currentNumber = i;

                while (currentNumber!=0)
                {
                    sum =sum+currentNumber%10;
                    currentNumber = currentNumber/10;
                }

                if (sum==5 || sum==7 || sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
