using Rezervasyon_Sistemi.Interfaces;
using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Identification
{
    public class Transport : IReservable
    {
        public static int transportIdCounter = 0;
        public int transportId { get;}
        public int tripId { get; set; }

        public int seatCount { get; set; } //30 max koltuk sayısıdır

        public Route route { get {
                return Data_Storage.routes.FirstOrDefault(r => r.BigRouteId  == this.trip.BigRouteId);
            } }

        public Trip trip { get {
                return Data_Storage.openTrips.FirstOrDefault(t => t.tripId == tripId);
            } }

        public LinkedList<TransferPoints> transferPoints { get; set; } = new LinkedList<TransferPoints>();


        public Transport(int tripId, int seatCount)
        {
            if (seatCount > 30)
                throw new ArgumentOutOfRangeException(paramName: "Transport.seatCount", message: "Koltuk sayısı 30 dan fazla olamaz");

            transportIdCounter++;
            transportId = transportIdCounter;
            this.tripId = tripId;
            this.seatCount = seatCount;

            var tripCities = route.cities.First;
            while(tripCities.Next != null)
            {
                transferPoints.AddLast(new TransferPoints(
                    startPos:tripCities.Value,
                    endPos:tripCities.Next.Value,
                    reservedChairs: new List<Reservation>(new Reservation[seatCount])
                    ));
                tripCities = tripCities.Next;
            }
            while (tripCities.Previous != null)
            {
                transferPoints.AddLast(new TransferPoints(
                    startPos: tripCities.Value,
                    endPos: tripCities.Previous.Value,
                    reservedChairs: new List<Reservation>(new Reservation[seatCount])
                    ));
                tripCities = tripCities.Previous;
            }


        }

        List<LinkedListNode<TransferPoints>> findFirstAndLastNode(string startPos, string endPos)
        {
            //Transfer pointlerde gezerek yolculuk sırasında geçilecek tüm transfer pointlere bak eğer start pos end postan sonra ise demek ki donustur ikisini de null yapıp devam et
            var travablePoints = transferPoints.First;
            LinkedListNode<TransferPoints> firstTransferPoint = null, lastTransferPoint = null;
            int count = 0;
            while (travablePoints != null)
            {
                if (travablePoints.Value.startPos == startPos)
                {
                    firstTransferPoint = travablePoints;
                }

                if (travablePoints.Value.endPos == endPos)
                {
                    if (firstTransferPoint != null)
                    {
                        lastTransferPoint = travablePoints;
                    }
                }
                if (firstTransferPoint != null && lastTransferPoint != null)
                {
                    break;
                }

                count++;
                travablePoints = travablePoints.Next;
            }

            //rota bulunamadı !
            if (firstTransferPoint == null || lastTransferPoint == null)
                return null;
            List<LinkedListNode<TransferPoints>> results = new List<LinkedListNode<TransferPoints>>()
            {
                firstTransferPoint, lastTransferPoint
            };
            return results;
        }


        //Eğer aralıkta müsait bir koltuk varsa döndürür
        public List<int> AnyTransportValid(string startPos, string endPos, DateTime dateTime)
        {
            //bug1
            var results = this.findFirstAndLastNode(startPos, endPos);
            if(results == null)
                return null;

            var firstTransferPoint = results[0];
            var lastTransferPoint = results[1];

            List<Reservation> usableSeats = new List<Reservation>(new Reservation[seatCount]);

            ///AAAA
            ///
            do
            {
                {
                    for (int i = 0; i < firstTransferPoint.Value.reservedChairs.Count; i++)
                    {
                        if (firstTransferPoint.Value.reservedChairs[i] != null && firstTransferPoint.Value.reservedChairs[i].transport.trip.date.CompareTo(dateTime) == 0)
                        {
                            usableSeats[i] = firstTransferPoint.Value.reservedChairs[i];
                        }
                    }
                    if(firstTransferPoint.Next != null)
                    firstTransferPoint = firstTransferPoint.Next;
                }
            } while (firstTransferPoint.Previous != lastTransferPoint && firstTransferPoint.Next != null);


            List<int> usableSeatsIndexes = new List<int>();

            for (int i = 0; i < usableSeats.Count; i++)
                if (usableSeats[i] == null)
                    usableSeatsIndexes.Add(i);

            return usableSeatsIndexes;
        }



        public bool reserveSeat(Passenger passenger,string startPos,string endPos,int seatNumber)
        {
            var results = this.findFirstAndLastNode(startPos, endPos);
            if (results == null)
                return false;

            var firstTransferPoint = results[0];
            var lastTransferPoint = results[1];


            while (firstTransferPoint.Previous != lastTransferPoint && firstTransferPoint.Next != null)
            {
                if (firstTransferPoint.Value.endPos == "koc")
                {
                    int xxa = 54;
                }


                firstTransferPoint.Value.reservedChairs[seatNumber] = new Reservation(passenger, seatNumber, transportId);
                if (firstTransferPoint.Next != null)
                {
                    firstTransferPoint.Next.Value.reservedChairs[seatNumber] = new Reservation(passenger, seatNumber, transportId);
                }
                firstTransferPoint = firstTransferPoint.Next;
            }

            return true;
        }

        public bool cancelSeat(Reservation reservation) //add reservation
        {
            throw new NotImplementedException();
        }
    }
}
