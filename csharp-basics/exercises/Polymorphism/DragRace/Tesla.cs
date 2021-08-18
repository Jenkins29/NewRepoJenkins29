using System;
using System.Runtime.InteropServices;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;
        public static string name = "Tesla";

        public void SpeedUp() 
        {
            currentSpeed+=30;
        }

        public void SlowDown() 
        {
            currentSpeed-=30;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }

        public string ShowName()
        {
            return "Tesla";
        }
    }
}