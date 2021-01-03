using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Data.SqlClient;
namespace CoffeeShopManagement
{
    public partial class FormQuenMatKhau : Form
    {
        string path = Application.LocalUserAppDataPath + "/admin.txt";
        FormLock khoa;
        string emailAdmin = "", passAdmin = "", OTP = "", userName = "";
        Timer time = new Timer();
        int t = 60;
        public FormLogin parent;
        public FormQuenMatKhau(FormLogin parent)
        {
            InitializeComponent();
            ThongTinAdmin();
            time.Interval = 1000;
            time.Tick += (s, e) =>
            {
                DesTime();
            };
            bXacNhan.Enabled = false;
            tbOTP.Enabled = false;
            this.parent = parent;
        }

        private void DesTime()
        {
            if (t > 0)
            {
                t--;
                lbTime.Text = t.ToString() + "s";
                tbOTP.Enabled = true;
                bXacNhan.Enabled = true;
                this.tbEmail.Enabled = false;

            }
            else
            {
                tbOTP.Text = OTP = "";
                tbOTP.Enabled = false;
                bXacNhan.Enabled = false;
                this.tbEmail.Enabled = true;
                t = 60;
                lbTime.Text = "60s";
                lbTime.Visible = false;
                time.Stop();
            }
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.LoadAdmin();
            this.khoa.Close();
        }

        private void TbOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BXacNhan_Click(object sender, EventArgs e)
        {
            if (tbOTP.Text == "")
            {
                IO.ExportWarning("Bạn hãy kiểm tra email và nhập mã OTP");
                return;
            }
            if (tbOTP.Text == OTP)
            {
                IO.ExportSuccess("Mã OTP chính xác");
                FormDoiMatKhau cus =  new FormDoiMatKhau(this, this.tbEmail.Text, tbEmail.Text == emailAdmin);
                FormLock khoa = new FormLock();
                khoa.Show();
                cus.Show();
                cus.SetLockForm(ref khoa);
                khoa.SetLockParent(cus);
                tbEmail.Text = "";
                t = 1;
                time.Start();
            }
            else
            {
                IO.ExportError("Mã OTP không đúng");
            }
        }

        private void ThongTinAdmin()
        {
            if (System.IO.File.Exists(path))
            {
                using (System.IO.StreamReader read = new System.IO.StreamReader(path))
                {
                    if (!read.EndOfStream)
                        passAdmin = read.ReadLine();
                    if (!read.EndOfStream)
                        emailAdmin = read.ReadLine();
                }
            }
            else
                System.IO.File.Create(path).Close();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void BtGuiOTP_Click(object sender, EventArgs e)
        {
            if (lbTime.Visible)
            {
                IO.ExportInfo("Đã gửi mã OTP, vui lòng kiểm tra email");
                return;
            }
            userName = "";
            OTP = "";
            if (tbEmail.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập email");
                return;
            }
            if (tbEmail.Text == emailAdmin)
            {
                userName = "1";
            }
            else
            {
                SqlConnection con = Data.OpenConnection();
                SqlDataReader read = Data.ReadData("TAIKHOAN", con, $"where EMAIL = '{tbEmail.Text}'", " * ");
                if (read.HasRows && read.Read())
                    userName = read.GetString(1);
                Data.CloseConnection(ref con);
            }
            if (userName == "")
            {
                IO.ExportWarning("Không tìm thấy tài khoản có email này");
                return;
            }
            lbTime.Visible = true;
            time.Start();
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "coffeeshop.uit@gmail.com",
                    Password = "lhptvt123456"
                }

            };
            MailAddress FromEmail = new MailAddress("coffeeshop.uit@gmail.com", "UIT-K14-11B-Coffee Shop Management");
            MailAddress ToEmail = new MailAddress(tbEmail.Text, "Staff");
            MailMessage mess = new MailMessage()
            {
                From = FromEmail,
                Subject = "Xác nhận yêu cầu thay đổi mật khẩu tài khoản",
                Body = "►►☼ Nếu bạn không thực hiện yêu cầu này thì hãy bỏ qua email này!\n" +
                        $"► Tên đăng nhập: {userName}\n" +
                        $"► Mã OTP: {OTP = new Random(DateTime.Now.Second).Next(100000, 999999).ToString()}",

            };
            mess.To.Add(ToEmail);
            try
            {
                Client.SendAsync(mess, "Đã gửi");
                IO.ExportSuccess("Gửi thành công mã OTP");
                tbEmail.Enabled = false;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi hệ thống");
            }

        }
    }
}
