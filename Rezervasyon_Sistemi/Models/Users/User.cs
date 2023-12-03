using Rezervasyon_Sistemi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public abstract class User : ILoginable
    {
        public string username;
        public string password;

        public abstract bool Login(string username, string password);
    }
}
