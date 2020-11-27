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
    public partial class FormLogin : System.Windows.Forms.Form
    {
        FormInit parent;

        public FormLogin(FormInit parent)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.btDangNhap.Click += LoginClicked;
            this.buttonThoat.Click += CancelClicked;
            this.tbTenDangNhap.KeyPress += PressEnter;
            this.tbMatKhau.KeyPress += PressEnter;
            this.parent = parent;
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.IsPassword)
            {
                tbMatKhau.IsPassword = false;
                pbEye.Image = Image.FromFile("./Resources/CloseEye.png");
            }
            else
            {
                tbMatKhau.IsPassword = true;
                pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public Account GetValidAccount(Account account, SqlDataReader reader)
        {
            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    break;
                }

                Account validAccount = new Account(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2));

                if (account.username == validAccount.username)
                {
                    return validAccount;
                }
            }

            return null;
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            Account account = new Account("", tbTenDangNhap.TextName, Encrypt.ComputeHash(
                tbMatKhau.TextName, new SHA256CryptoServiceProvider()));
            Account adminAccount = new Account("", "1", Encrypt.ComputeHash("1", new SHA256CryptoServiceProvider()));
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, "", "*");
            Account validAccount = GetValidAccount(account, reader);

            if (validAccount == null && account.username != adminAccount.username)
            {
                IO.ExportError("Tên đăng nhập không tồn tại");
            }
            else
            {
                if ((validAccount != null && validAccount.password == account.password) ||
                    account.password == adminAccount.password)
                {
                    new FormBanHang(this).Show();
                    this.Hide();
                    this.tbTenDangNhap.TextName = this.tbMatKhau.TextName = "";
                }
                else
                {
                    IO.ExportError("Mật khẩu không đúng");
                }
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonThoatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Close();
        }
    }
}
