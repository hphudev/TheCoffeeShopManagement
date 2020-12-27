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
using CoffeeShopManagement;
using DAO;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormMenuStaff : System.Windows.Forms.Form
    {
        #region Attributes
        private FormLock Lock;
        private BackgroundWorker loader;
        private AutoCompleteStringCollection sourceData;
        private object staff;
        private Semaphore[] semaphores;
        private bool isClearButtonClicked;

        public FormSell parent { get; private set; }
        #endregion

        #region Operations
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
                this.bClear.Click += Clear;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 69 Form Menu Staff");
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Event.Clear(this.cbFind, ref this.isClearButtonClicked);
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
                IO.ExportError("Lỗi không xác định\n(Line 106 Form Menu Staff");
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
                IO.ExportError("Lỗi không xác định\n(Line 118 Form Menu Staff");
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
                IO.ExportError("Lỗi không xác định\n(Line 130 Form Menu Staff");
            }
        }

        private void ShowImageClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.dgvMenu.Columns[9].Index && e.RowIndex >= 0)
                {
                    object tmp = null;
                    Event.GetSelectedInfo(ref tmp, this.dgvMenu.SelectedRows);
                    Staff selectedStaff = (Staff)tmp;
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
                IO.ExportError("Lỗi không xác định\n(Line 154 Form Menu Staff");
            }
        }

        private void AddStaffClicked(object sender, EventArgs e)
        {
            Event.ShowForm((new FormAddStaff(this)));
        }

        private void ChangeInfoStaffClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                object tmp = null;
                Event.GetSelectedInfo(ref tmp, this.dgvMenu.SelectedRows);
                Staff selectedStaff = (Staff)tmp;
                Event.ShowForm((new FormChangeInfoStaff(this, selectedStaff)));
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        private void DeleteStaffClicked(object sender, EventArgs e)
        {
            Event.Delete(this.dgvMenu.SelectedRows, "Staff");
            ClearMenu();
            LoadMenu();
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

        public DataGridViewSelectedRowCollection GetSelectedRows()
        {
            return this.dgvMenu.SelectedRows;
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            CoffeeShopManagement.Report.FormReportDanhSachNhanVien cus = new CoffeeShopManagement.Report.FormReportDanhSachNhanVien();
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
        #endregion
    }
}
