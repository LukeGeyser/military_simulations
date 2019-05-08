namespace military_simulations
{
    partial class GameResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_mainResult = new System.Windows.Forms.Panel();
            this.pnl_Altitude = new System.Windows.Forms.Panel();
            this.chrt_Speed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Speed = new System.Windows.Forms.Panel();
            this.chrt_Altitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_HealthFuel = new System.Windows.Forms.Panel();
            this.chrt_HealthFuel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Aircraft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Tanks = new System.Windows.Forms.Label();
            this.lbl_EnemyEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RPGsquads = new System.Windows.Forms.Button();
            this.btn_enemyemplacements = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnl_mainResult.SuspendLayout();
            this.pnl_Altitude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Speed)).BeginInit();
            this.pnl_Speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Altitude)).BeginInit();
            this.pnl_HealthFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_HealthFuel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousResultsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewPreviousResultsToolStripMenuItem
            // 
            this.viewPreviousResultsToolStripMenuItem.Name = "viewPreviousResultsToolStripMenuItem";
            this.viewPreviousResultsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewPreviousResultsToolStripMenuItem.Text = "View Previous Results";
            this.viewPreviousResultsToolStripMenuItem.Click += new System.EventHandler(this.ViewPreviousResultsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // pnl_mainResult
            // 
            this.pnl_mainResult.Controls.Add(this.pnl_Altitude);
            this.pnl_mainResult.Controls.Add(this.pnl_Speed);
            this.pnl_mainResult.Controls.Add(this.pnl_HealthFuel);
            this.pnl_mainResult.Controls.Add(this.panel2);
            this.pnl_mainResult.Location = new System.Drawing.Point(0, 27);
            this.pnl_mainResult.Name = "pnl_mainResult";
            this.pnl_mainResult.Size = new System.Drawing.Size(1184, 733);
            this.pnl_mainResult.TabIndex = 5;
            // 
            // pnl_Altitude
            // 
            this.pnl_Altitude.Controls.Add(this.chrt_Speed);
            this.pnl_Altitude.Location = new System.Drawing.Point(626, 381);
            this.pnl_Altitude.Name = "pnl_Altitude";
            this.pnl_Altitude.Size = new System.Drawing.Size(546, 344);
            this.pnl_Altitude.TabIndex = 7;
            // 
            // chrt_Speed
            // 
            chartArea4.Name = "ChartArea1";
            this.chrt_Speed.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrt_Speed.Legends.Add(legend4);
            this.chrt_Speed.Location = new System.Drawing.Point(3, 3);
            this.chrt_Speed.Name = "chrt_Speed";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chrt_Speed.Series.Add(series4);
            this.chrt_Speed.Size = new System.Drawing.Size(540, 338);
            this.chrt_Speed.TabIndex = 0;
            this.chrt_Speed.Text = "chart3";
            // 
            // pnl_Speed
            // 
            this.pnl_Speed.Controls.Add(this.chrt_Altitude);
            this.pnl_Speed.Location = new System.Drawing.Point(12, 381);
            this.pnl_Speed.Name = "pnl_Speed";
            this.pnl_Speed.Size = new System.Drawing.Size(608, 344);
            this.pnl_Speed.TabIndex = 6;
            // 
            // chrt_Altitude
            // 
            chartArea5.Name = "ChartArea1";
            this.chrt_Altitude.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrt_Altitude.Legends.Add(legend5);
            this.chrt_Altitude.Location = new System.Drawing.Point(3, 3);
            this.chrt_Altitude.Name = "chrt_Altitude";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrt_Altitude.Series.Add(series5);
            this.chrt_Altitude.Size = new System.Drawing.Size(602, 338);
            this.chrt_Altitude.TabIndex = 0;
            this.chrt_Altitude.Text = "chart2";
            // 
            // pnl_HealthFuel
            // 
            this.pnl_HealthFuel.Controls.Add(this.chrt_HealthFuel);
            this.pnl_HealthFuel.Location = new System.Drawing.Point(12, 7);
            this.pnl_HealthFuel.Name = "pnl_HealthFuel";
            this.pnl_HealthFuel.Size = new System.Drawing.Size(846, 356);
            this.pnl_HealthFuel.TabIndex = 5;
            // 
            // chrt_HealthFuel
            // 
            chartArea6.Name = "ChartArea1";
            this.chrt_HealthFuel.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrt_HealthFuel.Legends.Add(legend6);
            this.chrt_HealthFuel.Location = new System.Drawing.Point(3, 3);
            this.chrt_HealthFuel.Name = "chrt_HealthFuel";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chrt_HealthFuel.Series.Add(series6);
            this.chrt_HealthFuel.Size = new System.Drawing.Size(840, 350);
            this.chrt_HealthFuel.TabIndex = 0;
            this.chrt_HealthFuel.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Aircraft);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_Tanks);
            this.panel2.Controls.Add(this.lbl_EnemyEmp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_RPGsquads);
            this.panel2.Controls.Add(this.btn_enemyemplacements);
            this.panel2.Location = new System.Drawing.Point(882, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 356);
            this.panel2.TabIndex = 4;
            // 
            // lbl_Aircraft
            // 
            this.lbl_Aircraft.AutoSize = true;
            this.lbl_Aircraft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aircraft.ForeColor = System.Drawing.Color.White;
            this.lbl_Aircraft.Location = new System.Drawing.Point(165, 296);
            this.lbl_Aircraft.Name = "lbl_Aircraft";
            this.lbl_Aircraft.Size = new System.Drawing.Size(82, 18);
            this.lbl_Aircraft.TabIndex = 14;
            this.lbl_Aircraft.Text = "*invalid*";
            this.lbl_Aircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "AIRCRAFT \r\nUSED:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Tanks
            // 
            this.lbl_Tanks.AutoSize = true;
            this.lbl_Tanks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tanks.ForeColor = System.Drawing.Color.White;
            this.lbl_Tanks.Location = new System.Drawing.Point(48, 177);
            this.lbl_Tanks.Name = "lbl_Tanks";
            this.lbl_Tanks.Size = new System.Drawing.Size(49, 32);
            this.lbl_Tanks.TabIndex = 12;
            this.lbl_Tanks.Text = "20";
            // 
            // lbl_EnemyEmp
            // 
            this.lbl_EnemyEmp.AutoSize = true;
            this.lbl_EnemyEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnemyEmp.ForeColor = System.Drawing.Color.White;
            this.lbl_EnemyEmp.Location = new System.Drawing.Point(48, 69);
            this.lbl_EnemyEmp.Name = "lbl_EnemyEmp";
            this.lbl_EnemyEmp.Size = new System.Drawing.Size(49, 32);
            this.lbl_EnemyEmp.TabIndex = 11;
            this.lbl_EnemyEmp.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "NUMBER OF EACH OBSTACLE PLACED";
            // 
            // btn_RPGsquads
            // 
            this.btn_RPGsquads.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RPGsquads.Enabled = false;
            this.btn_RPGsquads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RPGsquads.Location = new System.Drawing.Point(154, 152);
            this.btn_RPGsquads.Name = "btn_RPGsquads";
            this.btn_RPGsquads.Size = new System.Drawing.Size(112, 93);
            this.btn_RPGsquads.TabIndex = 9;
            this.btn_RPGsquads.UseVisualStyleBackColor = false;
            this.btn_RPGsquads.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_RPGsquads_Paint_1);
            // 
            // btn_enemyemplacements
            // 
            this.btn_enemyemplacements.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enemyemplacements.Enabled = false;
            this.btn_enemyemplacements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enemyemplacements.Location = new System.Drawing.Point(154, 47);
            this.btn_enemyemplacements.Name = "btn_enemyemplacements";
            this.btn_enemyemplacements.Size = new System.Drawing.Size(112, 86);
            this.btn_enemyemplacements.TabIndex = 8;
            this.btn_enemyemplacements.UseVisualStyleBackColor = false;
            this.btn_enemyemplacements.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_enemyemplacements_Paint_1);
            // 
            // GameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnl_mainResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameResults";
            this.Load += new System.EventHandler(this.GameResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_mainResult.ResumeLayout(false);
            this.pnl_Altitude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Speed)).EndInit();
            this.pnl_Speed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Altitude)).EndInit();
            this.pnl_HealthFuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_HealthFuel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_mainResult;
        private System.Windows.Forms.Panel pnl_Altitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Speed;
        private System.Windows.Forms.Panel pnl_Speed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Altitude;
        private System.Windows.Forms.Panel pnl_HealthFuel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_HealthFuel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Aircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Tanks;
        private System.Windows.Forms.Label lbl_EnemyEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RPGsquads;
        private System.Windows.Forms.Button btn_enemyemplacements;
    }
}