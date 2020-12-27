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
namespace CoffeeShopManagement
{
    public partial class FormCaiDatThongBao : Form
    {
        FormLock khoa;
        Timer check = new Timer();
        public FormCaiDatThongBao()
        {
            InitializeComponent();
            check.Interval = 10;
            check.Tick += (s, e) =>
            {
                lbKyTu.Text = tbNoiDung.Text.Length.ToString() + " ký tự";
                if (tbNoiDung.Text.Length > 2000)
                    tbNoiDung.ReadOnly = true;
                else
                    tbNoiDung.ReadOnly = false;
            };
            check.Start();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            if (btGuiThongBao.Checked)
            {
                Data.UpdateData("THONGBAO", $"NOIDUNG = N'{tbNoiDung.Text}', TINHTRANG = 1, TINHTRANGXEM = 0", "");
            }
            else
            {
                Data.UpdateData("THONGBAO", $"NOIDUNG = N'{tbNoiDung.Text}', TINHTRANG = 0, TINHTRANGXEM = 1", "");
            }
            if (btKhuyenMai.Checked)
            {
                if (tbGiamGia.Text == "0" || tbGiaToiDa.Text == "0" || tbGiamGia.Text == "" || tbGiaToiDa.Text == "")
                {
                    IO.ExportError("Nội dung khuyến mãi chưa đúng");
                    return;
                }
                Data.UpdateData("KHUYENMAI", $"PHANTRAMKM = '{tbGiamGia.Text}', TINHTRANGKM = 1", "");
                if (btToiDa.Checked)
                {
                    Data.UpdateData("KHUYENMAI", $"TIENTOIDA = '{tbGiaToiDa.Text}', TINHTRANGTIENTOIDA = 1", "");
                }
                else
                {
                    Data.UpdateData("KHUYENMAI", "TINHTRANGTIENTOIDA = 0", "");
                }
            }
            else
            {
                Data.UpdateData("KHUYENMAI", "TINHTRANGKM = 0", "");
                Data.UpdateData("KHUYENMAI", "TINHTRANGTIENTOIDA = 0", "");
            }
            //FormCaiDatThongBao_Load(this, new EventArgs());
            check.Stop();
            this.khoa.Close();
            this.Close();
        }

        private void TbGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbGiaToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormCaiDatThongBao_Load(object sender, EventArgs e)
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData("THONGBAO", con, "", "*");
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                tbNoiDung.Text = read.GetString(0);
                btGuiThongBao.Checked = read.GetBoolean(1);
            }
            Data.CloseConnection(ref con);

            con = Data.OpenConnection();
            read = Data.ReadData("KHUYENMAI", con, "", "*");
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                tbGiamGia.Text = read.GetInt32(0).ToString();
                btKhuyenMai.Checked = read.GetBoolean(1);
                tbGiaToiDa.Text = read.GetInt32(2).ToString();
                btToiDa.Checked = read.GetBoolean(3);
            }
            Data.CloseConnection(ref con);
        }

        private void BtToiDa_CheckedChanged(object sender, EventArgs e)
        {
            tbGiaToiDa.ReadOnly = !btToiDa.Checked;
        }

        private void BtKhuyenMai_CheckedChanged(object sender, EventArgs e)
        {
            this.pnKhuyenMai.Visible = btKhuyenMai.Checked;
        }

        private void BtCapNhat_Click(object sender, EventArgs e)
        {
            if (btGuiThongBao.Checked)
            {
                Data.UpdateData("THONGBAO", $"NOIDUNG = N'{tbNoiDung.Text}', TINHTRANG = 1, TINHTRANGXEM = 0", "");
            }
            else
            {
                Data.UpdateData("THONGBAO", $"NOIDUNG = N'{tbNoiDung.Text}', TINHTRANG = 0, TINHTRANGXEM = 1", "");
            }
            if (btKhuyenMai.Checked)
            {
                if (tbGiamGia.Text == "0" || tbGiaToiDa.Text == "0" || tbGiamGia.Text == "" || tbGiaToiDa.Text == "")
                {
                    IO.ExportError("Nội dung khuyến mãi chưa đúng");
                    return;
                }
                Data.UpdateData("KHUYENMAI", $"PHANTRAMKM = '{tbGiamGia.Text}', TINHTRANGKM = 1", "");
                if (btToiDa.Checked)
                {
                    Data.UpdateData("KHUYENMAI", $"TIENTOIDA = '{tbGiaToiDa.Text}', TINHTRANGTIENTOIDA = 1", "");
                }
                else
                {
                    Data.UpdateData("KHUYENMAI", "TINHTRANGTIENTOIDA = 0", "");
                }
            }
            else
            {
                Data.UpdateData("KHUYENMAI", "TINHTRANGKM = 0", "");
                Data.UpdateData("KHUYENMAI", "TINHTRANGTIENTOIDA = 0", "");
            }
            FormCaiDatThongBao_Load(this, new EventArgs());
            IO.ExportSuccess("TÒ TÒ TÒ TEEEEEE");
        }
    }
}
