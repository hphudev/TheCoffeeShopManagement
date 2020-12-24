using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Expense
    {
        private string time, content;
        private ID idStaff;

        public ID id { get; }

        public int value { get; }

        public Expense(string ID, string time, string content, string idStaff, int value)
        {
            try
            {
                this.id = new ID(ID);
                this.time = time;
                this.content = content;
                this.idStaff = new ID(idStaff);
                this.value = value;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 30 Class Expense)");
            }
        }

        public string GetInfo()
        {
            try
            {
                return "'" + this.id.ToString() + "', '" + this.time + "', N'" + this.content +
                    (this.idStaff.ToString() == "NULL" ? "', " : "', '") + this.idStaff +
                    (this.idStaff.ToString() == "NULL" ? ", '" : "', '") + this.value.ToString() + "'";
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 44 Class Expense)");
                return null;
            }
        }
    }
}
