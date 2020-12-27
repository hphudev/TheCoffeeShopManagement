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
using System.Security.Cryptography;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class FormAddStaff : Form
    {
        #region Attributes
        private FormLock lockForm;
        private FormMenuStaff parent;
        #endregion

        #region Operations
        public FormAddStaff(FormMenuStaff parent)
        {
            try
            {
                InitializeComponent();
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                this.parent = parent;
                this.FormClosed += CloseForm;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.bReset.Click += ResetClicked;

                this.tbName.KeyPress += PressEnter;
                this.tbAddress.KeyPress += PressEnter;
                this.tbCMND.KeyPress += PressEnter;
                this.cbSex.KeyPress += PressEnter;
                this.cbPosition.KeyPress += PressEnter;
                this.tbPassword.KeyPress += PressEnter;
                this.tbSalary.KeyPress += PressEnter;
                this.tbSDT.KeyPress += PressEnter;
                this.tbUsername.KeyPress += PressEnter;

                this.cbSex.AutoCompleteCustomSource.AddRange(new string[] { "Nam", "Nữ" });
                this.cbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                this.cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
                this.bAddImage.Click += AddImageClicked;
                this.tbCMND.KeyPress += IO.LockWord;
                this.tbSDT.KeyPress += IO.LockWord;
                this.tbSalary.KeyPress += IO.LockWord;
                this.tbName.KeyPress += IO.LockNumber;
                this.cbSex.KeyPress += IO.LockNumber;
                this.cbPosition.KeyPress += IO.LockNumber;
                this.lID.Text = ID.FindNewID("NHANVIEN", " ORDER BY MANV DESC", "MANV", "NV",
                    2).ToString();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 64 Form Add Staff)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            Event.AddImage(ref this.pbImage, "./ImageStaff/", ID.FindNewID("NHANVIEN",
                    " ORDER BY MANV DESC", "MANV", "NV", 2).ToString());
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.lockForm);
            Event.ShowForm(this.parent);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.tbCMND.Text = "";
            this.cbSex.Text = "";
            this.cbPosition.Text = " ";
            this.tbSDT.Text = "";
            this.tbSalary.Text = "";
            this.tbPassword.Text = "";
            this.tbConfirm.Text = "";
            this.tbUsername.Text = "";
            this.tbAddress.Text = "";
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public bool IsError()
        {
            if (this.tbName.Text == "" || this.tbAddress.Text == "" || this.tbSDT.Text == "" ||
                    this.tbCMND.Text == "" || this.cbSex.Text == "" || this.tbSalary.Text == "" ||
                    this.cbPosition.Text == "" || this.tbUsername.Text == "" ||
                    this.tbPassword.Text == "" || this.tbConfirm.Text == "")
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

                if (this.tbConfirm.Text != this.tbPassword.Text)
                {
                    IO.ExportError("Mật khẩu nhập lại không đúng");
                    return;
                }

                Staff newStaff = new Staff("", this.tbName.Text, this.tbAddress.Text, this.tbSDT.Text,
                    this.cbSex.Text, DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() +
                    "/" + DateTime.Today.Day.ToString(), this.tbCMND.Text, this.cbPosition.Text,
                    int.Parse(this.tbSalary.Text));
                int flag = Staff.IsStaff(ref newStaff);
                Account newAccount = new Account(newStaff.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                    true);
                Account activeAccount = this.parent.parent.parent.account;
                Event.AddStaff(newStaff, flag, newAccount, activeAccount);

                if (flag != 0)
                {
                    this.parent.ClearMenu();
                    this.parent.LoadMenu();
                    Event.ShowForm(this.parent);
                    Event.CloseForm(this);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 154 Form Add Staff)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
