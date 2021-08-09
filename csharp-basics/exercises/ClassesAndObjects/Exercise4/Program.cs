using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie glass = new Movie("Glass", "Buena Vista International", "PG13");
            Movie peterParkerSpoderman = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

            Movie[] movieArr = { casinoRoyale, glass, peterParkerSpoderman };

            Console.Write(GetPG(movieArr));
            Console.ReadKey();
           
        }

        public static Movie[] GetPG(Movie[] input)
        {
            return input.Where(c => c._rating == "PG").ToArray();
        }
    }
}
