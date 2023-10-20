using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1_Console_Application
{
    public class Cell
    {
        // Properties for the game cell
        public int Row { get; set; } // Property for the row of the cell
        public int Column { get; set; } // Property for the column of the cell
        public bool Visited { get; set; } // Property to track if the cell has been visited
        public bool Live { get; set; } // Property to indicate if the cell is a "live bomb"
        public int LiveNeighbors { get; set; } // Property to store the number of live neighbors

        // Constructor to initialize the cell
        public Cell()
        {
            // Initially, set row and column to -1
            Row = -1;
            Column = -1;

            // Initially, the cell has not been visited, and it's not a live bomb
            Visited = false;
            Live = false;

            // Initially, there are no live neighbors
            LiveNeighbors = 0;
        }
    }
}
