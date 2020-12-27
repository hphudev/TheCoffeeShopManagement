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
using System.IO;

namespace CoffeeShopManagement
{
    public partial class FormAddItem : Form
    {
        private FormLock lockForm;
        private FormMenuItem parent;

        public FormAddItem(FormMenuItem parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                //this.lockForm = new FormLock(this);
                //Event.ShowForm(this.lockForm);

                this.tbName.KeyPress += PressEnter;
                this.tbPrice.KeyPress += PressEnter;
                this.cbUnit.KeyPress += PressEnter;
                this.FormClosed += CloseForm;
                this.bCancel.Click += CancelClicked;
                this.bOK.Click += OKClicked;
                this.bAddImage.Click += AddImageClicked;
                this.tbPrice.KeyPress += IO.LockWord;
                this.lID.Text = ID.FindNewID("MON", " ORDER BY MAMON DESC", "MAMON", "M", 
                    3).ToString();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 42 Form Add Item)");
            }

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.ShowForm(this.parent);
            Event.CloseForm(this.lockForm);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public bool IsItem(ref Item newItem)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("MON", connection, "", "*");
                string lastID = "";

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }

                    Item item = new Item(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetBoolean(5));

                    if (newItem.name == item.name && item.status)
                    {
                        Data.CloseConnection(ref connection);
                        return false;
                    }

                    if (newItem.name == item.name && !item.status)
                    {
                        newItem.id.SetID(item.id.FindID("M"), "M", 3);
                        Data.UpdateData("MON", "DVT = '" + newItem.unit + "', GIA = " + newItem.price +
                            ", TINHTRANG = 1, SOLANPHUCVU = 0", " WHERE MAMON = '" + newItem.id.ToString() + "'");
                        Data.CloseConnection(ref connection);
                        return true;
                    }

                    lastID = item.id.FindID("M").ToString();
                }

                reader.Close();

                if (lastID == "")
                {
                    newItem.id.SetID(1, "M", 3);
                }
                else
                {
                    newItem.id.SetID(int.Parse(lastID) + 1, "M", 3);
                }

                Data.AddData("MON", newItem.GetInfo());
                Data.CloseConnection(ref connection);
                return true;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 116 Form Add Item)");
                return false;
            }
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (this.tbPrice.Text == "" || this.tbName.Text == "" || this.cbUnit.Text == ""
                    || this.pbImageItem.Image == null)
                {
                    IO.ExportError("Phải nhập đầy đủ thông tin tất cả các trường");
                    return;
                }

                Item newItem = new Item("", tbName.Text, cbUnit.Text, 0, int.Parse(tbPrice.Text),
                    true);

                if (IsItem(ref newItem) == false)
                {
                    IO.ExportError("Món này đã có trong danh sách");
                    return;
                }

                IO.ExportSuccess("Thêm món thành công");
                this.parent.ClearMenu();
                this.parent.LoadMenu();
                this.parent.parent.LoadSomeThingPublic();
                Event.ShowForm(this.parent);
                this.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 150 Form Add Item)");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            try
            {
                Event.AddImage(ref this.pbImageItem, "./ImageItem/", ID.FindNewID("MON",
                    " ORDER BY MAMON DESC", "MAMON", "M", 3).ToString());
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 163 Form Add Item)");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.lockForm = khoa;
        }
    }
}
