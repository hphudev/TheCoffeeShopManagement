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
    public partial class FormChinhSuaKhachHang : System.Windows.Forms.Form
    {
        private FormLock khoa;
        bool Permiss = false;
        FormSell parent;
        public FormChinhSuaKhachHang(FormSell parent)
        {
            InitializeComponent();
            tbDoanhSo.ReadOnly = true;
            tbSoLanToiQuan.ReadOnly = true;
            tbNgayDangKy.ReadOnly = true;
            tbThanhVien.ReadOnly = true;
            StatusTextCombo(false);
            this.FormBorderStyle = FormBorderStyle.None;
            this.parent = parent;
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChinhSuaKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khoa.Close();
        }

        private void StatusTextCombo(bool status)
        {
            Permiss = status;
            if (status == false)
            {
                lbMaKH.Text = "";
                tbSDT.Text = "";
                tbHoTen.Text = "";
                cbGioiTinh.Text = "";
                dtpNgaySinh.Text = "";
                dtpNgaySinh.Value = DateTime.Today;
                tbThanhVien.Text = "";
                tbNgayDangKy.Text = "";
                tbDiaChi.Text = "";
                tbSoLanToiQuan.Text = "";
                tbDoanhSo.Text = "";
            }
            tbSDT.ReadOnly = !status;
            tbHoTen.ReadOnly = !status;
            cbGioiTinh.Enabled = status;
            tbDiaChi.ReadOnly = !status;
        }

        private void TbTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader Reader = Data.ReadData("KHACHHANG", connection, $" WHERE SDT = '{tbTimKiemSDT.Text}' AND TINHTRANG = 1", " * ");
            if (Reader.HasRows)
            {
                while (Reader.HasRows)
                {
                    if (!Reader.Read())
                        break;
                    Permiss = true;
                    lbMaKH.Text = Reader.GetString(0);
                    tbSDT.Text = Reader.GetString(3);
                    tbHoTen.Text = Reader.GetString(1);
                    cbGioiTinh.Text = Reader.GetString(7);
                    dtpNgaySinh.Value = Reader.GetDateTime(4);
                    tbThanhVien.Text = (!Reader.IsDBNull(9)) ? Reader.GetString(9) : "";
                    tbNgayDangKy.Text = new DateTime().GetDate(Reader.GetDateTime(6));
                    tbDiaChi.Text = Reader.GetString(2);
                    tbSoLanToiQuan.Text = Reader.GetInt32(8).ToString();
                    tbDoanhSo.Text = Reader.GetInt32(5).ToString();
                    StatusTextCombo(true);
                }
            }
            else
            {
                StatusTextCombo(false);
                Permiss = false;
            }
            Data.CloseConnection(ref connection);
        }

        private bool CheckSDT(string SDT)
        {
            int i = Data.Calculate(" count ", " * ", " khachhang ", $" where SDT = '{tbSDT.Text}' and makh <> '{lbMaKH.Text}'");
            return (i <= 0);
        }

        private bool CheckGioiTinh(string gioitinh)
        {
            return (gioitinh == "Nam" || gioitinh == "Nữ");
        }

        public bool CheckYear(int year)
        {
            // true là năm nhuận, false là năm không nhuận
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        private bool CheckNgayThangNam (string day, string month, string year)
        {
            int iDay = int.Parse(day);
            int iMonth = int.Parse(month);
            int iYear = int.Parse(year);
            if (iMonth >= 8)
                return (iMonth % 2 == 0 && iDay <= 31) || (iMonth % 2 != 0 && iDay <= 30);
            else
                return  (iMonth == 2 && CheckYear(iYear) && iDay <= 29) 
                    || (iMonth == 2 && !CheckYear(iYear) && iDay <= 28)
                    || (iMonth != 2 && iMonth % 2 == 0 && iDay <= 30) 
                    || (iMonth != 2 && iMonth % 2 != 0 && iDay <= 31);
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            if (!Permiss)
            {
                IO.ExportWarning("Hãy tìm kiếm khách hàng trước khi cập nhật!");
                return;
            }
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
            if (!CheckNgayThangNam(dtpNgaySinh.Value.Day.ToString(), dtpNgaySinh.Value.Month.ToString(), dtpNgaySinh.Value.Year.ToString()))
            {
                IO.ExportError("Sai trường ngày sinh");
                return;
            }
            string date = dtpNgaySinh.Value.Year.ToString() + '/' + dtpNgaySinh.Value.Month.ToString() + '/' + dtpNgaySinh.Value.Day.ToString(); 
            Data.UpdateData("khachhang", $"hoten = N'{tbHoTen.Text}', dchi = N'{tbDiaChi.Text}', sdt = N'{tbSDT.Text}'" +
                $", ngaysinh = '{date}', gioitinh = N'{cbGioiTinh.Text}', loaikh = N'{tbThanhVien.Text}'", $" where makh = '{lbMaKH.Text}' ");
            IO.ExportSuccess("Cập nhật thành công!");
            tbTimKiemSDT.Text = "";
        }

        private void TbTimKiemSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TbTimKiemSDT_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TbTimKiemSDT_Enter(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "Số điện thoại")
            {
                tbTimKiemSDT.Text = "";
                tbTimKiemSDT.ForeColor = Color.Black;
            }
        }

        private void TbTimKiemSDT_Leave(object sender, EventArgs e)
        {
            if (tbTimKiemSDT.Text == "")
            {
                tbTimKiemSDT.Text = "Số điện thoại";
                tbTimKiemSDT.ForeColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void TbNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar);
        }

        private void TbThangSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar);
        }

        private void TbNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar);
        }

        private void BtQuanLi_Click(object sender, EventArgs e)
        {
            if (!this.parent.parent.account.IsAdmin())
            {
                IO.ExportWarning("Bạn không có quyền truy xuất tính năng này");
                return;
            }
            tbTimKiemSDT.Text = "";
            FormMenuCustomer cus = new FormMenuCustomer();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void LoadSomething()
        {
            lbMaKH.Text = "";
            tbSDT.Text = "";
            tbHoTen.Text = "";
            cbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            tbThanhVien.Text = "";
            tbNgayDangKy.Text = "";
            tbDiaChi.Text = "";
            tbSoLanToiQuan.Text = "";
            tbDoanhSo.Text = "";
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            tbTimKiemSDT.Text = "";
        }
    }
}
