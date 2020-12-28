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

        public static ID FindNewID(string table, string condition, string column, string code,
            int lengthOfNumber)
        {
            try
            {
                ID lastID = ID.GetLastID(table, condition, column);

                if (lastID != null)
                {
                    lastID.SetID((lastID.FindID(code) + 1), code, lengthOfNumber);
                }
                else
                {
                    ID tmp = new ID("");
                    tmp.SetID(1, code, lengthOfNumber);
                    lastID = tmp;
                }

                return lastID;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 39 Class ID)");
                return null;
            }
        }

        public static ID GetLastID(string table, string condition, string column)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData(table, connection, condition, "TOP 1 " + column);

                if (reader.Read())
                {
                    ID id = new ID(reader.GetString(0));
                    Data.CloseConnection(ref connection);
                    return id;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 64 Class ID)");
                return null;
            }
        }

        public int FindID(string code)
        {
            try
            {
                char[] cCode = code.ToCharArray();
                string[] result = id.Split(cCode);
                return int.Parse(result[result.Length - 1]);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 79 Class ID)");
                return -1;
            }
        }

        public void SetID(int id, string code, int iAmountNumber)
        {
            try
            {
                this.id = code;

                for (int i = 0; i < iAmountNumber - (id / 10 + 1); i++)
                {
                    this.id += "0";
                }

                this.id += id.ToString();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 99 Class ID)");
            }
        }

        public override string ToString()
        {
            try
            {
                return this.id;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 111 Class ID)");
                return null;
            }
        }
    }
}
