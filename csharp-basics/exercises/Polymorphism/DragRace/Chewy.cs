using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Chewy : ICar
    {
        private int currentSpeed;
        public static string name = "Chewy";

        public void SpeedUp()
        {
            currentSpeed += 2;
        }

        public void SlowDown()
        {
            currentSpeed -= 2;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("..achooo...");
        }

        public string ShowName()
        {
            return "Chewy";
        }
    }
}
