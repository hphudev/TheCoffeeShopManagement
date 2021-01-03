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
using DAO;
using DTO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormInfoStaff : FormMain, IButtonOK, IAutofillForm
    {
        #region Attributes
        private Account account;
        #endregion

        #region Operations
        public void Autofill()
        {
            try
            {
                #region Code
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection, " WHERE " +
                    "NV.MANV = TK.ID AND TENDN = '" + this.account.username + "'", "*");
                reader.Read();
                Staff staff = Initialization.InitStaffFromReader(reader);
                this.account.id = staff.id;
                this.cbPosition.Text = staff.chucVu;
                this.tbCMND.Text = staff.cmnd;
                this.tbAddress.Text = staff.address;
                this.tbSalary.Text = staff.luong.ToString();
                this.tbName.Text = staff.name;
                this.tbSDT.Text = staff.sdt;
                this.tbUsername.Text = this.account.username;
                this.tbPassword.Text = this.tbConfirm.Text = this.account.password;
                this.tbEmail.Text = this.account.email;
                this.lID.Text = staff.id.ToString();
                this.cbSex.Text = staff.sex;
                this.pbStaff.Image = staff.image;
                #endregion
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Image Staff)");
            }
        }

        public FormInfoStaff(Account account)
        {
            try
            {
                #region Code
                InitializeComponent();
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                this.tbPassword.Enabled = false;
                this.tbConfirm.Enabled = false;
                this.account = account;
                Autofill();
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                #endregion
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Image Staff)");
            }
        }

        public void OKClicked(object sender, EventArgs e)
        {
            try
            {
                #region Code
                if (this.tbPassword.Text == "")
                {
                    IO.ExportError("Mật khẩu không được để trống");
                    return;
                }

                Account updatedAccount = new Account(this.account.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                    true, this.tbEmail.Text, "");
                if (!Account.IsEmail(updatedAccount.username, updatedAccount.email))
                {
                    IO.ExportWarning("Email này đã tồn tại");
                    return;
                }
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'" + $", EMAIL = '{tbEmail.Text}'",
                " WHERE ID = '" + updatedAccount.id.ToString() + "'");
                this.account.password = updatedAccount.password;
                this.account.email = updatedAccount.email;
                IO.ExportSuccess("Đổi thông tin thành công");
                Event.CloseForm(this);
                #endregion
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Image Staff)");
            }
        }
        #endregion

        private void BtThayDoi_CheckedChanged(object sender, EventArgs e)
        {
            if (btThayDoi.Checked)
            {
                this.tbPassword.Text = "";
                this.tbConfirm.Text = "";
                this.tbPassword.Enabled = true;
                this.tbConfirm.Enabled = true;
            }
            else
            {
                this.tbPassword.Text = this.account.password;
                this.tbConfirm.Text = this.account.password;
                this.tbPassword.Enabled = false;
                this.tbConfirm.Enabled = false;
            }
        }
    }
}
