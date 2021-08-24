using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public static class GravityCalculators
    {
        public static double CalculatePositionAfter10SecFallTime()
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;

            finalPosition = gravity * 0.5 * Math.Pow(fallingTime, 2) + (initialVelocity * fallingTime) + initialPosition;

            return finalPosition;
        }
    }
}
