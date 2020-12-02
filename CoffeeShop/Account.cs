using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeShopManagement
{
    public class Account
    {
        public ID id { get; set; }

        public string username { get; }

        public string password { get; }

        public bool status { get; }

        public bool IsAdmin()
        {
            if (this.username == "1")
            {
                return true;
            }

            return false;
        }

        public Account(string id, string username, string password, bool status)
        {
            this.id = new ID(id);
            this.username = username;
            this.password = password;
            this.status = status;
        }

        public string GetInfo()
        {
            return "'" + this.id.ToString() + "', '" + this.username + "', '" + this.password +
                "', '" + this.status + "'";
        }
    }
}
