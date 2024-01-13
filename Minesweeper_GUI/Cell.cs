﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_GUI
{
    public class Cell
    {
        // Properties 
        public int row { get; set; }
        public int col { get; set; }
        public bool isVisited { get; set; }
        public bool isLive { get; set; }
        public int liveNeighbors { get; set; }
        public bool hasFlag { get; set; }


        // Constructors 
        // Default Constructor 
        public Cell()
        {
            this.col = -1;
            this.row = -1;
            this.isVisited = false;
            this.isLive = false;
            this.liveNeighbors = 0;
            this.hasFlag = false;
        }

        // Non-Default Constructor 
        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.isVisited = false;
            this.isLive = false;
            this.liveNeighbors = 0;
            this.hasFlag = false;
        }

    } // end of class. 

} // end of namespace. 