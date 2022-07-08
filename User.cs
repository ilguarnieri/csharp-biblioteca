using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string name;
        public string surname;
        public string email;
        public string password;
        public string cellNumber;

        //costruttore
        public User(string name, string surname, string email, string password, string cellNumber)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.cellNumber = cellNumber;
        }
    }
}
