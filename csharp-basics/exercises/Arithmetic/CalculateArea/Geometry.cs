using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
           
            double area = Math.PI * (double)radius * (double)radius;
            return area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            
            double area = (double)length * (double)width;
            return area;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            
            double area = (double)ground * (double)h * 0.5;
            return area;
        }
    }
}
