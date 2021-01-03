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
using DTO;
using DAO;
using BUS;
using System.Threading;
using System.Configuration;
namespace CoffeeShopManagement
{
    public partial class FormLogin : Form, IButtonOK
    {
        #region Thư viện giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Atrributes
        private FormInit parent;
        string passAdmin = Encrypt.ComputeHash("1",
                new SHA256CryptoServiceProvider());
        string emailAdmin = "";
        string path = Application.LocalUserAppDataPath + "/admin.txt";
        public Account account { get; private set; }
        #endregion

        #region Operations
        public FormLogin(FormInit parent)
        {
            try
            {
                #region Code
                InitializeComponent();
                this.DoubleBuffered = true;
                this.btDangNhap.Click += OKClicked;
                this.btThoat.Click += CancelClicked;
                this.tbTenDangNhap.KeyPress += PressEnter;
                this.tbMatKhau.KeyPress += PressEnter;
                //this.tbMatKhau.PasswordChar = '*';
                //this.bMinimize.Click += MinimizeClicked;
                this.parent = parent;
                LoadAdmin();
                IO.ExportSuccess("Đã khởi động xong");
                #endregion

            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Login)");
            }
        }

        public void LoadAdmin()
        {
            string emailAdmin = "";
            passAdmin = Encrypt.ComputeHash("1",
                new SHA256CryptoServiceProvider());
            if (System.IO.File.Exists(path))
                using (System.IO.StreamReader read = new System.IO.StreamReader(path))
                {
                    if (!read.EndOfStream)
                        passAdmin = read.ReadLine();
                    if (!read.EndOfStream)
                        emailAdmin = read.ReadLine();
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
                pbEye.Image = Properties.Resources.OpenEye;
                tbTenDangNhap.Select();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Login)");
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
                IO.ExportError("Lỗi không xác định\n(Form Login)");
            }
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
                        reader.GetString(2), reader.GetBoolean(3), reader.GetString(4), reader.GetString(5));

                    if (account.username == validAccount.username)
                    {
                        return validAccount;
                    }
                }

                return null;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Login)");
                return null;
            }
        }

        public void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbTenDangNhap.Text == "Tên đăng nhập" || this.tbMatKhau.Text == "Mật khẩu")
                {
                    IO.ExportError("Tên đăng nhập và mật khẩu không được để trống");
                    return;
                }
                if (!bgWorker.IsBusy)
                {
                    this.load.Visible = true;
                    IO.ExportInfo("Đang kết nối cơ sở dữ liệu");
                    bgWorker.RunWorkerAsync();
                }
                else
                    MessageBox.Show("error");
            }
            catch (Exception)
            {
                this.load.Visible = false;
                //IO.ExportError("Lỗi không xác định\n(Line 177 Form Login)");
            }
        }

        public override void CancelClicked(object sender, EventArgs e)
        {
            base.CancelClicked(sender, e);
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
                IO.ExportError("Lỗi không xác định\n(Form Login)");
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
                IO.ExportError("Lỗi không xác định\n(Form Login)");
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
                IO.ExportError("Lỗi không xác định\n(Form Login)");
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
                IO.ExportError("Lỗi không xác định\n(Form Login)");
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            IO.ExportSuccess("Đã sãn sàng khởi động");
            Application.Restart();
        }

        #endregion

        int sleep = 2000;
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(sleep);
            this.lb.BackColor = Color.Orange;
            this.account = new Account("NULL", tbTenDangNhap.Text, Encrypt.ComputeHash(
                tbMatKhau.Text, new SHA256CryptoServiceProvider()), true, "NULL", "");
            Account adminAccount = new Account("", "1", passAdmin, true, emailAdmin, "");

            Account validAccount;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Server"].ConnectionString);
                connection.Open();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE TINHTRANG = 1",
                 "*");
                validAccount = GetValidAccount(this.account, reader);
                connection.Close();
                bgWorker.ReportProgress(4);
                if (validAccount == null && this.account.username != adminAccount.username)
                {

                    //IO.ExportError("Tên đăng nhập này không tồn tại");
                    bgWorker.ReportProgress(2);
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
                        bgWorker.ReportProgress(1);

                    }
                    else
                    {
                        //IO.ExportError("Mật khẩu không đúng");
                        bgWorker.ReportProgress(3);
                    }
                }
            }
            catch (Exception)
            {
                bgWorker.ReportProgress(0);
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.load.Visible = false;
            if (e.ProgressPercentage == 0)
            {
                this.load.BackColor = Color.Red;
                sleep *= 2;
                IO.ExportError($"Mất kết nối server");
                bgWorker.CancelAsync();

            }
            else
                if (e.ProgressPercentage == 1)
            {
                sleep = 1000;
                IO.ExportSuccess("Đăng nhập thành công");
                Event.ShowForm((new FormSell(this)));
                this.Hide();
                this.tbTenDangNhap.Text = this.tbMatKhau.Text = "";
                bgWorker.CancelAsync();

            }
            else
                if (e.ProgressPercentage == 2)
            {
                sleep = 1000;
                IO.ExportError("Tên đăng nhập này không tồn tại");
                this.load.BackColor = Color.Red;
                bgWorker.CancelAsync();

            }
            else
                if (e.ProgressPercentage == 3)
            {
                sleep = 1000;
                IO.ExportError("Mật khẩu không đúng");
                this.load.BackColor = Color.Red;
                bgWorker.CancelAsync();

            }
            else if (e.ProgressPercentage == 4)
            {
                IO.ExportSuccess("Server đã được kết nối");
            }
        }

        private void BtQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormLock khoa = new FormLock();
            FormQuenMatKhau cus = new FormQuenMatKhau(this);
            khoa.Show();
            cus.Show();
            khoa.SetLockParent(cus);
            cus.SetLockForm(ref khoa);
        }
    }
}
