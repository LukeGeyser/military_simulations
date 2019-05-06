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
        public PickAircraft()
        {
            InitializeComponent();
        }

        private void Btn_a394Jet_Click(object sender, EventArgs e)
        {
            this.Hide();
            MilitaryGame mg = new MilitaryGame("a394Jet");
            mg.Show();
        }

        private void Btn_cb478Jet_Click(object sender, EventArgs e)
        {
            this.Hide();
            MilitaryGame mg = new MilitaryGame("cb478Jet");
            mg.Show();
        }
    }
}
