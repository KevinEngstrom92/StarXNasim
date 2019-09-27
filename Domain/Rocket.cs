using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket_Simulator.Domain
{
    abstract class Rocket
    {
        public string rocket;
        internal static object name;

        public string Name { get; set; }
        public int FuelAmountInKilograms { get; set; }
        public int GrossWeight { get; set; }
        public int ThrustVacuum { get; set; }

        public Rocket(string name, int fuelAmountInKilograms, int grossWeight, int thrustVacuum)
        {
            this.Name = name;
            this.FuelAmountInKilograms = fuelAmountInKilograms;
            this.GrossWeight = grossWeight;
            this.ThrustVacuum = thrustVacuum;
        }
    }
}
