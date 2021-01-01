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

        public FormSell parent { get; }

        public FormMenu() 
        {

        }

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
                this.loader.WorkerReportsProgress = true;
                //this.loader.ProgressChanged += ShowProgress;
                //this.Load += LoadForm;
                this.sourceData = new AutoCompleteStringCollection();
                //this.bClear.Click += ClearContent;
                //this.bPrint.Click += PrintClicked;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Menu)");
            }
        }

        //public virtual void ClearMenu()
        //{
        //    (new BUS.Menu()).ClearMenu(this.dgvMenu);
        //}

        public void LoadMenu()
        {
            (new BUS.Menu()).LoadMenu(this.loader);
        }

        public virtual void AddRow(SqlDataReader reader)
        {

        }

        public void LoadData(string table, string condition, string column)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData(table, connection, condition, column);
            int count = Data.Calculate("COUNT", column, table, condition);
            int dem = 0;

            while (reader.HasRows)
            {
                dem++;

                if (!reader.Read())
                {
                    return;
                }

                Invoke((MethodInvoker)delegate
                {
                    AddRow(reader);
                });

                this.loader.ReportProgress((dem * 100) / count);
            }

            Data.CloseConnection(ref connection);
        }

        //public void ShowProgress(object sender, ProgressChangedEventArgs e)
        //{
        //    (new BUS.Menu()).ShowProgress(this.progressBar, e);
        //}

        //public void LoadForm(object sender, EventArgs e)
        //{
        //    this.dgvMenu.Rows.Clear();
        //    LoadMenu();
        //}

        public virtual void DeleteObj()
        {

        }

        public virtual void DeleteObjClicked(object sender, EventArgs e)
        {
            DeleteObj();
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

        //public virtual void ClearContent(object sender, EventArgs e)
        //{
        //    BUS.Menu.ClearContent(this.cbFind);
        //}

        public virtual FormObj InitFormAddObj()
        {
            return null;
        }

        public void AddObjClicked(object sender, EventArgs e)
        {
            ShowForm(InitFormAddObj());
        }

        public virtual FormObj InitFormChangeInfoObj()
        {
            return null;
        }

        //public virtual void ChangeInfoObjClicked(object sender, EventArgs e)
        //{
        //    if (this.dgvMenu != null && this.dgvMenu.Rows.Count != 0)
        //    {
        //        ShowForm(InitFormChangeInfoObj());
        //    }
        //    else
        //    {
        //        IO.ExportError("Hành động không hợp lệ");
        //    }
        //}

    }
}
