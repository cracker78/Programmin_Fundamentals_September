using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (long i = 0; i < n; i++)
            {
                if (i >= k)
                {
                    for (long j = i - k; j < i; j++)
                    {
                        numbers[i] += numbers[j];
                    }
                }
                else
                {
                    for (long j = 0; j < i; j++)
                    {
                        numbers[i] += numbers[j];
                    }
                }
            }

            Console.Write(string.Join(" ", numbers));
            Console.WriteLine();
        }
    }
}
