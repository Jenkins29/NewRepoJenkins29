using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        public static string[] wordList = { "leviathan", "oracle", "nebuchadnezzar", "matrix", "teardrop", "angel", "morpheus", "trinity", "mainframe" };
        public static string misses = "";
        public static int numOfGuesses = 9;
        public static Random index = new Random();
                
        public static char[] chosenHiddenWord;
        public static char guess;
        public static string chosenWordGlobal;

        static void Main(string[] args)
        {
            InitiateGame();

            while (1 == 1)
            {                
                MakeGuess();
                CheckGuess();
                Console.Clear();
                DisplayBoard();   
                
                if (numOfGuesses == 0 && chosenHiddenWord.Contains('_'))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Game over. You ran out of guesses. The word was '{chosenWordGlobal.ToUpper()}'");
                    Console.WriteLine();
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to start a new game");
                    Console.ReadKey();
                    Console.Clear();
                    numOfGuesses = 9;
                    misses = "";
                    InitiateGame();
                }

                else if (numOfGuesses >= 0 && chosenHiddenWord.Contains('_')==false)
                {
                    Console.WriteLine();
                    Console.WriteLine("CONGRATULATIONS! YOU GUESSED IT!");
                    Console.WriteLine();
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to start a new game");
                    Console.ReadKey();
                    Console.Clear();
                    numOfGuesses = 9;
                    misses = "";
                    InitiateGame();
                }                
            }
        }

        public static void InitiateGame()
        {
            ChooseAndHideWord();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.Write("Word: ");
            foreach (char letter in chosenHiddenWord)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Misses: ");
            Console.WriteLine();
            Console.Write($"Number of guesses left: {numOfGuesses}");
            Console.WriteLine();
        }

        public static void ChooseAndHideWord()
        {
            int randomIndex = index.Next(0,8);
            chosenWordGlobal  = wordList[randomIndex];
            chosenHiddenWord = chosenWordGlobal.ToCharArray();            

            for (int i = 0; i < chosenHiddenWord.Length; i++)
            {
                chosenHiddenWord[i] = '_';
            }                       
        }       

        public static void MakeGuess()
        {
            string input;
            Console.WriteLine();
            Console.Write("Guess: ");
            input = Console.ReadLine();            

            while (input.Length > 1 || string.IsNullOrEmpty(input) || Char.IsLetter(input[0]) == false)
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine();
                Console.WriteLine("Invalid guess, try again:");
                input = Console.ReadLine();                                                                                             
            }
            guess = char.Parse(input.ToLower());
            
            while (misses.Contains(guess))
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine();
                Console.WriteLine($"You already chose '{guess}'. Please choose another letter: ");
                input = Console.ReadLine();

                while (input.Length > 1 || string.IsNullOrEmpty(input) || Char.IsLetter(input[0]) == false)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine();
                    Console.WriteLine("Invalid guess, try again:");
                    input = Console.ReadLine();
                }

                guess = char.Parse(input.ToLower());
            }
            guess = char.Parse(input.ToLower());

            while (chosenHiddenWord.Contains(guess))
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine();
                Console.WriteLine($"You already guessed '{guess}'. Please choose another letter: ");
                input = Console.ReadLine();

                while(input.Length > 1 || string.IsNullOrEmpty(input) || Char.IsLetter(input[0]) == false)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine();
                    Console.WriteLine("Invalid guess, try again:");
                    input = Console.ReadLine();
                }

                guess = char.Parse(input.ToLower());
            }            
        }

        public static void CheckGuess()
        {            

            if (chosenWordGlobal.Contains(guess))
            {
                int indexOf;                
                indexOf = chosenWordGlobal.IndexOf(guess);                

                for (int i=0; i< chosenWordGlobal.Length; i++)
                {
                    if (chosenWordGlobal[i] == guess)
                    {
                        chosenHiddenWord[i] = guess;
                    }
                }
            }
            else
            {
                misses = misses + guess;
                numOfGuesses = numOfGuesses - 1;
            }
        }

        public static void DisplayBoard()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.Write("Word: ");
            foreach (char letter in chosenHiddenWord)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Misses: " + misses);
            Console.WriteLine();
            Console.WriteLine($"Number of guesses left: {numOfGuesses}");
        }
    }
}
