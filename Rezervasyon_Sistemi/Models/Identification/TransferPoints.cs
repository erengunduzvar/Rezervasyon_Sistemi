using Rezervasyon_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Identification
{
    public class TransferPoints
    {
        public string startPos { get; set; }
        public string endPos { get; set; }
        public List<Reservation> reservedChairs { get; set; }

        public TransferPoints(string startPos, string endPos, List<Reservation> reservedChairs)
        {
            this.startPos = startPos;
            this.endPos = endPos;
            this.reservedChairs = reservedChairs;
        }
    }    
}
