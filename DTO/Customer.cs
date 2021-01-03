using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DTO
{
    public class Customer : Person
    {
        #region Attributes
        public ID id { get; }

        public string NgaySinh { set; get; }

        public string NgayDangKy { set; get; }

        public string ThanhVien { set; get; }
        #endregion

        #region Operations
        public Customer(string id, string name, string address, string sdt, string sex, 
            string ngaysinh, string ngaydangky, string thanhvien) : base(name, address, sdt, sex)
        {
            try
            {
                this.id = new ID(id);
                this.NgaySinh = ngaysinh;
                this.NgayDangKy = ngaydangky;
                this.ThanhVien = thanhvien;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Customer)");
            }
        }
        #endregion
    }
}
