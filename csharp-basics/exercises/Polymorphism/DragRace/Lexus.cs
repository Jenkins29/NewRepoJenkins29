using System;

namespace DragRace
{
    public class Lexus : ICar, INOBoost
    {
        private int currentSpeed = 0;
        public static string name = "Lexus";

        public void SpeedUp() 
        {
            currentSpeed+=16;
        }

        public void SlowDown() 
        {
            currentSpeed+=16;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=50;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
        public string ShowName()
        {
            return "Lexus";
        }
    }
}