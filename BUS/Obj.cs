using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public abstract class Obj : Class
    {
        protected string path;

        public void AddImage(ref PictureBox pbImageItem, string path, string name)
        {
            try
            {
                OpenFileDialog openFileImage = new OpenFileDialog();
                DialogResult dialog = openFileImage.ShowDialog();

                if (dialog != DialogResult.Cancel)
                {
                    FileInfo file = new FileInfo(openFileImage.FileName);

                    if (file.Extension == ".jpg" || file.Extension == ".png")
                    {
                        pbImageItem.Image = Image.FromFile(openFileImage.FileName);
                        File.Copy(openFileImage.FileName, path + name + ".jpg", true);
                    }
                    else
                    {
                        IO.ExportError("Chỉ hỗ trợ file .jpg và .png");
                    }
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Add Obj)");
            }
        }

        public abstract void AddImageClicked(ref PictureBox pbImageItem, object arg = null);

    }
}
