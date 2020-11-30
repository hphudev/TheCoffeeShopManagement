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

namespace CoffeeShopManagement
{
    public partial class FormMenuItem : Form
    {
        public FormSell parent { get; }
        private FormLock lockForm;

        public void GetSelectedInfo(out Item selectedItem)
        {
            DataGridViewRow[] selectedRows = new DataGridViewRow[1];
            this.dgvMenu.SelectedRows.CopyTo(selectedRows, 0);

            selectedItem = new Item((string)selectedRows[0].Cells[0].Value,
                (string)selectedRows[0].Cells[1].Value, (string)selectedRows[0].Cells[2].Value,
                (int)selectedRows[0].Cells[3].Value, (int)selectedRows[0].Cells[4].Value);
        }

        public void LoadForm()
        {
            AutoCompleteStringCollection sourceData = new AutoCompleteStringCollection();
            this.dgvMenu.Rows.Clear();
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("MON", connection, "", "*");

            while (reader.HasRows)
            {
                if (reader.Read() == false)
                {
                    break;
                }

                Item item = new Item(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                this.dgvMenu.Rows.Add(item.id.ToString(), item.name, item.unit,
                    item.soLanPhucVu, item.price);
                sourceData.Add(item.name);
            }

            this.cbFind.AutoCompleteCustomSource = sourceData;
            Data.CloseConnection(ref connection);
        }

        public FormMenuItem(FormSell parent)
        {
            this.parent = parent;
            InitializeComponent();
            LoadForm();
            this.bAddItem.Click += AddItemClicked;
            this.bChangeInfoItem.Click += ChangeInfoItemClicked;
            this.bDeleteItem.Click += DeleteItemClicked;
            this.bFind.Click += FindItemClicked;
            this.bCancel.Click += CancelClicked;
            this.FormClosed += CloseForm;
            this.lockForm = new FormLock(this);
            this.lockForm.Show();
            this.Show();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemClicked(object sender, EventArgs e)
        {
            this.Hide();
            (new FormAddItem(this)).Show();
        }

        private void ChangeInfoItemClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                this.Hide();
                (new FormChangeInfoItem(this)).Show();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        private void DeleteItemClicked(object sender, EventArgs e)
        {
            if (this.dgvMenu.Rows.Count != 0)
            {
                Item selectedItem;
                GetSelectedInfo(out selectedItem);
                Data.DeleteData("MON", " WHERE MAMON = '" + selectedItem.id.ToString() + "'");
                IO.ExportSuccess("Xóa món thành công");
                LoadForm();
            }
            else
            {
                IO.ExportError("Hành động không hợp lệ");
            }
        }

        private void FindItemClicked(object sender, EventArgs e)
        {
            SqlConnection connection = Data.OpenConnection();
            SqlDataReader reader = Data.ReadData("MON", connection, "", "*");

            while (reader.HasRows)
            {
                if (!reader.Read())
                {
                    IO.ExportError("Món này không có trong danh sách");
                    break;
                }

                Item item = new Item(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));

                if (item.name == this.cbFind.Text)
                {
                    for (int i = 0; i < this.dgvMenu.Rows.Count; i++)
                    {
                        if (this.dgvMenu.Rows[i].Cells[1].Value.ToString() == this.cbFind.Text)
                        {
                            this.dgvMenu.Rows[i].Selected = true;
                            break;
                        }
                    }

                    break;
                }
            }

            Data.CloseConnection(ref connection);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.parent.LoadSomeThingPublic();
            this.lockForm.Close();
        }
    }
}
