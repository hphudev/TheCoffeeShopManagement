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
    public partial class FormThongTinNhanVien : System.Windows.Forms.Form
    {
        FormBangKhoa khoa;
        public FormThongTinNhanVien()
        {
            InitializeComponent();
            khoa = new FormBangKhoa(this);
            this.khoa.Show();
            this.Show();
        }

        private void FormThongTinNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
