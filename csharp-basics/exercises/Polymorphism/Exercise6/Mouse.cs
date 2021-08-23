using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    class Mouse : Mammal
    {
        public Mouse(string animalType, string name, double weight, string region):base(animalType, name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("peep");
        }

        public override void eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"A {this._animalType} doesn't eat meat");
            }
            else
            {
                _foodEaten += food._quantity;
            }
        }
    }
}
