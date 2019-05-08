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
    public partial class RestOfResults : Form
    {
        BindingSource bs = new BindingSource();
        public RestOfResults()
        {
            InitializeComponent();
            bs.DataSource = typeof(playerLog);
        }

        private void RestOfResults_Load(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            List<playerLog> playersLogs = dh.GetPlayerLog(MilitaryGame.playerID);
            foreach (var i in playersLogs)
            {
                bs.Add(i);
            }
            dgv_Results.DataSource = bs;
        }
    }
}
