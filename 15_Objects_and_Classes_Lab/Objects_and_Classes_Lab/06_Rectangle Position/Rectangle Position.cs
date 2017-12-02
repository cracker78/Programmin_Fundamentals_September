using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rectangle_Position
{
    class Rectangle
    {
        public int left, top, width, height;

        public Rectangle(int left, int top, int width, int height)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRectangel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondRectange = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle first = new Rectangle(firstRectangel[0], firstRectangel[1], firstRectangel[2], firstRectangel[3]);
            Rectangle second = new Rectangle(secondRectange[0], secondRectange[1], secondRectange[2], secondRectange[3]);
            IsInside(first, second);
        }

        private static void IsInside(Rectangle first, Rectangle second)
        {
            if (second.left<=first.left && second.top>=first.top && second.left+second.width>=first.left+first.width && second.top+second.height>=first.top+first.height)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
