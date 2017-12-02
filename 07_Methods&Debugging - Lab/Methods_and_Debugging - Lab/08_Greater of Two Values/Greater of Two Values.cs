using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();



            if (type=="int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(first, second));

            }
            else if (type=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxChar(first, second));

            }
            else if (type=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMaxString(first, second));
            }
        }

        static string GetMaxString(string first, string second)
        {
            string max = second;

            if (first.Equals(second))
            {
                max = first;
            }

            return max;
        }

        static char GetMaxChar(char first, char second)
        {
            char max = second;

            if (first.Equals(second))
            {
                max = first;
            }

            return max;
        }

        static int GetMax(int first, int second)
        {
            int max = second;

            if (first.Equals(second))
            {
                max=first;
            }

            return max;
        }
    }
}
