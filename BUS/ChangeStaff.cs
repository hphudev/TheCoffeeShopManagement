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
            AddImage(ref pbImageItem, "./ImageStaff/", ((Staff)staff).id.ToString());
        }

        public void ChangeInfoObj(object staff, object account = null)
        {
            Staff updatedStaff = (Staff)staff;
            Account updatedAccount = (Account)account;
            Data.UpdateData("NHANVIEN", "CHUCVU = N'" + updatedStaff.chucVu + "', luong = '" +
                updatedStaff.luong + "', DCHI = N'" + updatedStaff.address + "'", " WHERE MANV = '"
                + updatedStaff.id.ToString() + "'");
            if (updatedAccount != null)
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'",
                    " WHERE ID = '" + updatedAccount.id.ToString() + "'");
            IO.ExportSuccess("Sửa thông tin nhân viên thành công");
        }

    }
}
