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
    public partial class FormMain : Form
    {
        #region Attributes
        protected FormLock lockForm;
        #endregion

        #region Operations
        public FormMain()
        {
            this.FormClosed += CloseForm;
        }

        public virtual void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        public void SetLockForm(ref FormLock lockForm)
        {
            this.lockForm = lockForm;
        }

        public void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.lockForm);
        }

        #endregion
    }
}
