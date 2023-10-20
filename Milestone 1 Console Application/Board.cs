using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_Console_Application
{
    public class Board
    {
        // Properties for the game board
        public int Size { get; private set; } // Property for the size of the square board
        public Cell[,] Grid { get; private set; } // 2-dimensional array of cells to represent the board
        public double Difficulty { get; set; } // Property to set the percentage of live cells

        // Constructor to create the game board
        public Board(int size, double difficulty)
        {
            // Set the size of the square board
            Size = size;

            // Initialize the grid as a 2D array of Cell objects
            Grid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new Cell();
                }
            }

            // Set the difficulty percentage
            Difficulty = difficulty;
        }

        // Method to randomly initialize the grid with live cells
        public void SetupLiveNeighbors()
        {
            Random random = new Random();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    // Use randomization to set cells as live based on the specified difficulty
                    if (random.NextDouble() < Difficulty)
                    {
                        Grid[i, j].Live = true;
                    }
                }
            }
        }

        // Method to calculate the number of live neighbors for each cell
        public void CalculateLiveNeighbors()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    int liveNeighborCount = 0;

                    // Iterate through neighboring cells to count live neighbors
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            if (dx == 0 && dy == 0)
                                continue;

                            int neighborX = i + dx;
                            int neighborY = j + dy;

                            if (neighborX >= 0 && neighborX < Size && neighborY >= 0 && neighborY < Size)
                            {
                                if (Grid[neighborX, neighborY].Live)
                                {
                                    liveNeighborCount++;
                                }
                            }
                        }
                    }

                    Grid[i, j].LiveNeighbors = liveNeighborCount;
                }
            }
        }
    }
}
