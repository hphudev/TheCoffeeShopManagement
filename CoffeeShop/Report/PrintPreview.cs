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

namespace CoffeeShopManagement.Report
{
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            var dt = GetDataTableQUAN();
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            this.reportViewer1.LocalReport.ReportPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Report\ReportPhieuThanhToan.rdlc";
            //this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportDataset",dt));
            this.reportViewer1.RefreshReport();
        }

        public DataTable GetDataTable()
        {
            SqlConnection con = Data.OpenConnection();
            string sql = $"select  A.TENMON, B.SL, A.GIA, (B.SL * A.GIA) as THANHTIEN from MON A, CTHD B where (A.MAMON = B.MAMON) and (B.SOHD = 'HD0001')";
            var dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
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
            adapt.Fill(dt);
            Data.CloseConnection(ref con);
            return dt;
        }
    }
}
