using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Average_Grades
{
    class Program
    {
        class Student
        {
            private String name;
            private double[] grades;


            public Student(String name, double[] grades)
            {
                this.name = name;
                this.grades = new double[grades.Length];
                for (int i = 0; i < grades.Length; i++)
                {
                    this.grades[i] = grades[i];
                }
            }

            public String getName()
            {
                return name;
            }

            public double[] getGrades()
            {
                return grades;
            }

            public double average(double[] grades)
            {
                double temp = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    temp += grades[i];
                }

                return temp / (grades.Length - 1);
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                double[] grades = new double[input.Length];
                for (int r = 1; r < input.Length; r++)
                {
                    grades[r - 1] = double.Parse(input[r]);
                }

                students.Add(new Student(input[0], grades));
            }

            List<Student> newList = students.OrderBy(o => o.average(o.getGrades())).Reverse().OrderBy(x => x.getName())
                .ToList();

            foreach (var person in newList)
            {
                if (person.average(person.getGrades()) >= 5.0)
                {
                    Console.WriteLine("{0} -> {1:F2}", person.getName(), person.average(person.getGrades()));
                }
            }

        }
    }
}
