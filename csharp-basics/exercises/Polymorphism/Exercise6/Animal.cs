using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public abstract class Animal
    {
        public string _animalName;
        public string _animalType;
        public double _animalWeight;
        public int _foodEaten { get; set; }

        protected Animal(string animalType, string name, double weight)
        {
            _animalName = name;
            _animalType = animalType;
            _animalWeight = weight;
        }

        public virtual void eat(Food food)
        {
            _foodEaten += food._quantity;
        }

        public virtual string MakeSound()
        {
            //Console.WriteLine("Animal sounds....");
            return "Animal sounds....";
        }

        public override string ToString()
        {
            return $"This is a {_animalType} with the following details: name: {_animalName}, weight: {_animalWeight}." +
                   $" And it has eaten {_foodEaten} units of food.";
        }
    }
}
