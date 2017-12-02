using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] operation = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            List<int> resultList=new List<int>(input.Take(operation[0]));


            resultList.RemoveRange(0, operation[1]);

            if (resultList.Contains(operation[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
