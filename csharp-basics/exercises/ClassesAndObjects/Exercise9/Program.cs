using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);            
            SwapPoints(p1, p2);
            Console.WriteLine("(" + p1._x + ", " + p1._y + ")");
            Console.WriteLine("(" + p2._x + ", " + p2._y + ")");

        }
        public static void SwapPoints(Point point1, Point point2)
        {
            int x = point1._x;
            int y = point1._y;
            int x2 = point2._x;
            int y2 = point2._y;

            point1._x = x2;
            point1._y = y2;
            point2._x = x;
            point2._y = y;
        }
    }
}
