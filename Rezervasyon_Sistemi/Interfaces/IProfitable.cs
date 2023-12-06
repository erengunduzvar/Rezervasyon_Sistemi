using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Interfaces
{
    internal interface IProfitable
    {
        double dailyProfit(DateTime date);
        double calculateGeneralBalance();
    }
}
