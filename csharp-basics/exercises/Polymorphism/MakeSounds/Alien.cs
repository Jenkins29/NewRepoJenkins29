using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Alien : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Weeee cooomee iiin peeaaaceee.");
        }
    }
}
