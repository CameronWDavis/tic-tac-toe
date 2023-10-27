using System;

namespace TicTacToeProject
{
    class Point
    {
        // Properties to store the X and Y coordinates and the value ('X' or 'O') of a point on the board
        public int X { get; set; }
        public int Y { get; set; }
        public string Value { get; set; }

        // Constructor to initialize a point with coordinates and value
        public Point(int x, int y, string value)
        {
            X = x;
            Y = y;
            Value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables to store player and computer inputs
            string playerInput, computerPlayer;
            string[] board = new string[9];
            // Initialize the board with empty spaces
            for (int i = 0; i < 9; i++) board[i] = " ";
            // Welcome message
            Console.WriteLine("Welcome to the Tic Tac Toe simulator!");
            // Prompt the player to choose X or O
            Console.WriteLine("Would you like to be X or O?");
            playerInput = Console.ReadLine().ToUpper();
            // Set the computer's piece based on the player's choice
            computerPlayer = playerInput == "X" ? "O" : "X";
            Console.WriteLine("\nYou will be playing as " + playerInput + " and I as " + computerPlayer);

            // Variable to keep track of whose turn it is
            bool isPlayerTurn = true;
            // Main game loop
            while (true)
            {
                // Print the current state of the board
                PrintBoard(board);
                if (isPlayerTurn)
                {
                    // Get the player's move
                    Point playerMove = PlayerTurn(playerInput);
                    // Convert the player's move to an index in the board array
                    int index = (playerMove.X - 1) * 3 + (playerMove.Y - 1);
                    // Check if the move is valid
                    if (board[index] == " ")
                    {
                        // Make the move
                        board[index] = playerInput;
                        // Check if the player has won
                        if (CheckWinner(board, playerInput))
                        {
                            PrintBoard(board);
                            Console.WriteLine("Congratulations! You win!");
                            break;
                        }
                        // Switch to the computer's turn
                        isPlayerTurn = false;
                    }
                    else
                    {
                        // If the move is invalid, prompt the player to try again
                        Console.WriteLine("Invalid move. Try again.");
                    }
                }
                else
                {
                    // Computer's turn
                    Console.WriteLine("Computer's turn.");
                    Point computerMove = ComputerTurn(computerPlayer, board);
                    int index = (computerMove.X - 1) * 3 + (computerMove.Y - 1);
                    // Make the computer's move
                    board[index] = computerPlayer;
                    // Check if the computer has won
                    if (CheckWinner(board, computerPlayer))
                    {
                        PrintBoard(board);
                        Console.WriteLine("Computer wins!");
                        break;
                    }
                    // Switch to the player's turn
                    isPlayerTurn = true;
                }
                // Check if the board is full (resulting in a draw)
                if (IsBoardFull(board))
                {
                    PrintBoard(board);
                    Console.WriteLine("It's a draw!");
                    break;
                }
            }
        }

        // Method to get the player's move
        static Point PlayerTurn(string userInput)
        {
            while (true)
            {
                Console.Write("Enter a point in the format of x,y (between 1 and 3): ");
                string gameChoice = Console.ReadLine();
                string[] coordinates = gameChoice.Split(',');
                int x, y;
                // Validate the input and return the player's move if it's valid
                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out x) && int.TryParse(coordinates[1], out y) && x >= 1 && x <= 3 && y >= 1 && y <= 3)
                {
                    return new Point(x, y, userInput);
                }
                Console.WriteLine("Invalid input. Please enter values between 1 and 3.");
            }
        }

        // Method to get the computer's move
        static Point ComputerTurn(string computerInput, string[] board)
        {
            Random rnd = new Random();
            while (true)
            {
                int randomX = rnd.Next(1, 4);
                int randomY = rnd.Next(1, 4);
                int index = (randomX - 1) * 3 + (randomY - 1);
                // Ensure the computer's move is valid
                if (board[index] == " ")
                {
                    return new Point(randomX, randomY, computerInput);
                }
            }
        }

        // Method to check if a player has won
        static bool CheckWinner(string[] board, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows and columns
                if ((board[i * 3] == player && board[i * 3 + 1] == player && board[i * 3 + 2] == player) ||
                    (board[i] == player && board[i + 3] == player && board[i + 6] == player))
                {
                    return true;
                }
            }
            // Check diagonals
            if ((board[0] == player && board[4] == player && board[8] == player) ||
                (board[2] == player && board[4] == player && board[6] == player))
            {
                return true;
            }
            return false;
        }

        // Method to check if the board is full
        static bool IsBoardFull(string[] board)
        {
            foreach (var spot in board)
            {
                if (spot == " ")
                {
                    return false;
                }
            }
            return true;
        }

        // Method to print the current state of the board
        static void PrintBoard(string[] board)
        {
            Console.WriteLine(" 1 2 3");
            Console.WriteLine("1 " + board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine(" -----");
            Console.WriteLine("2 " + board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine(" -----");
            Console.WriteLine("3 " + board[6] + "|" + board[7] + "|" + board[8]);
        }
    }
}

