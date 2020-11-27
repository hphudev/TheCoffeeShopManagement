using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormAddItem : System.Windows.Forms.Form
    {
        private FormBangKhoa Lock;
        private FormMenuItem parent;
        public FormAddItem(FormMenuItem parent)
        {
            InitializeComponent();
            this.parent = parent;
            Lock = new FormBangKhoa(this);
            Lock.Show();
            this.Show();
        }

        private void BAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            DialogResult dialog = openFileImage.ShowDialog();
            if (dialog != DialogResult.Cancel)
            {
                pbImageItem.Image = Image.FromFile(openFileImage.FileName);
                // Khúc này là duy copy ảnh vào thư mục có địa chỉ là "./ImageItem" và tên của ảnh mới là <ID món>.jpg
            }
        }

        private void FormAddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
            this.Lock.Close();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
