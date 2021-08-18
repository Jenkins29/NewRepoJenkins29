using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    class Cat : Feline
    {
        public string _breed;
        public Cat(string animalType, string name, double weight, string region, string breed) : base(animalType, name, weight, region)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }
        public override string ToString()
        {
                return $"Animal: {_animalType}, name: {_animalName}, weight: {_animalWeight}, region: {_livingRegion}, " +
                       $"breed: {_breed}. And it has eaten {_foodEaten} units of food.";
        }
    }
}
