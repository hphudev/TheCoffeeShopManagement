using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using System.Security.Cryptography;
namespace CoffeeShopManagement
{
    public partial class FormThongTinAdmin : Form
    {
        FormLock khoa;
        string path = Application.LocalUserAppDataPath + "/admin.txt";
        string passRoot = "";
        string emailRoot = "";
        public FormThongTinAdmin()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtThayDoiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (btThayDoiMK.Checked)
            {
                tbMatKhau.Enabled = true;
                tbMatKhau.Text = "";
            }
            else
            {
                tbMatKhau.Enabled = false;
                tbMatKhau.Text = passRoot;
            }
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
            if (tbEmail.Text == "" || tbMatKhau.Text == "")
            {
                DAO.IO.ExportWarning("Bạn phải nhập đầy đủ các trường");
                return;
            }
            using (StreamWriter write = new StreamWriter(path))
            {
                if (!btThayDoiMK.Checked)
                    write.WriteLine(tbMatKhau.Text);
                else
                    write.WriteLine(Encrypt.ComputeHash(this.tbMatKhau.Text, new SHA256CryptoServiceProvider()));
                write.Write(tbEmail.Text);
            }
            DAO.IO.ExportSuccess("Cập nhật thành công");
            this.Close();
        }

        private void FormThongTinAdmin_Load(object sender, EventArgs e)
        {
            tbMatKhau.Enabled = false;
            tbEmail.Enabled = false;
            if (File.Exists(path))
            {
                using (StreamReader read = new StreamReader(path))
                {
                    if (!read.EndOfStream)
                        tbMatKhau.Text = passRoot = read.ReadLine();
                    if (!read.EndOfStream)
                        tbEmail.Text = emailRoot = read.ReadLine();
                }    
            }
            else
                File.Create(path).Close();

        }

        private void BtThayDoiEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (btThayDoiEmail.Checked)
            {
                tbEmail.Enabled = true;
            }
            else
            {
                tbEmail.Enabled = false;
                tbEmail.Text = emailRoot;
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormThongTinAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
