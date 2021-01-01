using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading;
using System.Drawing.Printing;
//using Guna.UI2.WinForms;
using DAO;
using DTO;

namespace BUS
{
    public static class Event
    {
        #region Operations
        public static void ReloadMenu(ref ComboBox cbFind, DataGridView dgvMenu, BackgroundWorker loader)
        {
            try
            {
                if (cbFind.Text != "")
                {
                    RunLoader(loader, dgvMenu, cbFind.Text);
                }
                else
                {
                    RunLoader(loader, dgvMenu, null);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void RunLoader(BackgroundWorker loader, DataGridView menu, object arg)
        {
            try
            {
                if (loader.IsBusy)
                {
                    IO.ExportWarning("Vui lòng đợi quá trình tải dữ liệu hoàn tất");
                }

                menu.Rows.Clear();
                loader.RunWorkerAsync(arg);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void Find(string table, string condition, string column, string type,
            ref DataGridView dgvMenu, ref ComboBox cbFind)
        {
            try
            {
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData(table, connection, condition, column);

                if (!reader.Read())
                {
                    IO.ExportError(type + " này không có trong danh sách");
                    return;
                }

                for (int i = 0; i < dgvMenu.Rows.Count; i++)
                {
                    if (dgvMenu.Rows[i].Cells[1].Value.ToString() == cbFind.Text)
                    {
                        dgvMenu.Rows[i].Selected = true;
                        cbFind.Text = "";
                        break;
                    }
                }

                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void CloseForm(Form form)
        {
            try
            {
                form.Close();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void AddImage(ref PictureBox pbImageItem, string path, string name)
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
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void PressEnter(object sender, KeyPressEventArgs e, System.Windows.Forms.Form f)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    Control ctl = ((Control)sender).Parent;
                    ctl.SelectNextControl(f.ActiveControl, true, true, true, true);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }

        public static void ShowForm(Form form)
        {
            try
            {
                form.Show();
            }
            catch(Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Event)");
            }
        }
        #endregion
    }
}
