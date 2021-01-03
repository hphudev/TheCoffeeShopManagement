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
    public partial class FormChangeInfoCustomerFromManager : Form
    {
        DataGridViewRow parent;
        FormMenuCustomer parentMenu;
        FormLock khoa;
        public FormChangeInfoCustomerFromManager(FormMenuCustomer parent,DataGridViewRow fromParent)
        {
            InitializeComponent();
            //khoa = new FormLock(this);
            //khoa.Show();
            tbDoanhSo.ReadOnly = true;
            tbSoLanToiQuan.ReadOnly = true;
            tbNgayDangKy.ReadOnly = true;
            tbThanhVien.ReadOnly = true;
            this.parent = fromParent;
            this.parentMenu = parent;
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private bool CheckSDT(string SDT)
        {
            int i = Data.Calculate(" count ", " * ", " khachhang ", $" where SDT = '{SDT}' and makh <> '{lbMaKH.Text}'");
            return (i <= 0);
        }

        private bool CheckGioiTinh(string gioitinh)
        {
            return (gioitinh == "Nam" || gioitinh == "Nữ");
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            if (tbSDT.Text.Length == 0)
            {
                IO.ExportError("Số điện thoại rỗng");
                return;
            }
            if (!CheckSDT(tbSDT.Text))
            {
                IO.ExportError("Trùng số điện thoại");
                return;
            }
            if (!CheckGioiTinh(cbGioiTinh.Text))
            {
                IO.ExportError("Sai trường giới tính");
                return;
            }
            string date = dtpNgaySinh.Value.Year.ToString() + '/' + dtpNgaySinh.Value.Month.ToString() + '/' + dtpNgaySinh.Value.Day.ToString();
            Data.UpdateData("khachhang", $"hoten = N'{tbHoTen.Text}', dchi = N'{tbDiaChi.Text}', sdt = N'{tbSDT.Text}'" +
                $", ngaysinh = '{date}', gioitinh = N'{cbGioiTinh.Text}', loaikh = N'{tbThanhVien.Text}'", $" where makh = '{lbMaKH.Text}' ");
            IO.ExportSuccess("Cập nhật thành công!");
            this.parentMenu.FormMenuCustomer_Load(this.parentMenu, new EventArgs());
            this.khoa.Close();
            this.Close();
        }

        private void LoadData()
        {
            this.lbMaKH.Text = this.parent.Cells[0].Value.ToString();
            this.tbHoTen.Text = this.parent.Cells[1].Value.ToString();
            this.cbGioiTinh.Text = this.parent.Cells[2].Value.ToString();

            string tmp = this.parent.Cells[3].Value.ToString();
            string[] tmps = tmp.Split('/');
            DateTime date = new DateTime(int.Parse(tmps[2]), int.Parse(tmps[1]), int.Parse(tmps[0]));
            this.dtpNgaySinh.Value = date;

            this.tbSDT.Text = this.parent.Cells[4].Value.ToString();
            this.tbDiaChi.Text = this.parent.Cells[5].Value.ToString();
            this.tbThanhVien.Text = this.parent.Cells[6].Value.ToString();
            this.tbNgayDangKy.Text = this.parent.Cells[7].Value.ToString();
            this.tbSoLanToiQuan.Text = this.parent.Cells[8].Value.ToString();
            this.tbDoanhSo.Text = this.parent.Cells[9].Value.ToString();
        }

        private void TbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormChangeInfoCustomerFromManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.khoa.Close();
            this.Close();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
