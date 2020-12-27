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
using System.Threading;
using CoffeeShopManagement;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class FormMenuItem : Form
    {
        #region Attributes
        public FormSell parent { get; }
        private FormLock lockForm;
        private BackgroundWorker loader;
        private AutoCompleteStringCollection sourceData;
        private object item;
        private Semaphore[] semaphores;
        private bool isClearButtonClicked;
        #endregion

        #region Operations
        public FormMenuItem(FormSell parent)
        {
            try
            {
                this.parent = parent;
                InitializeComponent();
                this.bAddItem.Click += AddItemClicked;
                this.bChangeInfoItem.Click += ChangeInfoItemClicked;
                this.bDeleteItem.Click += DeleteItemClicked;
                this.bFind.Click += FindItemClicked;
                this.bCancel.Click += CancelClicked;
                this.FormClosed += CloseForm;
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);
                //Event.ShowForm(this);
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
                IO.ExportError("Lỗi không xác định\n(Line 57 Form Menu Item)");
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
            Event.ShowProgress(ref this.semaphores, this.dgvMenu, this.item, this.progressBar, e);
        }

        private void LoadData(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (e.Argument == null)
                {
                    Event.LoadData(ref this.sourceData, "MON", " WHERE TINHTRANG = 1", ref this.semaphores,
                        ref this.item, "Item", this.loader);
                }
                else
                {
                    Event.LoadData(ref this.sourceData, "MON", " WHERE TINHTRANG = 1 AND TENMON LIKE N'" +
                        (string)e.Argument + "%'", ref this.semaphores, ref this.item, "Item", this.loader);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 93 Form Menu Item");
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
                IO.ExportError("Lỗi không xác định\n(Line 105 Form Menu Item");
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
                IO.ExportError("Lỗi không xác định\n(Line 117Form Menu Item");
            }
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void AddItemClicked(object sender, EventArgs e)
        {
            FormAddItem cus = new FormAddItem(this);
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        private void ChangeInfoItemClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                FormChangeInfoItem cus = new FormChangeInfoItem(this);
                FormLock ltmp = new FormLock();
                ltmp.Show();
                cus.Show();
                cus.SetLockForm(ref ltmp);
                ltmp.SetLockParent(cus);
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        private void DeleteItemClicked(object sender, EventArgs e)
        {
            Event.Delete(this.dgvMenu.SelectedRows, "Item");
            ClearMenu();
            LoadMenu();
            this.parent.LoadSomeThingPublic();
        }

        private void FindItemClicked(object sender, EventArgs e)
        {
            Event.Find("MON", " WHERE TINHTRANG = 1 AND TENMON = N'" + this.cbFind.Text + "'", "*",
                    "Món", ref this.dgvMenu, ref this.cbFind);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.lockForm);
        }

        public DataGridViewSelectedRowCollection GetSelectedRows()
        {
            return this.dgvMenu.SelectedRows;
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            CoffeeShopManagement.Report.FormReportDanhSachMon cus = new CoffeeShopManagement.Report.FormReportDanhSachMon();
            FormLock ltmp = new FormLock();
            ltmp.Show();
            cus.Show();
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
        #endregion
    }
}
