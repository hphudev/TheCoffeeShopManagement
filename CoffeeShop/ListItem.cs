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
    public partial class ListItem : UserControl
    {
        FormSell parent;
        public ListItem(FormSell parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.parent = parent;
        }
        #region Properties
        private string sTitle;
        private Image image;
        private int gia;
        private int times;
        private string idItem;

        [Category("Custom Pro")]
        public string ID
        {
            get { return idItem; }
            set { idItem = value;}
        }

        [Category("Custom Pro")]
        public string Title
        {
            get { return sTitle; }
            set { sTitle = value; lbTenMon.Text = value; }
        }
        
        [Category("Custom Pro")]
        public Image Image
        {
            get { return image; }
            set { image = value; pbAnhMon.Image = value; pbAnhMon.SizeMode = PictureBoxSizeMode.Zoom; }
        }

        [Category("Custom Pro")]
        public int Cost
        {
            get { return gia; }
            set
            {
                gia = value;
                if (value >= 1000)
                    lbCost.Text = (value % 1000 == 0) ? (value / 1000).ToString() + "K" : value.ToString();
                else
                    lbCost.Text = value.ToString();
            }
        }

        [Category("Custom Pro")]
        public int TimesChoice
        {
            get { return times; }
            set
            {
                 times = value;
            }
        }
        #endregion

        private void pbAnhMon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.parent.ItemsChoice.Contains(this))
            {
                this.parent.Choice = this;
                this.parent.ItemsChoice.Add(this);
                this.parent.ActionCheckOrder();
            }
        }

        private void pbAnhMon_MouseHover(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.DarkSalmon;
        }

        private void pbAnhMon_MouseEnter(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.FromArgb(102, 217, 255);
        }

        private void pbAnhMon_MouseLeave(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.DarkSalmon;
        }

        private void lbTenMon_MouseEnter(object sender, EventArgs e)
        {
            pbAnhMon_MouseEnter(sender, e);
        }

        private void lbTenMon_MouseLeave(object sender, EventArgs e)
        {
            pbAnhMon_MouseLeave(sender, e);
        }

        private void LbTenMon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.parent.ItemsChoice.Contains(this))
            {
                this.parent.Choice = this;
                this.parent.ItemsChoice.Add(this);
                this.parent.ActionCheckOrder();
            }
        }
    }
}
