using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters, hours, minutes, seconds, timeInSeconds;
            double timeInHours, kmH;
            

            Console.WriteLine("Input distance in meters:");
            int.TryParse(Console.ReadLine(), out meters);

            Console.WriteLine("Input hour:");
            int.TryParse(Console.ReadLine(), out hours);

            Console.WriteLine("Input minutes:");
            int.TryParse(Console.ReadLine(), out minutes);

            Console.WriteLine("Input seconds:");
            int.TryParse(Console.ReadLine(), out seconds);

            timeInSeconds = seconds + (minutes * 60) + (hours * 3600);
            timeInHours = hours + ((double)minutes / 60) + ((double)seconds/ 3600);
            kmH = (double)meters / 1000 / (double)timeInHours;

            Console.WriteLine($"Your speed in meters/seconds is {meters / timeInSeconds}");
            Console.WriteLine($"Your speed in km/h is {kmH.ToString("0.00")}");
            Console.WriteLine($"Your speed in miles/h is {((meters / 1609.344) / timeInHours).ToString("0.00")}");
            Console.WriteLine($"Your distance in kilometers is {meters / 1000} btw, just so you can makes sense of the numbers");
            
        }
    }
}
