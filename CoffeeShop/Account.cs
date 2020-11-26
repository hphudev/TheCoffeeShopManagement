using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Account
    {
        private ID id;

        public string username { get; }

        public string password { get; }

        public Account(string id, string username, string password)
        {
            this.id = new ID(id);
            this.username = username;
            this.password = password;
        }
    }
}
