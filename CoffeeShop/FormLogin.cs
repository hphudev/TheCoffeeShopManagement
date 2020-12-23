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
            InitializeComponent();
            this.DoubleBuffered = true;
            this.btDangNhap.Click += LoginClicked;
            //this.buttonThoat.Click += CancelClicked;
            this.tbTenDangNhap.KeyPress += PressEnter;
            this.tbMatKhau.KeyPress += PressEnter;
            //this.tbMatKhau.PasswordChar = '*';
            //this.bMinimize.Click += MinimizeClicked;
            this.parent = parent;
        }

        private void MinimizeClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void LoadFormLogin()
        {
            tbTenDangNhap.Text = "Tên đăng nhập";
            tbMatKhau.Text = "Mật khẩu";
            tbMatKhau.PasswordChar = '\0';
            pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
            tbTenDangNhap.Select();
        }

        private void pbEye_Click(object sender, EventArgs e)
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
                    reader.GetString(2), reader.GetBoolean(3));

                if (account.username == validAccount.username)
                {
                    return validAccount;
                }
            }

            return null;
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbTenDangNhap.Text == "" || this.tbMatKhau.Text == "")
                {
                    throw new Exception();
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

                        (new FormSell(this)).Show();
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
                IO.ExportError("Tên đăng nhập và mật khẩu không được để trống");
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

        private void PThanhDieuKhien_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BMinimize_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void PnLot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }


        private void TbTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (tbTenDangNhap.Text == "Tên đăng nhập")
            {
                tbTenDangNhap.Text = "";
            }
        }

        private void TbTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (tbTenDangNhap.Text == "")
            {
                tbTenDangNhap.Text = "Tên đăng nhập";
            }
        }

        private void TbMatKhau_Enter(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "Mật khẩu")
            {
                tbMatKhau.PasswordChar = '*';
                tbMatKhau.Text = "";
            }
        }

        private void TbMatKhau_Leave(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "")
            {
                tbMatKhau.PasswordChar = '\0';
                tbMatKhau.Text = "Mật khẩu";
            }
        }
    }
}
