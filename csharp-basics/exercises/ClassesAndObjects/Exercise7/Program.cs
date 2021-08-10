using System;

namespace Exercise7
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dog Max = new Dog("Max", "male");
            Dog Rocky = new Dog("Rocky", "male");
            Dog Sparky = new Dog("Sparky", "male");
            Dog Buster = new Dog("Buster", "male");
            Dog Sam = new Dog("Sam", "male");
            Dog Lady = new Dog("Lady", "female");
            Dog Molly = new Dog("Molly", "female");
            Dog Coco = new Dog("Coco", "female");

            Max._father = Rocky;
            Max._mother = Lady;

            Coco._father = Buster;
            Coco._mother = Molly;

            Rocky._mother = Molly;
            Rocky._father = Sam;

            Buster._mother = Lady;
            Buster._father = Sparky;

            Console.WriteLine(Coco.FathersName());            
            Console.WriteLine(Sparky.FathersName());
            Console.Write(Coco.HasSameMotherAsDog(Rocky));

            Console.ReadKey();
        }
    }
}
