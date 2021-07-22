using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
           // throw new NotImplementedException();

            double area = Math.PI * (double)radius * (double)radius;
            return area;
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            //throw new NotImplementedException();

            double area = (double)length * (double)width;
            return area;
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            //throw new NotImplementedException();
            double area = (double)ground * (double)h * 0.5;
            return area;
        }
    }
}
