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
            this.id = new ID(ID);
            this.time = time;
            this.content = content;
            this.idStaff = new ID(idStaff);
            this.value = value;
        }
    }
}
