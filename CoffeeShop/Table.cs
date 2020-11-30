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
        }

        private void LbTable_MouseClick(object sender, MouseEventArgs e)
        {
            this.parent.LoadSomeThingPublic();
            this.parent.TableChoice = new Table(this.parent, this);
            this.parent.cus = cus;
            this.parent.Orders = new List<ListOrder>(this.Orders);
        }
    }
}
