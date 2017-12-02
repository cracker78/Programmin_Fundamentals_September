using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Distance_between_Points
{
    public class Point
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
            int[] firstPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point first = new Point(firstPoint[0], firstPoint[1]);
            Point second = new Point(secondPoint[0], secondPoint[1]);

            Console.WriteLine(Math.Round(Distance(first, second), 3));

        }

        static double Distance(Point first, Point second)
        {
            double distanse = Math.Sqrt(Math.Pow((first.x - second.x), 2) + Math.Pow((first.y - second.y), 2));

            return distanse;
        }
    }
}
