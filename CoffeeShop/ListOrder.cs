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
        private int Tien;
        private int tongTien;
        private string id;
        private int index;
        private Timer CheckSumZero;
        private FormSell parent;
        public ListOrder(FormSell parent)
        {
            InitializeComponent();
            this.parent = parent;
            DoubleBuffered = true;
            CheckSumZero = new Timer();
            CheckSumZero.Interval = 1;
            CheckSumZero.Tick += ActionCheckSumZero;
            CheckSumZero.Start();
            //TenMon = "Cà phê đen";
            //lbSoTien.Text = (Tien * soluong).ToString() + "đ";
            tbSoLuongMon.Text = soluong.ToString();

        }

        [Category("Custom Pro")]
        public int Index
        {
            set { this.index = value; }
            get { return this.index; }
        }

        [Category("Custom Pro")]
        public string ID
        {
            set { this.id = value;}
            get { return this.id; }
        }

        [Category("Custom Pro")]
        public int SoLuong
        {
            set 
            { 
                this.soluong = value; 
                tbSoLuongMon.Text = value.ToString(); 
                TongTien = Gia * soluong;
            }
            get { return this.soluong; }
        }

        [Category("Custom Pro")]
        public int Gia
        {
            set { this.Tien = value; TongTien = value * soluong; }
            get { return this.Tien; }
        }

        [Category("Custom Pro")]
        public int TongTien
        {
            set { this.tongTien = value; lbSoTien.Text = Utility.StringToMoney(value.ToString()) + "đ"; }
            get { return this.tongTien; }
        }

        [Category("Custom Pro")]
        public string TenMon
        {
            set { this.tenMon = value; lbTenMon.Text = value.ToString(); }
            get { return this.tenMon; }
        }

        private void ActionCheckSumZero(object s, EventArgs e)
        {
            if (tbSoLuongMon.Text.Length == 1 && tbSoLuongMon.Text == "0")
            {
                tbSoLuongMon.Text = "";
                SoLuong = 1;
            }
        }

        private void BtTru_MouseDown(object sender, MouseEventArgs e)
        {
            if (soluong > 1)
            {
                SoLuong = soluong - 1;
                //this.parent.Orders[index].SoLuong--;
            }
            else
            {
                CheckSumZero.Stop();
                this.parent.Orders.RemoveAt(index);
                this.parent.ItemsChoice.RemoveAt(this.index);
                for (int i = this.index; i < this.parent.Orders.Count; i++)
                {
                    this.parent.Orders[i].index = i;
                }
                this.Dispose();
            }
        }

        private void BtCong_MouseDown(object sender, MouseEventArgs e)
        {
            SoLuong = soluong + 1;
            //this.parent.Orders[index].SoLuong++;
            //TongTien = soluong * Tien;
        }

        private void TbSoLuongMon_TextChanged(object sender, EventArgs e)
        {
            if (tbSoLuongMon.Text != "")
                SoLuong = int.Parse(tbSoLuongMon.Text);
        }

        private void TbSoLuongMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) || (char.IsDigit(e.KeyChar) && tbSoLuongMon.Text == "" && e.KeyChar == '0')) && !char.IsControl(e.KeyChar);
        }

        private void TbSoLuongMon_Enter(object sender, EventArgs e)
        {
            
        }

        private void TbSoLuongMon_Leave(object sender, EventArgs e)
        {
            if (tbSoLuongMon.Text == "")
            {
                SoLuong = 1;
            }
        }
    }
}
