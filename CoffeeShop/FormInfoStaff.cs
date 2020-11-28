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

        public string GetDate(DateTime dateTime)
        {
            return dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        }

        public void Autofill()
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection, " WHERE " +
                "NV.MANV = TK.ID AND TENDN = '" + this.account.username + "'", "*");
            reader.Read();
            Staff staff = new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(4), reader.GetString(6), GetDate(reader.GetDateTime(3)),
                    reader.GetString(5), reader.GetString(8), reader.GetInt32(7));
            this.account.id = staff.id;
            this.tbChucVu.Text = staff.chucVu;
            this.tbCMND.Text = staff.cmnd;
            this.tbDiaChi.Text = staff.address;
            this.tbLuong.Text = staff.luong.ToString();
            this.tbName.Text = staff.name;
            this.tbSoDienThoai.Text = staff.sdt;
            this.tbUsername.Text = this.account.username;
            this.tbPassword.Text = "";
            this.lID.Text = staff.id.ToString();
            this.cbGioiTinh.Text = staff.sex;
        }

        public FormInfoStaff(Account account)
        {
            InitializeComponent();
            this.lockForm = new FormLock(this);
            this.lockForm.Show();
            this.account = account;
            Autofill();
            this.bCancel.Click += CancelClicked;
            this.bOK.Click += OKClicked;
            this.FormClosed += CloseForm;
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.lockForm.Close();
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbPassword.Text == "")
                {
                    throw new Exception();
                }

                Account updatedAccount = new Account(this.account.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()));
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'",
                    " WHERE ID = '" + updatedAccount.id.ToString() + "'");
                IO.ExportSuccess("Đổi mật khẩu thành công");
                this.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Mật khẩu không được để trống");
            }
        }
    }
}
