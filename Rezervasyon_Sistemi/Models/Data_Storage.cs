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

        
        //expense hesaplama !!



        // -> Açıldığında hali hazırda açık olacak tripler

        public static List<Trip> openTrips = new List<Trip>();

        

        //doluluk kontrolü

        //bossa ana ekranda


        

     }       
}
