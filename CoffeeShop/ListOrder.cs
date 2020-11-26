using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopManagement.Properties;

namespace CoffeeShopManagement
{
    public partial class ListOrder : UserControl
    {
        private int soluong = 1;
        private string tenMon = "";
        private double Tien = 25000;
        private double tongTien = 25000;

        public ListOrder()
        {
            InitializeComponent();
            DoubleBuffered = true;
            TenMon = "Cà phê đen";
            lbSoTien.Text = (Tien * soluong).ToString() + "đ";
            lbSoLuongMon.Text = soluong.ToString();

        }
        
        [Category("Custom Pro")]
        public int SoLuong
        {
            set { this.soluong = value; lbSoLuongMon.Text = value.ToString(); }
            get { return this.soluong; }
        }

        [Category("Custom Pro")]
        public double TongTien
        {
            set { this.tongTien = value; lbSoTien.Text = value.ToString() + "đ"; }
            get { return this.tongTien; }
        }

        [Category("Custom Pro")]
        public string TenMon
        {
            set { this.tenMon = value; lbTenMon.Text = value.ToString(); }
            get { return this.tenMon; }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            if (soluong > 1)
                SoLuong = soluong - 1;
            else
                this.Dispose();
            TongTien = soluong * Tien;
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            SoLuong = soluong + 1;
            TongTien = soluong * Tien;
        }
    }
}
