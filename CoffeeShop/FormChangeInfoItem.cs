using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class FormChangeInfoItem : Form
    {
        #region Attributes
        private FormMenuItem parent;
        private FormLock lockForm;
        #endregion

        #region Operations
        public void Autofill()
        {
            try
            {
                object tmp = null;
                Item selectedItem;
                Event.GetSelectedInfo(ref tmp, this.parent.GetSelectedRows());
                selectedItem = (Item)tmp;
                this.tbName.Text = selectedItem.name;
                this.tbPrice.Text = selectedItem.price.ToString();
                this.tbUnit.Text = selectedItem.unit;
                this.lID.Text = selectedItem.id.ToString();
                this.pbImageItem.Image = selectedItem.image;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 41 Form Change Info Item)");
            }
        }

        public FormChangeInfoItem(FormMenuItem parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                Autofill();
                this.tbName.Enabled = false;

                this.tbPrice.KeyPress += PressEnter;
                this.tbUnit.KeyPress += PressEnter;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.FormClosed += CloseForm;
                this.bAddImage.Click += AddImageClicked;
                this.tbPrice.KeyPress += IO.LockWord;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 66 Form Change Info Item)");
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
            Event.CloseForm(this.lockForm);
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (tbPrice.Text == "" || tbUnit.Text == "")
                {
                    IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                    return;
                }

                object tmp = null;
                Event.GetSelectedInfo(ref tmp, this.parent.GetSelectedRows());
                Item selectedItem = (Item)tmp;
                Item updatedItem = new Item(selectedItem.id.ToString(), selectedItem.name,
                    this.tbUnit.Text, selectedItem.numberOfServings, int.Parse(this.tbPrice.Text),
                    true);
                Event.ChangeInfo(updatedItem, null);
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 109 Form Change Info Item)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            object tmp = null;
            Event.GetSelectedInfo(ref tmp, this.parent.GetSelectedRows());
            Item selectedItem = (Item)tmp;
            Event.AddImage(ref this.pbImageItem, "./ImageItem/", selectedItem.id.ToString());
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
