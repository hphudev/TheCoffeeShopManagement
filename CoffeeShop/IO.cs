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
        public static void ExportError(string sContent)
        {
            System.Windows.Forms.MessageBox.Show(sContent, "Lỗi", MessageBoxButtons.OK, 
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public static void ExportSuccess(string sContent)
        {
            System.Windows.Forms.MessageBox.Show(sContent, "Thông tin", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static void ExportWarning(string sContent)
        {
            System.Windows.Forms.MessageBox.Show(sContent, "Cảnh báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
