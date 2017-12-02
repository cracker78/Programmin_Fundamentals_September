using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_debugs
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
        }

        private static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
