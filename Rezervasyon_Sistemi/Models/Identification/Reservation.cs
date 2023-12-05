using Rezervasyon_Sistemi.Interfaces;
using Rezervasyon_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Identification
{
    public class Reservation
    {
        public static int ReservationIdCounter = 0;
        public int ReservationId { get;}
        public Passenger passenger { get; set; }
        public int seatNumber { get; set; }
        public int transportId { get; set; }

        public Transport transport
        {
            get => Data_Storage.openTransports.FirstOrDefault(t => t.transportId == transportId);
        }

        public Reservation(Passenger passenger, int seatNumber, int transportId)
        {
            this.ReservationId = ++ReservationIdCounter;
            this.passenger = passenger;
            this.seatNumber = seatNumber;
            this.transportId = transportId;
        }
    }
}
