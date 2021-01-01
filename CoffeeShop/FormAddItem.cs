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
using DTO;
using BUS;
using DAO;

namespace CoffeeShopManagement
{
    public partial class FormAddItem : FormItem, IImage
    {
        public FormAddItem(FormMenuItem parent) : base(parent)
        {
            try
            {
                InitializeComponent();
                this.tbName.KeyPress += PressEnter;
                this.tbPrice.KeyPress += PressEnter;
                this.cbUnit.KeyPress += PressEnter;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.bAddImage.Click += AddImageClicked;
                this.tbPrice.KeyPress += IO.LockWord;
                this.lID.Text = ID.FindNewID("MON", " ORDER BY MAMON DESC", "MAMON", "M", 
                    3).ToString();
                this.tbName.TabIndex = 0;
                this.cbUnit.TabIndex = 1;
                this.tbPrice.TabIndex = 2;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Add Item)");
            }

        }

        public void AddImageClicked(object sender, EventArgs e)
        {
            (new AddItem()).AddImageClicked(ref this.pbImageItem);
        }

        public override bool IsError()
        {
            if (this.tbPrice.Text == "" || this.tbName.Text == "" || this.cbUnit.Text == ""
                    || this.pbImageItem.Image == null)
            {
                IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                return true;
            }

            return false;
        }

        public override void ModifyObj()
        {
            Item newItem = new Item("", this.tbName.Text, this.cbUnit.Text, 0, 
                int.Parse(this.tbPrice.Text), true);

            if ((new AddItem()).AddNewObj(newItem))
            {
                this.parent.parent.LoadSomeThingPublic();
                Event.CloseForm(this);
            }
        }

    }
}
