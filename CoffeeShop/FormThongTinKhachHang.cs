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
using DTO;

namespace CoffeeShopManagement
{
    public partial class FormThongTinKhachHang : System.Windows.Forms.Form
    {
        FormLock BangKhoa;
        bool statusAdd = true;
        bool statusAddBefore = false;
        string soDienThoai;
        string hoTen;
        string gioiTinh;
        string ngaySinh;
        string thanhVien;
        string ngayDangKy;
        string diaChi;
        public string SoDienThoai
        {
            get => soDienThoai;
            set
            {
                soDienThoai = value;
                tbSoDienThoai.Text = value;
            }
        }
        public string id;
        public string HoTen 
        {
            set
            {
                hoTen = value;
                tbHoTen.Text = value;
            }
            get => hoTen; 
        }
        public string IDKH
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string GioiTinh 
        { 
            set
            {
                gioiTinh = value;
                cbGioiTinh.Text = value;
            }
            get => gioiTinh; 
        }
        public string NgaySinh 
        { 
            set
            {
                ngaySinh = value;
                if (ngaySinh.Length > 3)
                {
                    string[] date = ngaySinh.Split('/');
                    dtpNgaySinh.Value = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                }
                
            }
            get => ngaySinh;
        }
        public string ThanhVien 
        { 
            set
            {
                thanhVien = value;
                tbThanhVien.Text = value;
            }
            get => thanhVien;
        }
        public string DiaChi
        {
            set
            {
                diaChi = value;
                tbDiaChi.Text = value;
            }
            get => diaChi;
        }
        public string NgayDangKy
        {
            set
            {
                ngayDangKy = value;
                tbNgayDangKy.Text = value;
            }
            get => ngayDangKy;
        }

        private Timer CheckExists;
        FormSell parent;
        public FormThongTinKhachHang(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            tbNgayDangKy.ReadOnly = true;
            NgayDangKy = new DateTime().GetDate(DateTime.Now);
            tbThanhVien.ReadOnly = true;
            ThanhVien = "";
            //this.BangKhoa = new FormLock(this);
            //this.BangKhoa.Show();
            CheckExists = new Timer();
            CheckExists.Interval = 5;
            CheckExists.Tick += CheckExist;
            this.parent = parent;
            InitCustomer();
            //CheckExists.Start();
        }

        private void InitCustomer()
        {
            
            if (this.parent.cus.id.id != null || this.parent.cus.id.id != "")
            {
                this.SoDienThoai = this.parent.cus.sdt;
                this.HoTen = this.parent.cus.name;
                this.GioiTinh = this.parent.cus.sex;
                this.NgaySinh = this.parent.cus.NgaySinh;
                this.ThanhVien = this.parent.cus.ThanhVien;
                this.NgayDangKy = this.parent.cus.NgayDangKy;
                this.DiaChi = this.parent.cus.address;
            }
        }
        private void fThongTinKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        private void StatusTexbox(bool status)
        {
            tbHoTen.ReadOnly = tbThanhVien.ReadOnly = tbDiaChi.ReadOnly = !status;
            cbGioiTinh.Enabled = status;
        }

        private void CheckExist(object sender, EventArgs e)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader Reader =  Data.ReadData("KHACHHANG", connection, $" WHERE SDT = '{tbSoDienThoai.Text}'", " * ");
            if (Reader.HasRows)
            {
                statusAddBefore = statusAdd;
                statusAdd = false;
                CheckExists.Stop();
                while (Reader.HasRows)
                {
                    if (!Reader.Read())
                        break;
                    IDKH = Reader.GetString(0);
                    SoDienThoai = Reader.GetString(3);
                    HoTen = Reader.GetString(1);
                    GioiTinh = Reader.GetString(7);
                    NgaySinh = new DateTime().GetDate(Reader.GetDateTime(4));
                    ThanhVien = (!Reader.IsDBNull(9)) ? Reader.GetString(9) : "";
                    NgayDangKy = new DateTime().GetDate(Reader.GetDateTime(6));
                    DiaChi = Reader.GetString(2);
                    StatusTexbox(false);
                }
            }
            else
            {
                if (!statusAddBefore)
                {
                    HoTen = GioiTinh = NgaySinh = DiaChi = ThanhVien = "";
                    SqlConnection con = Data.OpenConnection();
                    SqlDataReader reader = Data.ReadData("LOAIKHACHHANG", con, "where TINHTRANG = 1 and TIENTICHLUY = 0", " * ");
                    while (reader.HasRows)
                    {
                        if (!reader.Read())
                            return;
                        ThanhVien = (!reader.IsDBNull(0)) ? reader.GetString(0) : "";
                        break;
                    }
                    NgayDangKy = new DateTime().GetDate(DateTime.Now);
                    StatusTexbox(true);
                }
                statusAddBefore = statusAdd;
                statusAdd = true;
            }
            Data.CloseConnection(ref connection);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.CheckExists.Stop();
            this.Close();
        }



        private bool DieuKienCapNhat()
        {
            if (tbSoDienThoai.Text == null || tbHoTen.Text == null || tbHoTen.Text == null || cbGioiTinh.Text == null
              )
            {
                IO.ExportWarning("Bạn đã chưa nhập đủ thông tin!");
                return false;
            }
            if (tbSoDienThoai.Text == "" || tbHoTen.Text == "" || tbHoTen.Text == "" || cbGioiTinh.Text == ""
               || tbThanhVien.Text == "")
            {
                IO.ExportWarning("Bạn đã chưa nhập đủ thông tin!");
                return false;
            }
            if (cbGioiTinh.Text != "Nam" && cbGioiTinh.Text != "Nữ")
            {
                IO.ExportError("Trường giới tính đã nhập sai!");
                return false;
            }
            return true;
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            if (!DieuKienCapNhat())
                return;
            this.parent.cus = new Customer(IDKH, this.tbHoTen.Text, tbDiaChi.Text, this.tbSoDienThoai.Text,this.cbGioiTinh.Text, new DateTime().GetDate(this.dtpNgaySinh.Value), this.tbNgayDangKy.Text, this.tbThanhVien.Text);
            if (!statusAdd)
                Data.UpdateData("KHACHHANG", " TINHTRANG = 1", $"WHERE MAKH = '{IDKH}'");
            if (statusAdd)
            {
                string count = (Data.Calculate("COUNT", "*", "KHACHHANG", "") + 1).ToString();
                IDKH = "KH" + count.PadLeft(4, '0');
                SoDienThoai = tbSoDienThoai.Text;
                HoTen = tbHoTen.Text;
                GioiTinh = cbGioiTinh.Text;
                NgaySinh = dtpNgaySinh.Value.Day.ToString() + '/' + dtpNgaySinh.Value.Month.ToString() + '/' + dtpNgaySinh.Value.Year.ToString();
                string date = dtpNgaySinh.Value.Year.ToString() + '/' + dtpNgaySinh.Value.Month.ToString() + '/' + dtpNgaySinh.Value.Day.ToString();
                DiaChi = tbDiaChi.Text;
                this.parent.cus = new Customer(IDKH, this.tbHoTen.Text, this.tbDiaChi.Text, this.tbSoDienThoai.Text, this.cbGioiTinh.Text, this.NgaySinh, this.tbNgayDangKy.Text, this.tbThanhVien.Text);
                Data.AddData("KHACHHANG", $"N'{IDKH}', N'{HoTen}', N'{DiaChi}', N'{SoDienThoai}', '{date}', 0, '{Utility.GetDateUS(NgayDangKy)}', N'{GioiTinh}', 0, NULL, 1");
            }
            this.Close();
        }

        private void TbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            CheckExists.Start();
        }

        private void TbNgaySinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void TbSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void TbThanhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);

        }

        private void CbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);

        }

        private void TbNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '/';
        }

        private void TbNgaySinh_KeyPress_1(object sender, KeyPressEventArgs e)
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

        public void SetLockForm(ref FormLock khoa)
        {
            this.BangKhoa = khoa;
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            this.SoDienThoai = this.parent.cus.sdt;
            this.HoTen = this.parent.cus.name;
            this.GioiTinh = this.parent.cus.sex;
            this.NgaySinh = this.parent.cus.NgaySinh;
            this.ThanhVien = this.parent.cus.ThanhVien;
            this.NgayDangKy = this.parent.cus.NgayDangKy;
            this.DiaChi = this.parent.cus.address;
        }
    }
}
