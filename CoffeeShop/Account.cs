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
            try
            {
                if (this.username == "1")
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 33 Class Account)");
                return false;
            }
        }

        public Account(string id, string username, string password, bool status)
        {
            try
            {
                this.id = new ID(id);
                this.username = username;
                this.password = password;
                this.status = status;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 49 Class Account)");
            }
        }

        public string GetInfo()
        {
            try
            {
                return "'" + this.id.ToString() + "', '" + this.username + "', '" + this.password +
                    "', '" + this.status + "'";
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 62 Class Account)");
                return null;
            }
        }
    }
}
