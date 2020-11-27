using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Staff : Person
    {
        public string date { get; }

        public string cmnd { get; }

        public string chucVu { get; }

        public int luong { get; }

        public Staff(string id, string name, string address, string sdt, string sex, string date,
            string cmnd, string chucVu, int luong) : base(id, name, address, sdt, sex)
        {
            this.date = date;
            this.cmnd = cmnd;
            this.chucVu = chucVu;
            this.luong = luong;
        }

        public string GetInfo()
        {
            return "'" + this.id + "', N'" + this.name + "', N'" + this.address + "', '" +
                this.date + "', '" + this.sdt + "', '" + this.cmnd + "', N'" + this.sex +
                "', '" + this.luong + "', N'" + this.chucVu + "'";
        }
    }
}
