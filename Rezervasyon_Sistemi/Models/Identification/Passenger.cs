using Rezervasyon_Sistemi.Models.Infrastructure;
using Rezervasyon_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Identification
{
    public class Passenger : Person
    {
        static int PassengerIdCounter = 0;
        int PassengerId { get;}
        string startPos { get; set; }
        string endPos { get; set; }
        int transportId { get; set; }
        public Transport transport
        {
            get => Data_Storage.openTransports.FirstOrDefault(t => t.transportId == transportId);
        }

        public Passenger(string startPos, string endPos, int transportId, string ad,string soyad)
        {
            PassengerIdCounter++;
            PassengerId = PassengerIdCounter;
            this.startPos = startPos;
            this.endPos = endPos;
            this.transportId = transportId;
            this.Ad = ad;
            this.Soyad = soyad;
        }
    }
}
