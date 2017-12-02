using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            bool found = false;
            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    start = numbers[i];
                    len++;
                    found = true;
                }
                else
                {
                    len = 1;
                    start = numbers[i];
                }
                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            if (!found)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                int[] result = new int[bestLen];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = bestStart;
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
