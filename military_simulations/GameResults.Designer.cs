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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_HealthFuel = new System.Windows.Forms.Panel();
            this.chrt_HealthFuel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Speed = new System.Windows.Forms.Panel();
            this.chrt_Altitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Altitude = new System.Windows.Forms.Panel();
            this.chrt_Speed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.pnl_HealthFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_HealthFuel)).BeginInit();
            this.pnl_Speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Altitude)).BeginInit();
            this.pnl_Altitude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Location = new System.Drawing.Point(972, 648);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Location = new System.Drawing.Point(28, 22);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(144, 59);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // pnl_HealthFuel
            // 
            this.pnl_HealthFuel.Controls.Add(this.chrt_HealthFuel);
            this.pnl_HealthFuel.Location = new System.Drawing.Point(12, 12);
            this.pnl_HealthFuel.Name = "pnl_HealthFuel";
            this.pnl_HealthFuel.Size = new System.Drawing.Size(846, 356);
            this.pnl_HealthFuel.TabIndex = 1;
            // 
            // chrt_HealthFuel
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_HealthFuel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_HealthFuel.Legends.Add(legend1);
            this.chrt_HealthFuel.Location = new System.Drawing.Point(3, 3);
            this.chrt_HealthFuel.Name = "chrt_HealthFuel";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrt_HealthFuel.Series.Add(series1);
            this.chrt_HealthFuel.Size = new System.Drawing.Size(840, 350);
            this.chrt_HealthFuel.TabIndex = 0;
            this.chrt_HealthFuel.Text = "chart1";
            // 
            // pnl_Speed
            // 
            this.pnl_Speed.Controls.Add(this.chrt_Altitude);
            this.pnl_Speed.Location = new System.Drawing.Point(12, 407);
            this.pnl_Speed.Name = "pnl_Speed";
            this.pnl_Speed.Size = new System.Drawing.Size(404, 341);
            this.pnl_Speed.TabIndex = 2;
            // 
            // chrt_Altitude
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_Altitude.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_Altitude.Legends.Add(legend2);
            this.chrt_Altitude.Location = new System.Drawing.Point(3, 3);
            this.chrt_Altitude.Name = "chrt_Altitude";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrt_Altitude.Series.Add(series2);
            this.chrt_Altitude.Size = new System.Drawing.Size(398, 335);
            this.chrt_Altitude.TabIndex = 0;
            this.chrt_Altitude.Text = "chart2";
            // 
            // pnl_Altitude
            // 
            this.pnl_Altitude.Controls.Add(this.chrt_Speed);
            this.pnl_Altitude.Location = new System.Drawing.Point(454, 407);
            this.pnl_Altitude.Name = "pnl_Altitude";
            this.pnl_Altitude.Size = new System.Drawing.Size(404, 341);
            this.pnl_Altitude.TabIndex = 3;
            // 
            // chrt_Speed
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt_Speed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrt_Speed.Legends.Add(legend3);
            this.chrt_Speed.Location = new System.Drawing.Point(3, 3);
            this.chrt_Speed.Name = "chrt_Speed";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chrt_Speed.Series.Add(series3);
            this.chrt_Speed.Size = new System.Drawing.Size(398, 335);
            this.chrt_Speed.TabIndex = 0;
            this.chrt_Speed.Text = "chart3";
            // 
            // GameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnl_Altitude);
            this.Controls.Add(this.pnl_Speed);
            this.Controls.Add(this.pnl_HealthFuel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GameResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameResults";
            this.Load += new System.EventHandler(this.GameResults_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_HealthFuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_HealthFuel)).EndInit();
            this.pnl_Speed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Altitude)).EndInit();
            this.pnl_Altitude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_HealthFuel;
        private System.Windows.Forms.Panel pnl_Speed;
        private System.Windows.Forms.Panel pnl_Altitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_HealthFuel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Altitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Speed;
    }
}