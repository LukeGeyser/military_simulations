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
using System.Drawing.Drawing2D;
using System.Media;

namespace military_simulations
{
    public partial class MilitaryGame : Form
    {

        #region List Of Items To Draw
        List<Cell> listOfEnemiesPlacements = new List<Cell>();
        List<Cell> listOfRPGSquads = new List<Cell>();
        List<Cell> listOfHomeBase = new List<Cell>();
        List<Cell> listOfEnemyBase = new List<Cell>();
        #endregion

        #region Booleans
        private bool initialLoad = false;
        private bool aStarRan = false;
        private bool initialFlight = false;
        private bool crashed = false;
        #endregion

        #region Home Base Points
        Point hp1 = new Point(16, 13);
        Point hp2 = new Point(17, 12);
        Point hp3 = new Point(15, 14);
        Point hp4 = new Point(14, 15);
        Point hp5 = new Point(13, 16);
        #endregion

        #region Enemy Base Points
        Point ep1 = new Point(0, 6);
        Point ep2 = new Point(1, 5);
        Point ep3 = new Point(2, 4);
        Point ep4 = new Point(3, 3);
        Point ep5 = new Point(6, 0);
        Point ep6 = new Point(5, 1);
        Point ep7 = new Point(4, 2);
        Point ep8 = new Point(3, 3);
        #endregion

        #region Vairables
        int gridX;
        int gridY;
        int width = 50;
        int obstacleIndexX;
        int obstacleIndexY;
        public static int playerID;
        #endregion

        #region Variables for Selecting Obstacles
        private bool enemyPlacementsClicked = false;
        private bool rpgSquads = false;
        private bool removeObstacles = false;
        #endregion

        #region Grid Variables
        Cell[,] grid;
        Cell[,] rectanglesReDraw;
        #endregion

        #region A* Variables
        List<Cell> openSet = new List<Cell>();
        List<Cell> closedSet = new List<Cell>();
        List<Cell> path = new List<Cell>();
        Cell start;
        Cell end;
        #endregion

        #region Aircraft Variables
        a394Jet a394Jet;
        cb478Jet cb478Jet;
        List<double> allRecordedSpeeds = new List<double>();
        List<double> allRecordedAltitudes = new List<double>();
        List<double> recordedHealth = new List<double>();
        List<double> recordedFuel = new List<double>();
        double tempSpeed = 0;
        double tempAltitude = 0;
        bool noSolution = false;
        #endregion

        #region Media Variables
        public static SoundPlayer pacman = new SoundPlayer("audio\\pacman.wav");
        #endregion

        private void PopulateHomeBase()
        {
            listOfHomeBase.Add(new Cell(hp1.X, hp1.Y, width));
            listOfHomeBase.Add(new Cell(hp2.X, hp2.Y, width));
            listOfHomeBase.Add(new Cell(hp3.X, hp3.Y, width));
            listOfHomeBase.Add(new Cell(hp4.X, hp4.Y, width));
            listOfHomeBase.Add(new Cell(hp5.X, hp5.Y, width));
        }

        private void PopulateEnemyBase()
        {
            listOfEnemyBase.Add(new Cell(ep1.X, ep1.Y, width));
            listOfEnemyBase.Add(new Cell(ep2.X, ep2.Y, width));
            listOfEnemyBase.Add(new Cell(ep3.X, ep3.Y, width));
            listOfEnemyBase.Add(new Cell(ep4.X, ep4.Y, width));
            listOfEnemyBase.Add(new Cell(ep5.X, ep5.Y, width));
            listOfEnemyBase.Add(new Cell(ep6.X, ep6.Y, width));
            listOfEnemyBase.Add(new Cell(ep7.X, ep7.Y, width));
            listOfEnemyBase.Add(new Cell(ep8.X, ep8.Y, width));
        }

        public MilitaryGame(string aircraftType, int ID)
        {
            InitializeComponent();
            playerID = ID;
            if (aircraftType == "a394Jet")
            {
                a394Jet = new a394Jet();
            }
            else if (aircraftType == "cb478Jet")
            {
                cb478Jet = new cb478Jet();
            }
            tlt_Fuel.Value = 100;
            tlb_Fuel.Text = tlt_Fuel.Value + "%";
            tlt_Health.Value = 100;
            tlb_Health.Text = tlt_Health.Value + "%";
            PopulateHomeBase();
            PopulateEnemyBase();
        }

        public MilitaryGame()
        {
            InitializeComponent();
            tlt_Fuel.Value = 100;
            tlb_Fuel.Text = tlt_Fuel.Value + "%";
            tlt_Health.Value = 100;
            tlb_Health.Text = tlt_Health.Value + "%";
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
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase.Rec);
                }
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase.Rec);
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
                // Adding Obstacles
                if (enemyPlacementsClicked == true)
                {
                    listOfEnemiesPlacements.Add(new Cell(obstacleIndexX, obstacleIndexY, width));
                }
                else if (rpgSquads == true)
                {
                    listOfRPGSquads.Add(new Cell(obstacleIndexX, obstacleIndexY, width));
                }

                // Display all Enemy Placements
                foreach (var enemies in listOfEnemiesPlacements)
                {
                    Image img = Image.FromFile(@"C:\Users\User-pc\Desktop\military_simulations_Project\military_simulations\military_simulations\images\solider.png");
                    Bitmap bimage = new Bitmap(img);
                    TextureBrush tx = new TextureBrush(bimage);
                    tx.Transform = new Matrix(
                       50.0f / 360.0f,
                       0.0f,
                       0.0f,
                       50.0f / 420.0f,
                       0.0f,
                       0.0f);
                    //e.Graphics.DrawRectangle(new Pen(Color.Violet, 3), enemies.Rec);
                    e.Graphics.FillRectangle(tx, enemies.Rec);
                }

                // Display all RPG Squads
                foreach (var rpg in listOfRPGSquads)
                {
                    Image img = Image.FromFile(@"C:\Users\User-pc\Desktop\military_simulations_Project\military_simulations\military_simulations\images\tank.png");
                    Bitmap bimage = new Bitmap(img);
                    TextureBrush tx = new TextureBrush(bimage);
                    tx.Transform = new Matrix(
                       50.0f / 507.0f,
                       0.0f,
                       0.0f,
                       50.0f / 363.0f,
                       0.0f,
                       0.0f);
                    e.Graphics.FillRectangle(tx, rpg.Rec);
                    //e.Graphics.DrawRectangle(new Pen(Color.Orange, 3), rpg.Rec);
                }

                // Display all HomeBase Structures
                foreach (var homeBase in listOfHomeBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.LimeGreen, 3), homeBase.Rec);
                }

                // Display all EnemyBase Structures
                foreach (var enemyBase in listOfEnemyBase)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), enemyBase.Rec);
                }

                if (aStarRan == true)
                {
                    // Draw Path
                    FlightPath(e, path);
                    aStarRan = false;
                }

                // Draw Start
                e.Graphics.DrawRectangle(new Pen(Color.Gold, 3), start.Rec);
                // Draw End
                e.Graphics.DrawRectangle(new Pen(Color.HotPink, 3), end.Rec);

            }
        }

        // Clicking on Panel and Adding to obstacles List
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
                            rectanglesReDraw[i, j].Obstacle = true;
                        }
                    }
                }
                panel1.Invalidate();
                //MessageBox.Show(enemyPlacementsClicked + " " + rpgSquads);
            }
            else if (enemyPlacementsClicked == false && rpgSquads == false && removeObstacles == true)
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
                            rectanglesReDraw[i, j].Obstacle = true;
                        }
                    }
                }
                panel1.Invalidate();
            }
            else if (enemyPlacementsClicked == false && rpgSquads == false)
            {
                MessageBox.Show("Please Select an Obstacle");
            }
        }

        // Closes Application
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region BUTTON DRAW OBSTACLES
        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, 112, 86);
            Image img = Image.FromFile(@"C:\Users\User-pc\Desktop\military_simulations_Project\military_simulations\military_simulations\images\solider.png");
            Bitmap bimage = new Bitmap(img);
            TextureBrush tx = new TextureBrush(bimage);
            tx.Transform = new Matrix(
               112.0f / 360.0f,
               0.0f,
               0.0f,
               86.0f / 420.0f,
               0.0f,
               0.0f);
            e.Graphics.FillRectangle(tx, rec);
            //e.Graphics.DrawRectangle(new Pen(Color.Violet, 2), rec);
        }

        private void Btn_RPGsquads_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, 112, 86);
            Image img = Image.FromFile(@"C:\Users\User-pc\Desktop\military_simulations_Project\military_simulations\military_simulations\images\tank.png");
            Bitmap bimage = new Bitmap(img);
            TextureBrush tx = new TextureBrush(bimage);
            tx.Transform = new Matrix(
               112.0f / 507.0f,
               0.0f,
               0.0f,
               86.0f / 363.0f,
               0.0f,
               0.0f);
            e.Graphics.FillRectangle(tx, rec);
            //e.Graphics.DrawRectangle(new Pen(Color.Orange, 2), rec);
        }
        #endregion

        #region OBSTACLES CLICKED
        private void Btn_enemyemplacements_MouseClick(object sender, MouseEventArgs e)
        {
            removeObstacles = false;
            if (enemyPlacementsClicked == false)
            {
                if (rpgSquads == true)
                {
                    btn_RPGsquads.BackColor = Color.White;
                    btn_enemyemplacements.Focus();
                    rpgSquads = false;
                }
                btn_enemyemplacements.BackColor = Color.Gray;
                if (!btn_RemoveObs.Focused)
                {
                    btn_RemoveObs.BackColor = Color.White;
                    btn_enemyemplacements.Focus();
                }
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
            removeObstacles = false;
            if (rpgSquads == false)
            {
                if (enemyPlacementsClicked == true)
                {
                    btn_enemyemplacements.BackColor = Color.White;
                    btn_RPGsquads.Focus();
                    enemyPlacementsClicked = false;
                }
                btn_RPGsquads.BackColor = Color.Gray;
                if (!btn_RemoveObs.Focused)
                {
                    btn_RemoveObs.BackColor = Color.White;
                    btn_RPGsquads.Focus();
                }
                rpgSquads = true;
            }
            else if (rpgSquads == true)
            {
                rpgSquads = false;
                btn_RPGsquads.BackColor = Color.White;
                panel1.Focus();
            }
        }

        private void Btn_RemoveObs_Click(object sender, EventArgs e)
        {
            if (btn_RemoveObs.Focused)
            {
                removeObstacles = true;
                rpgSquads = false;
                enemyPlacementsClicked = false;
                btn_RemoveObs.BackColor = Color.Gray;
            }
            if (!btn_enemyemplacements.Focused)
            {
                btn_enemyemplacements.BackColor = Color.White;
            }
            if (!btn_RPGsquads.Focused)
            {
                btn_RPGsquads.BackColor = Color.White;
            }
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    if (rectanglesReDraw[i, j].Obstacle == true)
                    {
                        rectanglesReDraw[i, j].Obstacle = false;
                    }
                }
            }
            listOfEnemiesPlacements.Clear();
            listOfRPGSquads.Clear();
            panel1.Invalidate();
        }
        #endregion

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if(SignIn.atari != null)
                SignIn.atari.Stop();
            pacman.PlayLooping();
            closedSet = new List<Cell>(); ;
            openSet = new List<Cell>();
            // Initializing Start
            start = new Cell(17, 16, width);
            start.AddNeighbors(rectanglesReDraw);
            openSet.Add(start);
            // Initializing End
            end = new Cell(0, 0, width);
            end.AddNeighbors(rectanglesReDraw);
            path = new List<Cell>();
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

                    if (!closedSet.Contains(neighbor) && !neighbor.Obstacle)
                    {
                        double tempG = current.G + 1;
                        bool newPath = false;
                        if (openSet.Contains(neighbor))
                        {
                            if (tempG < neighbor.G)
                            {
                                neighbor.G = tempG;
                                newPath = true;
                            }
                        }
                        else
                        {
                            neighbor.G = tempG;
                            newPath = true;
                            openSet.Add(neighbor);
                        }
                        if (newPath)
                        {
                            neighbor.H = Heuristic(neighbor, end);
                            neighbor.F = neighbor.G + neighbor.H;
                            neighbor.Previous = current;
                        }
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
                    panel1.Invalidate();
                    //MessageBox.Show("DONE!!", "Information");
                    break;
                }


                openSet.Remove(current);
                closedSet.Add(current);
            }

            if (openSet.Count <= 0)
            {
                // No Solution
                MessageBox.Show("NO SOLUTION", "Information");
                noSolution = true;
            }
        }

        private double Heuristic(Cell neighbor, Cell end)
        {
            double d = Math.Sqrt(Math.Pow((end.I - neighbor.I), 2) + Math.Pow((end.J - neighbor.J), 2));
            return d;
        }

        private void FlightPath(PaintEventArgs e, List<Cell> path)
        {
            int counter = 0;
            if (initialFlight == true)
            {
                btn_Start.Text = "Send Out Scout";
                foreach (var pathItem in path)
                {

                    e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), pathItem.Rec);
                    try
                    {
                        tlt_Fuel.ProgressBar.Value -= 1;
                        recordedFuel.Add(tlt_Fuel.ProgressBar.Value);
                        tlb_Fuel.Text = tlt_Fuel.Value + "%";
                        Thread.Sleep(500);
                        // To Determine the Speed and Altitude of Aircraft
                        counter++;
                        DetermineSpeedAndAltitude(path, counter);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You Have Run Out Of Fuel", "CRASH!!!");
                        break;
                    }
                    foreach (var item in pathItem.Neighbors)
                    {
                        if (item.Obstacle)
                        {
                            try
                            {
                                tlt_Health.ProgressBar.Value -= 5;
                                recordedHealth.Add(tlt_Health.ProgressBar.Value);
                                tlb_Health.Text = tlt_Health.Value + "%";
                                if (tlt_Health.Value == 0)
                                {
                                    MessageBox.Show("You have been Shot Down", "CRASH!!!");
                                    crashed = true;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("You have been Shot Down", "CRASH!!!");
                                crashed = true;
                                break;
                            }
                        }
                    }
                    if (crashed == true)
                        break;
                }
                initialFlight = false;
            }
            else if (initialFlight == false)
            {
                btn_Start.Text = "Bring Back Scout";
                path.Reverse();

                foreach (var pathItem in path)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), pathItem.Rec);

                    try
                    {
                        tlt_Fuel.ProgressBar.Value -= 1;
                        recordedFuel.Add(tlt_Fuel.ProgressBar.Value);
                        tlb_Fuel.Text = tlt_Fuel.Value + "%";
                        Thread.Sleep(500);
                        // To Determine the Speed and Altitude of Aircraft
                        counter++;
                        DetermineSpeedAndAltitude(path, counter);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You Have Run Out Of Fuel", "CRASH!!!");
                        break;
                    }
                    foreach (var item in pathItem.Neighbors)
                    {
                        if (item.Obstacle)
                        {
                            try
                            {
                                tlt_Health.ProgressBar.Value -= 5;
                                recordedHealth.Add(tlt_Health.ProgressBar.Value);
                                tlb_Health.Text = tlt_Health.Value + "%";
                                if (tlt_Health.Value == 0)
                                {
                                    MessageBox.Show("You have been Shot Down", "CRASH!!!");
                                    crashed = true;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("You have been Shot Down", "CRASH!!!");
                                crashed = true;
                                break;
                            }
                        }
                    }
                    if (crashed == true)
                        break;
                }
                initialFlight = true;
            }
            pacman.Stop();
            if (SignIn.atari != null)
                SignIn.atari.Play();
        }

        private void Btn_Signout_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void DetermineSpeedAndAltitude(List<Cell> path, int counter)
        {
            if (a394Jet != null)
            {
                if (counter == 1)
                {
                    allRecordedSpeeds.Add(a394Jet.Currentspeed);
                    allRecordedAltitudes.Add(a394Jet.CurrentAltitude);
                }

                if (a394Jet.CurrentAltitude < 5000)
                {
                    tempSpeed += a394Jet.AccelerationSpeed + 10;
                    tempAltitude += 1000;
                }
                else if (a394Jet.CurrentAltitude >= 5000 && a394Jet.CurrentAltitude < 15000)
                {
                    tempSpeed += a394Jet.AccelerationSpeed;
                    tempAltitude += 800;
                }
                else if (a394Jet.CurrentAltitude >= 15000 && a394Jet.CurrentAltitude < 38000)
                {
                    tempSpeed += a394Jet.AccelerationSpeed - 10;
                    if ((tempAltitude += 500) > 38000)
                    {
                        tempAltitude = 38000;
                    }
                    else
                    {
                        tempAltitude += 500;
                    }
                }

                if (a394Jet.Currentspeed >= a394Jet.MaxSpeed)
                {
                    tempSpeed = a394Jet.MaxSpeed;
                }

                a394Jet.Currentspeed = tempSpeed;
                a394Jet.CurrentAltitude = tempAltitude;

                txt_Speed.Text = a394Jet.Currentspeed.ToString();
                txt_Altitude.Text = a394Jet.CurrentAltitude.ToString();

                allRecordedSpeeds.Add(a394Jet.Currentspeed);
                allRecordedAltitudes.Add(a394Jet.CurrentAltitude);
            }
            else if (cb478Jet != null)
            {
                if (counter == 1)
                {
                    allRecordedSpeeds.Add(cb478Jet.Currentspeed);
                    allRecordedAltitudes.Add(cb478Jet.CurrentAltitude);
                }

                if (cb478Jet.CurrentAltitude < 5000)
                {
                    tempSpeed += cb478Jet.AccelerationSpeed + 10;
                    tempAltitude += 1100;
                }
                else if (cb478Jet.CurrentAltitude >= 5000 && cb478Jet.CurrentAltitude < 15000)
                {
                    tempSpeed += cb478Jet.AccelerationSpeed;
                    tempAltitude += 750;
                }
                else if (cb478Jet.CurrentAltitude >= 15000 && cb478Jet.CurrentAltitude < 39000)
                {
                    tempSpeed += cb478Jet.AccelerationSpeed - 10;
                    if ((tempAltitude += 625) > 39000)
                    {
                        tempAltitude = 38000;
                    }
                    else
                    {
                        tempAltitude += 625;
                    }
                }

                if (cb478Jet.Currentspeed >= cb478Jet.MaxSpeed)
                {
                    tempSpeed = cb478Jet.MaxSpeed;
                }

                cb478Jet.Currentspeed = tempSpeed;
                cb478Jet.CurrentAltitude = tempAltitude;

                txt_Speed.Text = cb478Jet.Currentspeed.ToString();
                txt_Altitude.Text = cb478Jet.CurrentAltitude.ToString();

                allRecordedSpeeds.Add(cb478Jet.Currentspeed);
                allRecordedAltitudes.Add(cb478Jet.CurrentAltitude);
            }
        }

        private void Txt_Speed_TextChanged(object sender, EventArgs e)
        {
            txt_Speed.Text = tempSpeed.ToString();
        }

        private void Btn_GetResults_Click(object sender, EventArgs e)
        {
            if (allRecordedSpeeds.Count > 0 || allRecordedAltitudes.Count > 0 || recordedHealth.Count > 0 || recordedFuel.Count > 0)
            {
                GameResults gameResults = new GameResults(allRecordedSpeeds, allRecordedAltitudes, recordedHealth, recordedFuel,
                    listOfEnemiesPlacements, listOfRPGSquads);
                this.Hide();
                gameResults.Show();
            }
        }
    }
}
