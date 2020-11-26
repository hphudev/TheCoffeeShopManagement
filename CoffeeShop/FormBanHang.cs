using CoffeeShopManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormBanHang : Form
    {
        bool bHienThi = true;
        bool bThongBao = true;
        bool bTaiKhoan = true;
        private FormLogin parent;

        public FormBanHang(FormLogin parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.WindowState = FormWindowState.Maximized;
            for (int i = 0; i < 10; i++)
            {
                ListItem item1 = new ListItem();
                item1.Image = Resources.KhoiDong;
                item1.Title = "CÀ PHÊ";
                flpDanhSachMon.Controls.Add(item1);
            }
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            if (bHienThi)
            {
                if (bThongBao)
                {
                    btThongBao_Click(sender, e);
                }
                if (bTaiKhoan)
                {
                    btTaiKhoan_Click(sender, e);
                }
                this.pnThanhChon.Height = 40;
                while (pnThanhChon.Height > 5)
                {
                    Thread.Sleep(1);
                    this.pnThanhChon.Height -= 5;
                }
                this.pnThanhChon.Visible = false;
                bHienThi = false;
                btHienThi.ButtonImage = Image.FromFile("./Resources/Expand.png");
                btHienThi.ButtonText = "Hiển thị menu";
            }
            else
            {
                this.pnThanhChon.Visible = true;
                while (pnThanhChon.Height < 40)
                {
                    Thread.Sleep(1);
                    this.pnThanhChon.Height += 5;
                }
                bHienThi = true;
                btHienThi.ButtonImage = Image.FromFile("./Resources/Collapse.png");
                btHienThi.ButtonText = "Ẩn menu";
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            if (bHienThi)
                btHienThi_Click(sender, e);
            if (bThongBao)
                btThongBao_Click(sender, e);
            if (bTaiKhoan)
                btTaiKhoan_Click(sender, e);
        }

        private void btThongBao_Click(object sender, EventArgs e)
        {
            if (bThongBao)
            {
                while (pnThongBao.Height > 5)
                {
                    Thread.Sleep(1);
                    pnThongBao.Height -= 5;
                }
                pnThongBao.Visible = false;
                bThongBao = false;
            }
            else
            {
                AnHetCacButtonMenu();
                pnThongBao.Visible = true;
                while (pnThongBao.Height < 38)
                {
                    Thread.Sleep(1);
                    pnThongBao.Height += 5;
                }
                bThongBao = true;
            }
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            if (bTaiKhoan)
            {
                while (pnTaiKhoan.Height > 5)
                {
                    Thread.Sleep(1);
                    pnTaiKhoan.Height -= 5;
                }
                pnTaiKhoan.Visible = false;
                bTaiKhoan = false;
            }
            else
            {
                AnHetCacButtonMenu();
                pnTaiKhoan.Visible = true;
                while (pnTaiKhoan.Height < 38)
                {
                    Thread.Sleep(1);
                    pnTaiKhoan.Height += 5;
                }
                bTaiKhoan = true;
            }
        }

        private void AnHetCacButtonMenu()
        {
            // Button Thông báo
            //
            while (pnThongBao.Height > 5)
            {
                Thread.Sleep(1);
                pnThongBao.Height -= 5;
            }
            pnThongBao.Visible = false;
            bThongBao = false;
            //
            //Button Tài khoản
            while (pnTaiKhoan.Height > 5)
            {
                Thread.Sleep(1);
                pnTaiKhoan.Height -= 5;
            }
            pnTaiKhoan.Visible = false;
            bTaiKhoan = false;
            //
            //
        }

        private void jMaterialTextbox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0k");
        }


        private void btOrder_Click(object sender, EventArgs e)
        {
            new F_Order(this);
        }

        private void btDanhSachBan_Click(object sender, EventArgs e)
        {
            new F_DanhSachBan();
        }

        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {
            new FormThongTinKhachHang();
        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void BtTK_QuanLy_Click(object sender, EventArgs e)
        {
            new FormQuanLyTaiKhoan().Show();
        }

        private void BtTK_ThongTin_Click(object sender, EventArgs e)
        {
            new FormThongTinNhanVien().Show();
        }

        private void BtTK_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtKhachHang_Click(object sender, EventArgs e)
        {
            AnHetCacButtonMenu();
            new FormChinhSuaKhachHang().Show();
        }

        private void BtDaOrder_Click(object sender, EventArgs e)
        {
            this.btDangOrder.ForeColor = Color.Black;
            this.btDaOrder.ForeColor = Color.FromArgb(192, 192, 0);
        }

        private void BtDangOrder_Click(object sender, EventArgs e)
        {
            this.btDaOrder.ForeColor = Color.Black;
            this.btDangOrder.ForeColor = Color.FromArgb(192, 192, 0);
        }

        private void BtThucDon_Click(object sender, EventArgs e)
        {
            AnHetCacButtonMenu();
        }

        private void BtThongKe_Click(object sender, EventArgs e)
        {
            AnHetCacButtonMenu();
        }
    }
}
