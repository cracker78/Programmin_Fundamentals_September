using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;


            for (int i = 0; i < numbers; i++)
            {

                decimal num = decimal.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
