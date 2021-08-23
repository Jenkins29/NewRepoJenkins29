using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundsOfTheUniverse = new List<ISound>();

            soundsOfTheUniverse.Add(new Alien());
            soundsOfTheUniverse.Add(new Firework());
            soundsOfTheUniverse.Add(new Thunder());

            foreach (var sound in soundsOfTheUniverse)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}