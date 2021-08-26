using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"../WordCount/lear.txt";

            int lineCount = FileAnalyzer.LineCounter(filePath);
            int wordCount = FileAnalyzer.WordCounter(filePath);
            int charCount = FileAnalyzer.CharCounter(filePath);

            Console.WriteLine($"Number of lines is {lineCount}");
            Console.WriteLine($"Number of words is {wordCount}");
            Console.WriteLine($"Number of chars is {charCount}");
            Console.ReadKey();
        }
    }
}
