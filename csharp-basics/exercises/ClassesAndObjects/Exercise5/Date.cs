using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Date
    {
        public int Day
        { get; set; }

        public int Month
        { get; set; }

        public int Year
        { get; set; }

        public Date()
        {

        }

        public void DisplayDate()
        {
            Console.Write($"{Day}/{Month}/{Year}");
        }
    }
}
