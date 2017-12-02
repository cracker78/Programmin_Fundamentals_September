using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TYPES_AND_VARIABLES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centries = byte.Parse(Console.ReadLine());

            int years = centries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            long seconds = hours * 60;

            Console.WriteLine($"{centries} centries ={years} years = {days} days = {hours} hours ={seconds} seconds");


        }
    }
}
