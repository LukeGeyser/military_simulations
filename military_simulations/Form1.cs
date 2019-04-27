using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace military_simulations
{
    public partial class Form1 : Form
    {
        List<Rectangle> listOfEnemiesPlacements = new List<Rectangle>();
        List<Rectangle> listOfRPGSquads = new List<Rectangle>();
        List<Rectangle> listOfHomeBase = new List<Rectangle>();
        List<Rectangle> listOfEnemyBase = new List<Rectangle>();

        // Booleans
        private bool initialLoad = false;
        private bool aStarRan = false;

        //Home Base Points
        Point hp1 = new Point(16, 13);
        Point hp2 = new Point(17, 12);
        Point hp3 = new Point(15, 14);
        Point hp4 = new Point(14, 15);
        Point hp5 = new Point(13, 16);

        //Enemy Base Points
        Point ep1 = new Point(0, 6);
        Point ep2 = new Point(1, 5);
        Point ep3 = new Point(2, 4);
        Point ep4 = new Point(3, 3);
        Point ep5 = new Point(6, 0);
        Point ep6 = new Point(5, 1);
        Point ep7 = new Point(4, 2);
        Point ep8 = new Point(3, 3);

        // Vairables
        int gridX;
        int gridY;
        int width = 50;
        int obstacleIndexX;
        int obstacleIndexY;

        // Variables for Selecting Obstacles
        private bool enemyPlacementsClicked = false;
        private bool rpgSquads = false;

        Cell[,] grid;
        Cell[,] rectanglesReDraw;

        // A* Variables
        List<Cell> openSet = new List<Cell>();
        List<Cell> closedSet = new List<Cell>();
        List<Cell> path = new List<Cell>();
        Cell start;
        Cell end;
        int cellIndexX;
        int cellIndexY;

        private void PopulateHomeBase()
        {
            listOfHomeBase.Add(new Rectangle(hp1.X * width, hp1.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp2.X * width, hp2.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp3.X * width, hp3.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp4.X * width, hp4.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp5.X * width, hp5.Y * width, width, width));          
        }

        private void PopulateEnemyBase()
        {
            listOfEnemyBase.Add(new Rectangle(ep1.X * width, ep1.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep2.X * width, ep2.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep3.X * width, ep3.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep4.X * width, ep4.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep5.X * width, ep5.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep6.X * width, ep6.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep7.X * width, ep7.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep8.X * width, ep8.Y * width, width, width));
        }

        public Form1()
        {
            InitializeComponent();            
            tlt_Fuel.Value = 100;
            PopulateHomeBase();
            PopulateEnemyBase();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            gridX = this.Width / width;
            gridY = this.Height / width;
            grid = new Cell[gridX, gridY];
            // INITIAL DRAW
            if (initialLoad == false)
            {
                initialLoad = true;
                // Display Grid                                                
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Cell cell = new Cell(i, j , width);
                        grid[i, j] = cell;
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 2), cell.Rec);                        
                    }
                }

                // Adding Neighbors
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        grid[i, j].AddNeighbors(grid);
                    }
                }

                // Initializing Start
                start = new Cell(17, 16, width);
                start.AddNeighbors(grid);
                openSet.Add(start);
                // Initializing End
                end = new Cell(0, 0, width);
                end.AddNeighbors(grid);

                foreach (var homeBase in listOfHomeBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase);
                }
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase);
                }

                // Draw Start
                e.Graphics.DrawRectangle(new Pen(Color.Gold, 3), start.Rec);
                // Draw End
                e.Graphics.DrawRectangle(new Pen(Color.HotPink, 3), end.Rec);

                rectanglesReDraw = grid;
            }
            // REDRAW
            else if (initialLoad == true)
            {
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Cell cell = new Cell(i, j, width);
                        grid[i, j] = cell;
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 2), cell.Rec);
                    }
                }

                // Adding Obstacles
                if (enemyPlacementsClicked == true)
                {
                    listOfEnemiesPlacements.Add(new Rectangle(obstacleIndexX * width, obstacleIndexY * width, width, width));
                }
                else if (rpgSquads == true)
                {
                    listOfRPGSquads.Add(new Rectangle(obstacleIndexX * width, obstacleIndexY * width, width, width));
                }

                // Display all Enemy Placements
                foreach (var enemies in listOfEnemiesPlacements)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Violet, 3), enemies);
                }

                // Display all RPG Sqauds
                foreach (var rpg in listOfRPGSquads)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Orange, 3), rpg);
                }

                // Display all HomeBase Structures
                foreach (var homeBase in listOfHomeBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase);
                }

                // Display all EnemyBase Structures
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase);
                }

                if (aStarRan == true)
                {
                    // Draw Path
                    foreach (var pathItem in path)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), pathItem.Rec);
                        Thread.Sleep(100);
                    }
                    aStarRan = false;
                }

                // Draw Start
                e.Graphics.DrawRectangle(new Pen(Color.Gold, 3), start.Rec);
                // Draw End
                e.Graphics.DrawRectangle(new Pen(Color.HotPink, 3), end.Rec);
                
            }
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (enemyPlacementsClicked == true || rpgSquads == true)
            {
                SetStyle(ControlStyles.ResizeRedraw, true);
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Point point = new Point(MousePosition.X, MousePosition.Y);
                        if (rectanglesReDraw[i, j].Rec.Contains(point))
                        {
                            obstacleIndexX = i;
                            obstacleIndexY = j;
                        }
                    }
                }                
                panel1.Invalidate();
                //MessageBox.Show(enemyPlacementsClicked + " " + rpgSquads);
            }
            else if (enemyPlacementsClicked == false && rpgSquads == false)
            {
                MessageBox.Show("Please Select an Obstacle");
            }            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region BUTTON DRAW
        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Point p = new Point(btn_enemyemplacements.Width / 2 - 25, btn_enemyemplacements.Height / 2 - 25);
            Rectangle rec = new Rectangle(p.X, p.Y, 50, 50);
            e.Graphics.DrawRectangle(new Pen(Color.Violet, 2), rec);
        }

        private void Btn_RPGsquads_Paint(object sender, PaintEventArgs e)
        {
            Point p = new Point(btn_enemyemplacements.Width / 2 - 25, btn_enemyemplacements.Height / 2 - 25);
            Rectangle rec = new Rectangle(p.X, p.Y, 50, 50);
            e.Graphics.DrawRectangle(new Pen(Color.Orange, 2), rec);
        }
        #endregion

        #region OBSTACLES CLICKED
        private void Btn_enemyemplacements_MouseClick(object sender, MouseEventArgs e)
        {
            if (enemyPlacementsClicked == false)
            {
                if (rpgSquads == true)
                {
                    btn_RPGsquads.BackColor = Color.White;
                    btn_enemyemplacements.Focus();
                    rpgSquads = false;
                }
                btn_enemyemplacements.BackColor = Color.Gray;                
                enemyPlacementsClicked = true;                
            }
            else if (enemyPlacementsClicked == true)
            {
                enemyPlacementsClicked = false;
                btn_enemyemplacements.BackColor = Color.White;
                panel1.Focus();
            }
        }

        private void Btn_RPGsquads_MouseClick(object sender, MouseEventArgs e)
        {
            if (rpgSquads == false)
            {
                if (enemyPlacementsClicked == true)
                {
                    btn_enemyemplacements.BackColor = Color.White;
                    btn_RPGsquads.Focus();
                    enemyPlacementsClicked = false;
                }
                btn_RPGsquads.BackColor = Color.Gray;                
                rpgSquads = true;
            }
            else if (rpgSquads == true)
            {
                rpgSquads = false;
                btn_RPGsquads.BackColor = Color.White;
                panel1.Focus();
            }
        }
        #endregion

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            aStarRan = true;
            // A* Algorithm
            while (openSet.Count > 0)
            {
                //we can keep going
                int winner = 0;
                for (int i = 0; i < openSet.Count; i++)
                {
                    if (openSet[i].F < openSet[winner].F)
                        winner = i;
                }

                //MessageBox.Show("1");
                Cell current = openSet[winner];

                var neighbors = current.Neighbors;

                for (int i = 0; i < neighbors.Count; i++)
                {
                    Cell neighbor = neighbors[i];
                    if (!closedSet.Contains(neighbor))
                    {
                        double tempG = current.G + 1;
                        if (openSet.Contains(neighbor))
                        {
                            //MessageBox.Show("2");
                            if (tempG < neighbor.G)
                                neighbor.G = tempG;
                        }
                        else
                        {
                            //MessageBox.Show("3");
                            neighbor.G = tempG;
                            openSet.Add(neighbor);
                        }
                        //MessageBox.Show("4");
                        neighbor.H = Heuristic(neighbor, end);
                        neighbor.F = neighbor.G + neighbor.H;
                        neighbor.Previous = current;

                    }
                    
                        
                }

                if (current.I == end.I && current.J == end.J)
                {
                    // Find the Path
                    Cell temp = current;
                    path.Add(temp);
                    while (temp.Previous != null)
                    {
                        path.Add(temp.Previous);
                        temp = temp.Previous;
                    }
                    MessageBox.Show("DONE!!");
                    break;
                }
                

                openSet.Remove(current);
                closedSet.Add(current);

                panel1.Invalidate();
            }

            if (openSet.Count <= 0)
            {
                // No Solution
            }
        }


        private double Heuristic(Cell neighbor, Cell end)
        {
            double d = (neighbor.I - end.I) + (neighbor.J - end.J);
            return d;
        }

    }
}
