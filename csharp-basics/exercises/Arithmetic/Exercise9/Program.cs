using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi, weigth, heigth;

            Console.WriteLine("Enter your weigth in kg:");
            double.TryParse(Console.ReadLine(), out weigth);

            Console.WriteLine("Enter your heigth in cm:");
            double.TryParse(Console.ReadLine(), out heigth);

            bmi = (weigth / heigth / heigth) * 10000.00;

            if (bmi >= 18.5 && bmi <= 25) Console.WriteLine($"Your BMI is: {bmi.ToString("0.0")}. You are at optimal weigth.");
            if (bmi < 18.5) Console.WriteLine($"Your BMI is: {bmi.ToString("0.0")}. You are at underweigth.");
            if (bmi > 25 ) Console.WriteLine($"Your BMI is: {bmi.ToString("0.0")}. You are at overweigth.");

            Console.ReadKey();
        }
        
    }
}
