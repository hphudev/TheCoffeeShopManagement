using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CoffeeShopManagement;
using BUS;
using DTO;
using DAO;

namespace GUI
{
    public partial class FormAddItem : Form
    {
        #region Attributes
        private FormLock lockForm;
        private FormMenuItem parent;
        #endregion

        #region Operations
        public FormAddItem(FormMenuItem parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);

                this.tbName.KeyPress += PressEnter;
                this.tbPrice.KeyPress += PressEnter;
                this.cbUnit.KeyPress += PressEnter;
                this.FormClosed += CloseForm;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.bAddImage.Click += AddImageClicked;
                this.tbPrice.KeyPress += IO.LockWord;
                this.lID.Text = ID.FindNewID("MON", " ORDER BY MAMON DESC", "MAMON", "M",
                    3).ToString();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 49 Form Add Item)");
            }

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
            Event.CloseForm(this.lockForm);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public bool IsError()
        {
            if (this.tbPrice.Text == "" || this.tbName.Text == "" || this.cbUnit.Text == ""
                    || this.pbImageItem.Image == null)
            {
                IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                return true;
            }

            return false;
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (IsError())
                {
                    return;
                }

                Event.AddItem(this.tbName.Text, this.cbUnit.Text, int.Parse(this.tbPrice.Text));
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                this.parent.parent.LoadSomeThingPublic();
                Event.ShowForm(this.parent);
                this.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 100 Form Add Item)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            Event.AddImage(ref this.pbImageItem, "./ImageItem/", ID.FindNewID("MON",
                " ORDER BY MAMON DESC", "MAMON", "M", 3).ToString());
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
