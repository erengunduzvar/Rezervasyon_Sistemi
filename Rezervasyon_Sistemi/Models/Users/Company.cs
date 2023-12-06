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

        public double dailyProfit(DateTime date)
        {
            throw new NotImplementedException();
        }

        public override bool Login(string username, string password)
        {
            if (username == this.username && password == this.password)
            {
                return true;
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
