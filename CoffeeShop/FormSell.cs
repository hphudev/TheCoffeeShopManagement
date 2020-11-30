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
        public Customer cus = new Customer("NULL","","","","","","","");
        public List<ListOrder> Orders = new List<ListOrder>();
        public List<ListItem> ItemsChoice = new List<ListItem>();
        public List<ListItem> Items = new List<ListItem>();
        public List<Table> Tables = new List<Table>();

        bool bHienThi = true;
        bool bThongBao = true;
        bool bTaiKhoan = true;
        bool statusOrder = true;
        int SumOrders;
        public Table TableChoice = null;
        public ListItem Choice = null;
        public FormLogin parent;
        private Timer CheckOrder;
        private Timer CheckTable;
        public FormSell(FormLogin parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.WindowState = FormWindowState.Maximized;
            CheckOrder = new Timer();
            CheckOrder.Interval = 1;
            CheckOrder.Tick += (s, e) =>
            {
                ActionCheckOrder();
            };
            CheckTable = new Timer();
            CheckTable.Interval = 1;
            CheckTable.Tick += (s, e) =>
            {
                ActionCheckTableChoice();
            };
            CheckTable.Start();
            LoadDanhSachMonPhoBien();
            LoadSomeThingPublic();
            CheckOrder.Start();
            //MessageBox.Show(this.parent.account.id.id);
            this.bInfoAccount.Click += InfoAccountClicked;
        }
        
        private void ActionCheckTableChoice()
        {
            if (TableChoice != null)
            {
                CheckTable.Stop();
                FormOrder OrderTable = new FormOrder(this);
                OrderTable.BangKhoa.Hide();
                OrderTable.Hide();
                OrderTable.BtThanhToan_Click(OrderTable, new EventArgs());
                TableChoice = null;
                OrderTable.Close();
                CheckTable.Start();
            }
        }

        private void LoadDanhSachMonPhoBien()
        {
            Items.Clear();
            cbTimKiem.Items.Clear();
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
                Items.Add(item);
                cbTimKiem.Items.Add(item.Title);
            }
            Data.CloseConnection(ref connection);
        }

        public void LoadSomeThingPublic()
        {
            cus = new Customer("NULL", "", "", "", "", "", "", "");
            string count = (Data.Calculate("COUNT", " * ", "HOADON", "") + 1).ToString();
            lbID_HoaDon.Text =  "HD" + count.PadLeft(6 - count.Length, '0');
            Orders.Clear();
            ItemsChoice.Clear();
            flpOrder.Controls.Clear();
            flpDanhSachMon.Controls.Clear();
            LoadDanhSachMonPhoBien();
        }

        private void LoadDanhSachMon()
        {
            Items.Clear();
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
                Items.Add(item);
            }
            Data.CloseConnection(ref connection);
        }

        private void ActionCheckOrder()
        {
            if (statusOrder && Choice != null)
            {
                ListOrder order = new ListOrder(this);
                order.Gia = Choice.Cost;
                order.ID = Choice.ID;
                order.TenMon = Choice.Title;
                order.Index = ItemsChoice.Count;
                Choice = null;
                Orders.Add(order);
                this.flpOrder.Controls.Add(order);
            }
            else
                Choice = null;
            SumOrders = 0;
            for (int i = 0; i < this.Orders.Count; i++)
            {
                Orders[i].Index = i;
                SumOrders += Orders[i].TongTien;
            }
            btOrder.Text = SumOrders.ToString();
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


        private void btOrder_Click(object sender, EventArgs e)
        {
            new FormOrder(this);
        }

        private void btDanhSachBan_Click(object sender, EventArgs e)
        {
            new FormDanhSachBan(this);
        }

        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {
            new FormThongTinKhachHang(this);
        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void BtTK_QuanLy_Click(object sender, EventArgs e)
        {
            new FormMenuStaff(this) ;
        }

        private void InfoAccountClicked(object sender, EventArgs e)
        {
            if (!this.parent.account.IsAdmin())
            {
                new FormInfoStaff(this.parent.account).Show();
            }
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
            statusOrder = false;
            this.flpOrder.Controls.Clear();
        }

        private void BtDangOrder_Click(object sender, EventArgs e)
        {
            this.btDaOrder.ForeColor = Color.Black;
            this.btDangOrder.ForeColor = Color.FromArgb(192, 192, 0);
            statusOrder = true;
            this.flpOrder.Controls.Clear();
            SumOrders = 0;
            for (int i = 0; i < this.Orders.Count; i++)
            {
                this.flpOrder.Controls.Add(Orders[i]);
                SumOrders += Orders[i].TongTien;
            }
            btOrder.Text = SumOrders.ToString();
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

        private void BtMonPhoBien_Click(object sender, EventArgs e)
        {
            this.flpDanhSachMon.Controls.Clear();
            LoadDanhSachMonPhoBien();
        }

        private void BtThucUong_Click(object sender, EventArgs e)
        {
            this.flpDanhSachMon.Controls.Clear();
            LoadDanhSachMon();
        }

        private void BtHuyNoiDungTimKiem_Click(object sender, EventArgs e)
        {
            cbTimKiem.Text = "";
        }

        private void BtTimKiem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
                if (cbTimKiem.Text == Items[i].Title)
                {
                    if (!ItemsChoice.Contains(Items[i]))
                    {
                        Choice = Items[i];
                        ItemsChoice.Add(Items[i]);
                        MessageBox.Show("Đã thêm món thành công!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Món này đã được thêm!");
                        return;
                    }
                }
            MessageBox.Show("Không tìm thấy món!");
        }
    }
}
