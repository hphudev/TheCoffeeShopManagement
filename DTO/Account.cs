using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;

namespace DTO
{
    public class Account
    {
        #region Attributes
        public ID id { get; set; }

        public string username { get; }

        public string password { get; }

        public bool status { get; }
        #endregion

        #region Operations
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
                IO.ExportError("Lỗi không xác định\n(Class Account)");
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
                IO.ExportError("Lỗi không xác định\n(Class Account)");
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
                IO.ExportError("Lỗi không xác định\n(Class Account)");
                return null;
            }
        }

        public static bool IsUsername(string username)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE TENDN = '" + 
                    username + "'", "*");

                if (!reader.HasRows)
                {
                    if (username == "1")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Account)");
                return false;
            }
        }

        #endregion
    }
}
