using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Management
{
    public class Client
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Client(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

}
