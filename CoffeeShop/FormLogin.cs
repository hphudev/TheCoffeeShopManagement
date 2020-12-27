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
using DAO;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        #region Thư viện giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Attributes
        private FormInit parent;

        public Account account { get; private set; }
        #endregion

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
                this.parent = parent;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 48 Form Login)");
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
                this.tbTenDangNhap.Text = "Tên đăng nhập";
                this.tbMatKhau.Text = "Mật khẩu";
                this.tbMatKhau.PasswordChar = '\0';
                this.pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
                this.tbTenDangNhap.Select();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 76 Form Login)");
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbMatKhau.PasswordChar == '*')
                {
                    this.tbMatKhau.PasswordChar = '\0';
                    this.pbEye.Image = Image.FromFile("./Resources/CloseEye.png");
                }
                else
                {
                    this.tbMatKhau.PasswordChar = '*';
                    this.pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 97 Form Login)");
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
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

                this.account = new Account("NULL", this.tbTenDangNhap.Text, Encrypt.ComputeHash(
                    this.tbMatKhau.Text, new SHA256CryptoServiceProvider()), true);

                if (Event.Login(this.account))
                {
                    Event.ShowForm((new FormSell(this)));
                    this.Hide();
                    this.tbTenDangNhap.Text = this.tbMatKhau.Text = "";
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 128 Form Login)");
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
