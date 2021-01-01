using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DTO
{
    public class Expense
    {
        #region Attributes
        private string time, content;
        private ID idStaff;

        public ID id { get; }

        public int value { get; }
        #endregion

        #region Operations
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
                IO.ExportError("Lỗi không xác định\n(Class Expense)");
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
                IO.ExportError("Lỗi không xác định\n(Class Expense)");
                return null;
            }
        }
        #endregion
    }
}
