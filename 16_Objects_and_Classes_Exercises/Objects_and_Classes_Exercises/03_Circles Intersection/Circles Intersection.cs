using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_Circles_Intersection
{
    public class Cyrcle
    {
        public long pointX { get; set; }
        public long pointY { get; set; }

        public double radius { get; set; }

        public Cyrcle()
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.radius = radius;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            long[] firstCyrcle = Console.ReadLine().Split().Select(long.Parse).ToArray();

            Cyrcle first = new Cyrcle();
            first.pointX = firstCyrcle[0];
            first.pointY = firstCyrcle[1];
            first.radius = firstCyrcle[2];

            long[] secondCyrcle = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Cyrcle second = new Cyrcle();
            second.pointX = secondCyrcle[0];
            second.pointY = secondCyrcle[1];
            second.radius = secondCyrcle[2];

            IsInside(first, second);
        }

        static void IsInside(Cyrcle first, Cyrcle second)
        {
            double distance = Math.Sqrt(Math.Pow(first.pointX - second.pointX, 2) +
                                                    Math.Pow(first.pointY - second.pointY, 2));

            if (distance <= second.radius || distance <= first.radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
