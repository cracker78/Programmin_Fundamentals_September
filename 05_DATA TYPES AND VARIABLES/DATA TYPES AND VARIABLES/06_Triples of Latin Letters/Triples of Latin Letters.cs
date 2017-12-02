using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char letter = 'a';

            for (int i = 0; i < num; i++)
            {
                
                for (int j = 0; j < num; j++)
                {
                    
                    for (int k = 0; k < num; k++)
                    {
                        char first = (char) (letter + i);
                        char second = (char)(letter + j);
                        char third = (char)(letter + k);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
