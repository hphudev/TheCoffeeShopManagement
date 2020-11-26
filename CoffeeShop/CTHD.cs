using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class CTHD
    {
        private ID id, idMon;
        private int soLuong;

        public CTHD(string id, string idMon, int soLuong)
        {
            this.id = new ID(id);
            this.idMon = new ID(idMon);
            this.soLuong = soLuong;
        }
    }
}
