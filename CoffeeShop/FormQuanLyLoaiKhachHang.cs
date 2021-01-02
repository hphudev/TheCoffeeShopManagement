using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using System.Data.SqlClient;
namespace CoffeeShopManagement
{
    public partial class FormQuanLyLoaiKhachHang : Form
    {
        FormLock khoa;
        public FormQuanLyLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAddObj_Click(object sender, EventArgs e)
        {
            FormThemLoaiKhachHang cus = new FormThemLoaiKhachHang(this.dgvMenu);
            FormLock khoa = new FormLock();
            Event.ShowForm(khoa);
            Event.ShowForm(cus);
            cus.SetLockForm(ref khoa);
            khoa.SetLockParent(cus);
        }

        private void BChangeInfo_Click(object sender, EventArgs e)
        {
            if (this.dgvMenu.SelectedRows == null || this.dgvMenu.SelectedRows.Count == 0)
            {
                IO.ExportError("Bạn phải chọn dòng cần chỉnh sửa");
                return;
            }

            FormSuaLoaiKhachHang cus = new FormSuaLoaiKhachHang(this.dgvMenu);
            FormLock khoa = new FormLock();
            Event.ShowForm(khoa);
            Event.ShowForm(cus);
            cus.SetLockForm(ref khoa);
            khoa.SetLockParent(cus);
        }

        private void BDeleteObj_Click(object sender, EventArgs e)
        {
            if (this.dgvMenu.SelectedRows == null || this.dgvMenu.SelectedRows.Count == 0)
            {
                IO.ExportError("Bạn phải chọn dòng cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa dòng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Data.UpdateData("LOAIKHACHHANG", "TINHTRANG = 0", $"where TENLKH = N'{this.dgvMenu.SelectedRows[0].Cells[0].Value.ToString()}'");
            IO.ExportSuccess("Xóa thành công");
            this.dgvMenu.Rows.RemoveAt(this.dgvMenu.SelectedRows[0].Index);
        }

        private void FormQuanLyLoaiKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData("LOAIKHACHHANG", con, "where TINHTRANG = 1", " * ");
            while (read.HasRows)
            {
                if (!read.Read())
                    return;
                this.dgvMenu.Rows.Add(read.GetString(0), read.GetInt32(1).ToString());
            }
            Data.CloseConnection(ref con);
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormQuanLyLoaiKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
