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
        List<Rectangle> listOfObstacles = new List<Rectangle>();
        
        private bool initialLoad = false;

        // Vairables
        int gridX;
        int gridY;
        int width = 50;
        Rectangle[,] rectangles;
        Color color;

        public Form1()
        {
            InitializeComponent();
            color = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (initialLoad == false)
            {
                initialLoad = true;
                // Display Grid                
                gridX = this.Width / width;
                gridY = this.Height / width;
                rectangles = new Rectangle[gridX, gridY];
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Rectangle rec = new Rectangle(i * width, j * width, width, width);
                        rectangles[i, j] = rec;
                        e.Graphics.DrawRectangle(new Pen(color), rec);
                        //Thread.Sleep(100);
                    }
                }
                Debug.WriteLine(rectangles.Length);
            }
            else if (initialLoad == true)
            {
                //Pen pen = new Pen(Color.Blue, 5);
                //foreach (var i in listOfObstacles)
                //{
                //    e.Graphics.DrawRectangle(pen, i);
                //}

                // Display Grid                
                gridX = this.Width / width;
                gridY = this.Height / width;
                rectangles = new Rectangle[gridX, gridY];
                for (int i = 0; i < gridX; i++)
                {
                    for (int j = 0; j < gridY; j++)
                    {
                        Rectangle rec = new Rectangle(i * width, j * width, width, width);
                        rectangles[i, j] = rec;
                        e.Graphics.DrawRectangle(new Pen(Color.Red), rec);
                        //Thread.Sleep(100);
                    }
                }
                Debug.WriteLine(rectangles.Length);
            }
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    Point point = new Point(MousePosition.X, MousePosition.Y);
                    if (rectangles[i, j].Contains(point))
                    {
                        MessageBox.Show(rectangles[i, j].X + "and" + rectangles[i, j].Y);
                        rectangles[i, j] = new Rectangle(i * width, j * width, width, width);
                        color = Color.Red;
                    }
                }
            }
            panel1.Invalidate();
        }       
    }
}
