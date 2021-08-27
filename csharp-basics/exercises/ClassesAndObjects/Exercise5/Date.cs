using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Date
    {
        public int Day
        { get; set; }

        public int Month
        { get; set; }

        public int Year
        { get; set; }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public string DisplayDate()
        {
            //Console.Write($"{Day}/{Month}/{Year}");
            return $"{Day}/{Month}/{Year}";
        }
    }
}
