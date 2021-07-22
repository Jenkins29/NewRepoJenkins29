﻿
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;

            finalPosition = gravity * 0.5 * Math.Pow(fallingTime,2) + (initialVelocity * fallingTime) + initialPosition;

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition.ToString("0.0") + " m.");
            Console.ReadKey();
        }
    }
}
