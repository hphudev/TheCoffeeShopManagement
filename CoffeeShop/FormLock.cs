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
namespace CoffeeShopManagement
{
    public partial class FormLock : System.Windows.Forms.Form
    {
        dynamic parent;
        public FormLock(dynamic parent)
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
