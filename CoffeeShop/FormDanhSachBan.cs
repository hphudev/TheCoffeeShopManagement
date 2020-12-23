using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormDanhSachBan : Form
    {
        FormLock BangKhoa;
        List<Table> Tables;
        FormSell parent;
        Timer LoadDanhSachBan = new Timer();
        public FormDanhSachBan(FormSell parent)
        {
            InitializeComponent();
            //this.Opacity = 0;
            DoubleBuffered = true;
            this.parent = parent;
            //this.WindowState = FormWindowState.Maximized;
            //this.Tables = new List<Table>(this.parent.Tables);
            this.BangKhoa = new FormLock(this);
            this.BangKhoa.Show();
            this.BangKhoa.Hide();
            this.BangKhoa.Show();
            for (int i = 0; i < this.parent.Tables.Count; i++)
                this.flpTable.Controls.Add(this.parent.Tables[i]);
            LoadDanhSachBan.Interval = 2;
            LoadDanhSachBan.Tick += LoadSomethingPublic;
            LoadDanhSachBan.Start();
            //this.Opacity = 1;
        }

        private void F_DanhSachBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        public void LoadSomethingPublic(object sender, EventArgs e)
        {
            LoadDanhSachBan.Stop();
            this.flpTable.Controls.Clear();
            if (tbTimKiem.Text == "")
            {
                for (int i = 0; i < this.parent.Tables.Count; i++)
                    this.flpTable.Controls.Add(this.parent.Tables[i]);
                LoadDanhSachBan.Start();
                return;
            }
            for (int i = 0; i < this.parent.Tables.Count; i++)
            {
                string tmpParent = this.parent.Tables[i].ID.ToLower();
                string tmpChild = this.tbTimKiem.Text.ToLower();
                if (tmpParent.IndexOf(tmpChild) >= 0)
                    this.flpTable.Controls.Add(this.parent.Tables[i]);
            }
            LoadDanhSachBan.Start();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.parent.LoadSomeThingPublic();
            LoadDanhSachBan.Stop();
            this.flpTable.Controls.Clear();
            this.Close();
        }

        private void TbTimKiem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TbTimKiem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtThanhToan_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text == "")
            {
                IO.ExportWarning("Bạn chưa nhập ID bàn!");
                return;
            }
            foreach (var table in this.parent.Tables)
            {
                if (table.ID == tbTimKiem.Text)
                {
                    table.LbTable_Click(table, e);
                    return;
                }
            }
            IO.ExportWarning($"Không tìm thấy bàn có ID {tbTimKiem.Text}");
        }

        private void TbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
