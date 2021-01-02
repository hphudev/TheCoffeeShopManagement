using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace CoffeeShopManagement
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

        }

        public virtual void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        public void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

    }
}
