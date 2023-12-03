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
            new Company(username:"A",password:"A1")
            ,new Company(username:"B",password:"B1")
            ,new Company(username:"C",password:"C1")
        };

        public static List<Route> routes = new List<Route>()
        {
            //1. sefer
            new Route(1,"is","an",375,new List<string>()
            {
                "is","koc","bi","es","an"
            }),

            new Route(2,"is","kon",450,new List<string>()
            {
                "is","koc","bi","es","kon"
            }),
            new Route(3,"is","an",500,new List<string>()
            {
                "is","koc","an"
            }),

            new Route(4,"is","kon",600,new List<string>()
            {
                "is","koc","es","kon"
            }),
            new Route(5,"is","kon",300,new List<string>()
            {
                "is","kon"
            }),

            new Route(6,"is","an",250,new List<string>()
            {
                "is","an"
            })

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
        
        public static int lastNameNum = 6;

        //expense hesaplama !!



        // -> Açıldığında hali hazırda açık olacak tripler

        public static List<Trip> openTrips = new List<Trip>()
        {
            new Trip(1,VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("A",3)),
            new Trip(2,VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("A",3)),

            new Trip(3,VehicleType.Bus,3,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("B",3)),
            new Trip(4,VehicleType.Bus,4,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("B",4)),

            new Trip(5,VehicleType.Bus,4,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",4)),
            new Trip(6,VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",5)),
            new Trip(7,VehicleType.Airplane,5,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("C",5)),

            new Trip(8,VehicleType.Train,1,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",1)),
            new Trip(9,VehicleType.Train,2,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",2)),
            new Trip(10,VehicleType.Train,2,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("D",2)),

            new Trip(11,VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("F",6)),
            new Trip(12,VehicleType.Airplane,6,new DateTime(year:2023,month:12,day:4),Expense.calculateTripCost("F",6))
        };

        

        //doluluk kontrolü

        //bossa ana ekranda


        

     }       
}
