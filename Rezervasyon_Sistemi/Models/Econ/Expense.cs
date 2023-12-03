using Rezervasyon_Sistemi.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Econ
{
    public static class Expense
    {
        public static double calculateTripCost(string CompanyName, int routeId)
        {
            double fuelCost = Expense.calculateFuelTripPrice(CompanyName, routeId);
            double personelExpense = Expense.calculatePersonelExpenses(CompanyName, routeId);

            return 2*(fuelCost + personelExpense);
        }

        static double calculatePersonelExpenses(string CompanyName,int routeId)
        {
            double totalPersonelExpense = 0;

            switch (routeId)
            {
                //Demiryolu
                case 1:
                case 2:
                    totalPersonelExpense = Data_Storage.personalExpenses.First(e => e.vehicleType == VehicleType.Train && e.CompanyName == CompanyName).PersonalPrice;
                    break;

                //Karayolu
                case 3:
                case 4:
                    totalPersonelExpense = Data_Storage.personalExpenses.First(e => e.vehicleType == VehicleType.Bus && e.CompanyName == CompanyName).PersonalPrice;
                    break;

                //Havayolu
                case 5:
                case 6:
                    totalPersonelExpense = Data_Storage.personalExpenses.First(e => e.vehicleType == VehicleType.Airplane && e.CompanyName == CompanyName).PersonalPrice;
                    break;
            }

            return totalPersonelExpense;

        }

        static double calculateFuelTripPrice(string CompanyName,int routeId)
        {
            double totalFuelPrice = 0;
            //fuel cost - personal cost
            switch (routeId) {
                //Demiryolu
                case 1:
                case 2:
                        totalFuelPrice = new Train().CalculateFuelCost(
                            fuelMultiplier: Data_Storage.fuelCosts.First(f => f.CompanyName == CompanyName && f.vehicleType == VehicleType.Train).fuelMultiplier,
                            km: Data_Storage.routes.First(r => r.BigRouteId == routeId).distance);
                    break;

                //Karayolu
                case 3:
                case 4:
                    totalFuelPrice = new Bus().CalculateFuelCost(
                            fuelMultiplier: Data_Storage.fuelCosts.First(f => f.CompanyName == CompanyName && f.vehicleType == VehicleType.Bus).fuelMultiplier,
                            km: Data_Storage.routes.First(r => r.BigRouteId == routeId).distance);
                    break;

                //Havayolu
                case 5:
                case 6:
                    totalFuelPrice = new Airplane().CalculateFuelCost(
                            fuelMultiplier: Data_Storage.fuelCosts.First(f => f.CompanyName == CompanyName && f.vehicleType == VehicleType.Airplane).fuelMultiplier,
                            km: Data_Storage.routes.First(r => r.BigRouteId == routeId).distance);
                    break;
            }

            return totalFuelPrice;

        }
    }
}
