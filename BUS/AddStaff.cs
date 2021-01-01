using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class AddStaff : AddObj
    {
        public override void AddImageClicked(ref PictureBox pbImageItem, object staff = null)
        {
            //MessageBox.Show(Application.LocalUserAppDataPath);
            AddImage(ref pbImageItem, $"./ImageStaff/", ID.FindNewID("NHANVIEN", " ORDER BY MANV DESC",
                "MANV", "NV", 2).ToString());
        }

        public override void AddNewObj(object staff, object updatedAccount)
        {
            Staff newStaff = (Staff)staff;
            Account account = (Account)updatedAccount;
            int flag = (Staff.IsStaff(ref newStaff));

            if (flag == 0 || flag == -1)
            {
                return;
            }
            else
            {
                if (Account.IsUsername(account.username))
                {
                    if (flag == 1)
                    {
                        Data.AddData("NHANVIEN", newStaff.GetInfo());
                        Data.AddData("TAIKHOAN", account.GetInfo());
                    }

                    if (flag == 2)
                    {
                        Data.UpdateData("NHANVIEN", "DCHI = N'" + newStaff.address + "', NGVL = '"
                            + DateTime.Today.Year.ToString() + "/" +
                            DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString()
                            + "', SDT = '" + newStaff.sdt + "', LUONG = " +
                            newStaff.luong.ToString() + ", CHUCVU = N'" + newStaff.chucVu + "'",
                            " WHERE MANV = '" + newStaff.id.ToString() + "'");
                        Data.UpdateData("TAIKHOAN", "TENDN = '" + account.username +
                            "', MATKHAU = '" + account.password + "', TINHTRANG = 1",
                            " WHERE ID = '" + account.id.ToString() + "'");
                    }

                    IO.ExportSuccess("Thêm nhân viên thành công");
                }
                else
                {
                    IO.ExportError("Tên đăng nhập đã tồn tại");
                }
            }
        }

    }
}
