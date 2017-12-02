using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int size = arr1.Length-1;

            if (size<arr2.Length-1)
            {
                size = arr2.Length-1;
            }

            if (arr1[0] == arr2[0])
            {
                int cnt = 0;

                int i = 0;

                while (arr1[i] == arr2[i] && i<size)
                {
                    cnt++;
                    i++;
                }

                Console.WriteLine(cnt);
            }

            else if (arr1[arr1.Length - 1] == arr2[arr2.Length - 1])
            {
                int cnt = 0;

                int i = arr1.Length - 1;
                int k = arr2.Length - 1;

                while (arr1[i] == arr2[k] && i>=0 && k>=0)
                {
                    cnt++;
                    i--;
                    k--;
                }
                Console.WriteLine(cnt);

            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
