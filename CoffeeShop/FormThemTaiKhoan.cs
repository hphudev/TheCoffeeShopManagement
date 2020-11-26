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
    public partial class FormThemTaiKhoan : Form
    {
        FormBangKhoa BangKhoa;
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            this.BangKhoa = new FormBangKhoa(this);
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
