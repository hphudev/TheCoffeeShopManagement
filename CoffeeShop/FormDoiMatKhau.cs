using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormDoiMatKhau : Form
    {
        string email;
        FormLock khoa;
        bool isAdmin = false;
        string path = Application.LocalUserAppDataPath + "/admin.txt";
        FormQuenMatKhau parent;
        public FormDoiMatKhau(FormQuenMatKhau parent, string email, bool admin)
        {
            InitializeComponent();
            this.email = email;
            this.isAdmin = admin;
            this.parent = parent;
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void BXacNhan_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" || tbConfirm.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập đủ thông tin");
                return;
            }
            if (tbConfirm.Text != tbPassword.Text)
            {
                IO.ExportWarning("Bạn xác nhận mật khẩu chưa đúng");
                return;
            }
            if(!isAdmin)
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + BUS.Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()) + "'",
                       " WHERE EMAIL = '" + email + "'");
            else
            {
                using (System.IO.StreamWriter write = new System.IO.StreamWriter(path))
                {
                    write.WriteLine(Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()));
                    write.Write(email);
                }
                
            }
            DAO.IO.ExportSuccess("Cập nhật thành công");
            this.Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Close();
            this.khoa.Close();
        }
    }
}
