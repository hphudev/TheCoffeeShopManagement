using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Customer : Person
    {
        public string NgaySinh { set; get; }

        public string NgayDangKy { set; get; }

        public string ThanhVien { set; get; }

        public Customer(string id, string name, string address, string sdt, string sex, 
            string ngaysinh, string ngaydangky, string thanhvien) : base(id, name, address, sdt, sex)
        {
            try
            {
                this.NgaySinh = ngaysinh;
                this.NgayDangKy = ngaydangky;
                this.ThanhVien = thanhvien;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 24 Class Customer)");
            }
        }
    }
}
