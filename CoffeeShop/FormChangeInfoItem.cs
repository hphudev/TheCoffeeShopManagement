using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoffeeShopManagement
{
    public partial class FormChangeInfoItem : Form
    {
        private FormMenuItem parent;
        private FormLock lockForm;

        public void Autofill()
        {
            Item selectedItem;
            this.parent.GetSelectedInfo(out selectedItem);
            this.tbName.Text = selectedItem.name;
            this.tbPrice.Text = selectedItem.price.ToString();
            this.tbUnit.Text = selectedItem.unit;
            this.lID.Text = selectedItem.id.ToString();
            this.pbImageItem.Image = selectedItem.image;
        }

        public FormChangeInfoItem(FormMenuItem parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.lockForm = new FormLock(this);
            this.lockForm.Show();
            Autofill();
            this.tbName.Enabled = false;

            this.tbPrice.KeyPress += PressEnter;
            this.tbUnit.KeyPress += PressEnter;
            this.bCancel.Click += CancelClicked;
            this.bOK.Click += OKClicked;
            this.FormClosed += CloseForm;
            this.tbPrice.KeyPress += ShowErrorWord;
            this.bAddImage.Click += AddImageClicked;
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.lockForm.Close();
            this.parent.Show();
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            Event.PressEnter(sender, e, this);
        }

        private void ShowErrorWord(object sender, KeyPressEventArgs e)
        {
            Event.ShowErrorWord(this.tbPrice, this.epShowError, e);
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tbPrice.Text) <= 0 || tbUnit.Text == "")
                {
                    throw new Exception();
                }

                Item selectedItem;
                this.parent.GetSelectedInfo(out selectedItem);
                Item updatedItem = new Item(selectedItem.id.ToString(), selectedItem.name,
                    tbUnit.Text, selectedItem.soLanPhucVu, int.Parse(tbPrice.Text));

                Data.UpdateData("MON", "DVT = '" + updatedItem.unit + "', GIA = '" +
                    updatedItem.price + "'", " WHERE MAMON = '" + selectedItem.id.ToString() + "'");
                IO.ExportSuccess("Sửa món thành công");
                this.parent.LoadForm();
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
            Item selectedItem;
            this.parent.GetSelectedInfo(out selectedItem);

            if (dialog != DialogResult.Cancel)
            {
                FileInfo file = new FileInfo(openFileImage.FileName);
                if (file.Extension == ".jpg" || file.Extension == ".png")
                {
                    pbImageItem.Image = Image.FromFile(openFileImage.FileName);
                    File.Copy(openFileImage.FileName, "./ImageItem/" + selectedItem.id.ToString() +
                        ".jpg", true);
                }
                else
                {
                    IO.ExportError("Chỉ hỗ trợ file .jpg và .png");
                }
            }
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
