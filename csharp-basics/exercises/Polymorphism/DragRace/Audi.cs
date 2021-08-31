using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private static int currentSpeed = 0;
        public int Speed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }

        public static string name = "Audi";

        public Audi()
        {
        }

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

        public string StartEngine() 
        {
            //Console.WriteLine("Rrrrrrr.....");
            return "Rrrrrrr.....";
        }

        public string ShowName()
        {
            return "Audi";
        }
    }
}