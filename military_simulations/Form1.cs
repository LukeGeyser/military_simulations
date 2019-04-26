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

        private bool initialLoad = false;

        //Home Base Points
        Point hp1 = new Point(16, 14);
        Point hp2 = new Point(16, 15);
        Point hp3 = new Point(15, 14);
        Point hp4 = new Point(15, 15);

        //Enemy Base Points
        Point ep1 = new Point(1, 1);
        Point ep2 = new Point(1, 2);
        Point ep3 = new Point(2, 1);
        Point ep4 = new Point(2, 2);

        // Vairables
        int gridX;
        int gridY;
        int width = 50;
        int obstacleIndexX;
        int obstacleIndexY;

        // Variables for Selecting Obstacles
        private bool enemyPlacementsClicked = false;
        private bool rpgSquads = false;

        Rectangle[,] rectanglesInitial;
        Rectangle[,] rectanglesReDraw;      

        private void PopulateHomeBase()
        {
            listOfHomeBase.Add(new Rectangle(hp1.X * width, hp1.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp2.X * width, hp2.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp3.X * width, hp3.Y * width, width, width));
            listOfHomeBase.Add(new Rectangle(hp4.X * width, hp4.Y * width, width, width));
        }

        private void PopulateEnemyBase()
        {
            listOfEnemyBase.Add(new Rectangle(ep1.X * width, ep1.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep2.X * width, ep2.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep3.X * width, ep3.Y * width, width, width));
            listOfEnemyBase.Add(new Rectangle(ep4.X * width, ep4.Y * width, width, width));
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
            rectanglesInitial = new Rectangle[gridX, gridY];
            // INITIAL DRAW
            if (initialLoad == false)
            {
                initialLoad = true;
                // Display Grid                                                
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Rectangle rec = new Rectangle(i * width, j * width, width, width);
                        rectanglesInitial[i, j] = rec;
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 2), rec);                        
                    }
                }                
                foreach (var homeBase in listOfHomeBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase);
                }
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase);
                }
                Debug.WriteLine(rectanglesInitial.Length);
                rectanglesReDraw = rectanglesInitial;
            }
            // REDRAW
            else if (initialLoad == true)
            {
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Rectangle rec = new Rectangle(i * width, j * width, width, width);
                        rectanglesReDraw[i, j] = rec;
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 2), rec);
                    }
                }
                foreach (var homeBase in listOfHomeBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase);
                }
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase);
                }
                if (enemyPlacementsClicked == true)
                {
                    listOfEnemiesPlacements.Add(new Rectangle(obstacleIndexX * width, obstacleIndexY * width, width, width));
                }
                else if (rpgSquads == true)
                {
                    listOfRPGSquads.Add(new Rectangle(obstacleIndexX * width, obstacleIndexY * width, width, width));
                }
                
                foreach (var enemies in listOfEnemiesPlacements)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LightSkyBlue, 3), enemies);
                }
                foreach (var rpg in listOfRPGSquads)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Orange, 3), rpg);
                }
                Debug.WriteLine(rectanglesReDraw.Length);
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
                        if (rectanglesReDraw[i, j].Contains(point))
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
            e.Graphics.DrawRectangle(new Pen(Color.LightSkyBlue, 2), rec);
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
    }
}
