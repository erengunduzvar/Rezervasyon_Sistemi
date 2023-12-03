using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Econ
{
    public class StaticPersonalExpenses
    {
        public string CompanyName { get; set; }
        public double PersonalPrice { get; set; }
        public VehicleType vehicleType { get; set; }

        public StaticPersonalExpenses(string companyName, double personalPrice, VehicleType vehicleType)
        {
            CompanyName = companyName;
            PersonalPrice = personalPrice;
            this.vehicleType = vehicleType;
        }
    }
}
