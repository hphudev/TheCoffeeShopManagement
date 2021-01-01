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
using DTO;
using DAO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormMenuStaff : FormMenu
    {
        public FormMenuStaff(FormSell parent) : base(parent)
        {
            InitializeComponent();
            this.bAddStaff.Click += AddObjClicked;
            this.bChangeInfoStaff.Click += ChangeInfoObjClicked;
            this.bDeleteStaff.Click += DeleteObjClicked;
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
            MenuStaff menuStaff = new MenuStaff();

            if (e.Argument == null)
            {
                menuStaff.LoadData(ref this.sourceData, "NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = "
                    + "TK.ID AND TINHTRANG = 1", ref this.semaphores, ref this.obj, this.loader);
            }
            else
            {
                menuStaff.LoadData(ref this.sourceData, "NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = "
                    + "TK.ID AND TINHTRANG = 1 AND HOTEN LIKE N'" + (string)e.Argument + "%'",
                    ref this.semaphores, ref this.obj, this.loader);
            }
        }

        public override void ShowProgress(object sender, ProgressChangedEventArgs e)
        {
            MenuStaff menuStaff = new MenuStaff();
            menuStaff.ShowProgress(ref this.semaphores, this.dgvMenu, this.obj, this.progressBar, e);
        }

        public override void FinishWork(object sender, RunWorkerCompletedEventArgs e)
        {
            BUS.Menu.FinishWork(ref this.cbFind, this.sourceData);
        }

        public override void FindObjClicked(object sender, EventArgs e)
        {
            Event.Find("NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = TK.ID AND TINHTRANG = 1 AND " +
                    "HOTEN = N'" + this.cbFind.Text + "'", "*", "Nhân viên", ref this.dgvMenu,
                    ref this.cbFind);
        }

        public override void ChangeInfoObjClicked(object sender, EventArgs e)
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

        public override void DeleteObjClicked(object sender, EventArgs e)
        {
            //base.DeleteObjClicked(sender, e);
            if (this.dgvMenu.Rows.Count != 0)
            {
                (new BUS.MenuStaff()).DeleteObj(this.dgvMenu, this.loader);
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public override FormMain InitFormReport()
        {
            return new Report.FormReportDanhSachNhanVien();
        }

        public override void ClearContent(object sender, EventArgs e)
        {
            BUS.Menu.ClearContent(this.cbFind);
        }

        public override FormAddObj InitFormAddObj()
        {
            return new FormAddStaff(this);
        }

        public override FormChangeInfoObj InitFormChangeInfoObj()
        {
            return new FormChangeInfoStaff(this);
        }

        public override object GetSelectedObj()
        {
            return (new BUS.MenuStaff()).GetSelectedObj(this.dgvMenu);
        }

    }
}
