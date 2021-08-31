using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion;

        protected Mammal(string animalType, string name, double weight, string region) :base(animalType, name, weight)
        {
            _livingRegion = region;
        }

        public override string ToString()
        {
            return $"Animal: {_animalType}, name: {_animalName}, weight: {_animalWeight}, region: {_livingRegion}, food eaten: {_foodEaten}.";
        }
    }
}
