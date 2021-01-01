using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class MenuItem : Menu
    {
        public override object GetSelectedObj(DataGridView dgvMenu)
        {
            try
            {
                DataGridViewRow selectedRow = BUS.Menu.GetInfoOfSelectedObj(dgvMenu);

                return new Item((string)selectedRow.Cells[0].Value, (string)selectedRow.Cells[1].Value,
                    (string)selectedRow.Cells[2].Value, (int)selectedRow.Cells[3].Value,
                    (int)selectedRow.Cells[4].Value, true);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu Item)");
                return null;
            }
        }

        public override void AddData(ref AutoCompleteStringCollection sourceData,
            ref object sharedVariable, SqlDataReader reader)
        {
            Item item = Initialization.InitItemFromReader(reader);
            sourceData.Add(item.name);
            sharedVariable = (object)item;
        }

        public override void AddRow(object data, DataGridView menu)
        {
            Item item = (Item)data;
            menu.Rows.Add(item.id.ToString(), item.name, item.unit, item.numberOfServings,
                item.price);
        }

        public override void DeleteObj(DataGridView dgvMenu)
        {
            try
            {
                Item selectedItem = (Item)GetSelectedObj(dgvMenu);
                Data.UpdateData("MON", "TINHTRANG = 0", " WHERE MAMON = '" +
                    selectedItem.id.ToString() + "'");
                IO.ExportSuccess("Xóa món thành công");
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Class Menu Item");
            }
        }

    }
}
