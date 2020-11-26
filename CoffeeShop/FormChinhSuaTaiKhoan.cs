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
    public partial class FormChinhSuaTaiKhoan : Form
    {
        FormBangKhoa khoa;
        public FormChinhSuaTaiKhoan()
        {
            InitializeComponent();
            khoa = new FormBangKhoa(this);
            khoa.Show();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChinhSuaTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
