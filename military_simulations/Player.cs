using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace military_simulations
{
    class Player
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private string dob;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Dob { get { return dob; } set { dob = value; } }

        public Player() { }

        public Player(int id, string name, string username, string password, string dob)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            this.dob = dob;
        }

        public Player(string name, string username, string password, string dob)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.dob = dob;
        }

    }
}
