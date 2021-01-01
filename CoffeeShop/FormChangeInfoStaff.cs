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
    public partial class FormChangeInfoStaff : FormChangeInfoObj
    {
        #region Operations
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

        public override void Autofill() 
        {
            try
            {
                Staff selectedStaff = (Staff)this.parent.GetSelectedObj();
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
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Change Info Staff)");
            }
        }

        public override void AddImageClicked(object sender, EventArgs e)
        {
            Staff selectedStaff = (Staff)this.parent.GetSelectedObj();
            (new ChangeStaff()).AddImageClicked(ref this.pbImage, selectedStaff);
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            Autofill();
        }

        public override bool IsError()
        {
            try
            {
                if (this.tbAddress.Text == "" || this.tbSDT.Text == "" || this.cbSex.Text == "" ||
                    this.tbSalary.Text == "" || this.cbPosition.Text == "" || this.tbPassword.Text == "")
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

        public override void ChangeInfoObj()
        {
            Staff selectedStaff = (Staff)this.parent.GetSelectedObj();
            Staff updatedStaff = new Staff(selectedStaff.id.ToString(), selectedStaff.name,
                tbAddress.Text, selectedStaff.sdt, selectedStaff.sex, selectedStaff.date,
                selectedStaff.cmnd, this.cbPosition.Text, int.Parse(this.tbSalary.Text));
            Account updatedAccount = new Account(selectedStaff.id.ToString(), this.tbUsername.Text,
                Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()), true);
            (new ChangeStaff()).ChangeInfoObj(updatedStaff, updatedAccount);
        }

        #endregion
    }
}
