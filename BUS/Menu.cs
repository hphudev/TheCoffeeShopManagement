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
    public class Menu : Class
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

        public void ShowProgress(ProgressBar progressBar, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar.Value = e.ProgressPercentage;
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
