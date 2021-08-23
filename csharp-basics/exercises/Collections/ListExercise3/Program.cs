using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            colors.Insert(0, "Gold");

            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();

            colors.Insert(0, "Orange");
            colors.Insert(2, "Pink");
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
