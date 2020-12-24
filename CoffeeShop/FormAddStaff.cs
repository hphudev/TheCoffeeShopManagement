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

        public FormAddStaff(FormMenuStaff parent)
        {
            try
            {
                InitializeComponent();
                this.lockForm = new FormLock(this);
                Event.ShowForm(this.lockForm);
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
                IO.ExportError("Lỗi không xác định\n(Line 58 Form Add Staff)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            try
            {
                Event.AddImage(ref this.pbImage, "./ImageStaff/", ID.FindNewID("NHANVIEN",
                    " ORDER BY MANV DESC", "MANV", "NV", 2).ToString());
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 71 Form Add Staff)");
            }
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
            try
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
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\nLine 103 Form Add Staff");
            }
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public int IsStaff(ref Staff newStaff)
        {
            try
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
                        reader.GetString(4), reader.GetString(6),
                        (reader.GetDateTime(3).ToString().Split(' '))[0], reader.GetString(5),
                        reader.GetString(8), reader.GetInt32(7));
                    Account account = new Account(reader.GetString(9), reader.GetString(10),
                        reader.GetString(11), reader.GetBoolean(12));

                    if (newStaff.cmnd == staff.cmnd && account.status)
                    {
                        Data.CloseConnection(ref connection);
                        IO.ExportError("Tồn tại nhân viên có số cmnd này trong danh sách");
                        return 0;
                    }

                    if (newStaff.cmnd == staff.cmnd && !account.status)
                    {
                        if (this.tbConfirm.Text != this.tbPassword.Text)
                        {
                            IO.ExportError("Mật khẩu nhập lại không đúng");
                            return 0;
                        }

                        newStaff.id.SetID(staff.id.FindID("NV"), "NV", 2);

                        Account updatedAccount = new Account(newStaff.id.ToString(), this.tbUsername.Text,
                            Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                            true);

                        if (IsUsername(updatedAccount.username))
                        {
                            Data.UpdateData("NHANVIEN", "DCHI = N'" + newStaff.address + "', NGVL = '" +
                                DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() +
                                "/" + DateTime.Today.Day.ToString() + "', SDT = '" + newStaff.sdt +
                                "', LUONG = " + newStaff.luong.ToString() + ", CHUCVU = N'" +
                                newStaff.chucVu + "'", " WHERE MANV = '" + newStaff.id.ToString() + "'");
                            Data.UpdateData("TAIKHOAN", "TENDN = '" + updatedAccount.username +
                                "', MATKHAU = '" + updatedAccount.password + "', TINHTRANG = 1",
                                " WHERE ID = '" + updatedAccount.id.ToString() + "'");
                            IO.ExportSuccess("Thêm nhân viên thành công");
                            this.parent.ClearMenu();
                            this.parent.LoadMenu();
                            Event.ShowForm(this.parent);
                            this.Close();
                        }
                        else
                        {
                            IO.ExportError("Tên đăng nhập đã tồn tại");
                            return 0;
                        }

                        Data.CloseConnection(ref connection);
                        return -1;
                    }

                    if (newStaff.sdt == staff.sdt)
                    {
                        Data.CloseConnection(ref connection);
                        IO.ExportError("Tồn tại nhân viên có số điện thoại này trong danh sách");
                        return 0;
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
                return 1;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 208 Form Add Staff)");
                return -1;
            }
        }

        public bool IsUsername(string username)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE TENDN = '" + username
                    + "'", "*");

                if (!reader.HasRows)
                {
                    if (username == this.parent.parent.parent.account.username &&
                        this.parent.parent.parent.account.IsAdmin())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 240 Form Add Staff)");
                return false;
            }
        }

        public bool IsError()
        {
            try
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
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 262 Form Add Staff)");
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

                Staff newStaff = new Staff("", this.tbName.Text, this.tbAddress.Text, this.tbSDT.Text,
                    this.cbSex.Text, DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() +
                    "/" + DateTime.Today.Day.ToString(), this.tbCMND.Text, this.cbPosition.Text,
                    int.Parse(this.tbSalary.Text));
                int flag = IsStaff(ref newStaff);

                if (flag == 0)
                {
                    return;
                }
                else if (flag == 1)
                {
                    if (this.tbConfirm.Text != this.tbPassword.Text)
                    {
                        IO.ExportError("Mật khẩu nhập lại không đúng");
                        return;
                    }

                    Account account = new Account(newStaff.id.ToString(), this.tbUsername.Text,
                        Encrypt.ComputeHash(this.tbPassword.Text, new SHA256CryptoServiceProvider()),
                        true);

                    if (IsUsername(account.username))
                    {
                        Data.AddData("NHANVIEN", newStaff.GetInfo());
                        Data.AddData("TAIKHOAN", account.GetInfo());
                        IO.ExportSuccess("Thêm nhân viên thành công");
                        this.parent.ClearMenu();
                        this.parent.LoadMenu();
                        Event.ShowForm(this.parent);
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
                IO.ExportError("Lỗi không xác định\n(Line 316 Form Add Staff)");
            }
        }
    }
}
