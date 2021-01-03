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
using DAO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormChangeInfoItem : FormItem, IImage, IAutofillForm
    {
        public FormChangeInfoItem(FormMenuItem parent) : base(parent)
        {
            try
            {
                InitializeComponent();
                Autofill();
                this.tbName.Enabled = false;

                this.tbPrice.KeyPress += PressEnter;
                this.tbUnit.KeyPress += PressEnter;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.bAddImage.Click += AddImageClicked;
                this.tbPrice.KeyPress += IO.LockWord;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Item)");
            }
        }

        public void Autofill()
        {
            try
            {
                Item selectedItem = (Item)((FormMenuItem)this.parent).GetSelectedObj();
                this.tbName.Text = selectedItem.name;
                this.tbPrice.Text = selectedItem.price.ToString();
                this.tbUnit.Text = selectedItem.unit;
                this.lID.Text = selectedItem.id.ToString();
                this.pbImageItem.Image = selectedItem.image;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Item)");
            }
        }

        public void AddImageClicked(object sender, EventArgs e)
        {
            Item selectedItem = (Item)((FormMenuItem)this.parent).GetSelectedObj();
            (new ChangeItem()).AddImageClicked(ref this.pbImageItem, selectedItem);
        }

        public override bool IsError()
        {
            if (this.tbPrice.Text == "" || this.tbUnit.Text == "" || this.tbName.Text == "")
            {
                IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                return true;
            }

            return false;
        }

        public override void ModifyObj()
        {
            Item selectedItem = (Item)((FormMenuItem)this.parent).GetSelectedObj();
            Item updatedItem = new Item(selectedItem.id.ToString(), this.tbName.Text, 
                this.tbUnit.Text, selectedItem.numberOfServings, int.Parse(this.tbPrice.Text),
                true);

            if ((new ChangeItem()).ChangeInfoObj(updatedItem))
            {
                this.parent.parent.LoadSomeThingPublic();
                Event.CloseForm(this);
            }
        }

    }
}
