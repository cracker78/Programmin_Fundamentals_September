using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employe = int.Parse(Console.ReadLine());
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Äge: {age}");
            Console.WriteLine($"Employee ID: {employe:D8}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
