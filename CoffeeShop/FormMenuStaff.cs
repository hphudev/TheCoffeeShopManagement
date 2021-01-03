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
    public partial class FormMenuStaff : FormMenu, IMenu
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
            this.loader.DoWork += LoadData;
            this.loader.ProgressChanged += ShowProgress;
            this.Load += LoadForm;
            this.dgvMenu.CellClick += ShowImageClicked;
        }

        public void ClearMenu()
        {
            (new BUS.Menu()).ClearMenu(this.dgvMenu);
        }

        public override void AddRow(SqlDataReader reader)
        {
            (new MenuStaff()).AddRow(reader, this.dgvMenu, this.cbFind, this.sourceData);
        }

        public void LoadData(object sender, DoWorkEventArgs e)
        {
            LoadData("NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = TK.ID AND TINHTRANG = 1", "*");
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
                (new BUS.MenuStaff()).DeleteObj(this.dgvMenu, this.loader);
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public void FindObjClicked(object sender, EventArgs e)
        {
            Event.Find("NHANVIEN NV, TAIKHOAN TK", " WHERE NV.MANV = TK.ID AND TINHTRANG = 1 AND " +
                    "HOTEN = N'" + this.cbFind.Text + "'", "*", "Nhân viên", ref this.dgvMenu,
                    ref this.cbFind);
        }

        public override FormMain InitFormReport()
        {
            return new Report.FormReportDanhSachNhanVien();
        }

        public void ClearContent(object sender, EventArgs e)
        {
            BUS.Menu.ClearContent(this.cbFind);
        }

        public override FormObj InitFormAddObj()
        {
            return new FormAddStaff(this);
        }

        public override FormObj InitFormChangeInfoObj()
        {
            return new FormChangeInfoStaff(this);
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
            return (new BUS.MenuStaff()).GetSelectedObj(this.dgvMenu);
        }

        public void ShowImageClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvMenu.Columns[9].Index && e.RowIndex >= 0)
            {
                Staff selectedStaff = (Staff)GetSelectedObj();
                FormImageStaff formImageStaff = new FormImageStaff(selectedStaff.image,
                    selectedStaff.id);
                ShowForm(formImageStaff);
            }
        }
    }
}
