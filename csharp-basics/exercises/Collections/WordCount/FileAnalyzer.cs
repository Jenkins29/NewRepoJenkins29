using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public static class FileAnalyzer
    {
        public static int LineCounter(string filePath)
        {
            var lineArray = File.ReadLines(filePath);
            var lineList = new List<string>(lineArray);
            int lineCount = 0;

            foreach (string line in lineList)
            {
                lineCount++;
            }
            return lineCount;
        }

        public static int WordCounter(string filePath)
        {
            var lineArray = File.ReadLines(filePath);
            var lineList = new List<string>(lineArray);
            var separators = new List<char> { '\'', ' ', };
            int lineCount = 0;
            int wordCount = 0;

            foreach (string line in lineList)
            {
                string newLine = line.Replace("  ", " ");
                lineCount++;

                foreach (char word in newLine)
                {
                    if (separators.Contains(word)) wordCount++;
                }
            }
            return lineCount + wordCount;
        }

        public static int CharCounter(string filePath)
        {
            var lineArray = File.ReadLines(filePath);
            var lineList = new List<string>(lineArray);
            int charCount = 0;

            foreach (string line in lineList)
            {
                foreach (char character in line)
                {
                    charCount++;
                }
            }
            return charCount;
        }
    }
}
