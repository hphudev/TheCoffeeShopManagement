using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CoffeeShopManagement
{
    public partial class FormInfoStaff : Form
    {
        FormLock lockForm;
        private Account account;

        public void Autofill()
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection, " WHERE " +
                    "NV.MANV = TK.ID AND TENDN = '" + this.account.username + "'", "*");
                reader.Read();
                Staff staff = Initialization.InitStaffFromReader(reader);
                this.account.id = staff.id;
                this.cbPosition.Text = staff.chucVu;
                this.tbCMND.Text = staff.cmnd;
                this.tbAddress.Text = staff.address;
                this.tbSalary.Text = staff.luong.ToString();
                this.tbName.Text = staff.name;
                this.tbSDT.Text = staff.sdt;
                this.tbUsername.Text = this.account.username;
                this.tbPassword.Text = "";
                this.lID.Text = staff.id.ToString();
                this.cbSex.Text = staff.sex;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 43 Form Image Staff)");
            }
        }

        public FormInfoStaff(Account account)
        {
            try
            {
                InitializeComponent();
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                this.account = account;
                Autofill();
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.FormClosed += CloseForm;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 62 Form Image Staff)");
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.lockForm);
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbPassword.Text == "")
                {
                    IO.ExportError("Mật khẩu không được để trống");
                    return;
                }

                Account updatedAccount = new Account(this.account.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                    true);
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'",
                    " WHERE ID = '" + updatedAccount.id.ToString() + "'");
                IO.ExportSuccess("Đổi mật khẩu thành công");
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 96 Form Image Staff)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
    }
}
