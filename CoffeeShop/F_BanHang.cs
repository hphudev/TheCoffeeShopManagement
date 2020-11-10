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

namespace CoffeeShop
{
    public partial class fBanHang : Form
    {
        bool bHienThi = true;
        bool bThongBao = true;
        bool bTaiKhoan = true;
        public fBanHang()
        {
            InitializeComponent();
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

        private void fBanHang_Load(object sender, EventArgs e)
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
                pnTaiKhoan.Visible = true;
                while (pnTaiKhoan.Height < 38)
                {
                    Thread.Sleep(1);
                    pnTaiKhoan.Height += 5;
                }
                bTaiKhoan = true;
            }
        }
    }
}
