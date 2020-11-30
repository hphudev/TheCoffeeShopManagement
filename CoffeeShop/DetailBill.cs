using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class DetailBill
    {
        private ID id; 
        public ID idMon { get; }
        public int soLuong { get; }

        public DetailBill(string id, string idMon, int soLuong)
        {
            this.id = new ID(id);
            this.idMon = new ID(idMon);
            this.soLuong = soLuong;
        }

        public void AddDetailBill()
        {
            Data.AddData("CTHD", $"'{this.id.id}', '{this.idMon.id}', '{this.soLuong}'");
        }
    }
}
