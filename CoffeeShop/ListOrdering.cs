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

namespace GUI
{
    public partial class ListOrdering : UserControl
    {
        public List<ListOrder> Ordering;
        FormSell parent;
        private string info;
        private string id;
        public string Info
        {
            get => info;
            set
            {
                info = value;
                lbThongTin.Text = value;
            }
        }
        public string ID
        {
            get => id;
            set
            {
                id = value;
                lbID.Text = value;
            }
        }
        public ListOrdering(FormSell parent)
        {
            InitializeComponent();
            this.parent = parent;
            Ordering = new List<ListOrder>(this.parent.Orders);
            //this.parent.LoadSomeThingPublic();
        }

        private void LbThongTin_Click(object sender, EventArgs e)
        {
            //this.parent.LoadSomeThingPublic();
            this.parent.Orders = new List<ListOrder>(this.Ordering);
        }
    }
}
