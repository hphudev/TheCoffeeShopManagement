using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class fThongTinKhachHang : Form
    {
        F_BangKhoa BangKhoa;
        public fThongTinKhachHang()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.BangKhoa = new F_BangKhoa(this);
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
