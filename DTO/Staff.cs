using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using DAO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DTO
{
    public class Staff : Person, IInfo
    {
        public ID id { get; }

        public string date { get; }

        public string cmnd { get; }

        public string chucVu { get; }

        public int luong { get; }

        public Image image { get; set; }

        public Staff(string id, string name, string address, string sdt, string sex, string date,
            string cmnd, string chucVu, int luong) : base(name, address, sdt, sex)
        {
            try
            {
                this.id = new ID(id);
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
                IO.ExportError("Lỗi không xác định\n(Class Staff)");
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
                IO.ExportError("Lỗi không xác định\n(Class Staff)");
                return null;
            }
        }

        public static int IsStaff(ref Staff newStaff)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection, " WHERE "
                    + "NV.MANV = TK.ID", "*");
                string lastID = "";

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }

                    Staff staff = new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(4), reader.GetString(6),
                        (reader.GetDateTime(3).ToString().Split(' '))[0], reader.GetString(5),
                        reader.GetString(8), reader.GetInt32(7));
                    Account account = new Account(reader.GetString(9), reader.GetString(10),
                        reader.GetString(11), reader.GetBoolean(12), reader.GetString(13), reader.GetString(14));

                    if (newStaff.cmnd == staff.cmnd && account.status)
                    {
                        if (newStaff.id.ToString() != staff.id.ToString())
                        {
                            Data.CloseConnection(ref connection);
                            IO.ExportError("Tồn tại nhân viên có số cmnd này trong danh sách");
                            return 0;
                        }
                    }

                    if (newStaff.cmnd == staff.cmnd && !account.status)
                    {
                        newStaff.id.SetID(staff.id.FindID("NV"), "NV", 2);
                        Data.CloseConnection(ref connection);
                        return 2;
                    }

                    if (newStaff.sdt == staff.sdt)
                    {
                        if (newStaff.id.ToString() != staff.id.ToString())
                        {
                            Data.CloseConnection(ref connection);
                            IO.ExportError("Tồn tại nhân viên có số điện thoại này trong danh sách");
                            return 0;
                        }
                    }

                    lastID = staff.id.FindID("NV").ToString();
                }

                reader.Close();

                if (newStaff.id.ToString() == "")
                {
                    if (lastID == "")
                    {
                        newStaff.id.SetID(1, "NV", 2);
                    }
                    else
                    {
                        newStaff.id.SetID(int.Parse(lastID) + 1, "NV", 2);
                    }
                }

                Data.CloseConnection(ref connection);
                return 1;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Staff)");
                return -1;
            }
        }

        public Account GetAccount()
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE ID = '" +
                    this.id.ToString() + "'", "*");
                reader.Read();
                Account account = new Account(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetBoolean(3), reader.GetString(4),
                    reader.GetString(5));
                Data.CloseConnection(ref connection);
                return account;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Staff");
                return null;
            }
        }

    }
}
