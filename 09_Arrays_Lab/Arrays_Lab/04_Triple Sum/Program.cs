using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if ((array[i]+array[j])==array[k])
                        {
                            Console.WriteLine($"{array[1]} + {array[j]} == {array[k]}");   
                        } 
                    }
                }
            }
        }
    }
}
