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

namespace CoffeeShopManagement
{
    public partial class FormExpense : Form
    {
        private FormSell parent;
        private FormLock khoa;
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
                this.InitLockForm();
                this.bCancel.Click += CancelClicked;
                this.FormClosed += CloseForm;
                this.cbType.TextChanged += ChooseType;
                this.bOK.Click += OKClicked;
                this.tbID.TextChanged += ChooseStaff;
                this.cbType.Text = "Trả lương";
                this.gbExpense.Height -= 50;
                this.Height -= 50;
                this.pbBackGround.Height -= 50;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 43 Form Expense)");
            }
        }

        private void ChooseStaff(object sender, EventArgs e)
        {
            try
            {
                this.tbValue.Text = "";

                if (this.tbID.Text.Length == 4)
                {
                    SqlConnection connection = Data.OpenConnection();
                    SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection,
                        " WHERE NV.MANV = TK.ID AND TINHTRANG = 1 AND NV.MANV = '" + this.tbID.Text +
                        "'", "*");
                    DateTime tmp = new DateTime();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        tmp = reader.GetDateTime(3);
                        Staff staff = new Staff(reader.GetString(0), reader.GetString(1),
                            reader.GetString(2), reader.GetString(4), reader.GetString(6),
                            tmp.GetDate(tmp), reader.GetString(5), reader.GetString(8),
                            reader.GetInt32(7));

                        if (tmp.Date.CompareTo(DateTime.Now.Date) >= 0)
                        {
                            IO.ExportError("Nhân viên này mới vào làm nên không thể trả lương");
                            Data.CloseConnection(ref connection);
                            return;
                        }

                        if (tmp.AddMonths(1).Date.CompareTo(DateTime.Now.Date) <= 0)
                        {
                            this.tbValue.Text = staff.luong.ToString();
                        }

                        this.tbValue.Text = (staff.luong *
                            (DateTime.Now.DayOfYear - tmp.DayOfYear) / 30).ToString();
                    }
                    else
                    {
                        IO.ExportError("Mã nhân viên này không tồn tại");
                        Data.CloseConnection(ref connection);
                        return;
                    }

                    Data.CloseConnection(ref connection);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 97 Form Expense)");
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

                DateTime tmp = new DateTime();
                Expense expense = new Expense(ID.FindNewID("CHITIEU", " ORDER BY ID DESC", "ID", "CT",
                    5).ToString(), tmp.GetDateUS(DateTime.Now),
                    this.tbContent.Text, this.cbType.Text == "Trả lương" ? this.tbID.Text : "NULL",
                    int.Parse(tbValue.Text));
                Data.AddData("CHITIEU", expense.GetInfo());
                IO.ExportSuccess("Thêm chi tiêu thành công");
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 120 Form Expense)");
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

                try
                {
                    if (int.Parse(this.tbValue.Text) <= 0)
                    {
                        IO.ExportError("Không được nhập số có giá trị nhỏ hơn bằng 0 trong trường số " +
                            "tiền");
                        return true;
                    }
                }
                catch (FormatException)
                {
                    IO.ExportError("Nội dung nhập trong trường số tiền không hợp lệ");
                }

                if (this.cbType.Text != "Trả lương" && this.cbType.Text != "Khác")
                {
                    IO.ExportError("Vui lòng chọn loại chi tiêu trong danh sách");
                    return true;
                }

                if (this.cbType.Text == "Trả lương")
                {
                    SqlConnection connection = Data.OpenConnection();
                    SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection,
                        " WHERE NV.MANV = TK.ID AND TINHTRANG = 1 AND NV.MANV = '" + this.tbID.Text +
                        "'", "*");

                    if (!reader.HasRows)
                    {
                        IO.ExportError("Mã nhân viên không tồn tại");
                        Data.CloseConnection(ref connection);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 174 Form Expense)");
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
                IO.ExportError("Lỗi không xác định\n(Line 213 Form Expense)");
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.khoa.Close();
            Event.CloseForm(this);
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
    }
}
