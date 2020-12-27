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
using System.Threading;

namespace CoffeeShopManagement
{
    public partial class FormMenuCustomer : Form
    {
        string condition;
        string columns;
        bool bTextChange = true;
        FormLock khoa;
        public FormMenuCustomer()
        {
            InitializeComponent();
            this.dgvMenu.MultiSelect = false;
            //khoa = new FormLock(this);
            //khoa.Show();
        }

        public void FormMenuCustomer_Load(object sender, EventArgs e)
        {
            condition = "where TINHTRANG = 1";
            columns = "*";
            dgvMenu.Rows.Clear();
            CallBackgroundWorker();
        }

        private void CallBackgroundWorker()
        {
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }
        private void LoadData(string conditon)
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData(" KHACHHANG ", con, condition, $" {columns} ");
            int count = Data.Calculate("count", " * ", "KHACHHANG", condition);
            int dem = 0;
            while (read.HasRows)
            {
                dem++;
                if (!read.Read())
                    return;
                Invoke((MethodInvoker)delegate
               {
                   dgvMenu.Rows.Add(read.GetString(0), read.GetString(1), read.GetString(7),
                    new DateTime().GetDate(read.GetDateTime(4)), read.GetString(3), read.GetString(2),
                    read.GetString(9), new DateTime().GetDate(read.GetDateTime(6)), read.GetInt32(8), read.GetInt32(5));
               });
                backgroundWorker.ReportProgress((dem * 100) / count);
            }
            Data.CloseConnection(ref con);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadData(condition);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void TbTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "Số điện thoại" || !bTextChange)
            {
                bTextChange = true;
                return;
            }
            dgvMenu.Rows.Clear();
            condition = $" where SDT like '%{tbTimKiemSDT.Text}%' and TINHTRANG = 1";
            columns = "*";
            CallBackgroundWorker();
        }

        private void TbTimKiemSDT_Enter(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "Số điện thoại")
            {
                bTextChange = false;
                tbTimKiemSDT.Text = "";
            }
        }

        private void TbTimKiemSDT_Leave(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "")
            {
                tbTimKiemSDT.Text = "Số điện thoại";
            }
        }

        private void BChangeInfoCus_Click(object sender, EventArgs e)
        {
            FormChangeInfoCustomerFromManager cus = new FormChangeInfoCustomerFromManager(this, dgvMenu.SelectedRows[0]);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void DeleteRow()
        {
            SqlConnection con = Data.OpenConnection();
            Data.UpdateData("KHACHHANG", " TINHTRANG = 0 ",$"where MAKH = '{dgvMenu.SelectedRows[0].Cells[0].Value.ToString()}'");
            Data.CloseConnection(ref con);
            this.FormMenuCustomer_Load(this, new EventArgs());
            IO.ExportSuccess("Xóa thành công");
        }

        private void DgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DeleteRow();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            khoa.Close();
            this.Close();
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            Report.FormReportDanhSachKhachHang cus =  new Report.FormReportDanhSachKhachHang();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }
    }
}
