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
    public partial class F_Order : Form
    {
        fBanHang parent;
        F_BangKhoa BangKhoa;
        public F_Order(fBanHang parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.BangKhoa = new F_BangKhoa(this);
            this.Location = this.Location;
            BangKhoa.Show();
            this.Show();
        }

        private void F_Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
