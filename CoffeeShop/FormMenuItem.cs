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
    public partial class FormMenuItem : FormMenu, IMenu
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
            this.loader.DoWork += LoadData;
            this.loader.ProgressChanged += ShowProgress;
            this.Load += LoadForm;
        }

        public void ClearMenu()
        {
            (new BUS.Menu()).ClearMenu(this.dgvMenu);
        }

        public override void AddRow(SqlDataReader reader)
        {
            (new BUS.MenuItem()).AddRow(reader, this.dgvMenu, this.cbFind, this.sourceData);
        }

        public void LoadData(object sender, DoWorkEventArgs e)
        {
            LoadData("MON", " WHERE TINHTRANG = 1", "*");
        }

        public void ShowProgress(object sender, ProgressChangedEventArgs e)
        {
            (new BUS.Menu()).ShowProgress(this.progressBar, e);
            this.cbFind.AutoCompleteCustomSource = this.sourceData;
        }

        public void LoadForm(object sender, EventArgs e)
        {
            this.dgvMenu.Rows.Clear();
            LoadMenu();
        }

        public override void DeleteObj()
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                (new BUS.MenuItem()).DeleteObj(this.dgvMenu, this.loader);
                this.parent.LoadSomeThingPublic();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public void FindObjClicked(object sender, EventArgs e)
        {
            Event.Find("MON", " WHERE TINHTRANG = 1 AND TENMON = N'" + this.cbFind.Text + "'", "*",
               "Món", ref this.dgvMenu, ref this.cbFind);
        }

        public override FormMain InitFormReport()
        {
            return new Report.FormReportDanhSachMon();
        }

        public void ClearContent(object sender, EventArgs e)
        {
            BUS.Menu.ClearContent(this.cbFind);
        }

        public override FormObj InitFormAddObj()
        {
            return new FormAddItem(this);
        }

        public override FormObj InitFormChangeInfoObj()
        {
            return new FormChangeInfoItem(this);
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

        public object GetSelectedObj()
        {
            return (new BUS.MenuItem()).GetSelectedObj(this.dgvMenu);
        }

    }
}
