using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthLenght = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyLenght = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {playerName}");
            Console.Write($"Health: |");
            for (int i = 0; i < health; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < (healthLenght-health); i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

            Console.Write("Energy: |");
            for (int i = 0; i < energy; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < (energyLenght - energy); i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
