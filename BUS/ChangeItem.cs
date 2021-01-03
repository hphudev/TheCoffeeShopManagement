using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace BUS
{
    public class ChangeItem : ObjItem, IChangeObj
    {
        public override void AddImageClicked(ref PictureBox pbImageItem, object item = null)
        {
            AddImage(ref pbImageItem, "./ImageItem/", ((Item)item).id.ToString());
        }

        public bool ChangeInfoObj(object item, object arg = null)
        {
            Item updatedItem = (Item)item;

            if (Item.IsItem(ref updatedItem) != 1)
            {
                IO.ExportError("Tên món đã tồn tại");
                return false;
            }

            Data.UpdateData("MON", "DVT = '" + updatedItem.unit + "', GIA = '" + updatedItem.price +
                    "', TENMON = N'" + updatedItem.name + "'", " WHERE MAMON = '" +
                    updatedItem.id.ToString() + "'");
            IO.ExportSuccess("Sửa món thành công");
            return true;
        }

    }
}
