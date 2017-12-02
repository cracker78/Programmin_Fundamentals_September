using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int course = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)students / course);

            Console.WriteLine(courses);
        }
    }
}
