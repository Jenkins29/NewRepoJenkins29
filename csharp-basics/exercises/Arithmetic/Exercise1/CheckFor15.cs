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
            if (numToCheck == 15 || numToCheck2 == 15) return true;

            return false;
        }

        public static bool CheckIfNumberSumIs15(int numToCheck, int numToCheck2)
        {
            if ((numToCheck + numToCheck2) == 15) return true;

            return false;
        }

        public static bool CheckIfNumberDifferenceIs15(int numToCheck, int numToCheck2)
        {
            if ((numToCheck - numToCheck2) == 15 || (numToCheck2 - numToCheck) == 15) return true;

            return false;
        }
    }
}
