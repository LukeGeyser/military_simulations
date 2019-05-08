using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace military_simulations
{
    class playerLog
    {
        private int id;
        private int playerId;
        private string health;
        private string fuel;
        private string maxSpeed;
        private string maxAltitude;
        private string aircraftUsed;

        public int Id { get { return id; }  set { id = value; } }
        public int PlayerId { get { return playerId; } set { playerId = value; } }
        public string Health { get { return health; } set { health = value; } }
        public string Fuel { get { return fuel; } set { fuel = value; } }
        public string MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
        public string MaxAltitude { get { return maxAltitude; } set { maxAltitude = value; } }
        public string AircraftUsed { get { return aircraftUsed; } set { aircraftUsed = value; } }

        public playerLog(int id, int playerId, string health, string fuel, string maxSpeed,
            string maxAltitude, string aircraftUsed)
        {
            this.id = id;
            this.playerId = playerId;
            this.health = health;
            this.fuel = fuel;
            this.maxSpeed = maxSpeed;
            this.maxAltitude = maxAltitude;
            this.aircraftUsed = aircraftUsed;
        }

        public playerLog(int playerId, string health, string fuel, string maxSpeed,
            string maxAltitude, string aircraftUsed)
        {
            this.playerId = playerId;
            this.health = health;
            this.fuel = fuel;
            this.maxSpeed = maxSpeed;
            this.maxAltitude = maxAltitude;
            this.aircraftUsed = aircraftUsed;
        }

    }
}
