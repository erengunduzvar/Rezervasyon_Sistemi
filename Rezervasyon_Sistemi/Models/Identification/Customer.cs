using Rezervasyon_Sistemi.Forms;
using Rezervasyon_Sistemi.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Identification
{
    public class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string tcNo { get; set; }
        public DateTime date { get; set; }

        public void buyTicket(Transport transport,string startPos,string endPos,int seatNum)
        {
            transport.reserveSeat(new Passenger(startPos, endPos, transport.transportId, name, surname, tcNo, date), startPos, endPos, seatNum);
        }

        public Customer(string name, string surname, string tcNo, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.tcNo = tcNo;
            this.date = date;
        }
    }
}
