using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DAO;
using System.Data.SqlClient;

namespace DTO
{
    public class Item
    {
        #region Atrributes
        public string unit { get; }

        public int numberOfServings { get; }

        public ID id { get; set; }

        public string name { get; }

        public int price { get; }
        
        public Image image { get; }

        public bool status { get; }
        #endregion

        #region Operations
        public Item(string id, string name, string unit, int numberOfServings, int price, bool status)
        {
            try
            {
                this.id = new ID(id);
                this.name = name;
                this.unit = unit;
                this.price = price;
                this.numberOfServings = numberOfServings;
                this.status = status;

                if (this.id.ToString() != "")
                {
                    using (var bitmap = new Bitmap("./ImageItem/" + this.id.ToString() + ".jpg"))
                    {
                        this.image = new Bitmap(bitmap);
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Item)");
            }
        }

        public string GetInfo()
        {
            try
            {
                return "'" + this.id + "', N'" + this.name + "', N'" + this.unit + "', N'" +
                    this.numberOfServings.ToString() + "', '" + this.price + "', '" + this.status +
                    "'";
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Item)");
                return null;
            }
        }

        public static int IsItem(ref Item newItem)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("MON", connection, "", "*");
                string lastID = "";

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }

                    Item item = new Item(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetBoolean(5));

                    if (newItem.name == item.name && item.status)
                    {
                        Data.CloseConnection(ref connection);
                        return 0;
                    }

                    if (newItem.name == item.name && !item.status)
                    {
                        newItem.id.SetID(item.id.FindID("M"), "M", 3);
                        Data.CloseConnection(ref connection);
                        return 2;
                    }

                    lastID = item.id.FindID("M").ToString();
                }

                reader.Close();

                if (lastID == "")
                {
                    newItem.id.SetID(1, "M", 3);
                }
                else
                {
                    newItem.id.SetID(int.Parse(lastID) + 1, "M", 3);
                }

                Data.CloseConnection(ref connection);
                return 1;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Item)");
                return -1;
            }
        }

        #endregion
    }
}
