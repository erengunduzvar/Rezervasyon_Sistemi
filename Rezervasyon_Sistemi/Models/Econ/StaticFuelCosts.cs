using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Econ
{
    public class StaticFuelCosts
    {
        public VehicleType vehicleType{ get; set; }
        public double fuelMultiplier { get; set; }

        public string CompanyName{ get; set; }

        public StaticFuelCosts(VehicleType vehicleType, double fuelMultiplier, string companyName)
        {
            this.vehicleType = vehicleType;
            this.fuelMultiplier = fuelMultiplier;
            CompanyName = companyName;
        }
    }
}
