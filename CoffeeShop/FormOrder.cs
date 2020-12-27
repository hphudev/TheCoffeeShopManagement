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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;

namespace CoffeeShopManagement
{
    public partial class FormOrder : System.Windows.Forms.Form
    {
        private static List<System.IO.Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public FormSell parent;
        public FormLock BangKhoa;
        public int tienKhachDua { set; get; }
        public int sumOrders { set; get; }
        public string idTable = null;
        public Table tableChoice = null;
        public int discount = 0;
        public int discountMax = 0;
        Timer checkFormTienKhachDua = new Timer();
        Timer checkIdTable = new Timer();
        public FormOrder(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            //this.BangKhoa = new FormLock(this);
            this.Location = this.Location;
            tienKhachDua = 0;
            checkFormTienKhachDua.Interval = 5;
            checkFormTienKhachDua.Tick += ThanhToan;
            checkIdTable.Interval = 5;
            checkIdTable.Tick += CheckIdTable;
            //BangKhoa.Show();
            //this.Show();
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
        string count;
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
                    for (int i = 0; i < this.parent.Tables.Count; i++)
                        this.parent.Tables[i].index = i;
                }
                count = (Data.Calculate("COUNT", " * ", "HOADON", "") + 1).ToString();
                count = "HD" + count.PadLeft(5, '0');
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
                discount = discount * sumOrders / 100;
                if (discountMax > 0 && discount > discountMax)
                    discount = discountMax;
                bill = new Bill(count, new DateTime().GetDate(DateTime.Now),
                    this.parent.cus.id.id, this.parent.parent.account.id.id, sumOrders, discount, tienKhachDua);
                bill.AddBill();
                Data.UpdateData("khachhang", $"solantoiquan = solantoiquan + 1, doanhso = doanhso + {bill.value}", $"where makh = '{bill.idCustomer.id}'");
                detailBill = new DetailBill[this.parent.Orders.Count];
                for (int i = 0; i < this.parent.Orders.Count; i++)
                {
                    detailBill[i] = new DetailBill(count, this.parent.Orders[i].ID, this.parent.Orders[i].SoLuong);
                    detailBill[i].AddDetailBill();
                    Data.UpdateData("mon", $"solanphucvu = solanphucvu + {detailBill[i].soLuong}", $"where mamon = '{detailBill[i].idMon}'");
                }
                string id_admin = "";
                if (this.parent.parent.account.id.id == "NULL")
                    id_admin = "Admin";
                FormReport cus = new FormReport(count, id_admin);
                FormLock ltmp = new FormLock();
                ltmp.Show();
                cus.Show();
                cus.SetLockForm(ref ltmp);
                ltmp.SetLockParent(cus);
                this.Hide();
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

        #region Vùng bí ẩn

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>6in</PageWidth>
                    <PageHeight>8.3in</PageHeight>
                    <MarginTop>0in</MarginTop>
                    <MarginLeft>0in</MarginLeft>
                    <MarginRight>0in</MarginRight>
                    <MarginBottom>0in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<System.IO.Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (System.IO.Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static System.IO.Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            System.IO.Stream stream = new System.IO.MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (System.IO.Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
        #endregion

        public DataTable GetDataTable()
        {
            SqlConnection con =  Data.OpenConnection();
            string sql = $"select  A.TENMON, B.SL, A.GIA, (B.SL * A.GIA) as THANHTIEN from MON A, CTHD B where (A.MAMON = B.MAMON) and (B.SOHD = '{count}')";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
        }

        public void BtThanhToan_Click(object sender, EventArgs e)
        {
            sumOrders = 0;
            for (int i = 0; i < this.parent.Orders.Count; i++)
            {
                sumOrders += this.parent.Orders[i].TongTien;
            }
            FormTienKhachDua cus = new FormTienKhachDua(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
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

        int numePage = 0;
        int posDetailBill = 0;
        int posPrint = -1;
        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaperSize paperSize = new PaperSize("PaperA4",826,1169);
            printBill.DefaultPageSettings.PaperSize = paperSize;
            //printBill.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("", 840, 15000);
            //printBill.DefaultPageSettings.Landscape = true;
            int height = 50, sum = 0;
            e.HasMorePages = false;
            if (posPrint == -1)
            {
                posPrint++;
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
                
                height = 370;
                sum = 0;
            }
            if (posDetailBill < this.parent.Orders.Count)
                for (int i = posDetailBill; i < this.parent.Orders.Count; i++)
                {
                    posDetailBill = i + 1;
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
                    if (height > 1000)
                    {
                        height = 50;
                        e.HasMorePages = true;
                        return;
                    }
                }
            if (posPrint == 0)
            {
                height += 30;
                e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 1)
            {
                height += 50;
                e.Graphics.DrawString($"- TỔNG TIỀN:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
                e.Graphics.DrawString($"{sum} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 2)
            {
                height += 50;
                e.Graphics.DrawString($"- GIẢM GIÁ:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
                e.Graphics.DrawString($"{0}  VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 3)
            {
                height += 50;
                e.Graphics.DrawString($"- TỔNG THU:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
                e.Graphics.DrawString($"{sum}  VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 4)
            {
                height += 30;
                e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 5)
            {
                height += 50;
                e.Graphics.DrawString($"- TIỀN KHÁCH ĐƯA:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
                e.Graphics.DrawString($"{tienKhachDua} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 6)
            {
                height += 50;
                e.Graphics.DrawString($"- TIỀN ĐƯA LẠI:", new Font("Segoe UI", 18), Brushes.Black, new Point(30, height));
                e.Graphics.DrawString($"{tienKhachDua - sum} VNĐ", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(400, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 7)
            {
                height += 30;
                e.Graphics.DrawString("----------------------------------------", new Font("Segoe UI", 40), Brushes.Black, new Point(0, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
            if (posPrint == 8)
            {
                height += 50;
                e.Graphics.DrawString($"CẢM ƠN QUÝ KHÁCH!", new Font("Segoe UI", 25, FontStyle.Bold), Brushes.Black, new Point(240, height));
                posPrint++;
                if (height > 1000)
                {
                    height = 20;
                    e.HasMorePages = true;
                    return;
                }
            }
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
                        IO.ExportWarning("Bàn đã tồn tại");
                        break;
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
                    this.parent.LoadSomeThingPublic();
                    this.Close();
                }
                else
                    idTable = null;
            }
        }

        private void BtThemBan_Click(object sender, EventArgs e)
        {
            FormIDTable cus = new FormIDTable(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
            checkIdTable.Start();   
        }

        private void BtLuuOrder_Click(object sender, EventArgs e)
        {
            
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.BangKhoa = khoa;
        }
    }
}
