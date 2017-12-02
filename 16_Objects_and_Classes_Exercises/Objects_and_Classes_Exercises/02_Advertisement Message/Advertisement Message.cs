using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] towns = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            for (int i = 0; i < inputNumber; i++)
            {
                Random rnd=new Random();
                int phrasesIndex = rnd.Next(0, 5);
                int eventsIndex = rnd.Next(0, 5);
                int authorsIndex = rnd.Next(0, 7);
                int townsIndex = rnd.Next(0, 4);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {towns[townsIndex]}");
            }

        }
    }
}
