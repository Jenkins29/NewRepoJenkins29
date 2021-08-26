using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public static class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius < 0) throw new ArgumentException();
           
            double area = Math.PI * (double)radius * (double)radius;
            return area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0) throw new ArgumentException();

            double area = (double)length * (double)width;
            return area;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0) throw new ArgumentException();

            double area = (double)ground * (double)h * 0.5;
            return area;
        }
    }
}
