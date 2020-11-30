using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Bill
    {
        public ID idCustomer { get; }
        public ID idStaff { get; }
        public string date { get; }

        public ID id { get; }

        public int value { get; }

        public int discount { get; }

        public Bill(string id, string date, string idCustomer, string idStaff, int value,
            int discount)
        {
            this.id = new ID(id);
            this.idCustomer = new ID(idCustomer);
            this.idStaff = new ID(idStaff);
            this.date = date;
            this.value = value;
            this.discount = discount;
        }

        public void AddBill()
        {
            string idStaffTmp = (idStaff.id == "NULL") ? idStaff.id : ("'" + idStaff.id + "'");
            string idCustomerTmp = (idCustomer.id == "NULL") ? idCustomer.id : ("'" + idCustomer.id + "'");
            Data.AddData("HOADON", $"N'{this.id.id}', '{Utility.GetDateUS(this.date)}', {idCustomerTmp}," +
                $"{idStaffTmp}, '{this.value}', '{this.discount}'");
        }
    }
}
