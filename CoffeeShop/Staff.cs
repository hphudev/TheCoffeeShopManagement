using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Staff : Person
    {
        private string date, cmnd, chucVu;
        private int luong;

        public Staff(string id, string name, string address, string sdt, string sex, string date, 
            string cmnd, string chucVu, int luong) : base(id, name, address, sdt, sex)
        {
            this.date = date;
            this.cmnd = cmnd;
            this.chucVu = chucVu;
            this.luong = luong;
        }
    }
}
