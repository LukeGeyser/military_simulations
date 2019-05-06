using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace military_simulations
{
    class DataHandler
    {
        OleDbConnection conn;
        OleDbDataReader dr = null;

        public DataHandler()
        {
            string connString = "Data Source=DESKTOP-DO11T9D\\GEYSERSQL;Initial Catalog=MilitaryGame;" +
            "Integrated Security=SSPI;Provider=sqloledb;";
            conn = new OleDbConnection(connString);
        }

        public Player GetPLayerLogin(string p1)
        {
            Player player = null;

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblPlayers WHERE username=" + "'" + p1 + "'", conn);

            dr = null;
            dr = cmd.ExecuteReader();
            dr.Read();

            try
            {
                player = new Player(int.Parse(dr["id"].ToString()), dr["Name"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["DOB"].ToString());
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure you fill all Inputs");
            }

            cmd.Dispose();
            conn.Close();

            return player;
        }

        public void AddPlayer(Player player)
        {
            conn.Open();
            string command = "INSERT INTO tblPlayers (Name, username, password, DOB) VALUES (" +
                "'" + player.Name + "'," +
                "'" + player.Username + "'," +
                "'" + player.Password + "'," +
                "'" + player.Dob + "')";
            OleDbCommand cmd = new OleDbCommand(command, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

    }
}
