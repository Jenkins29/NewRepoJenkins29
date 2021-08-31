using System;
using System.Runtime.InteropServices;

namespace DragRace
{
    public class Tesla : ICar
    {
        private static int currentSpeed = 0;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }
        public static string name = "Tesla";

        public Tesla()
        {
        }

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

        public string StartEngine() 
        {
            //Console.WriteLine("-- silence ---");
            return "-- silence ---";
        }

        public string ShowName()
        {
            return "Tesla";
        }
    }
}