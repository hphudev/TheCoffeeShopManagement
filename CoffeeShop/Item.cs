using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Item
    {
        public string unit { get; }

        public int soLanPhucVu { get; }

        public ID id { get; set; }

        public string name { get; }

        public int price { get; }

        public Item(string id, string name, string unit, int soLanPhucVu, int price)
        {
            this.id = new ID(id);
            this.name = name;
            this.unit = unit;
            this.price = price;
            this.soLanPhucVu = soLanPhucVu;
        }

        public string GetInfo()
        {
            return "'" + this.id + "', N'" + this.name + "', N'" + this.unit + "', N'" + 
                this.soLanPhucVu.ToString() + "', '" + this.price + "'";
        }
    }
}
