using System;

namespace DragRace
{
    public class Bmw : ICar, INOBoost
    {
        private int currentSpeed = 0;
        public static string name = "BMW";

        public void SpeedUp()
        {
            currentSpeed += 20;
        }

        public void SlowDown()
        {
            currentSpeed -= 20;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 50;
        }

        public string ShowName()
        {
            return "BMW";
        }
    }
}