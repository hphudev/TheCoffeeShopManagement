using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeShopManagement
{
    public class ID
    {
        public string id { get; set; }

        public ID(string id)
        {
            this.id = id;
        }

        public int FindID(string code)
        {
            char[] cCode = code.ToCharArray();
            string[] result = id.Split(cCode);
            return int.Parse(result[result.Length - 1]);
        }

        public void SetID(int id, string code, int iAmountNumber)
        {
            this.id = code;

            for (int i = 0; i < iAmountNumber - (id / 10 + 1); i++)
            {
                this.id += "0";
            }

            this.id += id.ToString();
        }

        public override string ToString()
        {
            return this.id;
        }

        public static ID GetLastIDStaff()
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("NHANVIEN", connection, " ORDER BY MANV DESC",
                "TOP 1 *");
            if (reader.Read())
            {
                Staff lastStaff = new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(4), reader.GetString(6),
                        (reader.GetDateTime(3).ToString().Split(' '))[0], reader.GetString(5),
                        reader.GetString(8), reader.GetInt32(7));
                Data.CloseConnection(ref connection);
                return lastStaff.id;
            }
            else
            {
                return null;
            }
        }

        public static ID GetLastIDItem()
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("MON", connection, " ORDER BY MAMON DESC",
                "TOP 1 *");
            if (reader.Read())
            {
                Item item = new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetInt32(4));
                Data.CloseConnection(ref connection);
                return item.id;
            }
            else
            {
                return null;
            }
        }
    }
}
