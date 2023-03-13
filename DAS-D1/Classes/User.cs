using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_D1.Classes
{
    internal class User
    {


        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool verifycredentials(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }

        public User(string username, string password, string name)
        {
            this.Username = username;
            this.Password = password;
            this.Nombre = name;
        }


    }
}
