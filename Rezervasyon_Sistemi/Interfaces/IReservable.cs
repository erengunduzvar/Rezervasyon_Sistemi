using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Interfaces
{
    public interface IReservable
    {
        bool isReserved(string seat_data);
        bool reserveSeat(string seat_data);
        bool cancelSeat(string seat_data);
    }
}
