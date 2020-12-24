using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CoffeeShopManagement
{
    public class Staff : Person
    {
        public string date { get; }

        public string cmnd { get; }

        public string chucVu { get; }

        public int luong { get; }

        public Image image { get; set; }

        public Staff(string id, string name, string address, string sdt, string sex, string date,
            string cmnd, string chucVu, int luong) : base(id, name, address, sdt, sex)
        {
            try
            {
                this.date = date;
                this.cmnd = cmnd;
                this.chucVu = chucVu;
                this.luong = luong;

                if (this.id.ToString() != "")
                {
                    FileInfo file = new FileInfo("./ImageStaff/" + this.id.ToString() + ".jpg");

                    if (file.Exists)
                    {
                        using (var bitmap = new Bitmap("./ImageStaff/" + this.id.ToString() + ".jpg"))
                        {
                            this.image = new Bitmap(bitmap);
                        }
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 48 Class Staff)");
            }
        }

        public string GetInfo()
        {
            try
            {
                return "'" + this.id + "', N'" + this.name + "', N'" + this.address + "', '" +
                    this.date + "', '" + this.sdt + "', '" + this.cmnd + "', N'" + this.sex +
                    "', '" + this.luong + "', N'" + this.chucVu + "'";
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 62 Class Staff)");
                return null;
            }
        }
    }
}
