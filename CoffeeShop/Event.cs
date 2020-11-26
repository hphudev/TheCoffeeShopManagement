using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public static class Event
    {
        public static void PressEnter(object sender, KeyPressEventArgs e, Form f)
        {
            if (e.KeyChar == '\r')
            {
                Control ctl = ((Control)sender).Parent;
                ctl.SelectNextControl(f.ActiveControl, true, true, true, true);
            }
        }

        public static void ShowError(Control c, ErrorProvider ep)
        {
            if (c.Text != "S" && c.Text != "M" && c.Text != "L")
            {
                ep.SetError(c, "Nội dung nhập không hợp lệ");
                ep.BlinkRate = 0;
            }
            else
            {
                ep.Clear();
            }
        }

        public static void ShowErrorValue(Control c, ErrorProvider ep, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                ep.SetError(c, "Nội dung nhập không hợp lệ");
                ep.BlinkRate = 0;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                ep.Clear();
            }
        }
    }
}
