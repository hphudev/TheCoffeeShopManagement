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
    public partial class FormInit : Form
    {
        Timer t = new Timer();
        public FormInit()
        {
            InitializeComponent();
            this.Opacity = 0;
            t.Interval = 1;
            t.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.0050;
                else
                {
                    t.Stop();
                    new FormLogin(this).Show();
                    this.Hide();
                }
            };
            t.Start();
        }

    }
}
