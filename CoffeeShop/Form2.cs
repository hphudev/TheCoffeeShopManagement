using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.IsPassword)
            {
                tbMatKhau.IsPassword = false;
                pbEye.Image = Image.FromFile("./Resources/CloseEye.png");
            }
            else
            {
                tbMatKhau.IsPassword = true;
                pbEye.Image = Image.FromFile("./Resources/OpenEye.png");
            }
        }
    }
}
