using System;

namespace DragRace
{
    public class Bmw : ICar, INOBoost
    {
        private static int currentSpeed = 0;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }
        public static string name = "BMW";

        public Bmw()
        {
        }

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

        public string StartEngine() 
        {
            //Console.WriteLine("Rrrrrrr.....");
            return "Rrrrrrr.....";
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