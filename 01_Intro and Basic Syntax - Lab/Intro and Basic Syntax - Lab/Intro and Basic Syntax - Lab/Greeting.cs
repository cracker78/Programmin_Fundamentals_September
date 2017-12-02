using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_and_Basic_Syntax___Lab
{
    class Greeting
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
