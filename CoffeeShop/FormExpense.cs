using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace GUI
{
    public partial class FormExpense : Form
    {
        #region Attributes
        private FormSell parent;
        private FormLock khoa;
        #endregion

        #region Operations
        public FormExpense(FormSell parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.lID.Visible = false;
                this.tbID.Visible = false;
                this.tbID.Text = "NV";
                this.bOK.Location = new Point(this.bOK.Location.X, this.bOK.Location.Y - 50);
                this.bCancel.Location = new Point(this.bCancel.Location.X, this.bCancel.Location.Y - 50);
                InitLockForm();
                this.bCancel.Click += CancelClicked;
                this.FormClosed += CloseForm;
                this.cbType.TextChanged += ChooseType;
                this.bOK.Click += OKClicked;
                this.tbID.TextChanged += ChooseStaff;
                this.cbType.Text = "Trả lương";
                this.gbExpense.Height -= 50;
                this.Height -= 50;
                this.pbBackGround.Height -= 50;
                this.tbValue.KeyPress += IO.LockWord;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 49 Form Expense)");
            }
        }

        private void ChooseStaff(object sender, EventArgs e)
        {
            try
            {
                this.tbValue.Text = "";

                if (this.tbID.Text.Length == 4)
                {
                    DateTime date = new DateTime();
                    Staff selectedStaff = Event.FindStaff(this.tbID.Text, date);

                    if (selectedStaff == null)
                    {
                        return;
                    }

                    if (date.Date.CompareTo(DateTime.Now.Date) >= 0)
                    {
                        IO.ExportError("Nhân viên này mới vào làm nên không thể trả lương");
                        return;
                    }

                    this.tbValue.Text = selectedStaff.luong.ToString();
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 80 Form Expense)");
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

                Event.Add(new object[] { this.tbContent.Text, this.cbType.Text, this.tbID.Text,
                    int.Parse(this.tbValue.Text) });
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 98 Form Expense)");
            }
        }

        public bool IsError()
        {
            try
            {
                if (this.tbContent.Text == "" || this.tbValue.Text == "" || this.cbType.Text == "" ||
                    (this.cbType.Text == "Trả lương" && this.tbID.Text == ""))
                {
                    IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                    return true;
                }

                if (this.cbType.Text == "Trả lương")
                {
                    if (Event.FindStaff(this.tbID.Text, new DateTime()) == null)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 126 Form Expense)");
                return true;
            }
        }

        private void ChooseType(object sender, EventArgs e)
        {
            try
            {
                if (this.cbType.Text == "Trả lương")
                {
                    this.lID.Visible = true;
                    this.tbID.Visible = true;
                    this.bOK.Location = new Point(this.bOK.Location.X, this.bOK.Location.Y + 50);
                    this.bCancel.Location = new Point(this.bCancel.Location.X,
                        this.bCancel.Location.Y + 50);
                    this.tbContent.Text = this.cbType.Text;
                    this.gbExpense.Height += 50;
                    this.Height += 50;
                    this.pbBackGround.Height += 50;
                }
                else
                {
                    if (this.lID.Visible)
                    {
                        this.lID.Visible = false;
                        this.tbID.Visible = false;
                        this.bOK.Location = new Point(this.bOK.Location.X, this.bOK.Location.Y - 50);
                        this.bCancel.Location = new Point(this.bCancel.Location.X,
                            this.bCancel.Location.Y - 50);
                        this.tbContent.Text = "";
                        this.gbExpense.Height -= 50;
                        this.Height -= 50;
                        this.pbBackGround.Height -= 50;
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 165 Form Expense)");
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
            Event.CloseForm(this.khoa);
        }

        private void InitLockForm()
        {
            //khoa = new FormLock(this);
            //this.khoa.Show();
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }
        #endregion
    }
}
