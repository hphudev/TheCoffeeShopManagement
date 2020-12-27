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

        class ListSortTimes : IComparer<ListItem>
        {
            int IComparer<ListItem>.Compare(ListItem x, ListItem y)
            {
                return y.TimesChoice.CompareTo(x.TimesChoice);
            }
        }

        class ListSortID : IComparer<ListItem>
        {
            int IComparer<ListItem>.Compare(ListItem x, ListItem y)
            {
                return x.ID.CompareTo(y.ID);
            }
        }

        public Customer cus = new Customer("NULL","","","","","","","");
        public List<ListOrder> Orders = new List<ListOrder>();
        public List<ListItem> ItemsChoice = new List<ListItem>();
        public List<ListItem> Items = new List<ListItem>();
        public List<Table> Tables = new List<Table>();

        bool bHienThi = false;
        bool bThongBao = false;
        bool bTaiKhoan = false;
        bool statusOrder = true;
        public int discount = 0;
        public int SumOrders;
        public Table TableChoice = null;
        public ListItem Choice = null;
        public FormLogin parent;
        public Timer CheckOrderSum;
        private Timer CheckFind;
        public Timer CheckThongBao;

        public FormSell(FormLogin parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.WindowState = FormWindowState.Maximized;
            this.InitMenu();
            this.Init_btThongBao();
            this.Init_btTaiKhoan();
            this.InitDanhSachMon();
            this.InitCheckOrderSum();
            this.InitCheckThongBao();
            this.InitCheckFind();
            LoadSomeThingPublic();
            //MessageBox.Show(this.parent.account.id.id);
            this.bInfoAccount.Click += InfoAccountClicked;
            this.bMenuStaff.Click += MenuStaffClicked;
        }

        // Khai báo tính tổng Orders tự động
        private void InitCheckOrderSum()
        {
            CheckOrderSum = new Timer();
            CheckOrderSum.Interval = 100;
            CheckOrderSum.Tick += (s, e) =>
            {
                ActionCheckOrderSum();
            };
        }

        private void InitCheckThongBao()
        {
            CheckThongBao = new Timer();
            CheckThongBao.Interval = 1500;
            CheckThongBao.Tick += (s, e) =>
            {
                SqlConnection con = Data.OpenConnection();
                SqlDataReader read = Data.ReadData("THONGBAO", con, "", "*");
                bool check = true;
                while (read.HasRows)
                {
                    if (!read.Read())
                        break;
                    check = read.GetBoolean(2);
                }
                if (!check)
                {
                    //if (System.IO.File.Exists($"./Resources/announ.gif"))
                    //{
                    //    using (var bitmap = new Bitmap($"./Resources/announ.gif"))
                    //    {
                    //        pbThongBao.Image = new Bitmap(bitmap);
                    //    }
                    //}
                    pbThongBao.Image = Resources.announ;

                }
                else
                {
                    //if (System.IO.File.Exists($"./Resources/announTinh.png"))
                    //{
                    //    using (var bitmap = new Bitmap($"./Resources/announTinh.png"))
                    //    {
                    //        pbThongBao.Image = new Bitmap(bitmap);
                    //    }
                    //}
                    pbThongBao.Image = Resources.announTinh;
                }
                Data.CloseConnection(ref con);
            };
            CheckThongBao.Start();
        }
        // Khai báo tìm kiếm món tự động
        private void InitCheckFind()
        {
            CheckFind = new Timer();
            CheckFind.Interval = 100;
            CheckFind.Tick += (s, e) =>
            {
                ActionCheackFind();
            };
            CheckFind.Stop();
        }

        private void ActionCheackFind()
        {
            //CheckFind.Stop();
            if (cbTimKiem.Text == "")
            {
                flpDanhSachMon.Controls.Clear();
                foreach (var item in Items)
                {
                    flpDanhSachMon.Controls.Add(item);
                }
                return;
            }
            flpDanhSachMon.Controls.Clear();
            foreach (var item in Items)
            {
                string tmpParent = item.Title.ToLower();
                string tmpChild = cbTimKiem.Text.ToLower();
                if (tmpParent.IndexOf(tmpChild) >= 0)
                {
                    flpDanhSachMon.Controls.Add(item);
                }
            }
        }

        #region Giao diện
        private void InitMenu()
        {
            this.bHienThi = false;
            CLoseMenu(this, new EventArgs());
            this.btMenu.MouseDown += (s, e) =>
            {
                if (!bHienThi)
                    OpenMenu(s, e);
                else
                    CLoseMenu(s, e);
            };
        }

        private void OpenMenu(object s, EventArgs e)
        {
            this.bHienThi = true;
            this.pnLotMenu.Visible = true;
        }

        private void CLoseMenu(object s, EventArgs e)
        {
            this.bHienThi = false;
            this.pnLotThongBao.Visible = false;
            this.pnLotTaiKhoan.Visible = false;
            this.pnLotMenu.Visible = false;
        }

        private void Init_btThongBao()
        {
            this.btThongBao.MouseDown += btThongBaoMouseDown;
        }

        private void btThongBaoMouseDown(object s, MouseEventArgs e)
        {
            HideMenuRemain();
            if (bThongBao)
            {
                bThongBao = false;
                this.pnLotThongBao.Visible = false;
            }
            else
            {
                bThongBao = true;
                this.pnLotThongBao.Visible = true;
            }
        }

        private void Init_btTaiKhoan()
        {
            this.btTaiKhoan.MouseDown += btTaiKhoanMouseDown;
        }

        private void btTaiKhoanMouseDown(object s, MouseEventArgs e)
        {
            HideMenuRemain();
            if (bTaiKhoan)
            {
                bTaiKhoan = this.pnLotTaiKhoan.Visible = false;
            }
            else
                bTaiKhoan = this.pnLotTaiKhoan.Visible = true;
        }

        private void HideMenuRemain()
        {
            if (bTaiKhoan)
            {
                bTaiKhoan = this.pnLotTaiKhoan.Visible = false;
            }
            if (bThongBao)
            {
                bThongBao = this.pnLotThongBao.Visible = false;
            }
        }
        #endregion

        public void ActionCheckTableChoice()
        {
            if (TableChoice != null)
            {
                FormOrder OrderTable = new FormOrder(this);
                FormLock ltmp = new FormLock();
                ltmp.SetLockParent(cus);
                OrderTable.SetLockForm(ref ltmp);
                OrderTable.BangKhoa.Hide();
                OrderTable.Hide();
                OrderTable.tableChoice = this.TableChoice;
                OrderTable.BtThanhToan_Click(OrderTable, new EventArgs());
                this.TableChoice = null;
                OrderTable.Close();
            }
        }

       
        private void InitDanhSachMon()
        {
            Items.Clear();
            cbTimKiem.Items.Clear();
            this.flpDanhSachMon.Controls.Clear();
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(" MON ", connection, " where TINHTRANG = 1 ", " * ");
            while (reader.HasRows)
            {
                if (!reader.Read())
                    break;
                ListItem item = new ListItem(this);
                item.ID = reader.GetString(0);
                if (System.IO.File.Exists($"./ImageItem/{ item.ID}.jpg"))
                {
                    using (var bitmap = new Bitmap($"./ImageItem/{item.ID}.jpg"))
                    {
                        item.Image = new Bitmap(bitmap);
                    }
                }
                item.Title = reader.GetString(1);
                item.Cost = reader.GetInt32(4);
                item.TimesChoice = reader.GetInt32(3);
                this.flpDanhSachMon.Controls.Add(item);
                Items.Add(item);
                cbTimKiem.Items.Add(item.Title);
            }
        }

        private void SapXepDanhSachTheoID()
        {
            ListSortID sort = new ListSortID();
            Items.Sort(sort);
        }

        private void SapXepDanhSachTheoTimes()
        {
            ListSortTimes sort = new ListSortTimes();
            Items.Sort(sort);
        }

        public void LoadSomeThingPublic()
        {
            cus = new Customer("NULL", "", "", "", "", "", "", "");
            string count = (Data.Calculate("COUNT", " * ", "HOADON", "") + 1).ToString();
            lbID_HoaDon.Text = "HD" + count.PadLeft(6 - count.Length, '0');
            this.Orders.Clear();
            this.InitDanhSachMon();
            this.ItemsChoice.Clear();
            this.flpOrder.Controls.Clear();
            this.flpDanhSachMon.Controls.Clear();
            LoadDanhSachMon();
        }

        private void LoadDanhSachMon()
        {
            flpDanhSachMon.Controls.Clear();
            foreach (var item in Items)
            {
                flpDanhSachMon.Controls.Add(item);
            }
        }

        public void ActionCheckOrder()
        {
            if (Choice != null)
            {
                ListOrder order = new ListOrder(this);
                order.Gia = Choice.Cost;
                order.ID = Choice.ID;
                order.TenMon = Choice.Title;
                order.Index = ItemsChoice.Count;
                Choice = null;
                Orders.Add(order);
                if (statusOrder)
                    this.flpOrder.Controls.Add(order);
                CheckOrderSum.Start();
            }
            else
                Choice = null;
        }

        public void ActionCheckOrderSum()
        {
            SumOrders = 0;
            for (int i = 0; i < this.Orders.Count; i++)
            {
                Orders[i].Index = i;
                SumOrders += Orders[i].TongTien;
            }
            btOrder.Text = Utility.StringToMoney(SumOrders.ToString());
            if (SumOrders > 0)
                btOrder.FillColor = Color.Red;
            else
                btOrder.FillColor = Color.DimGray;
        }


        private void btOrder_Click(object sender, EventArgs e)
        {
            if (btOrder.Text == "0")
            {
                IO.ExportWarning("Danh sách món trống!");
                return;
            }
            FormOrder cus = new FormOrder(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void btDanhSachBan_Click(object sender, EventArgs e)
        {
            FormDanhSachBan cus = new FormDanhSachBan(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {
            FormThongTinKhachHang cus = new FormThongTinKhachHang(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
           
        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.parent.LoadFormLogin();
        }

        private void MenuStaffClicked(object sender, EventArgs e)
        {
            if (!this.parent.account.IsAdmin())
            {
                IO.ExportWarning("Bạn không được cấp quyền tính năng này!");
                return;
            }
            FormMenuStaff cus = new FormMenuStaff(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void InfoAccountClicked(object sender, EventArgs e)
        {
            if (!this.parent.account.IsAdmin())
            {
                FormInfoStaff cus = new FormInfoStaff(this.parent.account);
                FormLock ltmp = new FormLock();
                ltmp.Show();
                cus.Show();
                cus.SetLockForm(ref ltmp);
                ltmp.SetLockParent(cus);
            }
        }

        private void BtTK_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtHuyNoiDungTimKiem_Click(object sender, EventArgs e)
        {
            cbTimKiem.Text = "";
        }

        private void BtThemMon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
                if (cbTimKiem.Text == Items[i].Title)
                {
                    if (!ItemsChoice.Contains(Items[i]))
                    {
                        Choice = Items[i];
                        ItemsChoice.Add(Items[i]);
                        ActionCheckOrder();
                        IO.ExportSuccess("Đã thêm món thành công!");
                        cbTimKiem.Text = "";
                        return;
                    }
                    else
                    {
                        IO.ExportSuccess("Món này đã được thêm!");
                        return;
                    }
                }
            IO.ExportError("Không tìm thấy món!");
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTimKiem_TextChanged(object sender, EventArgs e)
        {
            CheckFind.Start();
        }

        private void CbTimKiem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void CbTimKiem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtKhachHang_Click(object sender, EventArgs e)
        {
            HideMenuRemain();
            FormChinhSuaKhachHang cus = new FormChinhSuaKhachHang();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void BtThucDon_Click(object sender, EventArgs e)
        {
            HideMenuRemain();
            if (!this.parent.account.IsAdmin())
            {
                IO.ExportWarning("Bạn không được cấp quyền tính năng này!");
                return;
            }
            FormMenuItem cus = new FormMenuItem(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void BtThongTInKhachHang_Click(object sender, EventArgs e)
        {
            HideMenuRemain();
        }

        private void BtThongKe_Click(object sender, EventArgs e)
        {
            HideMenuRemain();
            if (!this.parent.account.IsAdmin())
            {
                IO.ExportWarning("Bạn không được cấp quyền tính năng này!");
                return;
            }
            FormStatistic cus = new FormStatistic(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void BtMonPhoBien_CheckedChanged(object sender, EventArgs e)
        {
            if (btMonPhoBien.Checked == false)
            {
                SapXepDanhSachTheoID();
                if (cbTimKiem.Text == "")
                    LoadDanhSachMon();
            }
            else
            {
                SapXepDanhSachTheoTimes();
                if (cbTimKiem.Text == "")
                    LoadDanhSachMon();
            }
        }

        private void BtTaiChinh_Click(object sender, EventArgs e)
        {
            FormExpense cus = new FormExpense(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void BtHangNgay_Click(object sender, EventArgs e)
        {
            //CheckThongBao.Stop();
            FormCaiDatThongBao cus = new FormCaiDatThongBao();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void PbThongBao_Click(object sender, EventArgs e)
        {
            FormNoiDungThongBao cus = new FormNoiDungThongBao(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            
        }

        private void BtThongTinQuan_Click(object sender, EventArgs e)
        {
            FormThongTinQuan cus = new FormThongTinQuan();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }
    }
}
