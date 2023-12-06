using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Econ
{
    public static class StaticRevenue
    {
        public static double calculateExpectedRevenue(string startPos, string endPos, VehicleType vehicleType)
        {
            List<string> positions = new List<string>() { startPos, endPos };
            double expectedRevenue = 0;
            switch (vehicleType)
            {
                case VehicleType.Airplane:
                    //istanbul - ankara
                    if (positions.Contains("is") && positions.Contains("an"))
                        expectedRevenue = 1000;

                    //istanbul - konya
                    if (positions.Contains("is") && positions.Contains("kon"))
                        expectedRevenue = 1200;
                    break;

                case VehicleType.Bus:
                    //istanbul - kocaeli
                    if (positions.Contains("is") && positions.Contains("koc"))
                        expectedRevenue = 50;

                    //istanbul - ankara
                    if (positions.Contains("is") && positions.Contains("an"))
                        expectedRevenue = 300;

                    //istanbul - eskisehir
                    if (positions.Contains("is") && positions.Contains("es"))
                        expectedRevenue = 150;

                    //istanbul - konya
                    if (positions.Contains("is") && positions.Contains("kon"))
                        expectedRevenue = 300;

                    //kocaeli - ankara
                    if (positions.Contains("koc") && positions.Contains("an"))
                        expectedRevenue = 400;

                    //kocaeli - eskisehir
                    if (positions.Contains("koc") && positions.Contains("es"))
                        expectedRevenue = 100;

                    //kocaeli - eskisehir
                    if (positions.Contains("koc") && positions.Contains("kon"))
                        expectedRevenue = 250;

                    //eskisehir - konya
                    if (positions.Contains("es") && positions.Contains("kon"))
                        expectedRevenue = 150;

                    break;
                case VehicleType.Train:
                    //istanbul - kocaeli
                    if (positions.Contains("is") && positions.Contains("koc"))
                        expectedRevenue = 50;

                    //istanbul - bilecik
                    if (positions.Contains("is") && positions.Contains("bi"))
                        expectedRevenue = 150;

                    //istanbul - ankara
                    if (positions.Contains("is") && positions.Contains("an"))
                        expectedRevenue = 250;

                    //istanbul - eskisehir
                    if (positions.Contains("is") && positions.Contains("es"))
                        expectedRevenue = 200;

                    //istanbul - konya
                    if (positions.Contains("is") && positions.Contains("kon"))
                        expectedRevenue = 300;

                    //kocaeli - bilecik
                    if (positions.Contains("koc") && positions.Contains("bi"))
                        expectedRevenue = 50;

                    //kocaeli - ankara
                    if (positions.Contains("koc") && positions.Contains("an"))
                        expectedRevenue = 200;

                    //kocaeli - eskisehir
                    if (positions.Contains("koc") && positions.Contains("es"))
                        expectedRevenue = 100;

                    //kocaeli - konya
                    if (positions.Contains("koc") && positions.Contains("kon"))
                        expectedRevenue = 250;

                    //bilecik - ankara
                    if (positions.Contains("bi") && positions.Contains("an"))
                        expectedRevenue = 150;

                    //bilecik - eskisehir
                    if (positions.Contains("bi") && positions.Contains("es"))
                        expectedRevenue = 50;

                    //bilecik - konya
                    if (positions.Contains("bi") && positions.Contains("kon"))
                        expectedRevenue = 200;

                    //ankara - eskisehir
                    if (positions.Contains("an") && positions.Contains("en"))
                        expectedRevenue = 100;

                    //eskisehir - konya
                    if (positions.Contains("es") && positions.Contains("kon"))
                        expectedRevenue = 150;
                    break;
                default:
                    throw new Exception("Vehicle Type cannot be null");
            }
            return expectedRevenue;
        }
    }
}
