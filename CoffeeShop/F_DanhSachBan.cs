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
    public partial class F_DanhSachBan : Form
    {
        F_BangKhoa BangKhoa;
        public F_DanhSachBan()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //this.WindowState = FormWindowState.Maximized;
            this.BangKhoa = new F_BangKhoa(this);
            this.BangKhoa.Show();
            this.Show();
        }

        private void F_DanhSachBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }
    }
}
