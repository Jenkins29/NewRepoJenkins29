using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            colors.Add("Maroon");
            colors.Add("Crimson");
            colors.Add("Forest Green");
            colors.Add("Toxic Waste Green");

            string element = colors[0];
            Console.WriteLine("First element: " + element);
            Console.ReadKey();

            element = colors[2];
            Console.WriteLine("Third element: " + element);
            Console.ReadKey();
        }
    }
}
