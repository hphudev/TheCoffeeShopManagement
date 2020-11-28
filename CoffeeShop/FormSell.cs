using CoffeeShopManagement.Properties;
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
using System.IO;
namespace CoffeeShopManagement
{
    public partial class FormSell : System.Windows.Forms.Form
    {
        bool bHienThi = true;
        bool bThongBao = true;
        bool bTaiKhoan = true;
        public ListItem Choice = null;
        private FormLogin parent;
        private Timer CheckOrder;
        public FormSell(FormLogin parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.WindowState = FormWindowState.Maximized;
            CheckOrder = new Timer();
            CheckOrder.Interval = 5;
            CheckOrder.Tick += (s, e) =>
            {
                ActionChacOrder();
            };
            LoadDanhSachMonPhoBien();
            CheckOrder.Start();
        }

        private void LoadDanhSachMonPhoBien()
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader Reader = Data.ReadData("MON", connection, " ORDER BY SOLANPHUCVU DESC", " TOP 20 * ");
            while (Reader.HasRows)
            {
                if (Reader.Read() == false)
                    break;
                ListItem item = new ListItem(this);
                item.ID = Reader.GetString(0);
                if (System.IO.File.Exists($"./ImageItem/{ item.ID}.jpg"))
                {
                    item.Image = Image.FromFile($"./ImageItem/{item.ID}.jpg");
                }
                item.Title = Reader.GetString(1);
                item.Cost = Reader.GetInt32(4);
                this.flpDanhSachMon.Controls.Add(item);
            }
            Data.CloseConnection(ref connection);
        }

        private void LoadDanhSachMon()
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader Reader = Data.ReadData("MON", connection, "", " * ");
            while (Reader.HasRows)
            {
                if (Reader.Read() == false)
                    break;
                ListItem item = new ListItem(this);
                item.ID = Reader.GetString(0);
                if (System.IO.File.Exists($"./ImageItem/{ item.ID}.jpg"))
                {
                    item.Image = Image.FromFile($"./ImageItem/{item.ID}.jpg");
                }
                item.Title = Reader.GetString(1);
                item.Cost = Reader.GetInt32(4);
                this.flpDanhSachMon.Controls.Add(item);
            }
            Data.CloseConnection(ref connection);
        }

        private void ActionChacOrder()
        {
            if (Choice != null)
            {
                ListOrder order = new ListOrder();
                order.Gia = Choice.Cost;
                order.ID = Choice.ID;
                order.TenMon = Choice.Title;
                Choice = null;
                this.flpOrder.Controls.Add(order);
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
                    //Thread.Sleep(1);
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
                    //Thread.Sleep(1);
                    this.pnThanhChon.Height += 10;
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
                    //Thread.Sleep(1);
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
                    //Thread.Sleep(1);
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
                    //Thread.Sleep(1);
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
                    //Thread.Sleep(1);
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
                //Thread.Sleep(1);
                pnThongBao.Height -= 5;
            }
            pnThongBao.Visible = false;
            bThongBao = false;
            //
            //Button Tài khoản
            while (pnTaiKhoan.Height > 5)
            {
                //Thread.Sleep(1);
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
            new FormMenuStaff(this) ;
        }

        private void BtTK_ThongTin_Click(object sender, EventArgs e)
        {
            new FormInfoStaff(this.parent.account).Show();
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
            new FormMenuItem(this);
        }

        private void BtThongKe_Click(object sender, EventArgs e)
        {
            AnHetCacButtonMenu();
        }
    }
}
