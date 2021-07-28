using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char player = 'X';               
        public static bool isWinner;
        public static bool isDraw;        
        public static void Main(string[] args)
        {            
            InitBoard();
            DisplayBoard();
            Console.WriteLine($"'{player}', choose your location (row, column):");

            while (isWinner == false && isDraw == false)
            {                
                UpdateBoard();                
                CheckForWinner();                

                if (isWinner == true)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine("Game is over:");                   
                    Console.WriteLine($"{player} has won");
                    Console.WriteLine("Press any key to start a new game:");
                    Console.ReadKey();
                    Console.Clear();
                    InitBoard();
                    DisplayBoard();
                    GetTurn();
                    Console.WriteLine($"'{player}', choose your location (row, column):");
                }
                else if (isDraw == true)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine($"It's a draw");
                    Console.WriteLine("Press any key to start a new game:");
                    Console.ReadKey();
                    Console.Clear();
                    InitBoard();
                    DisplayBoard();
                    GetTurn();
                    Console.WriteLine($"'{player}', choose your location (row, column):");
                }
                else
                {
                    Console.Clear();
                    DisplayBoard();
                    GetTurn();
                    Console.WriteLine($"'{player}', choose your location (row, column):");
                }
            }
        }
        private static void InitBoard()
        {
            Console.WriteLine("Welcome to tic tac toe.");
            Console.WriteLine("Press any button to start.");
            Console.ReadKey();
            Console.Clear();
            isWinner = false;
            isDraw = false;            
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }            
        }
        public static void DisplayBoard()
        {
            Console.WriteLine("     0 1 2 ");
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");            
            Console.ReadKey();         
        }
        public static void UpdateBoard()
        {            
            string input1 = Console.ReadLine();   
            
            while (input1.Length != 2 || int.Parse(input1[0].ToString()) < 0 || 
                int.Parse(input1[1].ToString()) < 0 || int.Parse(input1[0].ToString()) > 2 ||
                int.Parse(input1[1].ToString()) > 2 )
            {
                Console.Write("Invalid coordinates, please input a 2 digit number representing your " +
                                    "coordinates i.e. '01' ");
                input1 = Console.ReadLine();                
            }

            int row = int.Parse(input1[0].ToString());
            int column = int.Parse(input1[1].ToString());
            
            while (board[row, column] != ' ')
            {
                Console.Write("This field is already taken, choose another one:");
                input1 = Console.ReadLine();                

                while (input1.Length != 2 || int.Parse(input1[0].ToString()) < 0 ||
                int.Parse(input1[1].ToString()) < 0 || int.Parse(input1[0].ToString()) > 2 ||
                int.Parse(input1[1].ToString()) > 2)
                {
                    Console.Write("Invalid coordinates, please input a 2 digit number representing your " +
                                        "coordinates i.e. '01' ");
                    input1 = Console.ReadLine();                    
                    continue;
                }
                row = int.Parse(input1[0].ToString());
                column = int.Parse(input1[1].ToString());
            }

            if (player == 'X') board[row, column] = 'X';                
            else if (player == 'O') board[row, column] = 'O';          
        }
        public static void GetTurn()
        {            
            if (player == 'X') player = 'O';
            else if (player == 'O') player = 'X';            
        }
        public static void CheckForWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' ')
                isWinner = true;
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ')
                isWinner = true;
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ')
                isWinner = true;

            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' ')
                isWinner = true;
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' ')
                isWinner = true;
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' ')
                isWinner = true;

            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
                isWinner = true;
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
                isWinner = true;

            else if (board[0, 0] != ' ' && board[0, 1] != ' ' && board[0, 2] != ' '
                        && board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' '
                        && board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' '
                        && isWinner == false) 
                isDraw = true;
        }        
    }
}
