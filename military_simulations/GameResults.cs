using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulations
{
    public partial class GameResults : Form
    {
        List<double> allRecordedSpeeds;
        List<double> allRecordedAltitudes;
        List<double> recordedHealth;
        List<double> recordedFuel;
        public GameResults(List<double> speeds, List<double> altitudes, List<double> health, List<double> fuel)
        {
            InitializeComponent();
            this.allRecordedSpeeds = speeds;
            this.allRecordedAltitudes = altitudes;
            this.recordedHealth = health;
            this.recordedFuel = fuel;
        }

        private void GameResults_Load(object sender, EventArgs e)
        {
            HealthFuelChartLoad();
            AltitudeChartLoad();
            SpeedChartLoad();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Show();
            }
        }

        private void HealthFuelChartLoad()
        {
            var chart = chrt_HealthFuel.ChartAreas[0];

            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 120;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 10;

            chrt_HealthFuel.Series[0].IsVisibleInLegend = false;

            chrt_HealthFuel.Series.Add("Health");
            chrt_HealthFuel.Series["Health"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_HealthFuel.Series["Health"].Color = Color.Green;

            chrt_HealthFuel.Series.Add("Fuel");
            chrt_HealthFuel.Series["Fuel"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_HealthFuel.Series["Fuel"].Color = Color.Blue;
            if (recordedHealth.Count == 0)
            {
                for (int i = 0; i < recordedFuel.Count - 1; i++)
                {
                    chrt_HealthFuel.Series["Health"].Points.AddXY(i, 100);
                }
            }
            else if (recordedHealth.Count > 0)
            {
                for (int i = 0; i < recordedHealth.Count - 1; i++)
                {
                    chrt_HealthFuel.Series["Health"].Points.AddXY(i, recordedHealth[i]);
                }
            }

            for (int i = 0; i < recordedFuel.Count - 1; i++)
            {
                chrt_HealthFuel.Series["Fuel"].Points.AddXY(i, recordedFuel[i]);
            }

        }

        private void AltitudeChartLoad()
        {
            var chart = chrt_Altitude.ChartAreas[0];

            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 1000;

            chrt_Altitude.Series[0].IsVisibleInLegend = false;

            chrt_Altitude.Series.Add("Altitude");
            chrt_Altitude.Series["Altitude"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_Altitude.Series["Altitude"].Color = Color.Orange;

            for (int i = 0; i < allRecordedAltitudes.Count - 1; i++)
            {
                chrt_Altitude.Series["Altitude"].Points.AddXY(i, allRecordedAltitudes[i]);
            }
        }

        private void SpeedChartLoad()
        {
            var chart = chrt_Speed.ChartAreas[0];

            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 50;

            chrt_Speed.Series[0].IsVisibleInLegend = false;

            chrt_Speed.Series.Add("Speed");
            chrt_Speed.Series["Speed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrt_Speed.Series["Speed"].Color = Color.Purple;

            for (int i = 0; i < allRecordedSpeeds.Count - 1; i++)
            {
                chrt_Speed.Series["Speed"].Points.AddXY(i, allRecordedSpeeds[i]);
            }

        }


    }
}
