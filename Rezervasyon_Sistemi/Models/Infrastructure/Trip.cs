using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Infrastructure
{
    public class Trip
    {
        public int tripId { get; set; }

        //Arac Turu
        public VehicleType VehicleType { get; set; }
        
        //Guzergah takip ettiği
        public int BigRouteId { get; set; }
        public Route Route { get 
            {
                return Data_Storage.routes.Where(r => r.BigRouteId == BigRouteId).FirstOrDefault();
            }}
        //tarih
        public DateTime date{ get; set; }
        
        //fiyat
        public double Price { get; set; }
        
        //Gidiş Yolu mu Dönüş yolu mu
        public bool IsStraight { get; set; }



    }
}
