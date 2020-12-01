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

        public ID FindID()
        {
            ID lastID = ID.GetLastIDItem();
            ID newID = new ID("");

            if (lastID != null)
            {
                newID.SetID((lastID.FindID("M") + 1), "M", 3);
            }
            else
            {
                newID.SetID(1, "M", 3);
            }

            return newID;
        }

        public FormAddItem(FormMenuItem parent)
        {
            InitializeComponent();
            this.parent = parent;
            lockForm = new FormLock(this);
            lockForm.Show();
            this.lID.Text = FindID().id.ToString();

            this.tbName.KeyPress += PressEnter;
            this.tbPrice.KeyPress += PressEnter;
            this.tbUnit.KeyPress += PressEnter;
            this.FormClosed += CloseForm;
            this.bCancel.Click += CancelClicked;
            this.tbPrice.KeyPress += ShowErrorWord;
            this.bOK.Click += OKClicked;
            this.bAddImage.Click += AddImageClicked;
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.lockForm.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        public bool IsItem(ref Item newItem)
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
                    Data.DeleteData("MON", " WHERE MAMON = '" + item.id.ToString() + "'");
                    newItem.id.SetID(item.id.FindID("M"), "M", 3);
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

            Data.CloseConnection(ref connection);
            return true;
        }

        private void ShowErrorWord(object sender, KeyPressEventArgs e)
        {
            Event.ShowErrorWord(this.tbPrice, this.epShowError, e);
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbPrice.Text) <= 0 || this.tbName.Text == "" || this.tbUnit.Text == ""
                    || this.pbImageItem.Image == null)
                {
                    throw new Exception();
                }

                Item newItem = new Item("", tbName.Text, tbUnit.Text, 0, int.Parse(tbPrice.Text), 
                    true);

                if (IsItem(ref newItem) == false)
                {
                    IO.ExportError("Món này đã có trong danh sách");
                    return;
                }
                else
                {
                    Data.AddData("MON", newItem.GetInfo());
                }

                IO.ExportSuccess("Thêm món thành công");
                this.parent.LoadForm();
                this.parent.parent.LoadSomeThingPublic();
                this.parent.Show();
                this.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Nội dung nhập không hợp lệ");
            }
        }

        private void AddImageClicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            DialogResult dialog = openFileImage.ShowDialog();

            if (dialog != DialogResult.Cancel)
            {
                FileInfo file = new FileInfo(openFileImage.FileName);

                if (file.Extension == ".jpg" || file.Extension == ".png")
                {
                    pbImageItem.Image = Image.FromFile(openFileImage.FileName);
                    File.Copy(openFileImage.FileName, "./ImageItem/" + FindID().id.ToString() + 
                        ".jpg", true);
                }
                else
                {
                    IO.ExportError("Chỉ hỗ trợ file .jpg và .png");
                }
            }
        }
    }
}
