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
