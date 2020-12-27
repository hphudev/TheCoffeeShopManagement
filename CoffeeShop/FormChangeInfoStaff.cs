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

namespace GUI
{
    public partial class FormChangeInfoStaff : Form
    {
        #region Attributes
        private FormLock lockForm;
        private FormMenuStaff parent;
        private Staff selectedStaff;
        #endregion

        #region Operations
        public void Autofill()
        {
            try
            {
                Account selectedAccount = this.selectedStaff.GetAccount();
                this.tbName.Text = this.selectedStaff.name;
                this.tbAddress.Text = this.selectedStaff.address;
                this.tbCMND.Text = this.selectedStaff.cmnd;
                this.tbSalary.Text = this.selectedStaff.luong.ToString();
                this.tbSDT.Text = this.selectedStaff.sdt;
                this.cbPosition.Text = this.selectedStaff.chucVu;
                this.cbSex.Text = this.selectedStaff.sex;
                this.lID.Text = this.selectedStaff.id.ToString();
                this.tbUsername.Text = selectedAccount.username;
                this.pbImage.Image = this.selectedStaff.image;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 44 Form Change Info Staff)");
            }
        }

        public FormChangeInfoStaff(FormMenuStaff parent, Staff selectedStaff)
        {
            try
            {
                InitializeComponent();
                //lockForm = new FormLock(this);
                this.parent = parent;
                //Event.ShowForm(this.lockForm);
                this.bCancel.Click += CancelClicked;
                this.FormClosed += CloseForm;
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
                this.selectedStaff = selectedStaff;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 76 Form Change Info Staff)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            Event.AddImage(ref this.pbImage, "./ImageStaff/", this.selectedStaff.id.ToString());
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
            Event.CloseForm(this.lockForm);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            Autofill();
        }

        public bool IsError()
        {
            if (this.tbAddress.Text == "" || this.tbSDT.Text == "" || this.cbSex.Text == "" ||
                    this.tbSalary.Text == "" || this.cbPosition.Text == "" ||
                    this.tbPassword.Text == "")
            {
                IO.ExportError("Nhập không đầy đủ nội dung tất cả các trường");
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

                Staff updatedStaff = new Staff(this.selectedStaff.id.ToString(),
                    this.selectedStaff.name, this.tbAddress.Text, this.selectedStaff.sdt,
                    this.selectedStaff.sex, this.selectedStaff.date, this.selectedStaff.cmnd,
                    this.cbPosition.Text, int.Parse(this.tbSalary.Text));
                Account updatedAccount = new Account(this.selectedStaff.id.ToString(),
                    this.tbUsername.Text, Encrypt.ComputeHash(this.tbPassword.Text,
                    new SHA256CryptoServiceProvider()), true);
                Event.ChangeInfo(updatedStaff, updatedAccount);
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 140 Form Change Info Staff)");
            }
        }
        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
