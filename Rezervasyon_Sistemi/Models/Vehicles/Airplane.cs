using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Vehicles
{
    internal class Airplane : Vehicle
    {
        public override double CalculateFuelCost(double fuelMultiplier, double km) =>  fuelMultiplier * km;
    }
}
