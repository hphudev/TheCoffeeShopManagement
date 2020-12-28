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
using System.Threading;

namespace CoffeeShopManagement
{
    public partial class FormMenuStaff : System.Windows.Forms.Form
    {
        private FormLock Lock;
        private BackgroundWorker loader;
        private AutoCompleteStringCollection sourceData;
        private object staff;
        private Semaphore[] semaphores;

        public FormSell parent { get; private set; }

        public FormMenuStaff(FormSell parent)
        {
            try
            {
                InitializeComponent();
                //this.Lock = new FormLock(this);
                this.parent = parent;
                this.bCancel.Click += CancelClicked;
                this.bAddStaff.Click += AddStaffClicked;
                this.bChangeInfoStaff.Click += ChangeInfoStaffClicked;
                this.bDeleteStaff.Click += DeleteStaffClicked;
                this.FormClosed += CloseForm;
                this.bFind.Click += FindStaffClicked;
                //Event.ShowForm(this.Lock);
                //Event.ShowForm(this);
                #region Giao diện DataGridView
                this.dgvMenu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
                this.dgvMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0);
                this.dgvMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.dgvMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvMenu.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                this.dgvMenu.RowsDefaultCellStyle.Font = new Font("Time New Roman", 9, FontStyle.Bold);
                this.dgvMenu.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128);
                #endregion
                this.dgvMenu.CellClick += ShowImageClicked;
                this.loader = new BackgroundWorker();
                this.loader.DoWork += LoadData;
                this.loader.WorkerReportsProgress = true;
                this.loader.RunWorkerCompleted += FinishWork;
                this.loader.ProgressChanged += ShowProgress;
                this.loader.RunWorkerAsync();
                this.bClear.Click += ClearContent;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 61 Form Menu Staff");
            }
        }

        private void FinishWork(object sender, RunWorkerCompletedEventArgs e)
        {
            Event.FinishWork(ref this.cbFind, this.sourceData);
        }

        private void ShowProgress(object sender, ProgressChangedEventArgs e)
        {
            Event.ShowProgress(ref this.semaphores, this.dgvMenu, this.staff, this.progressBar, e);
        }

        private void LoadData(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (e.Argument == null)
                {
                    Event.LoadData(ref this.sourceData, "NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = " +
                        "TK.ID AND TINHTRANG = 1", ref this.semaphores, ref this.staff, "Staff", this.loader);
                }
                else
                {
                    Event.LoadData(ref this.sourceData, "NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = " +
                        "TK.ID AND TINHTRANG = 1 AND HOTEN LIKE N'" + (string)e.Argument + "%'",
                        ref this.semaphores, ref this.staff, "Staff", this.loader);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 93 Form Menu Staff");
            }
        }

        public void LoadMenu()
        {
            try
            {
                this.loader.RunWorkerAsync();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 105 Form Menu Staff");
            }
        }

        public void ClearMenu()
        {
            try
            {
                this.dgvMenu.Rows.Clear();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 117 Form Menu Staff");
            }
        }

        private void ShowImageClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.dgvMenu.Columns[9].Index && e.RowIndex >= 0)
                {
                    Staff selectedStaff;
                    GetSelectedInfo(out selectedStaff);
                    FormImageStaff cus = new FormImageStaff(selectedStaff.image, selectedStaff.id);
                    FormLock ltmp = new FormLock();
                    ltmp.Show();
                    cus.Show();
                    cus.SetLockForm(ref ltmp);
                    ltmp.SetLockParent(cus);
                    //Event.ShowForm((new FormImageStaff(selectedStaff.image, selectedStaff.id)));
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 145 Form Menu Staff");
            }
        }

        private void AddStaffClicked(object sender, EventArgs e)
        {
            FormAddStaff staff = new FormAddStaff(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            Event.ShowForm(staff);
            staff.SetLockForm(ref ltmp);
            ltmp.SetLockParent(staff);
        }

        private void ChangeInfoStaffClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
                {
                FormChangeInfoStaff staff = new FormChangeInfoStaff(this);
                FormLock ltmp = new FormLock();
                ltmp.Show();
                Event.ShowForm(staff);
                staff.SetLockForm(ref ltmp);
                ltmp.SetLockParent(staff);
                }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public void GetSelectedInfo(out Staff selectedStaff)
        {
            try
            {
                DataGridViewRow[] selectedRows = new DataGridViewRow[1];
                this.dgvMenu.SelectedRows.CopyTo(selectedRows, 0);

                selectedStaff = new Staff((string)selectedRows[0].Cells[0].Value,
                    (string)selectedRows[0].Cells[1].Value,
                    (string)selectedRows[0].Cells[2].Value, (string)selectedRows[0].Cells[4].Value,
                    (string)selectedRows[0].Cells[6].Value, (string)selectedRows[0].Cells[3].Value,
                    (string)selectedRows[0].Cells[5].Value, (string)selectedRows[0].Cells[8].Value,
                    (int)selectedRows[0].Cells[7].Value);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 183 Form Menu Staff");
                selectedStaff = null;
            }
        }

        public void GetSelectedAccount(out Account selectedAccount)
        {
            try
            {
                Staff selectedStaff;
                GetSelectedInfo(out selectedStaff);

                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("TAIKHOAN", connection, " WHERE ID = '" +
                    selectedStaff.id.ToString() + "'", "*");
                reader.Read();
                selectedAccount = new Account(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetBoolean(3));
                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 205 Form Menu Staff");
                selectedAccount = null;
            }
        }

        private void DeleteStaffClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMenu.Rows.Count != 0)
                {
                    Staff selectedStaff;
                    GetSelectedInfo(out selectedStaff);
                    Data.UpdateData("TAIKHOAN", "TINHTRANG = 0", " WHERE ID  = '" +
                        selectedStaff.id.ToString() + "'");
                    IO.ExportSuccess("Xóa nhân viên thành công");
                    ClearMenu();
                    LoadMenu();
                }
                else
                {
                    IO.ExportError("Hành động không hợp lệ");
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 231 Form Menu Staff");
            }
        }

        private void FindStaffClicked(object sender, EventArgs e)
        {
            Event.Find("NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = TK.ID AND TINHTRANG = 1 AND " +
                    "HOTEN = N'" + this.cbFind.Text + "'", "*", "Nhân viên", ref this.dgvMenu,
                    ref this.cbFind);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            FormMenuStaff menu = (FormMenuStaff)sender;
            Event.ShowForm(menu.parent);
        }

        private void FormMenuStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.Lock);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            Report.FormReportDanhSachNhanVien cus = new Report.FormReportDanhSachNhanVien();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.Lock = khoa;
        }

        private void ClearContent(object sender, EventArgs e)
        {
            this.cbFind.Text = "";
        }
    }
}
