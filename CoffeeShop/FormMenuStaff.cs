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
    public partial class FormMenuStaff : System.Windows.Forms.Form
    {
        private FormSell parent;
        private FormLock Lock;

        public void LoadForm()
        {
            #region Giao diện DataGridView
            this.dgvMenu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            this.dgvMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 0, 0);
            this.dgvMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvMenu.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.dgvMenu.RowsDefaultCellStyle.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            this.dgvMenu.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128);
            #endregion

            AutoCompleteStringCollection sourceData = new AutoCompleteStringCollection();
            this.dgvMenu.Rows.Clear();
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("NHANVIEN, TAIKHOAN", connection, " WHERE " +
                "NHANVIEN.MANV = TAIKHOAN.ID AND TINHTRANG = 1", "*");
            DateTime tmp = new DateTime();

            while (reader.HasRows)
            {
                if (reader.Read() == false)
                {
                    break;
                }

                Staff staff = new Staff(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(4), reader.GetString(6), tmp.GetDate(reader.GetDateTime(3)),
                    reader.GetString(5), reader.GetString(8), reader.GetInt32(7));
                this.dgvMenu.Rows.Add(staff.id.ToString(), staff.name, staff.address, staff.date,
                    staff.sdt, staff.cmnd, staff.sex, staff.luong, staff.chucVu);
                sourceData.Add(staff.name);
            }

            this.cbFind.AutoCompleteCustomSource = sourceData;
            Data.CloseConnection(ref connection);
        }

        public FormMenuStaff(FormSell parent)
        {
            InitializeComponent();
            this.Lock = new FormLock(this);
            this.parent = parent;
            LoadForm();
            this.bAddStaff.Click += AddStaffClicked;
            this.bChangeInfoStaff.Click += ChangeInfoStaffClicked;
            this.bDeleteStaff.Click += DeleteStaffClicked;
            this.FormClosed += CloseForm;
            this.bFind.Click += FindStaffClicked;
            this.Lock.Show();
            this.Show();
        }

        private void AddStaffClicked(object sender, EventArgs e)
        {
            //this.Hide();
            (new FormAddStaff(this)).Show();
        }

        private void ChangeInfoStaffClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                //this.Hide();
                (new FormChangeInfoStaff(this)).Show();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        public void GetSelectedInfo(out Staff selectedStaff)
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

        public void GetSelectedAccount(out Account selectedAccount)
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

        private void DeleteStaffClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                Staff selectedStaff;
                GetSelectedInfo(out selectedStaff);
                Data.UpdateData("TAIKHOAN", "TINHTRANG = 0", " WHERE ID  = '" +
                    selectedStaff.id.ToString() + "'");
                IO.ExportSuccess("Xóa nhân viên thành công");
                LoadForm();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        private void FindStaffClicked(object sender, EventArgs e)
        {

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            FormMenuStaff menu = (FormMenuStaff)sender;
            menu.parent.Show();
        }

        private void FormMenuStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Lock.Close();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
