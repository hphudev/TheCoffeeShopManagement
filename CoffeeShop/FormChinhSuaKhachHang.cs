using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormChinhSuaKhachHang : Form
    {
        private FormBangKhoa khoa;
        public FormChinhSuaKhachHang()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            khoa = new FormBangKhoa(this);
            khoa.Show();
            this.Show();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChinhSuaKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khoa.Close();
        }
    }
}
