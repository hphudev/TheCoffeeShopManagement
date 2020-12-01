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
    public partial class FormIDTable : Form
    {
        FormOrder parent;
        FormLock Lock;
        public FormIDTable(FormOrder parent)
        {
            InitializeComponent();
            this.parent = parent;
            Lock = new FormLock(this);
            Lock.Show();
            this.Show();
        }

        private void TbIDTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            this.parent.idTable = tbIDTable.Text;
            this.Close();
        }

        private void FormIDTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Lock.Close();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
