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
    public partial class F_ThemTaiKhoan : Form
    {
        F_BangKhoa BangKhoa;
        public F_ThemTaiKhoan()
        {
            InitializeComponent();
            this.BangKhoa = new F_BangKhoa(this);
            this.BangKhoa.Show();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_ThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }
    }
}
