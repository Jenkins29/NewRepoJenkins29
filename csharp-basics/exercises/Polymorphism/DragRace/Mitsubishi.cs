using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Mitsubishi : ICar
    {
        private int currentSpeed;
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

        public void StartEngine()
        {
            Console.WriteLine("....ZZzhhhhhhhh..");
        }

        public string ShowName()
        {
            return "Mitsubishi";
        }
    }
}
