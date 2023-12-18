using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Services
{
    public static class ServiceClass
    {
        public static string cityShortcutToFullName(string shrtcut)
        {
            shrtcut = shrtcut.ToLower();
            switch (shrtcut)
            {
                case "is":
                    shrtcut = "Istanbul";
                    break;
                case "koc":
                    shrtcut = "Kocaeli";
                    break;
                case "bi":
                    shrtcut = "Bilecik";
                    break;
                case "es":
                    shrtcut = "Eskişehir";
                    break;
                case "an":
                    shrtcut = "Ankara";
                    break;
                case "kon":
                    shrtcut = "Konya";
                    break;
            }
            return shrtcut;
        }

        public static string cityToFullNameToShortcut(string fullname)
        {
            fullname = fullname.ToLower();
            switch (fullname)
            {
                case "istanbul":
                    fullname = "is";
                    break;
                case "ıstanbul":
                    fullname = "is";
                    break;
                case "kocaeli":
                    fullname = "koc";
                    break;
                case "bilecik":
                    fullname = "bi";
                    break;
                case "eskişehir":
                    fullname = "es";
                    break;
                case "ankara":
                    fullname = "an";
                    break;
                case "konya":
                    fullname = "kon";
                    break;
            }
            return fullname;
        }

        public static async void fillRandomSeats()
        {

            try
            {
                Transport transport = Data_Storage.openTransports[new Random().Next(Data_Storage.openTransports.Count)];
                string startPos, endPos;
                while (true)
                {
                    var cities = transport.route.cities;
                    startPos = cities.ToList()[new Random().Next(cities.Count)];
                    endPos = cities.ToList()[new Random().Next(cities.Count)];

                    if (startPos != endPos)
                        break;
                }
                var seats = transport.AnyTransportValid(startPos, endPos, transport.trip.date);
                var seatNo = seats[new Random().Next(seats.Count)];
                if (seats != null)
                {
                    transport.reserveSeat(new Passenger(startPos,endPos,transport.transportId,"temp","tempSurname","12312312322",new DateTime(2001,1,1))
                        ,startPos
                        ,endPos
                        ,seatNo);
                }
            }
            catch (Exception)
            {
            }




            //choose a random route 
        }
    }
}
