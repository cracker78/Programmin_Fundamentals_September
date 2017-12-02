using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bestElement = input[0];
            int bestLenght = 1;
            int currentLenght = 0;
            int currentElement=input[0];

            for (int i = 0; i < input.Count-1; i++)
            {
                currentElement = input[i];

                if (currentElement == input[i+1])
                {
                    currentLenght++;

                    if (currentLenght>bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestElement = currentElement;
                    }
                }
                else
                {
                    currentLenght=0;
                }

            }

            for (int i = 0; i <= bestLenght; i++)
            {
                Console.Write($"{bestElement} ");
            }

            Console.WriteLine();
            
        }
    }
}
