using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03_Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            result = BigFactorial(cnt, result);

            Console.WriteLine(result);
        }

        static BigInteger BigFactorial(int cnt, BigInteger result)
        {
            for (int i = 1; i <= cnt; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
