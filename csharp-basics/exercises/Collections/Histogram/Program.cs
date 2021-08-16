using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
   
    class Program
    {
        private const string Path = @"../Histogram/midtermscores.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);

            var input = readText.Split(' ');
            var ranges = new List<string>();
            ranges.Add("00-09: ");
            ranges.Add("10-19: ");
            ranges.Add("20-29: ");
            ranges.Add("30-39: ");
            ranges.Add("40-49: ");
            ranges.Add("50-59: ");
            ranges.Add("60-69: ");
            ranges.Add("70-79: ");
            ranges.Add("80-89: ");
            ranges.Add("90-99: ");
            ranges.Add("  100: ");

            foreach (var x in input)
            {
                var score = int.Parse(x) / 10;
                ranges[score] += "*";
            }
            foreach (var k in ranges)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
