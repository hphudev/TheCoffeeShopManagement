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
        public static void ExportError(string content)
        {
            System.Windows.Forms.MessageBox.Show(content, "Lỗi", MessageBoxButtons.OK, 
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public static void ExportSuccess(string content)
        {
            System.Windows.Forms.MessageBox.Show(content, "Thông tin", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static void ExportWarning(string content)
        {
            System.Windows.Forms.MessageBox.Show(content, "Cảnh báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        public static bool IsContainNumber(string content)
        {
            char[] characters = content.ToCharArray();

            foreach (char charecter in characters)
            {
                if (char.IsNumber(charecter))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
