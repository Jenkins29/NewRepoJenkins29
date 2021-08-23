using System;

namespace TenBillion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            long input;            

            Console.WriteLine("Input an integer number less than ten billion: ");
            long.TryParse(Console.ReadLine(), out input);
                        
            if (input < 10000000000) 
            {
                
                if (input < 0) 
                {
                    input *= -1;
                }

                
                if (input >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (input > 9) 
                    {
                        digits = 2;
                    } 
                    else if (input > 99  ) 
                    {
                        digits = 3;
                    } 
                    else if (input > 999) 
                    {
                        digits = 4;
                    } 
                    else if (input > 9999) 
                    {
                        digits = 5;
                    } 
                    else if (input > 99999) 
                    {
                        digits = 6;
                    } 
                    else if (input > 999999) 
                    {
                        digits = 7;
                    } 
                    else if (input > 9999999) 
                    {
                        digits = 8;
                    } 
                    else if (input > 99999999) 
                    {
                        digits = 9;
                    } 
                    else if (input > 999999999) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
