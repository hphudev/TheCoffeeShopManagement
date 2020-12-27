using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace GUI.Report
{
    public partial class FormReportDanhSachKhachHang : Form
    {
        FormLock khoa;
        public FormReportDanhSachKhachHang()
        {
            InitializeComponent();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormReportDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            this.reportViewer.LocalReport.ReportEmbeddedResource = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\ReportDanhSachKhachHang.rdlc";
            this.reportViewer.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\ReportDanhSachKhachHang.rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
            var dt = GetDataTableKHACHHANG();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("KHACHHANG", dt));
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

        public DataTable GetDataTableKHACHHANG()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select MAKH, HOTEN, DCHI, SDT, " +
                $" CONVERT(NVARCHAR(10),DAY(NGAYSINH)) + '/' + CONVERT(NVARCHAR(10),MONTH(NGAYSINH)) + '/' + CONVERT(NVARCHAR(10),YEAR(NGAYSINH)) as NGAYSINH, " +
                $"DOANHSO, " +
                $"CONVERT(NVARCHAR(10),DAY(NGAYDK)) + '/' + CONVERT(NVARCHAR(10),MONTH(NGAYDK)) + '/' + CONVERT(NVARCHAR(10),YEAR(NGAYDK)) as NGAYDK, " +
                $"GIOITINH, SOLANTOIQUAN, LOAIKH from KHACHHANG where TINHTRANG = 1";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableKHACHHANG";
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

        private void FormReportDanhSachKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khoa.Close();
        }
    }
}
