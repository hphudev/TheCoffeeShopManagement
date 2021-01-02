using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;

namespace CoffeeShopManagement
{
    public partial class FormTienKhachDua : Form
    {
        public int discount = 0;
        public int discountMax = 0;
        FormOrder parent;
        FormLock Lock;
        public FormTienKhachDua(FormOrder parent)
        {
            InitializeComponent();
            this.parent = parent;
            //Lock = new FormLock(this);
            tbManHinh.Text = "";
            CalTIenCanDua();
            lbTienCanDua.Text = Utility.StringToMoney((this.parent.sumOrders - discount).ToString());
            //this.Lock.Show();
            //this.Show();
        }

        void CalTIenCanDua()
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData("KHUYENMAI", con, "where TINHTRANGKM = 1", "*");
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                discount = read.GetInt32(0);
            }
            Data.CloseConnection(ref con);
            con = Data.OpenConnection();
            read = Data.ReadData("KHUYENMAI", con, "where TINHTRANGTIENTOIDA = 1", "*");
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                discountMax = read.GetInt32(2);
            }
            Data.CloseConnection(ref con);
            discount = discount * this.parent.sumOrders / 100;
            if (discountMax > 0 && discount > discountMax)
                discount = discountMax;
        }
        private void BtXacNhan_Click(object sender, EventArgs e)
        {
            if (tbManHinh.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập số tiền khách đưa!");
                return;
            }
            
            if (int.Parse(tbManHinh.Text) < this.parent.sumOrders - discount)
            {
                IO.ExportWarning("Khách đưa tiền còn thiếu " + (this.parent.sumOrders - discount - int.Parse(tbManHinh.Text)) + " VNĐ");
                return;
            }
            this.parent.tienKhachDua = int.Parse(tbManHinh.Text);
            this.Close();
        }

        private void FormTienKhachDua_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Lock.Close();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.parent.tienKhachDua = -1;
            this.Close();
        }

        private void TbManHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Bt00_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "00";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt0_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "0";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt1_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "1";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt2_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "2";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt3_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "3";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt4_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "4";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt5_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "5";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt6_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "6";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt7_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "7";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt8_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "8";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt9_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text += "9";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void BtAC_MouseDown(object sender, EventArgs e)
        {
            tbManHinh.Text = "";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void BtCE_MouseDown(object sender, EventArgs e)
        {
            if (tbManHinh.Text.Length == 0)
                return;
            tbManHinh.Text = tbManHinh.Text.Remove(tbManHinh.Text.Length - 1, 1);
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.Lock = khoa;
        }
    }
}
