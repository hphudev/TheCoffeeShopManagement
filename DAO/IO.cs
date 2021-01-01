using IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DAO
{
    public static class IO
    {
        #region Operations
        public static void LockWord(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class IO)");
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
                IO.ExportError("Lỗi không xác định\n(Class IO)");
            }
        }

        public static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public static void ExportError(string content)
        {
            try
            {
                Alert(content, Form_Alert.enmType.Error);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 46 Class IO)");
            }
        }

        public static void ExportInfo(string content)
        {
            try
            {
                Alert(content, Form_Alert.enmType.Info);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 59 Class IO)");
            }
        }

        public static void ExportSuccess(string content)
        {
            try
            {
                Alert(content, Form_Alert.enmType.Success);
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
                Alert(content, Form_Alert.enmType.Warning);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 72 Class IO)");
            }
        }
        #endregion
    }
}
