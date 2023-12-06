using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public class Admin : User
    {
        public static int AdminFee { get; set; }
        public Admin(string _username,string _password)
        {
            username = _username;
            password = _password;
        }

        public override bool Login(string _username, string _password)
        {
            if(_username == this.username && _password == this.password)
            {
                return true;
            }
            return false;
        }
    }
}
