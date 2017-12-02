using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0]!="Odd" && command[0]!="Even")
            {

                if (command[0]=="Delete")
                {
                    input.RemoveAll(x=> x==int.Parse(command[1]));
                }
                if (command[0]=="Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine().Split(' ').ToList();
                //Console.WriteLine(string.Join(", ", input));
            }

            

            for (int i = 0; i < input.Count; i++)
            {
                if (command[0]== "Even")
                {
                    if (input[i]%2==0)
                    {
                        Console.Write(input[i] + " ");
                    } 
                }
                if (command[0] == "Odd")
                {
                    if (input[i] % 2 != 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
