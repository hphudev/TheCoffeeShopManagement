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
    public partial class FormAddObj : FormMain, IButtonOK, IImage, IError
    {
        protected FormMenu parent;

        public FormAddObj(FormMenu parent)
        {
            this.parent = parent;
        }

        public virtual void AddImageClicked(object sender, EventArgs e)
        {

        }

        public virtual bool IsError()
        {
            return false;
        }

        public virtual void AddObj()
        {

        }

        public void OKClicked(object sender, EventArgs e)
        {
            if (IsError())
            {
                return;
            }

            AddObj();
            this.parent.ClearMenu();
            this.parent.LoadMenu();
            Event.CloseForm(this);
        }

    }
}
