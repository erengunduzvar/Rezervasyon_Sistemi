using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models.Econ;
using Rezervasyon_Sistemi.Models.Infrastructure;
using Rezervasyon_Sistemi.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public static class Data_Storage
    {
        public static Admin admin = new Admin(_username: "admin", _password: "123123Er");
        public static List<Company> companies = new List<Company>()
        {
            new Company(username:"A",password:"A1") //0
            ,new Company(username:"B",password:"B1") //1
            ,new Company(username:"C",password:"C1") //2
            ,new Company(username:"D",password:"D1") //3
            ,new Company(username:"F",password:"F1") //4
        };

        public static List<Route> routes = new List<Route>()
        {
 
            new Route(1,"is","an",375,new LinkedList<string>(new string[] { "is", "koc", "bi", "es", "an" })),
            new Route(2,"is","kon",450,new LinkedList<string>(new string[] { "is","koc","bi","es","kon" })),
            new Route(3,"is","an",500,new LinkedList<string>(new string[] {"is","koc","an"})),
            new Route(4,"is","kon",600,new LinkedList<string>(new string[] {"is","koc","es","kon"})),
            new Route(5,"is","kon",300,new LinkedList<string>(new string[] {"is","kon"})),
            new Route(6,"is","an",250,new LinkedList<string>(new string[] {"is","an"})),

        };
        public static List<StaticFuelCosts> fuelCosts = new List<StaticFuelCosts>() {
            new StaticFuelCosts(VehicleType.Bus,10,"A"),
            new StaticFuelCosts(VehicleType.Bus,5,"B"),
            new StaticFuelCosts(VehicleType.Bus,6,"C"),
            new StaticFuelCosts(VehicleType.Train,3,"D"),
            new StaticFuelCosts(VehicleType.Airplane,20,"F"),
            new StaticFuelCosts(VehicleType.Airplane,25,"C")
        };
        public static List<StaticPersonalExpenses> personalExpenses = new List<StaticPersonalExpenses>()
        {
            new StaticPersonalExpenses(companyName:"A",personalPrice:7000,vehicleType:VehicleType.Bus),
            new StaticPersonalExpenses(companyName:"B",personalPrice:4500,vehicleType:VehicleType.Bus),
            new StaticPersonalExpenses(companyName:"C",personalPrice:6000,vehicleType:VehicleType.Bus),
            new StaticPersonalExpenses(companyName:"D",personalPrice:3000,vehicleType:VehicleType.Train),
            new StaticPersonalExpenses(companyName:"F",personalPrice:11500,vehicleType:VehicleType.Airplane),
            new StaticPersonalExpenses(companyName:"C",personalPrice:16000,vehicleType:VehicleType.Airplane),
        };
        

        //expense hesaplama !!



        // -> Açıldığında hali hazırda açık olacak tripler

        public static List<Trip> openTrips = new List<Trip>()
        {
            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("A",3), 0),
            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("A",3), 0),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("B",3), 1),
            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("B",4), 1),

            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",4), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",5), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",5), 2),

            new Trip(VehicleType.Train,1,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",1), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",2), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",2), 3),

            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("F",6), 4),
            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("F",6), 4),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("A",3), 0),
            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("A",3), 0),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("B",3), 1),
            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("B",4), 1),

            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("C",4), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("C",5), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("C",5), 2),

            new Trip(VehicleType.Train,1,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("D",1), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("D",2), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("D",2), 3),

            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("F",6), 4),
            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:5),Expense.calculateTripCost("F",6), 4),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("A",3), 0),
            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("A",3), 0),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("B",3), 1),
            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("B",4), 1),

            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("C",4), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("C",5), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("C",5), 2),

            new Trip(VehicleType.Train,1,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("D",1), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("D",2), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("D",2), 3),

            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("F",6), 4),
            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:6),Expense.calculateTripCost("F",6), 4),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("A",3), 0),
            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("A",3), 0),

            new Trip(VehicleType.Bus,3,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("B",3), 1),
            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("B",4), 1),

            new Trip(VehicleType.Bus,4,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("C",4), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("C",5), 2),
            new Trip(VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("C",5), 2),

            new Trip(VehicleType.Train,1,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("D",1), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("D",2), 3),
            new Trip(VehicleType.Train,2,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("D",2), 3),

            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("F",6), 4),
            new Trip(VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:7),Expense.calculateTripCost("F",6), 4),







        };

        public static List<Transport> openTransports = new List<Transport>()
        {
            new Transport(Data_Storage.openTrips[0].tripId,20),
            new Transport(Data_Storage.openTrips[1].tripId,15),
            new Transport(Data_Storage.openTrips[2].tripId,15),
            new Transport(Data_Storage.openTrips[3].tripId,20),
            new Transport(Data_Storage.openTrips[4].tripId,20),
            new Transport(Data_Storage.openTrips[5].tripId,30),
            new Transport(Data_Storage.openTrips[6].tripId,30),
            new Transport(Data_Storage.openTrips[7].tripId,25),
            new Transport(Data_Storage.openTrips[8].tripId,25),
            new Transport(Data_Storage.openTrips[9].tripId,25),
            new Transport(Data_Storage.openTrips[10].tripId,30),
            new Transport(Data_Storage.openTrips[11].tripId,30),

            new Transport(Data_Storage.openTrips[12].tripId,20),
            new Transport(Data_Storage.openTrips[13].tripId,15),
            new Transport(Data_Storage.openTrips[14].tripId,15),
            new Transport(Data_Storage.openTrips[15].tripId,20),
            new Transport(Data_Storage.openTrips[16].tripId,20),
            new Transport(Data_Storage.openTrips[17].tripId,30),
            new Transport(Data_Storage.openTrips[18].tripId,30),
            new Transport(Data_Storage.openTrips[19].tripId,25),
            new Transport(Data_Storage.openTrips[20].tripId,25),
            new Transport(Data_Storage.openTrips[21].tripId,25),
            new Transport(Data_Storage.openTrips[22].tripId,30),
            new Transport(Data_Storage.openTrips[23].tripId,30),

            new Transport(Data_Storage.openTrips[24].tripId,20),
            new Transport(Data_Storage.openTrips[25].tripId,15),
            new Transport(Data_Storage.openTrips[26].tripId,15),
            new Transport(Data_Storage.openTrips[27].tripId,20),
            new Transport(Data_Storage.openTrips[28].tripId,20),
            new Transport(Data_Storage.openTrips[29].tripId,30),
            new Transport(Data_Storage.openTrips[30].tripId,30),
            new Transport(Data_Storage.openTrips[31].tripId,25),
            new Transport(Data_Storage.openTrips[32].tripId,25),
            new Transport(Data_Storage.openTrips[33].tripId,25),
            new Transport(Data_Storage.openTrips[34].tripId,30),
            new Transport(Data_Storage.openTrips[35].tripId,30),

            new Transport(Data_Storage.openTrips[36].tripId,20),
            new Transport(Data_Storage.openTrips[37].tripId,15),
            new Transport(Data_Storage.openTrips[38].tripId,15),
            new Transport(Data_Storage.openTrips[39].tripId,20),
            new Transport(Data_Storage.openTrips[40].tripId,20),
            new Transport(Data_Storage.openTrips[41].tripId,30),
            new Transport(Data_Storage.openTrips[42].tripId,30),
            new Transport(Data_Storage.openTrips[43].tripId,25),
            new Transport(Data_Storage.openTrips[44].tripId,25),
            new Transport(Data_Storage.openTrips[45].tripId,25),
            new Transport(Data_Storage.openTrips[46].tripId,30),
            new Transport(Data_Storage.openTrips[47].tripId,30),


        };

        public static List<Reservation> openReservations = new List<Reservation>();

        //doluluk kontrolü

        //bossa ana ekranda


        

     }       
}
