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
    public partial class FormQuanLyTaiKhoan : Form
    {
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void BtThemTaiKhoan_Click(object sender, EventArgs e)
        {
            new FormThemTaiKhoan().Show();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            new FormChinhSuaTaiKhoan().Show();
        }
    }
}
