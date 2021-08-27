using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Mitsubishi : ICar
    {
        private static int currentSpeed;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }

        public string name = "Mitsubishi";

        public Mitsubishi()
        {
        }
        public void SpeedUp()
        {
            currentSpeed += 25;
        }

        public void SlowDown()
        {
            currentSpeed -= 25;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            //Console.WriteLine("....ZZzhhhhhhhh..");
            return "....ZZzhhhhhhhh..";
        }

        public string ShowName()
        {
            return "Mitsubishi";
        }
    }
}
