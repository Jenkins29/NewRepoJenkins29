using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class CheckFor15
    {
        public CheckFor15()
        {
        }

        public static bool CheckIfNumberIs15(int numToCheck, int numToCheck2)
        {
            return (numToCheck == 15 || numToCheck2 == 15);
        }

        public static bool CheckIfNumberSumIs15(int numToCheck, int numToCheck2)
        {
            return ((numToCheck + numToCheck2) == 15);
        }

        public static bool CheckIfNumberDifferenceIs15(int numToCheck, int numToCheck2)
        {
            return ((numToCheck - numToCheck2) == 15 || (numToCheck2 - numToCheck) == 15);
        }
    }
}
