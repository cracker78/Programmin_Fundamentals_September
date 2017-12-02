using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime currentDate=DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(currentDate.DayOfWeek);
        }
    }
}
