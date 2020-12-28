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
using Guna.UI2.WinForms;

namespace CoffeeShopManagement
{
    public static class Event
    {
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
                IO.ExportError("Lỗi không xác định\n(Line 33 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 51 Class Event)");
            }
        }

        public static void FinishWork(ref ComboBox cbFind, AutoCompleteStringCollection sourceData)
        {
            try
            {
                cbFind.AutoCompleteCustomSource = sourceData;
                cbFind.Items.Clear();

                foreach (string data in sourceData)
                {
                    cbFind.Items.Add(data);
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 63 Class Event)");
            }
        }

        public static void ShowProgress(ref Semaphore[] semaphores, DataGridView dgvMenu,
            object sharedVariable, ProgressBar progressBar, ProgressChangedEventArgs e)
        {
            try
            {
                semaphores[0].WaitOne();

                switch (sharedVariable.GetType().Name)
                {
                    case "Item":
                        Item item = (Item)sharedVariable;
                        AddRow(item, dgvMenu);
                        break;
                    case "Staff":
                        Staff staff = (Staff)sharedVariable;
                        AddRow(staff, dgvMenu);
                        break;
                }

                progressBar.Value = e.ProgressPercentage;
                semaphores[1].Release();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 91 Class Event)");
            }
        }

        public static void LoadData(ref AutoCompleteStringCollection sourceData, string table,
            string condition, ref Semaphore[] semaphores, ref object sharedVariable, string type,
            BackgroundWorker loader)
        {
            try
            {
                sourceData = new AutoCompleteStringCollection();
                int numberOfRowData = (int)Data.Calculate("COUNT", "*", table, condition);
                int percentProgress = 0;
                decimal ratio = (decimal)numberOfRowData / 100, count = 0, flag = ratio;
                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData(table, connection, condition, "*");
                semaphores = new Semaphore[2];
                semaphores[0] = new Semaphore(0, 1);
                semaphores[1] = new Semaphore(0, 1);

                while (reader.HasRows)
                {
                    if (reader.Read() == false)
                    {
                        break;
                    }

                    switch (type)
                    {
                        case "Item":
                            Item item = Initialization.InitItemFromReader(reader);
                            sourceData.Add(item.name);
                            sharedVariable = (object)item;
                            break;
                        case "Staff":
                            Staff staff = Initialization.InitStaffFromReader(reader);
                            sourceData.Add(staff.name);
                            sharedVariable = (object)staff;
                            break;
                    }

                    count++;

                    while (count >= flag)
                    {
                        percentProgress++;
                        flag += ratio;
                    }

                    semaphores[0].Release();
                    loader.ReportProgress(percentProgress);
                    semaphores[1].WaitOne();
                }

                Data.CloseConnection(ref connection);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 149 Class Event)");
            }
        }

        public static void AddRow(object data, DataGridView menu)
        {
            try
            {
                switch (data.GetType().Name)
                {
                    case "Item":
                        Item item = (Item)data;
                        menu.Rows.Add(item.id.ToString(), item.name, item.unit, item.numberOfServings,
                            item.price);
                        break;
                    case "Staff":
                        Staff staff = (Staff)data;
                        menu.Rows.Add(staff.id.ToString(), staff.name, staff.address, staff.date, staff.sdt,
                            staff.cmnd, staff.sex, staff.luong, staff.chucVu, "Xem ảnh");
                        break;
                }
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 173 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 205 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 217 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 245 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 261 Class Event)");
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
                IO.ExportError("Lỗi không xác định\n(Line 273 Class Event)");
            }
        }
    }
}
