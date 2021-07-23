using System;

namespace RealExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneKeyPad();
        }

        static void PhoneKeyPad()
        {
            string input;

            Console.WriteLine("Input your character sequence here:");
            input = Console.ReadLine().ToLower();

            while (String.IsNullOrEmpty(input) == true)
            {
                Console.WriteLine("You have to input something. Try again:");
                input = Console.ReadLine().ToLower();
            }
            
            for (int i=0; i<input.Length; i++)
                {               
                  switch (input[i])
                 {
                   case 'a': case 'b': case 'c':
                    Console.Write(2); break;
                   case 'd': case 'e': case 'f':
                    Console.Write(3); break;
                   case 'g': case 'h': case 'i':
                    Console.Write(4); break;
                   case 'j': case 'k': case 'l':
                    Console.Write(5); break;
                   case 'm': case 'n': case 'o':
                    Console.Write(6); break;
                   case 'p': case 'q': case 'r': case 's':
                    Console.Write(7); break;
                   case 't': case 'u': case 'v':
                    Console.Write(8); break;
                   case 'w': case 'x': case 'y': case 'z':
                    Console.Write(9); break;
                   default:
                    Console.Write('#'); break;
                 }                 
                }
            Console.ReadKey();
        }
    }
}
