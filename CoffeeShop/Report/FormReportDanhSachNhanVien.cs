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
using Microsoft.Reporting.WinForms;
using GUI;
using DAO;

namespace CoffeeShopManagement.Report
{
    public partial class FormReportDanhSachNhanVien : Form
    {
        FormLock khoa;
        public FormReportDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormReportDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            this.reportViewer.LocalReport.ReportEmbeddedResource = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\ReportDanhSachNhanVien.rdlc";
            this.reportViewer.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\ReportDanhSachNhanVien.rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
            var dt = GetDataTableNHANVIEN();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("NHANVIEN", dt));
            dt = GetDataTableQUAN();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("QUAN", dt));
            dt = GetDataTableDATENOW();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DATENOW", dt));
            this.reportViewer.RefreshReport();
        }

        public DataTable GetDataTableQUAN()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select TENQUAN, LINK, DIACHI, LOICHAO, WIFI from QUAN";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableQuan";
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
        }

        public DataTable GetDataTableMON()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select MAMON, TENMON, DVT, GIA, SOLANPHUCVU from MON where TINHTRANG = 1";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableMON";
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
        }

        public DataTable GetDataTableNHANVIEN()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select MANV, HOTEN, DCHI, CONVERT(NVARCHAR(10),DAY(NGVL)) + '/' " +
                $"+ CONVERT(NVARCHAR(10),MONTH(NGVL)) + '/' + CONVERT(NVARCHAR(10),YEAR(NGVL)) AS NGVL, " +
                $"SDT, CMND, GIOITINH, LUONG, CHUCVU from NHANVIEN, TAIKHOAN where TINHTRANG = 1 and MANV = ID";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableNHANVIEN";
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
        }

        public DataTable GetDataTableDATENOW()
        {
            var dt = new DataTable(Name);
            dt.TableName = "DataTableDATENOW";
            dt.Columns.Add("DATE");
            dt.Rows.Add("Xuất ngày  " + new DateTime().GetDate(DateTime.Now));
            return dt;
        }

        private void FormReportDanhSachNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
