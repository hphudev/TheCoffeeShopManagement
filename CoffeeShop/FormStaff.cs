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
    public partial class FormStaff : FormObj
    {
        public FormStaff()
        {

        }

        public FormStaff(FormMenu parent) : base(parent)
        {

        }

        public override void ClearMenu()
        {
            ((FormMenuStaff)this.parent).ClearMenu();
        }

    }
}
