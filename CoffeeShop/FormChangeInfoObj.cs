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
    public partial class FormChangeInfoObj : FormMain, IFormMain, IImage, IError, IButtonOK
    {
        protected FormMenu parent;

        public FormChangeInfoObj(FormMenu parent)
        {
            this.parent = parent;
        }

        public virtual void Autofill()
        {

        }

        public virtual void AddImageClicked(object sender, EventArgs e)
        {

        }

        public virtual bool IsError()
        {
            return false;
        }

        public virtual void ChangeInfoObj()
        {

        }

        public void OKClicked(object sender, EventArgs e)
        {
            if (IsError())
            {
                return;
            }

            ChangeInfoObj();
            this.parent.ClearMenu();
            this.parent.LoadMenu();
            Event.CloseForm(this);
        }

    }
}
