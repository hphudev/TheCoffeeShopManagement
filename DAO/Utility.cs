using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class Utility
    {
        #region Operations
        public static string GetDate(this DateTime tmp, DateTime dateTime)
        {
            try
            {
                return dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Utility)");
                return null;
            }
        }

        public static string GetDateUS(this DateTime tmp, DateTime dateTime)
        {
            try
            {
                return dateTime.Year + "/" + dateTime.Month + "/" + dateTime.Day;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Utility)");
                return null;
            }
        }

        public static string GetDateUS(string dateTime)
        {
            try
            {
                if (dateTime == null)
                    return null;
                string[] date = dateTime.Split('/');
                if (date.Length < 3)
                    return null;
                return date[2] + "/" + date[1] + "/" + date[0];
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Utility)");
                return null;
            }
        }

        public static string StringToMoney(string a)
        {
            try
            {
                string tmp = "";
                int dem = 0;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    dem++;
                    if (i > 0 && dem % 3 == 0)
                        tmp = "." + a[i].ToString() + tmp;
                    else
                        tmp = a[i] + tmp;
                }
                return tmp;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Utility)");
                return null;
            }
        }

        public static string MoneyToString(string a)
        {
            try
            {
                while (a.IndexOf('.') > -1)
                    a.Remove(a.IndexOf('.'), 1);
                return a;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Utility)");
                return null;
            }
        }

        public static string ChangeAnyToString(string parameter)
        {
            return (parameter != null) ? parameter : "";
        }
        #endregion
    }
}
