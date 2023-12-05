using Rezervasyon_Sistemi.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Interfaces
{
    public interface IReservable
    {
        List<int> AnyTransportValid(string startPos, string endPos, DateTime dateTime);
        bool reserveSeat(Passenger passenger, string startPos, string endPos, int seatNumber);
        bool cancelSeat(Reservation reservation);
    }
}
