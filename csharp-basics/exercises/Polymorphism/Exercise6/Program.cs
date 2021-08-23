using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int animalCount = 0;
            List<Animal> animalList = new List<Animal>();
            Console.ReadLine();
            var input = String.Empty;

            while (input.ToLower() != "end")
            {
                animalList.Add(CreateAnimal());
                animalList[animalCount].MakeSound();

                try
                {
                    animalList[animalCount].eat(CookAndGiveFood());
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }

                animalList[animalCount].MakeSound();
                animalCount++;

                Console.ReadKey();
                Console.WriteLine("Input 'End' if you'd like to finish this program, otherwise press any key to continue:");
                input = Console.ReadLine();
                Console.Clear();
            }
            
            foreach (var animal in animalList)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.ReadKey();
        }

        public static Food CookAndGiveFood()
        {
            Console.WriteLine("What would you like to feed your new buddy? Input 'vegetable' or 'meat'.");
            var foodType = Console.ReadLine();

            Console.WriteLine("And how much?");
            var foodAmt = int.Parse(Console.ReadLine());

            if (foodType.ToLower() == "vegetable")
            {
                return new Vegetable(foodAmt);
            }
            else if (foodType.ToLower() == "meat")
            {
                return new Meat(foodAmt);
            }
            else throw new ArgumentException(message: $"Can't cook {foodType}, never heard of it.");
        }

        public static Animal CreateAnimal()
        {
            Console.Write("Input the type of animal you'd like to create (e.g. 'tiger'): ");
            var animalType = Console.ReadLine();
            List<string> animalDetails = new List<string>() { "name", "weight", "region"};
            List<string> animalDetails2 = new List<string>() { "name", "weight", "region", "breed" };

            if (animalType.ToLower() == "mouse")
            {
                for (int i = 0; i < animalDetails.Count; i++)
                {
                    Console.WriteLine($"Input {animalDetails[i]}");
                    animalDetails[i] = Console.ReadLine();
                }
                return new Mouse(animalType, animalDetails[0], double.Parse(animalDetails[1]), animalDetails[2]);
            }
            if (animalType.ToLower() == "cat")
            {
                for (int i = 0; i < animalDetails2.Count; i++)
                {
                    Console.WriteLine($"Input {animalDetails2[i]}");
                    animalDetails2[i] = Console.ReadLine();
                }
                return new Cat(animalType, animalDetails2[0], double.Parse(animalDetails2[1]), animalDetails2[2], animalDetails2[3]);
            }
            if (animalType.ToLower() == "zebra")
            {
                for (int i = 0; i < animalDetails.Count; i++)
                {
                    Console.WriteLine($"Input {animalDetails[i]}");
                    animalDetails[i] = Console.ReadLine();
                }
                return new Zebra(animalType, animalDetails[0], double.Parse(animalDetails[1]), animalDetails[2]);
            }
            if (animalType.ToLower() == "tiger")
            {
                for (int i = 0; i < animalDetails.Count; i++)
                {
                    Console.WriteLine($"Input {animalDetails[i]}");
                    animalDetails[i] = Console.ReadLine();
                }
                return new Tiger(animalType, animalDetails[0], double.Parse(animalDetails[1]), animalDetails[2]);
            }
            else
            {
                throw new ArgumentException($"{animalType}is not a valid animal (at least in this program)!");
            }
        }
    }
}
