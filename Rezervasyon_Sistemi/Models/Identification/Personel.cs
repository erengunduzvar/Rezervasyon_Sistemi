using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Identification
{
    class Personel : Person
    {
        public string Company { get; set; }
        public int tripId { get; set; }

        public Trip trip{ get {
                return Data_Storage.openTrips.FirstOrDefault(t => t.tripId == tripId);
            } }
    }
}
