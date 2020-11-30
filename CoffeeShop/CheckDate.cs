using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    class CheckDate
    {
        private char e;
        private string Text;
        public CheckDate()
        {
        }

        public bool CheckYear(int year)
        {
            // true là năm nhuận, false là năm không nhuận
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        public bool CheckDayMonthYear(char e, string text)
        {
            if (text.Length == 0)
            {
                if (int.Parse(e.ToString()) > 3)
                    return false;
                return true;
            }
            if (text.Length == 1)
            {
                if (int.Parse(text[1].ToString()) == 3)
                    return int.Parse(e.ToString()) >= 0 || int.Parse(e.ToString()) <= 1;
                return true;
            }
            if (text.Length == 2)
            {
                return e == '/';
            }
            if (text.Length == 3)
            {
                return int.Parse(e.ToString()) <= 1;
            }
            if (text.Length == 4)
            {
                if (text[text.Length - 1] == '1')
                    return int.Parse(e.ToString()) <= 2;
                return true;
            }
            if (text.Length == 5)
            {
                return e == '/';
            }
            if (text.Length == 9)
            {
                //string year = text[]
                //if ()
            }
            return true;
        }

    }
}
