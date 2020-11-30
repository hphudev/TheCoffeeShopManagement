﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CoffeeShopManagement
{
    public partial class FormChinhSuaKhachHang : System.Windows.Forms.Form
    {
        private FormLock khoa;
        bool Permiss = false;
        public FormChinhSuaKhachHang()
        {
            InitializeComponent();
            tbDoanhSo.ReadOnly = true;
            tbSoLanToiQuan.ReadOnly = true;
            tbNgayDangKy.ReadOnly = true;
            StatusTextCombo(false);
            this.FormBorderStyle = FormBorderStyle.None;
            khoa = new FormLock(this);
            khoa.Show();
            this.Show();
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
                tbNgaySinh.Text = "";
                tbThanhVien.Text = "";
                tbNgayDangKy.Text = "";
                tbDiaChi.Text = "";
                tbSoLanToiQuan.Text = "";
                tbDoanhSo.Text = "";
            }
            tbSDT.ReadOnly = !status;
            tbHoTen.ReadOnly = !status;
            cbGioiTinh.Enabled = status;
            tbNgaySinh.ReadOnly = !status;
            tbThanhVien.ReadOnly = !status;
            tbDiaChi.ReadOnly = !status;
        }

        private void TbTimKiemSDT_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader Reader = Data.ReadData("KHACHHANG", connection, $" WHERE SDT = '{tbTimKiemSDT.Text}'", " * ");
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
                    tbNgaySinh.Text = new DateTime().GetDate(Reader.GetDateTime(4));
                    tbThanhVien.Text = Reader.GetString(9);
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
            int i = Data.Calculate(" count ", " * ", " khachhang ", $" where SDT = '{int.Parse(SDT)}' and makh <> '{lbMaKH.Text}'");
            return (i == 0);
        }

        private bool CheckGioiTinh(string gioitinh)
        {
            return (gioitinh == "Nam" || gioitinh == "Nữ");
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            if (!Permiss)
            {
                IO.ExportWarning("Hãy tìm kiếm khách hàng trước khi cập nhật!");
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
            string[] dates = tbNgaySinh.Text.Split('/');
            string date = dates[2] + '/' + dates[1] + '/' + dates[0]; 
            Data.UpdateData("khachhang", $"hoten = N'{tbHoTen.Text}', dchi = N'{tbDiaChi.Text}', sdt = N'{tbSDT.Text}'" +
                $", ngaysinh = '{date}', gioitinh = N'{cbGioiTinh.Text}', loaikh = N'{tbThanhVien.Text}'", $" where makh = '{lbMaKH.Text}' ");
            IO.ExportSuccess("Cập nhật thành công!");
        }

        private void TbTimKiemSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TbTimKiemSDT_MouseEnter(object sender, EventArgs e)
        {

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
    }
}
