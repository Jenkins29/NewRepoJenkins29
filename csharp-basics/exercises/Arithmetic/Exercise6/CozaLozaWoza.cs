using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public static class CozaLozaWoza
    {
        public static string PrintCozaLozaWoza()
        {
            string result = string.Empty;

            for (int i = 1; i < 111; i++)
            {
                if ((i - 1) % 11 == 0 && (i - 1) != 0)
                {
                    result += "\n";
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "CozaLoza" + " ";
                }
                else if (i % 3 == 0)
                {
                    result += "Coza" + " ";
                }
                else if (i % 5 == 0)
                {
                    result += "Loza" + " ";
                }
                else if (i % 7 == 0)
                {
                    result += "Woza" + " ";
                }
                else result += $"{i} ";
            }

            return result;
        }
    }
}
