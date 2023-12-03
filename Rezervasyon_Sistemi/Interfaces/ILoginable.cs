using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Interfaces
{
    public interface ILoginable
    {
        bool Login(string username,string password);
    }
}
