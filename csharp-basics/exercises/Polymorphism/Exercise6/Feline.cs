using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
     public abstract class Feline : Mammal
    {
        protected Feline(string animalType, string name, double weight, string region) : base(animalType, name, weight, region)
        {
        }
    }
}
