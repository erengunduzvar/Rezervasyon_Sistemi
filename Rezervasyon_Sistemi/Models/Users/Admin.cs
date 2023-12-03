using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon_Sistemi.Models
{
    public class Admin : User
    {

        public Admin(string _username,string _password)
        {
            username = _username;
            password = _password;
        }

        public override bool Login(string _username, string _password)
        {
            if (_username == Data_Storage.admin.username && _password == Data_Storage.admin.password)
            {
                return true;
            }
            else return false;
        }
    }
}
