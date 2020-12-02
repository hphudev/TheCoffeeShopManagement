using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace CoffeeShopManagement
{
    public partial class FormOrder : System.Windows.Forms.Form
    {
        public FormSell parent;
        public FormLock BangKhoa;
        public int tienKhachDua { set; get; }
        public int sumOrders { set; get; }
        public string idTable = null;
        public Table tableChoice = null;
        Timer checkFormTienKhachDua = new Timer();
        Timer checkIdTable = new Timer();
        public FormOrder(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.BangKhoa = new FormLock(this);
            this.Location = this.Location;
            tienKhachDua = 0;
            checkFormTienKhachDua.Interval = 5;
            checkFormTienKhachDua.Tick += ThanhToan;
            checkIdTable.Interval = 5;
            checkIdTable.Tick += CheckIdTable;
            BangKhoa.Show();
            this.Show();
        }

        private void F_Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bill bill;
        DetailBill[] detailBill;

        private void ThanhToan(object sender, EventArgs e)
        {
            if (tienKhachDua > 0)
            {
                checkFormTienKhachDua.Stop();
                if (this.tableChoice != null)
                {
                    this.parent.Tables.RemoveAt(this.tableChoice.index);
                    this.tableChoice.Dispose();
                    this.tableChoice = null;
                }
                string count = (Data.Calculate("COUNT", " * ", "HOADON", "") + 1).ToString();
                count = "HD" + count.PadLeft(4, '0');
                
                bill = new Bill(count, new DateTime().GetDate(DateTime.Now),
                    this.parent.cus.id.id, this.parent.parent.account.id.id, sumOrders, 0);
                bill.AddBill();
                Data.UpdateData("khachhang", $"solantoiquan = solantoiquan + 1, doanhso = doanhso + {bill.value}", $"where makh = '{bill.idCustomer.id}'");
                detailBill = new DetailBill[this.parent.Orders.Count];
                for (int i = 0; i < this.parent.Orders.Count; i++)
                {
                    detailBill[i] = new DetailBill(count, this.parent.Orders[i].ID, this.parent.Orders[i].SoLuong);
                    detailBill[i].AddDetailBill();
                    Data.UpdateData("mon", $"solanphucvu = solanphucvu + {detailBill[i].soLuong}", $"where mamon = '{detailBill[i].idMon}'");
                }
                printPreviewBill.Document = printBill;
                printPreviewBill.ShowDialog();
                this.parent.LoadSomeThingPublic();
                this.Close();
            }
            else
                if (tienKhachDua == -1)
                {
                    checkFormTienKhachDua.Stop();
                    this.Close();
                }
        }

        public void BtThanhToan_Click(object sender, EventArgs e)
        {
            sumOrders = 0;
            for (int i = 0; i < this.parent.Orders.Count; i++)
            {
                sumOrders += this.parent.Orders[i].TongTien;
            }
            new FormTienKhachDua(this);
            checkFormTienKhachDua.Start();
        }

        private int CalSizeLineTenMon(string HeaderTitle)
        {
            int max = HeaderTitle.Length;
            for (int i = 0; i < this.parent.Orders.Count; i++)
                max = Math.Max(max, this.parent.Orders[i].TenMon.Length);
            return max;
        }

        private int CalSizeLineSL(string HeaderTitle)
        {
            int max = HeaderTitle.Length;
            for (int i = 0; i < this.parent.Orders.Count; i++)
                max = Math.Max(max, this.parent.Orders[i].SoLuong.ToString().Length);
            return max;
        }

        private int CalSizeLineGia(string HeaderTitle)
        {
            int max = HeaderTitle.Length;
            for (int i = 0; i < this.parent.Orders.Count; i++)
                max = Math.Max(max, this.parent.Orders[i].Gia.ToString().Length);
            return max;
        }


        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //PaperSize paperSize = new PaperSize("", 50,50);
            //printBill.DefaultPageSettings.PaperSize = paperSize;
            Image image = Image.FromFile("./Resources/Logo.jpg");
            Bitmap map = new Bitmap(image, 100, 100);
            e.Graphics.DrawImageUnscaled(map, new Point(700, 0));
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Segoe UI", 40, FontStyle.Bold), Brushes.Black, new Point(280, 50));
            e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString($"- Mã hóa đơn: {bill.id.id} ", new Font("Segoe UI", 30), Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString($"- Mã nhân viên: {bill.idStaff.id} ", new Font("Segoe UI", 30), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString($"- Ngày hóa đơn: {DateTime.Now} ", new Font("Segoe UI", 30), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, 300));
            int maxSizeTenMon = CalSizeLineTenMon("TÊN MÓN");
            int maxSizeSL = CalSizeLineSL("SỐ LƯỢNG");
            int maxSizeGia = CalSizeLineGia("GIÁ");
            //MessageBox.Show("TÊN MÓN".Length.ToString());
            e.Graphics.DrawString("STT",
               new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 370));
            e.Graphics.DrawString("TÊN MÓN",
                new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(100, 370));
            e.Graphics.DrawString("SL",
                new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(420, 370));
            e.Graphics.DrawString("GIÁ",
                new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(520, 370));
            e.Graphics.DrawString("THÀNH TIỀN",
                new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(670, 370));
            int height = 370, sum = 0; ;
            for (int i = 0; i < this.parent.Orders.Count; i++)
            {
                height += 50;
                e.Graphics.DrawString((i+1).ToString(),
               new Font("Microsoft Sans Serif", 15, FontStyle.Bold), Brushes.Black, new Point(10, height));
                e.Graphics.DrawString(this.parent.Orders[i].TenMon,
                new Font("Microsoft Sans Serif", 15, FontStyle.Regular), Brushes.Black, new Point(100, height));
                e.Graphics.DrawString(this.parent.Orders[i].SoLuong.ToString(),
                    new Font("Microsoft Sans Serif", 15, FontStyle.Regular), Brushes.Black, new Point(420, height));
                e.Graphics.DrawString(this.parent.Orders[i].Gia.ToString(),
                    new Font("Microsoft Sans Serif", 15, FontStyle.Regular), Brushes.Black, new Point(520, height));
                e.Graphics.DrawString(this.parent.Orders[i].TongTien.ToString(),
                    new Font("Microsoft Sans Serif", 15, FontStyle.Regular), Brushes.Black, new Point(670, height));
                sum += this.parent.Orders[i].TongTien;
            }
            height += 30;
            e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
            height += 50;
            e.Graphics.DrawString($"- TỔNG TIỀN:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
            e.Graphics.DrawString($"{sum} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
            height += 50;
            e.Graphics.DrawString($"- GIẢM GIÁ:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
            e.Graphics.DrawString($"{0}  VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
            height += 50;
            e.Graphics.DrawString($"- TỔNG THU:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
            e.Graphics.DrawString($"{sum}  VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
            height += 30;
            e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
            height += 50;
            e.Graphics.DrawString($"- TIỀN KHÁCH ĐƯA:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
            e.Graphics.DrawString($"{tienKhachDua} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
            height += 50;
            e.Graphics.DrawString($"- TIỀN ĐƯA LẠI:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
            e.Graphics.DrawString($"{tienKhachDua - sum} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
            height += 30;
            e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
            height += 50;
            e.Graphics.DrawString($"CẢM ƠN QUÝ KHÁCH!", new Font("Segoe UI", 25, FontStyle.Bold), Brushes.Black, new Point(240, height));
        }

        private void PrintPreviewBill_Load(object sender, EventArgs e)
        {
            printPreviewBill.Document = printBill;
            printPreviewBill.ShowDialog();
        }

        private void CheckIdTable(object sender, EventArgs e)
        {
            if (idTable != null)
            {
                checkIdTable.Stop();
                Table tmp = new Table(this.parent);
                tmp.ID = this.idTable;
                tmp.index = this.parent.Tables.Count();
                //
                bool checkExists = false;
                foreach (var table in this.parent.Tables)
                    if (table.ID == tmp.ID)
                    {
                        checkExists = true;
                        for (int i = 0; i < tmp.Orders.Count; i++)
                        {
                            bool checkExist = false;
                            foreach (var item in table.Orders)
                                if (item.ID == tmp.Orders[i].ID)
                                {
                                    checkExist = true;
                                    item.SoLuong += tmp.Orders[i].SoLuong;
                                    break;
                                }
                            if (!checkExist)
                                this.parent.Tables[i].Orders.Add(tmp.Orders[i]);
                        }
                        table.LoadSomeThingPublic();
                        break;
                    }
                if (!checkExists)
                {
                    tmp.LoadSomeThingPublic();
                    this.parent.Tables.Add(tmp);
                }
                //
                this.parent.LoadSomeThingPublic();
                this.Close();
            }
        }

        private void BtThemBan_Click(object sender, EventArgs e)
        {
            new FormIDTable(this);
            checkIdTable.Start();   
        }

        private void BtLuuOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
