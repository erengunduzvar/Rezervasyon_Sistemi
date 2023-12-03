using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public enum VehicleType
    {
        Airplane,
        Bus,
        Train
    }

    public abstract class Vehicle
    {
        string fuelName;
        public abstract double CalculateFuelCost(double fuelMultiplier, double km);
    }
}
