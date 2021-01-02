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
namespace CoffeeShopManagement
{
    public partial class FormThemLoaiKhachHang : Form
    {
        DataGridView parent;
        FormLock khoa;
        public FormThemLoaiKhachHang(DataGridView dtg)
        {
            InitializeComponent();
            this.parent = dtg;
        }

        private void TbWeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbDoanhSo.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập đầy đủ các trường");
                return;
            }
            this.parent.Rows.Add(tbName.Text, tbDoanhSo.Text);
            int count = Data.Calculate("count", " * ", "LOAIKHACHHANG", $"where TENLKH = N'{tbName.Text}' and TINHTRANG = 1");
            if (count > 0)
            {
                IO.ExportError("Loại khách hàng này đã tồn tại");
                return;
            }
            count = Data.Calculate("count", " * ", "LOAIKHACHHANG", $"where TENLKH = N'{tbName.Text}' and TINHTRANG = 0");
            if (count > 0)
                Data.UpdateData("LOAIKHACHHANG", $"TINHTRANG = 1, TIENTICHLUY = '{tbDoanhSo.Text}' ", $"where TENLKH = N'{tbName.Text}'");
            else
                Data.AddData("LOAIKHACHHANG", $"N'{tbName.Text}', '{tbDoanhSo.Text}', 1");
            IO.ExportSuccess("Thêm loại thành viên thành công");
            this.Close();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void FormThemLoaiKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.khoa.Close();
        }
    }
}
