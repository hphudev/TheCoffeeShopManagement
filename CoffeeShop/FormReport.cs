using Microsoft.Reporting.WinForms;
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
    public partial class FormReport : Form
    {
        string id_invoice = "";
        string id_Admin = "";
        FormLock khoa;
        public FormReport(string invoice, string admin)
        {
            InitializeComponent();
            this.id_invoice = invoice;
            this.id_Admin = admin;
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var dt = GetDataTableCTHD();
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            reportViewer.ProcessingMode = ProcessingMode.Local;
            this.reportViewer.LocalReport.ReportEmbeddedResource = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Report\ReportPhieuThanhToan.rdlc";
            this.reportViewer.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Report\ReportPhieuThanhToan.rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CTHD",dt));
            dt = GetDataTableQUAN();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("QUAN", dt));
            dt = GetDataTableHOADON();
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("HOADON", dt));
            this.reportViewer.RefreshReport();
        }

        public DataTable GetDataTableCTHD()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select  A.TENMON, B.SL, A.GIA, (B.SL * A.GIA) as THANHTIEN from MON A, CTHD B where (A.MAMON = B.MAMON) and (B.SOHD = '{this.id_invoice}')";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableCTHD";
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
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

        public DataTable GetDataTableHOADON()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select TRIGIA, GIAMGIA, TRIGIA - GIAMGIA AS THANHTOAN, MANV, CONVERT(NVARCHAR(10),DAY(NGHD)) + '/' + CONVERT(NVARCHAR(10),MONTH(NGHD)) + '/' + CONVERT(NVARCHAR(10),YEAR(NGHD)) AS NGHD, SOHD," +
                $"TIENMAT, TIENMAT - TRIGIA + GIAMGIA AS TIENTHOILAI FROM HOADON " +
                $"where SOHD = '{this.id_invoice}'";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            dt.TableName = "DataTableHoaDon";
            adapt.Fill(dt);
            if (id_Admin.Length > 0)
            {
                dt.Rows[0][3] = id_Admin;
            }
            Data.CloseConnection(ref con);
            return dt;
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
