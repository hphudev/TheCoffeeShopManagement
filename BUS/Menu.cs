using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class Menu
    {
        public static DataGridViewRow GetInfoOfSelectedObj(DataGridView dgvMenu)
        {
            try
            {
                DataGridViewRow[] selectedRows = new DataGridViewRow[1];
                dgvMenu.SelectedRows.CopyTo(selectedRows, 0);
                return selectedRows[0];
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu)");
                return null;
            }
        }

        public virtual object GetSelectedObj(DataGridView dgvMenu)
        {
            return null;
        }
    
        public void ClearMenu(DataGridView dgvMenu)
        {
            try
            {
                dgvMenu.Rows.Clear();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu");
            }
        }

        public void LoadMenu(BackgroundWorker loader)
        {
            try
            {
                loader.RunWorkerAsync();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu");
            }
        }

        public virtual void AddData(ref AutoCompleteStringCollection sourceData,
            ref object sharedVariable, SqlDataReader reader)
        {

        }

        public void LoadData(ref AutoCompleteStringCollection sourceData, string table,
            string condition, ref Semaphore[] semaphores, ref object sharedVariable,
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

                    AddData(ref sourceData, ref sharedVariable, reader);
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
                IO.ExportError("Lỗi không xác định\n(Class Menu)");
            }
        }

        public virtual void AddRow(object data, DataGridView menu)
        {
            
        }

        public void ShowProgress(ref Semaphore[] semaphores, DataGridView dgvMenu,
            object sharedVariable, ProgressBar progressBar, ProgressChangedEventArgs e)
        {
            try
            {
                semaphores[0].WaitOne();
                AddRow(sharedVariable, dgvMenu);
                progressBar.Value = e.ProgressPercentage;
                semaphores[1].Release();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu)");
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
                IO.ExportError("Lỗi không xác định\n(Class Menu)");
            }
        }
        
        public virtual void DeleteObj(DataGridView dgvMenu)
        {

        }

        public void DeleteObj(DataGridView dgvMenu, BackgroundWorker loader)
        {
            DeleteObj(dgvMenu);
            ClearMenu(dgvMenu);
            LoadMenu(loader);
        }

        public static void ClearContent(ComboBox cbFind)
        {
            cbFind.Text = "";
        }

    }
}
