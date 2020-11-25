using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace CoffeeShop
{
    public partial class F_BangKhoa : Form
    {
        dynamic parent;
        public F_BangKhoa(dynamic parent)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Opacity = 0.5;
            this.parent = parent;
            this.MouseClick += (s, e) =>
            {
                this.parent.BringToFront();
            };
            this.MouseDoubleClick += (s, e) =>
            {
                this.parent.BringToFront();
            };
        }
    }
}
