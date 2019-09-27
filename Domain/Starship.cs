using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket_Simulator.Domain
{
    class Starship : Rocket
    {
        public Starship(string name, int fuelAmountInKilograms, int grossWeight, int thrustVacuum)
          : base(name, fuelAmountInKilograms, grossWeight, thrustVacuum)
        {
            return;
        }
    }
}
