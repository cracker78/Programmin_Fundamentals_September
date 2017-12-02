using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd=new Random();

            int min = 0;
            int max = input.Length - 1;

            for (int p1 = 0; p1 < input.Length; p1++)
            {
                int p2=rnd.Next(min, max);

                string temp = input[p1];
                input[p1] = input[p2];
                input[p2] = temp;

            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
