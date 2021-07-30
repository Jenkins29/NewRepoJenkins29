using System;

namespace Exercise8
{
    
    class AsciiFigure
    {
        public const int repeats = 3;
        static void Main(string[] args)
        {
            string backslash = "\\";         

            for (int i=1; i<=repeats; i++)
            {                
                for (int j=0; j<(repeats*4)-(i*4); j++)
                {
                    Console.Write("/");
                }                

                for (int x=0; x<i*4-4; x++)
                {
                    Console.Write("*");
                }                

                for (int x=0; x <i*4-4; x++)
                {
                    Console.Write("*");
                }

                for (int j=0; j<(repeats*4)-(i*4); j++)
                {
                    Console.Write(backslash);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
