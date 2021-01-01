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
using DAO;
using DTO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormMenu : FormMain
    {
        protected BackgroundWorker loader;
        protected AutoCompleteStringCollection sourceData;
        protected Semaphore[] semaphores;
        protected object obj;

        public FormSell parent { get; }

        public FormMenu(FormSell parent)
        {
            try
            {
                this.parent = parent;
                //InitializeComponent();
                //this.bAddObj.Click += AddObjClicked;
                //this.bChangeInfoObj.Click += ChangeInfoObjClicked;
                //this.bDeleteObj.Click += DeleteObjClicked;
                //this.bFind.Click += FindObjClicked;
                //this.bCancel.Click += CancelClicked;
                this.loader = new BackgroundWorker();
                this.loader.DoWork += LoadData;
                this.loader.WorkerReportsProgress = true;
                this.loader.RunWorkerCompleted += FinishWork;
                this.loader.ProgressChanged += ShowProgress;
                this.loader.RunWorkerAsync();
                //this.bClear.Click += ClearContent;
                //this.bPrint.Click += PrintClicked;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Menu)");
            }
        }

        public virtual void ClearMenu()
        {
            //(new BUS.Menu()).ClearMenu(this.dgvMenu);
        }

        public void LoadMenu()
        {
            (new BUS.Menu()).LoadMenu(this.loader);
        }

        public virtual void LoadData(object sender, DoWorkEventArgs e)
        {

        }

        public virtual void ShowProgress(object sender, ProgressChangedEventArgs e)
        {

        }

        public virtual void FinishWork(object sender, RunWorkerCompletedEventArgs e)
        {
            //BUS.Menu.FinishWork(ref this.cbFind, this.sourceData);
        }

        public virtual void DeleteObjClicked(object sender, EventArgs e)
        {
            //if (this.dgvMenu.Rows.Count != 0)
            //{
            //    (new BUS.Menu()).DeleteObj(this.dgvMenu, this.loader);
            //}
            //else
            //{
            //    IO.ExportError("Hành động không hợp lệ");
            //}
        }

        public virtual void FindObjClicked(object sender, EventArgs e)
        {

        }

        public virtual FormMain InitFormReport()
        {
            return null;
        }

        public void ShowForm(FormMain cus)
        {
            FormLock ltmp = new FormLock();
            Event.ShowForm(ltmp);
            Event.ShowForm(cus);
            cus.SetLockForm(ref ltmp);
            ltmp.SetLockParent(cus);
        }

        public void PrintClicked(object sender, EventArgs e)
        {
            ShowForm(InitFormReport());
        }

        public virtual void ClearContent(object sender, EventArgs e)
        {
            //BUS.Menu.ClearContent(this.cbFind);
        }

        public virtual FormAddObj InitFormAddObj()
        {
            return null;
        }

        public void AddObjClicked(object sender, EventArgs e)
        {
            ShowForm(InitFormAddObj());
        }

        public virtual FormChangeInfoObj InitFormChangeInfoObj()
        {
            return null;
        }

        public void ChangeInfoObjClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu != null && this.dgvMenu.Rows.Count != 0)
            {
                ShowForm(InitFormChangeInfoObj());
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public virtual object GetSelectedObj()
        {
            //return (new BUS.Menu()).GetSelectedObj(this.dgvMenu);
            return null;
        }

    }
}
