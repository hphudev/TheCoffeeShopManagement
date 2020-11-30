using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public static class Utility
    {
        public static string GetDate(this DateTime tmp, DateTime dateTime)
        {
            return dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
        }

        public static string GetDateUS(this DateTime tmp, DateTime dateTime)
        {
            return dateTime.Year + "/" + dateTime.Month + "/" + dateTime.Day;
        }

        public static string GetDateUS(string dateTime)
        {
            if (dateTime == null)
                return null;
            string[] date = dateTime.Split('/');
            if (date.Length < 3)
                return null;
            return date[2] + "/" + date[1] + "/" + date[0];
        }
    }
}
