using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public class Item
    {
        public string unit { get; }

        public int numberOfServings { get; }

        public ID id { get; set; }

        public string name { get; }

        public int price { get; }
        
        public Image image { get; }

        public bool status { get; }

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
                IO.ExportError("Lỗi không xác định\n(Line 48 Class Item)");
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
                IO.ExportError("Lỗi không xác định\n(Line 62 Class Item)");
                return null;
            }
        }
    }
}
