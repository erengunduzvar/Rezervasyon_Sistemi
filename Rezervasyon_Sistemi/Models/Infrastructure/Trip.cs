using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models.Infrastructure
{
    public class Trip
    {
        //Counter ekleme eklenecek
        static int tripIdCounter = 0;
        //static
        public int tripId { get;}

        //Arac Turu
        public VehicleType VehicleType { get; set; }
        
        //Guzergah takip ettiği
        public int BigRouteId { get; set; }
        public Route Route { get 
            {
                return Data_Storage.routes.Where(r => r.BigRouteId == BigRouteId).FirstOrDefault();
            }}
        //tarih
        public DateTime date { get; set; }
        
        //fiyat
        public double Price { get; set; } = -1;

        //Gidiş Yolu mu Dönüş yolu mu

        public Trip( VehicleType vehicleType, int bigRouteId, DateTime date, double price)
        {
            tripIdCounter++;
            this.tripId = tripIdCounter;
            VehicleType = vehicleType;
            BigRouteId = bigRouteId;
            this.date = date;
            Price = price;
        }
    }
}
