using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace BUS
{
    public class ChangeStaff : ObjStaff, IChangeObj
    {
        public override void AddImageClicked(ref PictureBox pbImageItem, object staff = null)
        {
            //MessageBox.Show(Application.LocalUserAppDataPath);
            AddImage(ref pbImageItem, path, ((Staff)staff).id.ToString());
        }

        public bool ChangeInfoObj(object staff, object account = null)
        {
            Staff updatedStaff = (Staff)staff;
            Account updatedAccount = (Account)account;
            int flag = Staff.IsStaff(ref updatedStaff);

            if (flag != 1)
            {
                return false;
            }

            if (!Account.IsEmail(updatedAccount.username, updatedAccount.email))
            {
                IO.ExportError("Email này đã tồn tại");
                return false;
            }

            Data.UpdateData("NHANVIEN", "CHUCVU = N'" + updatedStaff.chucVu + "', luong = '" +
                updatedStaff.luong + "', DCHI = N'" + updatedStaff.address + "', HOTEN = N'" + 
                updatedStaff.name + "', GIOITINH = N'" + updatedStaff.sex + "', CMND = '" + 
                updatedStaff.cmnd + "', SDT = '" + updatedStaff.sdt + "'", " WHERE MANV = '"
                + updatedStaff.id.ToString() + "'");

            if (updatedAccount != null)
            {
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + $"', " +
                    $"EMAIL = '{updatedAccount.email}'", " WHERE ID = '" + updatedAccount.id.ToString()
                    + "'");
            }

            IO.ExportSuccess("Sửa thông tin nhân viên thành công");
            return true;
        }

    }
}
