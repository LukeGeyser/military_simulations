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
    public partial class PickAircraft : Form
    {
        private int playerID;
        public static string aircraftUsed;
        public PickAircraft(int ID)
        {
            InitializeComponent();
            playerID = ID;
        }

        private void Btn_a394Jet_Click(object sender, EventArgs e)
        {
            this.Hide();
            MilitaryGame mg = new MilitaryGame("a394Jet", playerID);
            aircraftUsed = "a394Jet";
            mg.Show();
        }

        private void Btn_cb478Jet_Click(object sender, EventArgs e)
        {
            this.Hide();
            MilitaryGame mg = new MilitaryGame("cb478Jet", playerID);
            aircraftUsed = "cb478Jet";
            mg.Show();
        }
    }
}
