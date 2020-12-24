using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeShopManagement
{
    public static class Initialization
    {
        public static Item InitItemFromReader(SqlDataReader reader)
        {
            try
            {
                return new Item(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetInt32(4), reader.GetBoolean(5));
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 21 Class Initialization)");
                return null;
            }
        }

        public static Staff InitStaffFromReader(SqlDataReader reader)
        {
            try
            {
                DateTime tmp = new DateTime();
                return new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(4), reader.GetString(6), tmp.GetDate(reader.GetDateTime(3)),
                        reader.GetString(5), reader.GetString(8), reader.GetInt32(7));
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 37 Class Initialization)");
                return null;
            }
        }
    }
}
