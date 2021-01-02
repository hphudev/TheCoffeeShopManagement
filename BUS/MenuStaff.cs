using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class MenuStaff : Menu, IMenu
    {
        public object GetSelectedObj(DataGridView dgvMenu)
        {
            try
            {
                DataGridViewRow selectedRow = BUS.Menu.GetInfoOfSelectedObj(dgvMenu);

                return new Staff((string)selectedRow.Cells[0].Value,
                    (string)selectedRow.Cells[1].Value, (string)selectedRow.Cells[2].Value,
                    (string)selectedRow.Cells[4].Value, (string)selectedRow.Cells[6].Value,
                    (string)selectedRow.Cells[3].Value, (string)selectedRow.Cells[5].Value,
                    (string)selectedRow.Cells[8].Value, (int)selectedRow.Cells[7].Value);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu Staff)");
                return null;
            }
        }

        public void AddRow(SqlDataReader reader, DataGridView menu, ComboBox finder,
            AutoCompleteStringCollection sourceData)
        {
            Staff staff = Initialization.InitStaffFromReader(reader);
            menu.Rows.Add(staff.id.ToString(), staff.name, staff.address, staff.date, staff.sdt,
                staff.cmnd, staff.sex, staff.luong, staff.chucVu, "Xem ảnh");
            finder.Items.Add(staff.name);
            sourceData.Add(staff.name);
        }

        public override void DeleteObj(DataGridView dgvMenu)
        {
            try
            {
                Staff selectedStaff = (Staff)GetSelectedObj(dgvMenu);
                Data.UpdateData("TAIKHOAN", "TINHTRANG = 0", " WHERE ID  = '" +
                    selectedStaff.id.ToString() + "'");
                IO.ExportSuccess("Xóa nhân viên thành công");
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu Staff");
            }
        }

    }
}
