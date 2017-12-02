using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {secondName}. You are {ages} years old.");
        }
    }
}
