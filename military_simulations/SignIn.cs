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
    public partial class SignIn : Form
    {
        DataHandler dh;
        Player player;

        public SignIn()
        {
            InitializeComponent();
            dh = new DataHandler();
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
                    MessageBox.Show("Successful Signin", "Successful");
                    this.Hide();
                    MilitaryGame mg = new MilitaryGame();
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
