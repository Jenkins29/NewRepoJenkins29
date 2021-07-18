using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            string a = "1";
            int convertedNumber;
            bool isParsable = int.TryParse(a, out convertedNumber);
            int b = 2;
            int c = 3;
            double d = 4.0;
            float e = 5;

            //fixme - should be 15 :|
            int sum = convertedNumber + b + c + (int)d + (int)e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            String a = "1";
            float convertedNum;
            bool isFloatNow = float.TryParse(a, out convertedNum);            
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            float sum = convertedNum + b + c + (float)d + e;
            Console.WriteLine(sum);
        }
    }
}
