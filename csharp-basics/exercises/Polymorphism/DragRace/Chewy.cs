using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Chewy : ICar
    {
        private static int currentSpeed;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }
        public static string name = "Chewy";

        public Chewy()
        {
        }

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

        public string StartEngine()
        {
            //Console.WriteLine("..achooo...");
            return "..achooo...";
        }

        public string ShowName()
        {
            return "Chewy";
        }
    }
}
