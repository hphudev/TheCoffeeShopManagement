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
using System.Runtime.InteropServices;

namespace CoffeeShopManagement
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        #region Thư viện giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion 

        private FormInit parent;

        public Account account { get; private set; }

        public FormLogin(FormInit parent)
        {
            try
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                this.btDangNhap.Click += LoginClicked;
                this.controlboxClose.Click += CancelClicked;
                this.tbTenDangNhap.KeyPress += PressEnter;
                this.tbMatKhau.KeyPress += PressEnter;
                //this.tbMatKhau.PasswordChar = '*';
                //this.bMinimize.Click += MinimizeClicked;
                this.parent = parent;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 45 Form Login)");
            }
        }

        private void MinimizeClicked(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định");
            }
        }

        public void LoadFormLogin()
        {
            try
            {
                tbTenDangNhap.Text = "Tên đăng nhập";
                tbMatKhau.Text = "Mật khẩu";
                tbMatKhau.PasswordChar = '\0';
                pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
                tbTenDangNhap.Select();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 73 Form Login)");
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMatKhau.PasswordChar == '*')
                {
                    tbMatKhau.PasswordChar = '\0';
                    pbEye.Image = Image.FromFile("./Resources/CloseEye.png");
                }
                else
                {
                    tbMatKhau.PasswordChar = '*';
                    pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 94 Form Login)");
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public Account GetValidAccount(Account account, SqlDataReader reader)
        {
            try
            {
                while (reader.HasRows)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    Account validAccount = new Account(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetBoolean(3));

                    if (account.username == validAccount.username)
                    {
                        return validAccount;
                    }
                }

                return null;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 127 Form Login)");
                return null;
            }
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbTenDangNhap.Text == "" || this.tbMatKhau.Text == "")
                {
                    IO.ExportError("Tên đăng nhập và mật khẩu không được để trống");
                    return;
                }

                this.account = new Account("NULL", tbTenDangNhap.Text, Encrypt.ComputeHash(
                    tbMatKhau.Text, new SHA256CryptoServiceProvider()), true);
                Account adminAccount = new Account("", "1", Encrypt.ComputeHash("1",
                    new SHA256CryptoServiceProvider()), true);
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE TINHTRANG = 1",
                    "*");
                Account validAccount = GetValidAccount(this.account, reader);

                if (validAccount == null && this.account.username != adminAccount.username)
                {
                    IO.ExportError("Tên đăng nhập này không tồn tại");
                }
                else
                {
                    if ((validAccount != null && validAccount.password == this.account.password) ||
                        this.account.password == adminAccount.password)
                    {
                        if (validAccount != null)
                        {
                            this.account = validAccount;
                        }

                        Event.ShowForm((new FormSell(this)));
                        this.Hide();
                        this.tbTenDangNhap.Text = this.tbMatKhau.Text = "";
                    }
                    else
                    {
                        IO.ExportError("Mật khẩu không đúng");
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 177 Form Login)");
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
            Event.CloseForm(this.parent);
        }

        private void PThanhDieuKhien_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TbTenDangNhap_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tbTenDangNhap.Text == "Tên đăng nhập")
                {
                    tbTenDangNhap.Text = "";
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 204 Form Login)");
            }
        }

        private void TbTenDangNhap_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbTenDangNhap.Text == "")
                {
                    tbTenDangNhap.Text = "Tên đăng nhập";
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 219 Form Login)");
            }
        }

        private void TbMatKhau_Enter(object sender, EventArgs e)
        {
            try
            {
                if (tbMatKhau.Text == "Mật khẩu")
                {
                    tbMatKhau.PasswordChar = '*';
                    tbMatKhau.Text = "";
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 235 Form Login)");
            }
        }

        private void TbMatKhau_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbMatKhau.Text == "")
                {
                    tbMatKhau.PasswordChar = '\0';
                    tbMatKhau.Text = "Mật khẩu";
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 251 Form Login)");
            }
        }
    }
}
