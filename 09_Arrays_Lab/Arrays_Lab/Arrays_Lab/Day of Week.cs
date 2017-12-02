using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days={
                "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int day = int.Parse(Console.ReadLine());

            if (day>7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else if(day<=0)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(days[day]);
            }
        }
    }
}
