using Rezervasyon_Sistemi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public class Company : User, IProfitable
    {

        static int CompanyIdCounter = 0;
        public int CompanyId { get;}

        public double calculateGeneralBalance()
        {
            throw new NotImplementedException();
        }

        public double dailyProfit()
        {
            throw new NotImplementedException();
        }

        public override bool Login(string username, string password)
        {
            foreach (var _company in Data_Storage.companies)
            {
                if(_company.username == username && _company.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public Company(string username, string password)
        {
            this.CompanyId = CompanyIdCounter++;
            this.username = username;
            this.password = password;
        }
    }
}
