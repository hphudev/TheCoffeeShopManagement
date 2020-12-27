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
using DAO;
using BUS;

namespace GUI
{
    public partial class FormInfoStaff : Form
    {
        #region Atrributes
        private FormLock lockForm;
        private Account account;
        #endregion

        #region Operations
        public void Autofill()
        {
            try
            {
                Staff staff = this.account.GetOwner();
                this.account.id = staff.id;
                this.cbPosition.Text = staff.chucVu;
                this.tbCMND.Text = staff.cmnd;
                this.tbAddress.Text = staff.address;
                this.tbSalary.Text = staff.luong.ToString();
                this.tbName.Text = staff.name;
                this.tbSDT.Text = staff.sdt;
                this.tbUsername.Text = this.account.username;
                this.tbPassword.Text = "";
                this.lID.Text = staff.id.ToString();
                this.cbSex.Text = staff.sex;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 45 Form Image Staff)");
            }
        }

        public FormInfoStaff(Account account)
        {
            try
            {
                InitializeComponent();
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                this.account = account;
                Autofill();
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.FormClosed += CloseForm;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 64 Form Image Staff)");
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.lockForm);
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbPassword.Text == "")
                {
                    IO.ExportError("Mật khẩu không được để trống");
                    return;
                }

                Account updatedAccount = new Account(this.account.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                    true);
                Event.ChangePassword(updatedAccount);
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 96 Form Image Staff)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
