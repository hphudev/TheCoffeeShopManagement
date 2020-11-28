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
    public partial class F_DanhSachBan : System.Windows.Forms.Form
    {
        FormLock BangKhoa;
        public F_DanhSachBan()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //this.WindowState = FormWindowState.Maximized;
            this.BangKhoa = new FormLock(this);
            this.BangKhoa.Show();
            this.Show();
            
        }

        private void F_DanhSachBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }
    }
}
