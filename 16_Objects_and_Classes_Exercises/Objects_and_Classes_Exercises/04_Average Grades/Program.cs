using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average_Grades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double Average()
        {
            //this.Name = Name;
            //this.Grades = Grades;

            double average = Grades.Sum() / Grades.Count;
            return average;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            Student student = new Student();

            for (int i = 0; i < students; i++)
            {
                string[] current = Console.ReadLine().Split().ToArray();


                student.Name = current[0];
                List<double> grades = new List<double>();

                for (int j = 1; j < students; j++)
                {

                    grades.Add(double.Parse(current[j]));
                }

                student.Grades = grades;
            }

        }
    }
}
