﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, long>();
            long counter = 0;
            string recourcesss = "";

            while (true)
            {
                string curent = Console.ReadLine();

                if (curent == "stop")
                {
                    break;
                }
                counter++;
                if (counter % 2 != 0) // odd number
                {
                    if (!dictionary.ContainsKey(curent))
                    {
                        dictionary[curent] = 0;
                    }
                    recourcesss = curent;
                }
                if (counter % 2 == 0)
                {
                    dictionary[recourcesss] = long.Parse(curent);
                }
            }
            foreach (var recource in dictionary)
            {
                Console.WriteLine("{0} -> {1}", recource.Key, recource.Value);

            }
        }
    }
}
