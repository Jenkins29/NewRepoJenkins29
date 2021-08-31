using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string name, double weight, string region) : base(animalType, name, weight, region)
        {
        }

        public override string MakeSound()
        {
            //Console.WriteLine("weirdZebraSounds");
            return "weirdZebraSounds";
        }

        public override void eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"A {this._animalType} doesn't eat meat");
                throw new ArgumentException(message: $"A {this._animalType} doesn't eat meat");
            }
            else
            {
                _foodEaten += food._quantity;
            }
        }
    }
}
