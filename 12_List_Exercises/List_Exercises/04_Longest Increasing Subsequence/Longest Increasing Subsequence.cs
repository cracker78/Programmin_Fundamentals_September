using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> output=new List<int>(input[0]);

            for (int i = 0; i < input.Count; i++)
            {
                output.Add(input[i]);

                    for (int j = 0; j < output.Count - 1; j++)
                    {
                        if (output[output.Count-1] <= output[j])
                        {
                            output.Remove(output[j]);
                            j--;
                        }

                    }
                
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
