using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class HoaDon
    {
        private ID id, idKhachHang, idNhanVien;
        private string date;
        private int triGia, discount;

        public HoaDon(string id, string idKhachHang, string idNhanVien, string date, int triGia, 
            int discount)
        {
            this.id = new ID(id);
            this.idKhachHang = new ID(idKhachHang);
            this.idNhanVien = new ID(idNhanVien);
            this.date = date;
            this.triGia = triGia;
            this.discount = discount;
        }
    }
}
