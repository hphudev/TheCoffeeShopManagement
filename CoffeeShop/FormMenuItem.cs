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
    public partial class FormMenuItem : FormMenu
    {
        public FormMenuItem(FormSell parent) : base(parent)
        {
            InitializeComponent();
            this.bAddObj.Click += AddObjClicked;
            this.bChangeInfoObj.Click += ChangeInfoObjClicked;
            this.bDeleteObj.Click += DeleteObjClicked;
            this.bFind.Click += FindObjClicked;
            this.bCancel.Click += CancelClicked;
            this.bClear.Click += ClearContent;
            this.bPrint.Click += PrintClicked;
        }

        public override void ClearMenu()
        {
            (new BUS.Menu()).ClearMenu(this.dgvMenu);
        }

        public override void LoadData(object sender, DoWorkEventArgs e)
        {
            BUS.MenuItem menuItem = new BUS.MenuItem();

            if (e.Argument == null)
            {
                menuItem.LoadData(ref this.sourceData, "MON", " WHERE TINHTRANG = 1", ref this.semaphores,
                    ref this.obj, this.loader);
            }
            else
            {
                menuItem.LoadData(ref this.sourceData, "MON", " WHERE TINHTRANG = 1 AND TENMON LIKE N'"
                    + (string)e.Argument + "%'", ref this.semaphores, ref this.obj, this.loader);
            }
        }

        public override void ShowProgress(object sender, ProgressChangedEventArgs e)
        {
            BUS.MenuItem menuItem = new BUS.MenuItem();
            menuItem.ShowProgress(ref this.semaphores, this.dgvMenu, this.obj, this.progressBar, e);
        }

        public override void FinishWork(object sender, RunWorkerCompletedEventArgs e)
        {
            BUS.Menu.FinishWork(ref this.cbFind, this.sourceData);
        }

        public override void DeleteObjClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                //base.DeleteObjClicked(sender, e);
                (new BUS.Menu()).DeleteObj(this.dgvMenu, this.loader);
                this.parent.LoadSomeThingPublic();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public override void FindObjClicked(object sender, EventArgs e)
        {
            Event.Find("MON", " WHERE TINHTRANG = 1 AND TENMON = N'" + this.cbFind.Text + "'", "*",
               "Món", ref this.dgvMenu, ref this.cbFind);
        }

        public override FormMain InitFormReport()
        {
            return new Report.FormReportDanhSachMon();
        }
       
        public override void ClearContent(object sender, EventArgs e)
        {
            BUS.Menu.ClearContent(this.cbFind);
        }

        public override FormAddObj InitFormAddObj()
        {
            return new FormAddItem(this);
        }

        public override FormChangeInfoObj InitFormChangeInfoObj()
        {
            return new FormChangeInfoItem(this);
        }

        public override object GetSelectedObj()
        {
            return (new BUS.Menu()).GetSelectedObj(this.dgvMenu);
        }

    }
}
