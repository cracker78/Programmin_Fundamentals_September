using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01_Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int baseNumber = input[0];
            int number = input[1];

            string output=string.Empty;

            while (number>=0)
            {
                int result = number % baseNumber;
                //Console.WriteLine(result);

                output = output + result.ToString();
                if (result==0)
                {
                    output = output+"1";
                    break;
                }
                
                number = number/baseNumber;
            }

            output.Reverse();

            Console.WriteLine(string.Join("", output));
        }
    }
}
