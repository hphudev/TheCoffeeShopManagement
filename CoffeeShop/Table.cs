using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopManagement.Properties;

namespace CoffeeShopManagement
{
    public partial class Table : UserControl
    {
        public List<ListOrder> Orders;
        public Customer cus;
        public int index;
        FormSell parent;
        private string id;
        public string ID
        {
            get => id;
            set
            {
                id = value; lbTable.Text = value;
            }
        }
        public Table(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
            this.cus = this.parent.cus;
            this.Orders = new List<ListOrder>(this.parent.Orders);
        }

        public Table(FormSell parent, Table t)
        {
            InitializeComponent();
            this.parent = t.parent;
            this.cus = this.parent.cus;
            this.Orders = new List<ListOrder>(t.parent.Orders);
            this.index = t.index;
        }

        public void LoadSomeThingPublic()
        {
            int sum = 0;
            foreach (var item in this.Orders)
            {
                sum += item.TongTien;
            }
            lbTongTien.Text = Utility.StringToMoney(sum.ToString());
        }

        private void Table_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGreen;
        }

        private void Table_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumSeaGreen;
        }

        private void LbTable_MouseEnter(object sender, EventArgs e)
        {
            this.lbTable.BackColor = Color.PaleGreen;
        }

        private void LbTable_MouseLeave(object sender, EventArgs e)
        {
            this.lbTable.BackColor = Color.MediumSeaGreen;
        }

        public void LbTable_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Bạn có muốn thanh toán bàn {this.ID} không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
                return;
            this.parent.LoadSomeThingPublic();
            this.parent.TableChoice = new Table(this.parent, this);
            this.parent.cus = cus;
            this.parent.Orders = new List<ListOrder>(this.Orders);
        }
    }
}
