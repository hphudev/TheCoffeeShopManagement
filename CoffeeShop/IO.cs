using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public static class IO
    {
        public static void LockWord(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 21 Class IO)");
            }
        }

        public static void LockNumber(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 33 Class IO)");
            }
        }

        public static void ExportError(string content)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(content, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 46 Class IO)");
            }
        }

        public static void ExportSuccess(string content)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(content, "Thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 59 Class IO)");
            }
        }

        public static void ExportWarning(string content)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(content, "Cảnh báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 72 Class IO)");
            }
        }
    }
}
