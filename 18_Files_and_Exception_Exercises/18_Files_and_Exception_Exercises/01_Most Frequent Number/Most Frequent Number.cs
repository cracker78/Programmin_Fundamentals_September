using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _01_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "../../input.txt";

            if (!File.Exists(inputFile))
            {
                File.Create(inputFile);
            }
            File.AppendAllText(inputFile, "4 1 1 4 2 3 4 4 1 2 4 9 3");

            var input = File.ReadAllText(inputFile);

            var numbers = input.Split(' ').Select(int.Parse).ToArray();


            int bestCount = 0;
            int mostFrequentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }

                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    mostFrequentNumber = numbers[i];
                }

            }
            File.AppendAllText("../../output.txt", mostFrequentNumber.ToString());
        }
    }
}
