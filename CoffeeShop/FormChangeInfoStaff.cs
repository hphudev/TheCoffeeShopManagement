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

namespace CoffeeShopManagement
{
    public partial class FormChangeInfoStaff : System.Windows.Forms.Form
    {
        FormBangKhoa khoa;
        FormMenuStaff parent;

        public void Autofill()
        {
            Staff selectedStaff;
            this.parent.GetSelectedInfo(out selectedStaff);
            Account selectedAccount;
            this.parent.GetSelectedAccount(out selectedAccount);
            this.tbName.Text = selectedStaff.name;
            this.tbAddress.Text = selectedStaff.address;
            this.tbCMND.Text = selectedStaff.cmnd;
            this.tbSalary.Text = selectedStaff.luong.ToString();
            this.tbSDT.Text = selectedStaff.sdt;
            this.cbPosition.Text = selectedStaff.chucVu;
            this.cbSex.Text = selectedStaff.sex;
            this.tbUsername.Text = selectedAccount.username;
        }

        public FormChangeInfoStaff(FormMenuStaff parent)
        {
            InitializeComponent();
            khoa = new FormBangKhoa(this);
            this.parent = parent;
            khoa.Show();
            this.bCancel.Click += CancelClicked;
            this.FormClosed += CloseForm;
            this.bReset.Click += ResetClicked;
            Autofill();
            this.bOK.Click += OKClicked;

            this.tbAddress.KeyPress += PressEnter;
            this.cbPosition.KeyPress += PressEnter;
            this.tbSalary.KeyPress += PressEnter;
            this.tbSDT.KeyPress += PressEnter;
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
            this.khoa.Close();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            Autofill();
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbSalary.Text) <= 0 || tbAddress.Text == "" || cbPosition.Text == "")
                {
                    throw new Exception();
                }

                Staff selectedStaff;
                this.parent.GetSelectedInfo(out selectedStaff);
                Staff updatedStaff = new Staff(selectedStaff.id.ToString(), selectedStaff.name,
                    tbAddress.Text, selectedStaff.sdt, selectedStaff.sex, selectedStaff.date,
                    selectedStaff.cmnd, this.cbPosition.Text, int.Parse(this.tbSalary.Text));
                Data.UpdateData("NHANVIEN", "CHUCVU = N'" + updatedStaff.chucVu + "', LUONG = '" +
                    updatedStaff.luong + "', DCHI = N'" + updatedStaff.address + "'", " WHERE MANV = '"
                    + selectedStaff.id.ToString() + "'");

                Account updatedAccount = new Account(selectedStaff.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()));
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'",
                    " WHERE ID = '" + updatedAccount.id.ToString() + "'");

                IO.ExportSuccess("Sửa thông tin nhân viên thành công");
                this.parent.LoadForm();
                this.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Nội dung nhập không hợp lệ");
            }
        }
    }
}
