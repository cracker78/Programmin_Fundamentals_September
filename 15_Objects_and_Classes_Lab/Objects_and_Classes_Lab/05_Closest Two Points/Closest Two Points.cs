using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_Two_Points
{
    class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());

            Point[] points = new Point[numberOfPoints];

            double distance = Double.MaxValue;
            Point firstPoint = points[0];
            Point secondPoint = points[1];

            for (int i = 0; i < numberOfPoints; i++)
            {
                int[] currentpoint = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int x = currentpoint[0];
                int y = currentpoint[1];

                points[i] = new Point(x, y);
            }

            for (int i = 0; i < numberOfPoints; i++)
            {
                for (int j = 0; j < numberOfPoints; j++)
                {
                    if (i!=j)
                    {
                        if (Distance(points[i], points[j]) < distance)
                        {
                            distance = Distance(points[i], points[j]);
                            firstPoint = points[i];
                            secondPoint = points[j];
                        }
                    }
                    
                }
            }

            Console.WriteLine(Math.Round(distance, 3));
            Console.WriteLine($"({firstPoint.x}, {firstPoint.y})");
            Console.WriteLine($"({secondPoint.x}, {secondPoint.y})");
        }
        static double Distance(Point first, Point second)
        {
            double distanse = Math.Sqrt(Math.Pow((first.x - second.x), 2) + Math.Pow((first.y - second.y), 2));

            return distanse;
        }
    }
}
