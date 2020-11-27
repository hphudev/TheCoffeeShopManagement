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
    public partial class FormThongTinKhachHang : System.Windows.Forms.Form
    {
        FormBangKhoa BangKhoa;
        public FormThongTinKhachHang()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.BangKhoa = new FormBangKhoa(this);
            this.BangKhoa.Show();
            this.Show();
        }

        private void fThongTinKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
