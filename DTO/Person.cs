using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DTO
{
    public class Person
    {
        #region Atrributes
        public string name { get; }

        public string address { get; }

        public string sdt { get; }

        public string sex { get; }
        #endregion

        #region Operations
        public Person(string name, string address, string sdt, string sex)
        {
            try
            {
                this.name = name;
                this.address = address;
                this.sdt = sdt;
                this.sex = sex;
            }
            catch(Exception)
            {
                IO.ExportError("Lỗi không xác định\nClass Person");
            }
        }
        #endregion
    }
}
