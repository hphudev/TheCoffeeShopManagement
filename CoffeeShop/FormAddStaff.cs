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
    public partial class FormAddStaff : FormStaff, IImage, IButtonReset
    {
        public FormAddStaff(FormMenuStaff parent) : base(parent)
        {
            try
            {
                InitializeComponent();
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
                IO.ExportError("Lỗi không xác định\n(Form Add Staff)");
            }
        }

        public void AddImageClicked(object sender, EventArgs e)
        {
            (new AddStaff()).AddImageClicked(ref this.pbImage);
        }

        public void ResetClicked(object sender, EventArgs e)
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

        public override bool IsError()
        {
            if (this.tbName.Text == "" || this.tbAddress.Text == "" || this.tbSDT.Text == "" ||
                        this.tbCMND.Text == "" || this.cbSex.Text == "" || this.tbSalary.Text == "" ||
                        this.cbPosition.Text == "" || this.tbUsername.Text == "" ||
                        this.tbPassword.Text == "" || this.tbConfirm.Text == "" || 
                        this.tbEmail.Text == "")
            {
                IO.ExportError("Nhập không đầy đủ nội dung tất cả các trường");
                return true;
            }

            if (this.tbConfirm.Text != this.tbPassword.Text)
            {
                IO.ExportError("Mật khẩu nhập lại không đúng");
                return true;
            }

            return false;
        }

        public override void ModifyObj()
        {
            Staff newStaff = new Staff("", this.tbName.Text, this.tbAddress.Text, this.tbSDT.Text,
                this.cbSex.Text, DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() +
                "/" + DateTime.Today.Day.ToString(), this.tbCMND.Text, this.cbPosition.Text,
                int.Parse(this.tbSalary.Text));
            Account account = new Account(newStaff.id.ToString(), this.tbUsername.Text,
                Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                true, this.tbEmail.Text, "");
            
            if ((new AddStaff()).AddNewObj(newStaff, account))
            {
                Event.CloseForm(this);
            }
        }

    }
}
