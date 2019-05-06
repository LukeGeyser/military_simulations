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
    public partial class SignUp : Form
    {
        DataHandler dh;
        Player player;

        public SignUp()
        {
            InitializeComponent();
            dh = new DataHandler();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = dtp_Player.Value;
                if (CheckDates(dt) == true)
                {
                    player = new Player(txt_Name.Text, txt_Username.Text, txt_Password.Text, dtp_Player.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show("Player Added Successfully", "TIME TO GAME!!");
                    dh.AddPlayer(player);
                    this.Hide();
                    PickAircraft sn = new PickAircraft();
                    sn.Show();
                }
                else if (CheckDates(dt) == false)
                {
                    MessageBox.Show("You need to be at least 16 to Play MILITARY MADNESS", "OOPS...");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private bool CheckDates(DateTime dtp)
        {
            int r = DateTime.Now.Year - dtp.Year;
            if (r >= 16)
            {
                return true;
            }
            else
                return false;
        }

    }
}
