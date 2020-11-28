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

namespace CoffeeShopManagement
{
    public partial class FormAddStaff : Form
    {
        private FormLock lockForm;
        private FormMenuStaff parent;

        public void AutofillLabelID()
        {
            ID lastID = ID.GetLastIDStaff();
            ID newID = new ID("");

            if (lastID != null)
            {
                newID.SetID((lastID.FindID("NV") + 1), "NV", 2);
            }
            else
            {
                newID.SetID(1, "NV", 2);
            }

            this.lID.Text = newID.id;
        }

        public FormAddStaff(FormMenuStaff parent)
        {
            InitializeComponent();
            this.lockForm = new FormLock(this);
            this.lockForm.Show();
            this.parent = parent;
            this.FormClosed += CloseForm;
            this.bCancel.Click += CancelClicked;
            this.bOK.Click += OKClicked;
            this.bReset.Click += ResetClicked;
            AutofillLabelID();

            this.tbSalary.KeyPress += ShowErrorWord;
            this.tbCMND.KeyPress += ShowErrorWord;
            this.tbSDT.KeyPress += ShowErrorWord;

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
            this.cbSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.lockForm.Close();
            this.parent.Show();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetClicked(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.lCMND.Text = "";
            this.cbSex.Text = "";
            this.tbSDT.Text = "";
            this.cbPosition.Text = " ";
            this.tbAddress.Text = "";
            this.lSalary.Text = "";
            this.tbPassword.Text = "";
            this.tbConfirm.Text = "";
            this.tbUsername.Text = "";
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public bool IsStaff(ref Staff newStaff)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("NHANVIEN NV, TAIKHOAN TK", connection, " WHERE " +
                "NV.MANV = TK.ID", "*");
            string lastID = "";

            while (reader.HasRows)
            {
                if (reader.Read() == false)
                {
                    break;
                }

                Staff staff = new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(4), reader.GetString(6), (reader.GetDateTime(3).ToString().Split(' '))[0],
                    reader.GetString(5), reader.GetString(8), reader.GetInt32(7));

                if (newStaff.cmnd == staff.cmnd)
                {
                    Data.CloseConnection(ref connection);
                    IO.ExportError("Tồn tại nhân viên có số cmnd này trong danh sách");
                    return false;
                }

                if (newStaff.sdt == staff.sdt)
                {
                    Data.CloseConnection(ref connection);
                    IO.ExportError("Tồn tại nhân viên có số điện thoại này trong danh sách");
                    return false;
                }

                lastID = staff.id.FindID("NV").ToString();
            }

            reader.Close();

            if (lastID == "")
            {
                newStaff.id.SetID(1, "NV", 2);
            }
            else
            {
                newStaff.id.SetID(int.Parse(lastID) + 1, "NV", 2);
            }

            Data.CloseConnection(ref connection);
            return true;
        }

        public bool IsUsername(string username)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE TENDN = '" + username +
                "'", "*");
            return !reader.HasRows;
        }

        private void ShowErrorWord(object sender, KeyPressEventArgs e)
        {
            //Event.NhapChu((TextBox)sender, new ErrorProvider(), e);
        }

        private void ShowErrorNumber(object sender, KeyPressEventArgs e)
        {
            //Event.NhapSo()
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

            if ((int.Parse(this.tbSalary.Text)) < 0 || int.Parse(this.tbSDT.Text) < 0 || 
                int.Parse(this.tbCMND.Text) < 0)
            {
                IO.ExportError("Nhập số có giá trị nhỏ hơn 0");
                return true;
            }

            if (IO.IsContainNumber(this.tbName.Text) || IO.IsContainNumber(this.cbPosition.Text) ||
                IO.IsContainNumber(this.cbSex.Text))
            {
                IO.ExportError("Nhập số vào trường họ tên, chức vụ hoặc giới tính");
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

                Staff newStaff = new Staff("", this.tbName.Text, this.tbAddress.Text, this.tbSDT.Text,
                    this.cbSex.Text, DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() +
                    "/" + DateTime.Today.Day.ToString(), this.tbCMND.Text, this.cbPosition.Text,
                    int.Parse(this.tbSalary.Text));

                if (IsStaff(ref newStaff) == false)
                {
                    return;
                }
                else
                {
                    if (this.tbConfirm.Text != this.tbPassword.Text)
                    {
                        IO.ExportError("Mật khẩu nhập lại không đúng");
                        return;
                    }

                    Account account = new Account(newStaff.id.ToString(), this.tbUsername.Text,
                        Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()));

                    if (IsUsername(account.username))
                    {
                        Data.AddData("NHANVIEN", newStaff.GetInfo());
                        Data.AddData("TAIKHOAN", account.GetInfo());
                        IO.ExportSuccess("Thêm nhân viên thành công");
                        this.parent.LoadForm();
                        this.parent.Show();
                        this.Close();
                    }
                    else
                    {
                        IO.ExportError("Tên đăng nhập đã tồn tại");
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Nội dung nhập không hợp lệ");
            }

        }
    }
}
