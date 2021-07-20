using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, eyes, teeth, hair;
            int age, height, weight;

            name = "Zed A. Shaw";
            age = 35;
            height = 74;  // inches
            weight = 180; // lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            double heightInCm = height * 2.54;
            double weightInKg = weight * 0.453592;
            string weightInKgClean = weightInKg.ToString("0.00");

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight
                               + " I get " + (age + height + weight) + ".");

            Console.WriteLine(heightInCm);
            Console.WriteLine(weightInKgClean);
            Console.ReadKey();
        }
    }
}