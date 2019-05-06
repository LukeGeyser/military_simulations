using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace military_simulations
{
    class a394Jet
    {
        private const double fuelAmount = 100;
        private double currentSpeed = 0;
        private double currentAltitude = 0;
        private double maxSpeedAchieved;
        private double maxAltitudeAchieved;
        private const double maxSpeed = 858;
        private const double maxAltitude = 38000;
        private const double accelerationSpeed = 33;
        private List<InventoryItems> inventoryItems;

        public static double FuelAmount => fuelAmount;

        public double Currentspeed { get => currentSpeed; set => currentSpeed = value; }

        public static double MaxSpeed => maxSpeed;

        public static double MaxAltitude => maxAltitude;

        internal List<InventoryItems> InventoryItems { get => inventoryItems; set => inventoryItems = value; }
        public double CurrentAltitude { get => currentAltitude; set => currentAltitude = value; }
        public double MaxSpeedAchieved { get => maxSpeedAchieved; set => maxSpeedAchieved = value; }
        public double MaxAltitudeAchieved { get => maxAltitudeAchieved; set => maxAltitudeAchieved = value; }

        public static double AccelerationSpeed => accelerationSpeed;
    }
}
