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
    public partial class FormChangeInfoItem : Form
    {
        private FormMenuItem parent;
        private FormBangKhoa Lock;
        public FormChangeInfoItem(FormMenuItem parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.Lock = new FormBangKhoa(this);
            this.Lock.Show();
            this.Show();
        }

        private void FormChangeInfoItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Lock.Close();
            this.parent.Show();
        }
    }
}
