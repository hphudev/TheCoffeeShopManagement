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
    public partial class FormInit : System.Windows.Forms.Form
    {
        Timer t = new Timer();
        FormLogin child;
        public FormInit()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Opacity = 0;
            t.Interval = 1;
            t.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.0050;
                else
                {
                    t.Stop();
                    this.WindowState = FormWindowState.Maximized;
                    child = new FormLogin(this);
                    child.Show();
                    //this.Hide();
                }
            };
            t.Start();
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            child.BringToFront();
        }
    }
}
