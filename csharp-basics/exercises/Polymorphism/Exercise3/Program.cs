using System;
using System.Net.Sockets;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student janis = new Student(6.0);
            Employee matiss = new Employee("Butcher");

            janis.GetSetAddress = "Somewhere in Riga";
            janis.GetSetFirstName = "Janis";
            janis.GetSetLastName = "Lazdans";
            janis.GetSetID = 125678910;

            matiss.GetSetFirstName = "Matiss";
            matiss.GetSetLastName = "Lazdans";
            matiss.GetSetAddress = "Somewhere in Marupe";
            matiss.GetSetID = 109654321;

            janis.Display();
            Console.WriteLine();
            matiss.Display();
            Console.ReadKey();

            Console.WriteLine($"After some studying, {janis.GetSetFirstName}' GPA improved drastically");
            janis.GetSetGpa = 8.0;
            Console.WriteLine($"Now his GPA is a whopping {janis.GetSetGpa.ToString("0.00")}");

            Console.WriteLine($"On another note, {matiss.GetSetFirstName} went on to re-qualify himself.");
            matiss.GetSetJobTitle = "Rocket scientist";
            Console.WriteLine($"Now, he is proud to be a {matiss.GetSetJobTitle}");
            Console.ReadKey();
        }
    }
}
