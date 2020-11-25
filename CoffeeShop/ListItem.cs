using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Properties;

namespace CoffeeShop
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        #region Properties
        private string sTitle;
        private Image image;
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
        #endregion

        private void pbAnhMon_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void pbAnhMon_MouseHover(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.Silver;
        }

        private void pbAnhMon_MouseEnter(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.FromArgb(102, 217, 255);
        }

        private void pbAnhMon_MouseLeave(object sender, EventArgs e)
        {
            this.lbTenMon.BackColor = Color.Gainsboro;
        }

        private void lbTenMon_MouseEnter(object sender, EventArgs e)
        {
            pbAnhMon_MouseEnter(sender, e);
        }

        private void lbTenMon_MouseLeave(object sender, EventArgs e)
        {
            pbAnhMon_MouseLeave(sender, e);
        }
    }
}
