using System;

namespace DragRace
{
    public class Lexus : ICar, INOBoost
    {
        private static int currentSpeed = 0;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }
        public static string name = "Lexus";

        public Lexus()
        {
        }

        public void SpeedUp() 
        {
            currentSpeed+=16;
        }

        public void SlowDown() 
        {
            currentSpeed-=16;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=50;
        }

        public string StartEngine() 
        {
            //Console.WriteLine("Rrrrrrr.....");
            return "Rrrrrrr.....";
        }
        public string ShowName()
        {
            return "Lexus";
        }
    }
}