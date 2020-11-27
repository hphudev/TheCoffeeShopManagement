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
        public ID id { get; }

        public string username { get; }

        public string password { get; }

        public Account(string id, string username, string password)
        {
            this.id = new ID(id);
            this.username = username;
            this.password = password;
        }

        public static Account GetValidAccount(string username, SqlDataReader reader)
        {
            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                Account validAccount = new Account(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2));

                if (username == validAccount.username)
                {
                    return validAccount;
                }
            }

            return null;
        }

        public string GetInfo()
        {
            return "'" + this.id.ToString() + "', '" + this.username + "', '" + this.password + "', '1'";
        }
    }
}
