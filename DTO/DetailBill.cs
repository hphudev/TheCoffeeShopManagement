using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DTO
{
    public class DetailBill
    {
        #region Attributes
        private ID id; 

        public ID idMon { get; }

        public int soLuong { get; }
        #endregion

        #region Operations
        public DetailBill(string id, string idMon, int soLuong)
        {
            try
            {
                this.id = new ID(id);
                this.idMon = new ID(idMon);
                this.soLuong = soLuong;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Detail Bill)");
            }
        }

        public void AddDetailBill()
        {
            try
            {
                Data.AddData("CTHD", $"'{this.id.id}', '{this.idMon.id}', '{this.soLuong}'");
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Detail Bill)");
            }
        }
        #endregion
    }
}
