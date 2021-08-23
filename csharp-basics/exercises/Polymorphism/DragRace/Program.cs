using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> carList = new List<ICar>
            {
                new Audi(), new Chewy(), new Bmw(), new Lexus(), new Tesla(), new Mitsubishi()
            };

            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < carList.Count; i++)
                {
                    if (k == 0)
                    {
                        carList[i].StartEngine();
                    }

                    if (k == 2)
                    {
                        if (carList[i] is INOBoost)
                        { 
                            ((INOBoost)carList[i]).UseNitrousOxideEngine();
                        }
                    }
                    else
                    {
                        carList[i].SpeedUp();
                    }
                } 
            }

            var orderedCarList = carList.OrderByDescending(car => int.Parse(car.ShowCurrentSpeed())).ToList();

            Console.WriteLine($"The fastest car is {orderedCarList.First().ShowName()} with a speed of {orderedCarList.First().ShowCurrentSpeed()}");
            Console.WriteLine("-------------------");
            Console.WriteLine("The remaining cars and their speeds are: ");
            Console.WriteLine();

            foreach (var car in orderedCarList)
            {
                if (car.ShowName() == orderedCarList.First().ShowName()) continue;
                
                Console.WriteLine($"Car name: {car.ShowName()}, speed: {car.ShowCurrentSpeed()}");
                Console.WriteLine("*******************");
            }
            Console.ReadKey();
        }
    }
}