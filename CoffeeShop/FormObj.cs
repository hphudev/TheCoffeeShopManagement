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
    public partial class FormObj : FormMain
    {
        protected FormMenu parent;

        public FormObj()
        {

        }

        public FormObj(FormMenu parent)
        {
            this.parent = parent;
        }

        public virtual bool IsError()
        {
            return false;
        }

        public virtual void ModifyObj()
        {

        }

        public virtual void ClearMenu()
        {

        }

        public void OKClicked(object sender, EventArgs e)
        {
            if (IsError())
            {
                return;
            }

            ModifyObj();
            ClearMenu();
            this.parent.LoadMenu();
        }

    }
}
