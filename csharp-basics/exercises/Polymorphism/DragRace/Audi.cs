using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;
        public static string name = "Audi";

        public void SpeedUp()
        {
            currentSpeed+=10;
        }

        public void SlowDown()
        {
            currentSpeed-=10;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public string ShowName()
        {
            return "Audi";
        }
    }
}