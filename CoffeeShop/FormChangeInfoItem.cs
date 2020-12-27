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

namespace CoffeeShopManagement
{
    public partial class FormChangeInfoItem : Form
    {
        private FormMenuItem parent;
        private FormLock lockForm;

        public void Autofill()
        {
            try
            {
                Item selectedItem;
                this.parent.GetSelectedInfo(out selectedItem);
                this.tbName.Text = selectedItem.name;
                this.tbPrice.Text = selectedItem.price.ToString();
                this.tbUnit.Text = selectedItem.unit;
                this.lID.Text = selectedItem.id.ToString();
                this.pbImageItem.Image = selectedItem.image;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 33 Form Change Info Item)");
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
                IO.ExportError("Lỗi không xác định\n(Line 58 Form Change Info Item)");
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

                Item selectedItem;
                this.parent.GetSelectedInfo(out selectedItem);
                Item updatedItem = new Item(selectedItem.id.ToString(), selectedItem.name,
                    tbUnit.Text, selectedItem.numberOfServings, int.Parse(tbPrice.Text), true);

                Data.UpdateData("MON", "DVT = '" + updatedItem.unit + "', GIA = '" +
                    updatedItem.price + "'", " WHERE MAMON = '" + selectedItem.id.ToString() + "'");
                IO.ExportSuccess("Sửa món thành công");
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 102 Form Change Info Item)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            try
            {
                Item selectedItem;
                this.parent.GetSelectedInfo(out selectedItem);
                Event.AddImage(ref this.pbImageItem, "./ImageItem/", selectedItem.id.ToString());
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 116 Form Change Info Item)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
    }
}
