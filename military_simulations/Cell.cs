using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace military_simulations
{
    class Cell
    {
        private double f = 0;
        private double g = 0;
        private double h = 0;
        private Rectangle rec;
        private int i;
        private int j;
        private int width;
        private List<Cell> neighbors = new List<Cell>();
        private Cell previous = null;
        private bool obstacle = false;

        public double F { get => f; set => f = value; }
        public double G { get => g; set => g = value; }
        public double H { get => h; set => h = value; }
        public Rectangle Rec { get => rec; set => rec = value; }
        public int I { get => i; set => i = value; }
        public int J { get => j; set => j = value; }
        public int Width { get => width; set => width = value; }
        internal List<Cell> Neighbors { get => neighbors; set => neighbors = value; }
        internal Cell Previous { get => previous; set => previous = value; }
        public bool Obstacle { get => obstacle; set => obstacle = value; }

        public Cell(int i, int j, int width)
        {
            this.i = i;
            this.j = j;
            this.width = width;
            rec = new Rectangle(i * width, j * width, width, width);
        }


        public void AddNeighbors(Cell[,] grid)
        {
            if (i < 17 - 1)
                neighbors.Add(grid[i + 1, j]);
            if (i > 0)
                neighbors.Add(grid[i - 1, j]);
            if (j < 16 - 1)
                neighbors.Add(grid[i, j + 1]);
            if (j > 0)
                neighbors.Add(grid[i, j - 1]);
            //Diagonals
            if (i > 0 && j > 0)
                neighbors.Add(grid[i - 1, j - 1]);
            if (i < 17 - 1 && j > 0)
                neighbors.Add(grid[i + 1, j - 1]);
            if (i > 0 && j < 16 -1)
                neighbors.Add(grid[i - 1, j + 1]);
            if (i < 17 -1 && j < 16 -1)
                neighbors.Add(grid[i + 1, j + 1]);
        }

    }
}
