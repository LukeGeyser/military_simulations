using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace military_simulations
{
    public partial class SignIn : Form
    {
        DataHandler dh;
        Player player;
        public static SoundPlayer atari;
        public static int playerID;
        public SignIn()
        {
            InitializeComponent();
            dh = new DataHandler();
            atari = new SoundPlayer("audio\\atari.wav");
            atari.Play();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            dh = new DataHandler();
            player = dh.GetPLayerLogin(txt_Username.Text);
            if (player == null)
            {
                MessageBox.Show("NOT FOUND");
            }
            else if (player != null)
            {
                if (txt_Username.Text != player.Username || txt_Password.Text != player.Password)
                {
                    txt_Username.Clear();
                    txt_Password.Clear();
                    MessageBox.Show("Username and Passwords do not match!", "Error");
                }
                else if (txt_Username.Text == player.Username || txt_Password.Text == player.Password)
                {
                    MessageBox.Show("Successful Sign In", "Successful");
                    this.Hide();
                    Player p = dh.GetPLayerLogin(txt_Username.Text);
                    playerID = p.Id;
                    PickAircraft mg = new PickAircraft(p.Id);
                    mg.Show();
                }
            }
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
