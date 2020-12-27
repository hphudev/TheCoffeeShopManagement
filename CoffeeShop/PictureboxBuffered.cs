using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoffeeShopManagement
{
    class PictureboxBuffered : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            base.OnPaint(e);
        }
    }
}
