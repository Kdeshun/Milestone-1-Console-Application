using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Board class.
            int boardSize = 5; // Change the board size as needed
            double difficulty = 0.2; // Change the difficulty percentage as needed

            Board board = new Board(boardSize, difficulty);

            // Call the necessary methods to initialize the grid.
            board.SetupLiveNeighbors();
            board.CalculateLiveNeighbors();

            // Call the PrintBoard method to display the contents of the grid.
            PrintBoard(board);
        }

        // Helper method to print the contents of the Board.
        static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    // Check if the cell is "live" (a bomb) or not and display accordingly.
                    if (board.Grid[i, j].Live)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(board.Grid[i, j].LiveNeighbors + " ");
                    }
                }
                Console.WriteLine(); // Move to the next row.
            }
        }
    }
}
