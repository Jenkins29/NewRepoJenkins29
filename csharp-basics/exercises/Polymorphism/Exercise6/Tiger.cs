using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    class Tiger : Feline
    {
        public Tiger(string animalType, string name, double weight, string region) 
            : base(animalType, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAARRR!");
        }

        public override void eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine($"A {this._animalType} doesn't eat veggies, try meat");
            }
            else
            {
                _foodEaten += food._quantity;
            }
        }
    }
}
