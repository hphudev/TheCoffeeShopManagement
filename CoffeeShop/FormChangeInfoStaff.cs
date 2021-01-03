using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DTO;
using DAO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormChangeInfoStaff : FormStaff, IImage, IAutofillForm, IButtonReset
    {
        public FormChangeInfoStaff(FormMenuStaff parent) : base(parent)
        {
            try
            {
                InitializeComponent();
                this.bCancel.Click += CancelClicked;
                this.bReset.Click += ResetClicked;
                Autofill();
                this.bOK.Click += OKClicked;

                this.tbAddress.KeyPress += PressEnter;
                this.cbPosition.KeyPress += PressEnter;
                this.tbSalary.KeyPress += PressEnter;
                this.tbSDT.KeyPress += PressEnter;
                this.bAddImage.Click += AddImageClicked;
                this.tbSalary.KeyPress += IO.LockWord;
                this.tbSDT.KeyPress += IO.LockWord;
                this.cbPosition.KeyPress += IO.LockNumber;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Staff)");
            }
        }

        public void Autofill() 
        {
            try
            {
                Staff selectedStaff = (Staff)((FormMenuStaff)this.parent).GetSelectedObj();
                Account selectedAccount = selectedStaff.GetAccount();
                this.tbName.Text = selectedStaff.name;
                this.tbAddress.Text = selectedStaff.address;
                this.tbCMND.Text = selectedStaff.cmnd;
                this.tbSalary.Text = selectedStaff.luong.ToString();
                this.tbSDT.Text = selectedStaff.sdt;
                this.cbPosition.Text = selectedStaff.chucVu;
                this.cbSex.Text = selectedStaff.sex;
                this.lID.Text = selectedStaff.id.ToString();
                this.tbUsername.Text = selectedAccount.username;
                this.pbImage.Image = selectedStaff.image;
                this.tbPassword.Text = this.tbConfirm.Text = selectedAccount.password;
                this.tbPassword.Enabled = this.tbConfirm.Enabled = false;
                this.tbEmail.Text = selectedAccount.email;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Staff)");
            }
        }

        public void AddImageClicked(object sender, EventArgs e)
        {
            Staff selectedStaff = (Staff)((FormMenuStaff)this.parent).GetSelectedObj();
            (new ChangeStaff()).AddImageClicked(ref this.pbImage, selectedStaff);
        }

        public void ResetClicked(object sender, EventArgs e)
        {
            Autofill();
        }

        public override bool IsError()
        {
            try
            {
                if (this.tbAddress.Text == "" || this.tbSDT.Text == "" || this.cbSex.Text == "" ||
                    this.tbSalary.Text == "" || this.cbPosition.Text == "" || 
                    this.tbPassword.Text == "" || this.tbEmail.Text == "" || this.tbCMND.Text == "" ||
                    this.tbConfirm.Text == "" || this.tbName.Text == "")
                {
                    IO.ExportError("Nhập không đầy đủ nội dung tất cả các trường");
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Staff)");
                return false;
            }
        }

        public override void ModifyObj()
        {
            Staff selectedStaff = (Staff)((FormMenuStaff)this.parent).GetSelectedObj();
            Staff updatedStaff = new Staff(selectedStaff.id.ToString(), this.tbName.Text,
                this.tbAddress.Text, this.tbSDT.Text, this.cbSex.Text, selectedStaff.date,
                this.tbCMND.Text, this.cbPosition.Text, int.Parse(this.tbSalary.Text));
            Account updatedAccount = new Account(selectedStaff.id.ToString(), this.tbUsername.Text,
                Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()), true, 
                this.tbEmail.Text, "");
            
            if ((new ChangeStaff()).ChangeInfoObj(updatedStaff, updatedAccount))
            {
                Event.CloseForm(this);
            }
        }

        private void BtThayDoi_CheckedChanged(object sender, EventArgs e)
        {
            if (btThayDoi.Checked)
            {
                //this.tbName.Enabled = true;
                this.tbPassword.Text = "";
                this.tbConfirm.Text = "";
                this.tbPassword.Enabled = true;
                this.tbConfirm.Enabled = true;
            }
            else
            {
                Staff selectedStaff = (Staff)((FormMenuStaff)this.parent).GetSelectedObj();
                Account selectedAccount = selectedStaff.GetAccount();
                //this.tbName.Enabled = false;
                this.tbPassword.Text = selectedAccount.password;
                this.tbConfirm.Text = selectedAccount.password;
                this.tbPassword.Enabled = false;
                this.tbConfirm.Enabled = false;
            }
        }

    }
}
