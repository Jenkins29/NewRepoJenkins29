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
            var shakeSpear = File.ReadAllLines(@"C:\Users\JL\NewRepoJenkins29\csharp-basics\exercises\Collections\WordCount\lear.txt");
            var shakeList = new List<string>(shakeSpear);
            var separators = new List<char>
            {
                '\'',
                ' ',
            };

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            foreach (string line in shakeList)
            {
                string newLine = line.Replace("  ", " ");
                Console.WriteLine(line); lineCount++;
                
                foreach (char letter in line)
                {
                    charCount++;
                    
                }

                foreach (char word in newLine)
                {
                    if (separators.Contains(word)) wordCount++;
                }
            }

            Console.WriteLine($"Number of lines is {lineCount}");
            Console.WriteLine($"Number of words is {wordCount+lineCount}");
            Console.WriteLine($"Number of chars is {charCount}");
            Console.ReadKey();
        }
    }
}
