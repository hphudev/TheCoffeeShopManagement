using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace CoffeeShopManagement
{
    public partial class FormSuaLoaiKhachHang : Form
    {
        FormLock khoa;
        DataGridView dgv;
        public FormSuaLoaiKhachHang(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuaLoaiKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            if (tbDoanhSo.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập đầy đủ các trường");
                return;
            }
            this.dgv.SelectedRows[0].SetValues(tbName.Text, tbDoanhSo.Text);
            Data.UpdateData("LOAIKHACHHANG", $"TIENTICHLUY = N'{tbDoanhSo.Text}'", $"where TENLKH = N'{tbName.Text}'");
            IO.ExportSuccess("Sửa loại thành viên thành công");
            this.Close();
        }

        private void FormSuaLoaiKhachHang_Load(object sender, EventArgs e)
        {
            tbName.Text = this.dgv.SelectedRows[0].Cells[0].Value.ToString();
            tbDoanhSo.Text = this.dgv.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
