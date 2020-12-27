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
    public partial class FormChangeInfoStaff : Form
    {
        FormLock lockForm;
        FormMenuStaff parent;

        public void Autofill() 
        {
            try
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
                this.lID.Text = selectedStaff.id.ToString();
                this.tbUsername.Text = selectedAccount.username;
                this.pbImage.Image = selectedStaff.image;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 40 Form Change Info Staff)");
            }
        }

        public FormChangeInfoStaff(FormMenuStaff parent)
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
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 69 Form Change Info Staff)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            try
            {
                Staff selectedStaff;
                this.parent.GetSelectedInfo(out selectedStaff);
                Event.AddImage(ref this.pbImage, "./ImageStaff/", selectedStaff.id.ToString());
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 83 Form Change Info Staff)");
            }
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
                IO.ExportError("Lỗi không xác định\n(Line 123 Form Change Info Staff)");
                return false;
            }
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (IsError())
                {
                    return;
                }

                Staff selectedStaff;
                this.parent.GetSelectedInfo(out selectedStaff);
                Staff updatedStaff = new Staff(selectedStaff.id.ToString(), selectedStaff.name,
                    tbAddress.Text, selectedStaff.sdt, selectedStaff.sex, selectedStaff.date,
                    selectedStaff.cmnd, this.cbPosition.Text, int.Parse(this.tbSalary.Text));
                Data.UpdateData("NHANVIEN", "CHUCVU = N'" + updatedStaff.chucVu + "', salary = '" +
                    updatedStaff.luong + "', DCHI = N'" + updatedStaff.address + "'", " WHERE MANV = '"
                    + selectedStaff.id.ToString() + "'");

                Account updatedAccount = new Account(selectedStaff.id.ToString(), this.tbUsername.Text,
                    Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                    true);
                Data.UpdateData("TAIKHOAN", "MATKHAU = '" + updatedAccount.password + "'",
                    " WHERE ID = '" + updatedAccount.id.ToString() + "'");

                IO.ExportSuccess("Sửa thông tin nhân viên thành công");
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                Event.CloseForm(this);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 159 Form Change Info Staff)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
    }
}
