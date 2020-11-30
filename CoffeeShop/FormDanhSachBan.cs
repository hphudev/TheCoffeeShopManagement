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
    public partial class FormDanhSachBan : System.Windows.Forms.Form
    {
        FormLock BangKhoa;
        List<Table> Tables;
        FormSell parent;
        public FormDanhSachBan(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            //this.WindowState = FormWindowState.Maximized;
            this.Tables = this.parent.Tables;
            this.BangKhoa = new FormLock(this);
            this.BangKhoa.Show();
            this.Show();
        }

        private void F_DanhSachBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BangKhoa.Close();
        }

        private void FormDanhSachBan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Tables.Count; i++)
                flpTable.Controls.Add(Tables[i]);
        }
    }
}
